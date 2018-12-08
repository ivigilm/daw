
var palabras = ["APROBAR", "APTO", "CATEAR", "CERO", "EXAMEN", "NOTA", "NOTABLE", "TEST"];

// Variables palabra: casilla inicio (i, j), fin (i, j), sentido (norte, etc)
var aprobar = [8, 3, 2, 3, "n" ];
var apto = [6, 4, 9, 1, "so" ];
var catear = [ 5, 0, 0, 0, "n" ];
var cero = [ 5, 0, 5, 3, "e" ];
var examen = [ 1, 1, 6, 6, "se" ];
var nota = [ 6, 6, 9, 6, "s" ];
var notable = [ 6, 6, 0, 6, "n" ];
var test = [ 4, 6, 1, 3, "no" ];

var abecedario = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
var i, j, k, letra, numeroboton, fila, col, correcta = true, primeraletra, click = 1;




window.onload = function(){

	// Creo los botones

	for(var i = 0; i < 10; i++){
		for(var j = 0; j < 8; j++){
			var btn = document.createElement("button");
			var aleatorioabc = Math.floor(Math.random() * abecedario.length);
			btn.id = j + 8*i;
			btn.innerHTML =  abecedario[aleatorioabc];
			btn.setAttribute("onclick", "comprobarBoton(this)");
			document.getElementById("sopa").appendChild(btn);
		}

		document.getElementById("sopa").innerHTML += "<br/>";
	}

	// Coloco las palabras
	ponerPalabras();
}



