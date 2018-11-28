/* Desarrollo del juego adivinarnumero.html */

window.onload = function(){

	document.getElementById('numerodelusuario').style.display = "none";
	document.getElementById('botoncomprueba').style.display = "none";
}

var aleatorio;
var min;
var max;

function iniciaJuego(){
	aleatorio = Math.floor(Math.random() * 100 + 1);
	min = 1;
	max = 100;	

	document.getElementById('numerodelusuario').style.display = "block";
	document.getElementById('botoncomprueba').style.display = "block";
	document.getElementById('botoninicio').style.display = "none";
}

function compruebaNum(){

	if(document.getElementById('numerodelusuario').value == aleatorio){
	alert('¡Felicidades! ¡Has acertado!');
	document.getElementById('estado').innerHTML = "";
	document.getElementById('numerodelusuario').style.display = "none";
	document.getElementById('botoncomprueba').style.display = "none";
	document.getElementById('botoninicio').style.display = "block";
	}
	else if(document.getElementById('numerodelusuario').value > aleatorio){
		max = parseInt(document.getElementById('numerodelusuario').value) - 1;
		document.getElementById('estado').innerHTML = "<br/>¡Demasiado alto!<br/>" + "El número se encuentra comprendido entre " + 
		min + " y " + max + ".";
	}
	else{
		min = parseInt(document.getElementById('numerodelusuario').value) + 1;
		document.getElementById('estado').innerHTML = "<br/>¡Demasiado bajo!<br/>" + "El número se encuentra comprendido entre " + 
		min + " y " + max + ".";
	}

}