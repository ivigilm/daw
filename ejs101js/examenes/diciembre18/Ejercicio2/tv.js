var programacion;

window.onload = function(){
	var xhr = new XMLHttpRequest();
	xhr.onreadystatechange = function(){
		if(this.status == 200 && this.readyState == 4){
			var canales = JSON.parse(this.responseText);
			if(canales["estado"] == 200){
				cargaCanales(canales);
			}else{
				alert("Error al procesar la petición inicial.");
			}
		}
	}
	xhr.open("GET", "canales.php", true);
	xhr.send();
}

function cargaCanales(canales){
	for(var i = 0; i < canales.data.length; i++){	
		var	rutaimagen = canales.data[i].url;
		var idcanal = canales.data[i].id;

		var imagen = document.createElement("img");
		imagen.src = "logos/" + rutaimagen;
		imagen.id = idcanal;
		imagen.onclick = cargaProgramacion;

		document.getElementById("logos").appendChild(imagen);
	}
}

function cargaProgramacion(){
	var xhr2 = new XMLHttpRequest();
	xhr2.onreadystatechange = function(){
		if(this.status == 200 && this.readyState == 4){
			if(this.responseText == "error"){
				alert("Este canal no tiene programación.");
			}else{
				programacion = JSON.parse(this.responseText); // array de objetos (programas)
				programacion.sort(function(a,b){
					if( a.hora < b.hora) return -1;
					if(a.hora > b.hora) return 1;
					return 0; 
					});
				muestraProgramacion(programacion);
			}
		}
	}
	xhr2.open("POST", "programas.php", true);
	xhr2.setRequestHeader("Content-Type","application/x-www-form-urlencoded");
	xhr2.send("id=" + this.id + "&fecha=" + "2018-03-08"); // this.id = id de la imagen
}

function muestraProgramacion(programacion){
	var tabla = document.getElementsByTagName("table")[0];
	tabla.innerHTML = "<tr><th>Hora</th><th>Programa</th></tr>";

	for(var i = 0; i < programacion.length; i++){
		var fila = document.createElement("tr");
		fila.insertCell(0).innerHTML = programacion[i].hora;
		fila.insertCell(1).innerHTML = programacion[i].nombre;
		fila.onclick = mostrarDescripcion;
/*		fila.onfocusout = function(){
			this.style.color = 'black';
			this.childNodes[1].innerHTML = programacion[i].nombre;
		};*/
		tabla.appendChild(fila);
	}
}


function mostrarDescripcion(){
	var tabla = document.getElementsByTagName("table")[0];
	
	// Forma regulera de devolver el aspecto original a las filas:
	for(var i = 1; i < tabla.childNodes.length; i++){
		tabla.childNodes[i].style.color = 'black';
		tabla.childNodes[i].childNodes[1].innerHTML = programacion[i-1].nombre;
	}

	this.style.color = 'red';
	// this.focus();
	
	for(var i = 0; i < programacion.length; i++){
		if(this.childNodes[1].innerHTML == programacion[i].nombre && programacion[i].descripcion != null){
			this.childNodes[1].innerHTML += "<br/>" + programacion[i].descripcion;
		}
	}	
}