// Coloca las palabras en la sopa de letras
function ponerPalabras(){

	// aprobar
	for(i = aprobar[0], j = aprobar[1], letra = 0; i >= 2 ; i--, letra++){
		numeroboton = j + 8*i;
		document.getElementById(numeroboton).innerHTML = palabras[0][letra];
	}

	// apto
	for(i = apto[0], j = apto[1], letra = 0; i <= 9; i++, j--, letra++){
		numeroboton = j + 8*i;
		document.getElementById(numeroboton).innerHTML = palabras[1][letra];
	}

	// catear
	for(i = catear[0], j = catear[1], letra = 0; i >= 0; i--, letra++){
		numeroboton = j + 8*i;
		document.getElementById(numeroboton).innerHTML = palabras[2][letra];
	}

	// cero
	for(i = cero[0], j = cero[1], letra = 0; j <= 3; j++, letra++){
		numeroboton = j + 8*i;
		document.getElementById(numeroboton).innerHTML = palabras[3][letra];
	}

	// examen
	for(i = examen[0], j = examen[1], letra = 0; i <= 6; i++, j++, letra++){
		numeroboton = j + 8*i;
		document.getElementById(numeroboton).innerHTML = palabras[4][letra];		
	}

	// nota
	for(i = nota[0], j = nota[1], letra = 0; i <= 9; i++, letra++){
		numeroboton = j + 8*i;
		document.getElementById(numeroboton).innerHTML = palabras[5][letra];		
	}

	// notable
	for(i = notable[0], j = notable[1], letra = 0; i >= 0 ; i--, letra++){
		numeroboton = j + 8*i;
		document.getElementById(numeroboton).innerHTML = palabras[6][letra];		
	}

	// test
	for(i = test[0], j = test[1], letra = 0; i >= 1 ; i--, j--, letra++){
		numeroboton = j + 8*i;
		document.getElementById(numeroboton).innerHTML = palabras[7][letra];		
	}
}


	
function comprobarBoton(btn){

	if(click == 1){		// click de inicio de palabra
		// guardo fila y columna del primer botón pulsado
		fila = (btn.id - btn.id % 8)/8;
		col = 0 + btn.id % 8;
		// si no se ha dado click en el inicio de una palabra, intento erróneo
		if(btn.id != 67 && btn.id != 52 && btn.id !=  40 && btn.id != 
		 9 && btn.id !=  54 && btn.id !=  38){
			correcta = false;
		}else{
			primeraletra = btn.id;
		}

		click = 2;
	}else{				// click de fin de palabra
		// solo compruebo la segunda letra si el intento no es ya erróneo
		// (si se ha pulsado un inicio de palabra)
		if(correcta){
			switch(parseInt(primeraletra)){
				case 67:
					if(btn.id == 19){
						for(i = aprobar[0], j = aprobar[1], letra = 0; i >= 2 ; i--, letra++){
							numeroboton = j + 8*i;
							document.getElementById(numeroboton).style.backgroundColor = 'pink';
							// elimino palabra
							for(k = 0; k < palabras.length; k++){
								if(palabras[k] == "APROBAR"){
									palabras.splice(k, 1);
								}
							}
						}
					};
				break;
				case 52:
					if(btn.id == 73){
						for(i = apto[0], j = apto[1], letra = 0; i <= 9; i++, j--, letra++){
							numeroboton = j + 8*i;
							document.getElementById(numeroboton).style.backgroundColor = 'pink';
							for(k = 0; k < palabras.length; k++){
								if(palabras[k] == "APTO"){
									palabras.splice(k, 1);
								}
							}
						}
					};
				break;
				case 40:
					if(btn.id == 0){		// catear
						for(i = catear[0], j = catear[1], letra = 0; i >= 0; i--, letra++){
							numeroboton = j + 8*i;
							document.getElementById(numeroboton).style.backgroundColor = 'pink';
							for(k = 0; k < palabras.length; k++){
								if(palabras[k] == "CATEAR"){
									palabras.splice(k, 1);
								}
							}
						}
					} else if(btn.id == 43){		// cero
						for(i = cero[0], j = cero[1], letra = 0; j <= 3; j++, letra++){
							numeroboton = j + 8*i;
							document.getElementById(numeroboton).style.backgroundColor = 'pink';
							for(k = 0; k < palabras.length; k++){
								if(palabras[k] == "CERO"){
									palabras.splice(k, 1);
								}
							}
						}
					};
				break;
				case 9:
					if(btn.id == 54){
						for(i = examen[0], j = examen[1], letra = 0; i <= 6; i++, j++, letra++){
							numeroboton = j + 8*i;
							document.getElementById(numeroboton).style.backgroundColor = 'pink';
							for(k = 0; k < palabras.length; k++){
								if(palabras[k] == "EXAMEN"){
									palabras.splice(k, 1);
								}
							}		
						}
					};
				break;
				case 54:
					if(btn.id == 78){
						for(i = nota[0], j = nota[1], letra = 0; i <= 9; i++, letra++){
							numeroboton = j + 8*i;
							document.getElementById(numeroboton).style.backgroundColor = 'pink';
							for(k = 0; k < palabras.length; k++){
								if(palabras[k] == "NOTA"){
									palabras.splice(k, 1);
								}
							}		
						}	
					}else if(btn.id == 6){
						for(i = notable[0], j = notable[1], letra = 0; i >= 0 ; i--, letra++){
							numeroboton = j + 8*i;
							document.getElementById(numeroboton).style.backgroundColor = 'pink';
							for(k = 0; k < palabras.length; k++){
								if(palabras[k] == "NOTABLE"){
									palabras.splice(k, 1);
								}
							}		
						}
					};
				break;
				case 38:
					if(btn.id == 11) {
						for(i = test[0], j = test[1], letra = 0; i >= 1 ; i--, j--, letra++){
							numeroboton = j + 8*i;
							document.getElementById(numeroboton).style.backgroundColor = 'pink';
							for(k = 0; k < palabras.length; k++){
								if(palabras[k] == "TEST"){
									palabras.splice(k, 1);
								}
							}		
						}
					};
				break;
				default:
				console.log("Fallo en el switch.");	
			}
		}

		correcta = true;
		click = 1;

		// FIN DEL JUEGO
		if(palabras.length == 0){
			alert("¡Ganaste!");
			location.reload();
		}
	}
}
