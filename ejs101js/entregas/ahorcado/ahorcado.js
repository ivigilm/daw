//function inicioJuego()
window.onload = function(){

			// Obtengo una posición aleatorio del diccionario
			var aleatorio = Math.floor(Math.random() * diccionario.length);

			// Obtengo la palabra correspondiente
			var palabra = diccionario[aleatorio];
			// Quito acentos y diéresis
			palabra = quitaAcentos(palabra);
			// Convierto la palabra en un array de letras
			palabra = palabra.split("");
			
			var abecedarioes = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'];

			var fallos = 0;				// fallos (dibujo)
			var pulsado = "";			// guardará la última tecla pulsada
			var i = "";					// contador 
			var palabraoculta = [];		// barritas donde se insertarán las letras acertadas

			for(i = 0; i < palabra.length; i++){
				// Coloco las barras de la palabra				
				palabraoculta[i] = "_";

				// Muestro las letras que se han acertado
				document.getElementById("palabraoculta").innerHTML += palabraoculta[i] + " ";
			};

			// Colocar botones de letras
			for(i = 0; i < abecedarioes.length; i++){
				var btn = document.createElement("button");
				var t = document.createTextNode(abecedarioes[i]);
				var botones = document.getElementsByTagName("button");
				btn.appendChild(t);
				btn.id = abecedarioes[i];			
				btn.onclick = function() {
					this.style.backgroundColor = "#20557F";
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
							alert('¡Felicidades! ¡Acertaste!');							
							location.reload();					
						}
					}else{								// si la letra no está
						fallos++;
						var h = document.getElementById("horca");
						var ctx = h.getContext("2d");	// context object (with 2D rendering context and drawing functions)
						ctx.lineWidth = 4;

						switch(fallos){
							case 1:
								ctx.moveTo(50, 20);		// punto donde empieza la línea
								ctx.lineTo(50, 140);	// punto donde acaba
								ctx.stroke();
								ctx.moveTo(48, 20);
								ctx.lineTo(200, 20);
								ctx.stroke();
							break;
							case 2:
								ctx.moveTo(200, 18);
								ctx.lineTo(200, 40);
								ctx.stroke();
							break;
							case 3:
								ctx.beginPath();
								ctx.arc(200, 50, 10, 0, 2 * Math.PI);
								ctx.stroke();
							break;
							case 4:
								ctx.moveTo(200, 60);
								ctx.lineTo(200, 100);
								ctx.stroke();

							break;
							case 5:
								ctx.moveTo(200, 100);
								ctx.lineTo(170, 110);
								ctx.stroke();

							break;
							case 6:
								ctx.moveTo(200, 100);
								ctx.lineTo(230, 110);
								ctx.stroke();

							break;
							case 7:
								ctx.moveTo(200, 80);
								ctx.lineTo(170, 80);
								ctx.stroke();

							break;
							case 8:
								ctx.moveTo(200, 80);
								ctx.lineTo(230, 80);
								ctx.stroke();

						}

						if(fallos == 8){
							alert('¡Oh, no! Has fallado. La palabra oculta era ' + diccionario[aleatorio] + ".");							
							location.reload();				
						}
					}

					document.getElementById("palabraoculta").innerHTML = "";

					for(i = 0; i < palabra.length; i++){
						document.getElementById("palabraoculta").innerHTML += palabraoculta[i] + " ";
					}
				}
				document.body.childNodes[5].childNodes[3].appendChild(btn);
			}
		
		}

function quitaAcentos(cadena){
	var nuevacadena = cadena;
	var acentos = "áäéëíïóöúü";
	var sustitutos = "aaeeiioouu";
	for (var i = 0; i < nuevacadena.length; i++){
		if(acentos.includes(nuevacadena[i])){
			var posicion = acentos.indexOf(nuevacadena.charAt(i));
			nuevacadena = nuevacadena.slice(0, i) + sustitutos.charAt(posicion) + 
						nuevacadena.slice(i+1);	
		}
	}
	return nuevacadena;
}		