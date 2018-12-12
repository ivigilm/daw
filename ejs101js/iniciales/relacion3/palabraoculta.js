var palabra = "";
var aciertos = 0;
var intentos = 0;
var porcentaje;

function iniciaJuego(){
	var aleatorio = Math.floor(Math.random() * diccionario.length);
	palabra = diccionario[aleatorio];
	var letras = palabra.split("");
	letras.sort();
	document.getElementById('desordenada').value = "";
	document.getElementById('solucion').value = "";
	for(var i = 0; i < letras.length; i++){
		document.getElementById('desordenada').value += letras[i];
	}	
	document.getElementById('comprueba').disabled = false;
	intentos++;
	console.log(palabra);
}

function verSolucion(){
	document.getElementById('solucion').value = palabra;
	document.getElementById('comprueba').disabled = true;
	porcentaje = aciertos*100/intentos;
	document.getElementsByTagName('p')[0].innerHTML = "Porcentaje de aciertos: " + porcentaje + "%";
}

function comprobarAcierto(){
	if(document.getElementById('solucion').value == palabra){
		alert("¡Has acertado!");
		aciertos++;
	}else{
		alert("¡Has fallado! La solución era " + palabra + ".");
	}
	document.getElementById('desordenada').value = "";
	document.getElementById('solucion').value = "";
	porcentaje = aciertos*100/intentos;
	document.getElementsByTagName('p')[0].innerHTML = "Porcentaje de aciertos: " + porcentaje + "%";
}


/* NO VA */
function finJuego(){	
	
}