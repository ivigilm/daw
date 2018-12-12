var datosjson;
var tabla;

// Al cargar la página, realizo la primera consulta AJAX a la base de datos
// Muestro la información
window.onload = muestraInfo();

function muestraInfo(){
	var xhr1 = new XMLHttpRequest();
	xhr1.onreadystatechange = function(){
		if(xhr1.readyState == 4 && xhr1.status == 200){
			datosjson = JSON.parse(xhr1.responseText);
			CargaDatos(datosjson);
		}
	}
	xhr1.open("GET", "espectaculos.php", true);
	xhr1.send();
}

// Muestra la información de la base de datos en una tabla y añade botones para votar
function CargaDatos(datosjson){
	tabla = document.getElementsByTagName("table")[0];
	tabla.innerHTML = "<tr><th>Fecha</th><th>Espectáculo</th><th>Artista</th><th>Votos</th><th></th></tr>";
	
	// ordenar el json por número de votos
	datosjson.sort(function(a,b){return b.votos - a.votos});

	// Crea una fila nueva por cada espectáculo
	for(var i = 0; i < datosjson.length; i++){

		var fila = document.createElement("tr");

		// Formateo de fecha
		var fecha = formateaFecha(datosjson[i].fecha);

		// Se crean las celdas y se insertan los datos correspondientes
		fila.insertCell(0).innerHTML = fecha;
		fila.insertCell(1).innerHTML = datosjson[i].espectaculo;
		fila.insertCell(2).innerHTML = datosjson[i].artista;
		fila.insertCell(3).innerHTML = datosjson[i].votos;
		fila.insertCell(4).innerHTML = "<button>Votar</button>";
		
		// Se agregan los eventos necesarios
		fila.onmouseover = pasaRaton;
		fila.cells[4].firstChild.onclick = votaEspectaculo;

		// Se agrega la fila a la tabla
		tabla.appendChild(fila);
	}
}

// Colorea la fila sobre la que está el ratón y muestra la foto del espectáculo
function pasaRaton(){

	// Recorro los espectáculos hasta encontrar el actual
	for(var i = 0; i < datosjson.length; i++){

		// Para la fila sobre la que está el ratón
		if(datosjson[i].espectaculo == this.cells[1].innerHTML){

			// si tiene foto, la muestro
			if(datosjson[i].foto != null){
				document.getElementById("imagenes").innerHTML = "<img src=fotos/" + datosjson[i].foto + " />";
			}else{
				document.getElementById("imagenes").innerHTML = "";
			}			
		}
	}
}


// Incrementa en 1 el nº votos de ese espectáculo y se vuelve a presentar la información
function votaEspectaculo(){
	// Hallo el id del espectáculo cuyo botón se pulsó
	var nombreespectaculo = this.parentNode.parentNode.cells[1].innerHTML; // this: button
	var id;

	for(var i = 0; i < datosjson.length; i++){
		if(datosjson[i].espectaculo == nombreespectaculo){
			id = datosjson[i].idespectaculo;
		}
	}

	var xhr2 = new XMLHttpRequest();
	xhr2.onreadystatechange = function(){
		if(this.readyState == 4 && this.status == 200){
			if(this.responseText == 200){
				console.log("Voto añadido a la base de datos.");
				muestraInfo(); // recarga la info de la tabla
			}else{
				console.log("Error al procesar el voto.");
			}
		}
	}
	xhr2.open("POST", "votar.php", true);
	xhr2.setRequestHeader("Content-Type", "application/x-www-form-urlencoded"); // necesario para el envío
	xhr2.send("id=" + id); // envío el id del espectáculo
}


// Transforma una fecha en formato yyyy-mm-dd a formato "Díadelasemana, dd de mes de yyyy"
function formateaFecha(fecha){
	var fechainicial = new Date(fecha);
	var semana = ["Domingo", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado" ];
	var mes = ["Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"];
	var fechafinal = semana[fechainicial.getDay()] + ", " + fechainicial.getDate() + " de " + 
						mes[fechainicial.getMonth()] + " de " + fechainicial.getFullYear();
	return fechafinal;
}