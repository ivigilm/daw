//function inicioJuego()
window.onload = function(){

			// Obtengo una palabra aleatoria del diccionario
			// var diccionarioIsa = ["bailar", "tetera", "ventana", "lago"];
			var aleatorio = Math.floor(Math.random() * diccionario.length);

			// Convierto la palabra en un array de letras
			var palabra = diccionario[aleatorio].split("");
			var abecedarioes = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'];

			var fallos = 0;				// fallos (dibujo)
			var pulsado = "";			// guardará la última tecla pulsada
			var i = "";					// contador 
			var palabraoculta = [];		// barritas donde se insertarán las letras acertadas

			// Coloco las barras de la palabra
			for(i = 0; i < palabra.length; i++){
				palabraoculta[i] = "_";

				// Muestro la palabra secreta (para comprobar que funciona bien)
				document.getElementById("pruebas").innerHTML += palabra[i];
				document.getElementById("palabraoculta").innerHTML += palabraoculta[i] + " ";
			};

			// Colocar botones de letras
			for(i = 0; i < abecedarioes.length; i++){
				var btn = document.createElement("button");
				var t = document.createTextNode(abecedarioes[i]);
				var botones = document.getElementsByTagName("button");
				btn.appendChild(t);
				btn.id = abecedarioes[i];
				btn.style.backgroundColor = 'green';				
				btn.onclick = function() {
					this.style.backgroundColor = 'red';
					this.disabled = true;
					pulsado = this.id;					// última letra pulsada

					if(palabra.includes(pulsado)){		// si la letra está en la palabra, relleno huecos
						for(i = 0; i < palabra.length; i++){
							if(palabra[i] == pulsado){
								palabraoculta[i] = pulsado;
							}
						}

						// Si rellenó la palabra completa
						if(!palabraoculta.includes('_')){							
							alert('¡Felicidades!');							
							for(i = 0; i < botones.length; i++){
								botones[i].disabled = true;
							}							
						}
					}else{								// si la letra no está
						fallos++;
						if(fallos == 8){
							// PRUEBAS: aquí irá el dibujo
							document.getElementById("estado").innerHTML = "Número de fallos: " + fallos;

							alert('Perdiste');
							for(i = 0; i < botones.length; i++){
								botones[i].disabled = true;
							}							
						}
						document.getElementById("estado").innerHTML = "Número de fallos: " + fallos;
					}

					document.getElementById("palabraoculta").innerHTML = "Palabra oculta: ";

					for(i = 0; i < palabra.length; i++){
						document.getElementById("palabraoculta").innerHTML += palabraoculta[i] + " ";
					}
				}
				document.body.appendChild(btn);
			}
		
		}