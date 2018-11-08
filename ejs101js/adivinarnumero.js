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

	// Borrar cuando esté acabado el diseño y cambiar el texto de "estado" para que solo dé el último intervalo.
	document.getElementById('estado').innerHTML = "El número secreto es: " + aleatorio;
}

function compruebaNum(){

console.log("Dentro de compruebaNum al principio: aleatorio = " + aleatorio + ", min = " + min + ", max = " + max);

	if(document.getElementById('numerodelusuario').value == aleatorio){
	alert('¡Felicidades! ¡Has acertado!');
	document.getElementById('estado').innerHTML = "";
	document.getElementById('numerodelusuario').style.display = "none";
document.getElementById('botoncomprueba').style.display = "none";
	document.getElementById('botoninicio').style.display = "block";
	}
	else if(document.getElementById('numerodelusuario').value > aleatorio){
		max = parseInt(document.getElementById('numerodelusuario').value) - 1;
		document.getElementById('estado').innerHTML += "<br/>" + "El número se encuentra comprendido entre " + 
		min + " y " + max + ".";
	}
	else{
		min = parseInt(document.getElementById('numerodelusuario').value) + 1;
		document.getElementById('estado').innerHTML += "<br/>" + "El número se encuentra comprendido entre " + 
		min + " y " + max + ".";
	}

}