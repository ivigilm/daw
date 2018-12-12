/* Relación 1 de ejercicios. */

// Ejercicio 1
// Devuelve una cadena con la tabla de multiplicar del número introducido por parámetro.
function tablaMultiplicar(numero){

	var tabla = "";

	for(var i = 1; i <= 10; i++){
		tabla = tabla + numero + ' x ' + i + ' = ' + numero*i + '<br / >';
	}

	return tabla;
}

// Ejercicio 2
// Devuelve una cadena con el texto introducido escrito en 6 tamaños: h1 a h6 (HTML).
function escribeCabeceras(texto){
	var escrito = "";
	for(i = 1; i <= 6; i++){
		escrito = escrito + '<h' + i + '>' + "Javascript" + '</h' + i + '>' + '<br />';
	}

	return escrito;
}

// Ejercicio 3
// Devuelve una cadena con la factorial del número introducido.
function miFactorial(n){
	var factorial = 1;

	for(i = n; i >= 1; i--){
    	factorial = factorial * i;
	}

	return n + "! = " + factorial;
}

//Ejercicio 4
// Devuelve una cadena que dice si el texto dado tiene mayúsculas, minúsculas o ambas.
function mayusculasMinusculas(texto){

	ups = 0;
	lows = 0;
	msj = "";

    for(i = 0; i < texto.length; i++){        
    	if(texto[i].toUpperCase() == texto[i]){
    		ups = ups + 1; } // if it's uppercase
    	else{
    		if(texto[i].toLowerCase() == texto[i]){
    			lows = lows + 1;} // if it's lowercase
       		}
    	}

    	if(ups == texto.length){
    		msj = "¡Tu texto solo contiene mayúsculas!";
    	}else{
    		if(lows == texto.length){
    			msj = "¡Tu texto solo contiene minúsculas!";
    		}else{
    			msj = "¡Tu texto contiene tanto mayúsculas como minúsculas!";
    		}
    	}
	return msj;    
}

// Ejercicio 5
// Devuelve información sobre una cadena dada.
function infoCadena(texto){

	var array1 = texto.split(" ");

	var resultado = "El número de palabras de la cadena es: " + array1.length + '<br />';
	resultado = resultado + "La primera palabra es: " + array1[0] + '<br />';
	resultado = resultado + "La última palabra es: " + array1[array1.length -1] + '<br />';
	array1.reverse();
	resultado = resultado + "Palabras en orden inverso: " + array1 + '<br />';
	array1.sort()
	resultado = resultado + "Palabras ordenadas de la A a la Z: " + array1 + '<br />';
	array1.reverse();
	resultado = resultado + "Palabras ordenadas de la Z a la A: " + array1 + '<br />';

	return resultado;
}

// Ejercicio 6: crear un array con los doce meses

var meses = ["enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre"];

// Ejercicio 7
// Dado un número, devuelve una cadena que dice si es par o impar.
function parImpar(numero){
	var texto = "";

	if(numero%2 == 0){
		texto = "El número es par.";
	}
	else{
		texto = "El número es impar.";
	}

	return texto;
}

// Ejercicio 8
// Dado un DNI comprueba si es correcto. Para ello se utiliza la siguiente fórmula:
// DNI / 23 = índice de la letra correspondiente en "TRWAGMYFPDXBNJZSQVHLCKE".
function dniCorrecto(numero, letra){
	var abecedariodni = "TRWAGMYFPDXBNJZSQVHLCKE";
	var suma = 0;
	var correctoono = "";

	for(i = 0; i < 8; i++){
		suma = suma + numero[i];
	}

	if(letra.toUpperCase() == abecedariodni[suma%23]){
		correctoono = "DNI correcto";
	}else{
		correctoono = "DNI incorrecto";
	}

	return correctoono;
}

// Ejercicio 9
// Comprueba si la cadena dada es un palíndromo.
function esPalindromo(texto){

	var puntuacion = " ,.;:'¡!¿?\"";
	var letras;
	var letrasreves;
	var compruebapalindromo = true;
	var resultado = "";

	// elimino espacios y puntuación

	var palabras = texto.split(/[ ,.;:"'!¿?¡]/);
	texto = "";

	for(i = 0; i < palabras.length; i++){
		texto += palabras[i];
	}
	
	// convierto el texto a minúsculas para comprobar si las letras coinciden

	texto = texto.toLowerCase();

	// creo dos arrays: cada uno en un sentido

	letras = texto.split("");
	letrasreves = texto.split("").reverse();

	// compruebo si coinciden los caracteres uno a uno

	for(i in letras){
		if(letras[i] != letrasreves[i]){
			compruebapalindromo = false;
		}
	}

	// una vez comprobado si es palíndromo, creo el texto de salida

	if(compruebapalindromo){
		resultado = "Es un palíndromo.";
	}
	else{
		resultado = "No es un palíndromo.";
	}

	return resultado;
}

// Ejercicio 10
// Resuelto en el .html