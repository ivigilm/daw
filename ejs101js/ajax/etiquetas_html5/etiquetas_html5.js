window.onload = function() {
    var xhr = new XMLHttpRequest();
    xhr.onreadystatechange = function() {
    	if(this.readyState == 4 && this.status == 200){
    		var respuesta = this.responseText;	// JSON
	        var jsonobj = JSON.parse(respuesta); // array
	        
	        // Ordeno alfabéticamente
	        jsonobj.sort(function(a, b){
	        	if(a.etiqueta < b.etiqueta){
	        		return -1;
	        	}
	        	if(b.etiqueta < a.etiqueta){
	        		return 1;
	        	}
	        	return 0;
	        });

	        // Posición de la primera etiqueta aleatoria
	        var aleatorio = Math.floor(Math.random() * (jsonobj.length - 1));
	        // Aciertos
	        var aciertos = 0;
	        var intentos = 0;

	        // Muestro la primera definición
	        document.getElementById("descripcion").innerHTML = 
	        jsonobj[aleatorio].definicion;

	        // Creo los botones y les asigno onclick
	        for (var i = 0; i < jsonobj.length; i++) {
	            var btn = document.createElement("button");
	            var t = document.createTextNode(jsonobj[i].etiqueta);
	            btn.id = t;	            
	            btn.appendChild(t);

	            btn.onclick = function() {
	            	intentos++;
	            	// Se pone rojo o verde
	            	// .etiqueta pertenece al json (var respuesta), no al jsonobj ?!
/*	            	console.log(this.childNodes[0].data);
	            	console.log(jsonobj[aleatorio].etiqueta);*/
	            	// this.id -> objectText (hay que hacerlo string "ol", "li"...)

	            	/* LA PRIMERA LA FALLA SIEMPRE */
	            	if(this.childNodes[0].data == jsonobj[aleatorio].etiqueta){
	            		this.style.backgroundColor = 'lime';
	            		this.disabled = true;
	            		// elimino la etiqueta acertada del array para q no vuelva a salir
	            		for(var k = 0; k < jsonobj.length; k++){
	            			if(jsonobj[k].etiqueta == this.childNodes[0].data){
	            				jsonobj.splice(k, 1);
	            			}
	            		}
	            		aciertos++;
	            	}else{
	            		this.style.backgroundColor = 'red';
	            	}

	            	// Se muestran los aciertos
	            	document.getElementById("aciertos").innerHTML = "Aciertos: " + aciertos + " (" 
	            	+ (aciertos*100/intentos).toFixed(2)  + "%)";

	            	// Presenta siguiente definición
	            	if(jsonobj.length > 0){
	            		aleatorio = Math.floor(Math.random() * (jsonobj.length - 1));
	            		document.getElementById("descripcion").innerHTML = 
	            		jsonobj[aleatorio].definicion;
	            	}else{
	            		alert("¡Bien hecho!");
	            		location.reload();
	            	}
	            }
	            document.getElementById("botoneshtml").appendChild(btn);
	        }
    	}
        
    }
    xhr.open("GET", "etiquetas_html5.json", true);
    xhr.send();
}