var m = 0, s = 0, d = 0;
var intervalo;
var mejores10 = []; // formato "mm:ss:dd"

function play(){
	intervalo = setInterval(enMarcha, 10);	
}

function enMarcha(){
	d++;
	
	if(d == 100){
		d = 0;
		s++;

		if(s == 60){
		s = 0;
		m++;
		}
	}	

	document.getElementById("crono").innerHTML =  
	(m ? (m < 10 ? "0" + m : m) : "00") + ":" + 
	(s ? (s < 10 ? "0" + s : s) : "00") + ".<span>" + 
	( d ? (d < 10 ? "0" + d + "</span>" : d + "</span>") : "00</span>" );
}

function reiniciar(){	
	m = 0, s = 0, d = 0;

	// Actualizo el contenido de las cajas y las oculto
	document.getElementById("crono").innerHTML = "00:00<span>.00</span>";
	document.getElementById("marcas").innerHTML = "Tiempos:<br/><br/>";
	document.getElementById("marcas").style.display = "none";
	document.getElementById("info").style.display = "none";
	document.getElementById("mejoresmarcas").style.display = "none";
	document.getElementById("mejoresmarcas").innerHTML = "Mejores marcas:<br/><br/>";

	mejores10.forEach(function(valor, indice){
		document.getElementById("mejoresmarcas").innerHTML += valor + "<br/>";
	});	
}

function pause(){
	clearInterval(intervalo);
}

// Muestra los tiempos que se van señalando
// (Funcionalidad: tiempo q se tarda en dar una vuelta a la pista)
function tiempo(){
	document.getElementById("marcas").style.display = "block";
	document.getElementById("marcas").innerHTML += document.getElementById("crono").innerHTML + "<br/>";	
	// compruebo si hay que guardar la marca
	guardarMarca(document.getElementById("crono").innerHTML);
}

// Guardo el tiempo si está entre los mejores 10
function guardarMarca(marca){
	if(mejores10.length < 10){
		mejores10.push(marca);
	}else if(esMejorMarca(marca)){
		mejores10[9] = marca;
	}
	mejores10.sort();
}

// Comprueba si el tiempo dado es menor que alguno de los del array
function esMejorMarca(marca){
	var esmejor = false;
	// si la nueva marca es menor que alguna de las ya guardadas = true
	if(marca < mejores10[9]){
		esmejor = true;
	}
	return esmejor;
}

function muestraMarcas(){
	document.getElementById("mejoresmarcas").style.display = "block";
}

function muestraInfo(){	
	document.getElementById("info").style.display = "block";		
}