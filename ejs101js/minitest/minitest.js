var primeravez = true; // controla si es el primer intento
var intentos = 0;
var aciertos = 0;

function correccion(){
	intentos++;
	aciertos = 0;

	// Tras el primer intento el botón se llamará "Reintentar".
	if(primeravez){
		primeravez = false;
		document.getElementById("corregir").value = "Reintentar";
	}

	// Comprueba las respuestas

	// Pregunta 1
	if(document.getElementsByTagName("input")[0].checked &&
		document.getElementsByTagName("input")[1].checked &&
		!document.getElementsByTagName("input")[2].checked &&
		!document.getElementsByTagName("input")[3].checked ){
		aciertos++;
	}

	// Pregunta 2
	if(!document.getElementsByTagName("input")[4].checked &&
		!document.getElementsByTagName("input")[5].checked &&
		document.getElementsByTagName("input")[6].checked ){
		aciertos++;
	}

	// Pregunta 3
	if(document.getElementById("query").selected){
		aciertos++;
	}

	// Pregunta 4
	if(document.getElementById("gusta").value == "sí" ){
		aciertos++;
	}

	// Porcentaje de aciertos y el número de intentos realizados
	document.getElementById("porcentaje").innerHTML = "Aciertos: " + (aciertos*25) +
	"%<br/>" + "Intentos: " + intentos;

	// Si se acertaron todas las preguntas (100% aciertos), deshabilita botón
	if(aciertos == 4){
		document.getElementById("corregir").disabled = true;
	}
	
}