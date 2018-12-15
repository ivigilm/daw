var codigo;
var caja1;
var caja2;

window.onload = function(){

	codigo = JSON.parse(cifrado); // string -> array
	caja1 = document.getElementById("caja1");
	caja2 = document.getElementById("caja2");	
}

function cifrarTexto(){
	var textocifrado = "";
	var encontrada = false;

	// Recorro los caracteres del texto introducido
	for(var i = 0; i < caja1.value.length; i++){
		encontrada = false;

		// Busco el caracter en codigo
		for(var j = 0; j < codigo.length; j++){

			if(codigo[j].letra.toLowerCase() == caja1.value.charAt(i).toLowerCase()){
				textocifrado += codigo[j].numero + " ";
				encontrada = true;
			}
		}		

		if(!encontrada){
			textocifrado += "* ";
		}
	}

	caja2.value = textocifrado;
}

function descifrarTexto(){
	var textodescifrado = "";
	var encontrada = false;
	var numeros = caja2.value.split(" "); // guardo los códigos en un array

	for(var i = 0; i < numeros.length; i++){
		encontrada = false;

		for(var j = 0; j < codigo.length; j++){
			if(numeros[i] == codigo[j].numero){
				textodescifrado += codigo[j].letra;
				encontrada = true;
			}
		}

		if(!encontrada){
			textodescifrado += "*";
		}
	}

	caja1.value = textodescifrado;
}