/* EJERCICIO 1 */

// Devuelve los milisegundos que hay entre el momento actual y fin de año.
function milisgFinAnyo(){
	var fechaactual = new Date(); // fecha de hoy como cadena
	var y = fechaactual.getFullYear(); // año actual
	var findeanyo = new Date(y+1, 1, 1, 0); // 00:00 del 31 dic - 1 enero
	var milisgrestantes = findeanyo - fechaactual;
	var texto = "Fecha de hoy: " + fechaactual + "<br/>" + 
				 "Fecha de fin de año: " + findeanyo +  "<br/>" + 
				 "Milisegundos hasta fin de año: " + milisgrestantes + "<br/>";
	return texto;
}

/* EJERCICIO 2 */

function areaCirculo(r){
	var area = Math.PI * Math.pow(r, 2);
	return area;
}

/* EJERCICIO 3 */

function formateaPi4Dec(){
	var n4 = (Math.PI).toPrecision(5);
	return n4;
}

/* EJERCICIO 4 */

function infoCadena(texto){
	var info = "Longitud de la cadena: " + texto.length + "<br/>" + 
				"Cadena formateada: " + texto.italics().strike();

	return info;
}

/* EJERCICIO 5 */

var aleatorios1al1000 = [];
var texto = "";

function insertarFin(){
	var aleatorio = Math.floor(Math.random()*1000 + 1);
	aleatorios1al1000.push(aleatorio);
	texto = "Este es tu array: " + aleatorios1al1000;
	return texto;
}

function insertarInicio(){
	var aleatorio = Math.floor(Math.random()*1000 + 1);
	aleatorios1al1000.unshift(aleatorio);
	texto = "Este es tu array: " + aleatorios1al1000;
	return texto;
}

function borrarInicio(){
	aleatorios1al1000.shift();
	texto = "Este es tu array: " + aleatorios1al1000;
	return texto;
}

function borrarFin(){
	aleatorios1al1000.pop();
	texto = "Este es tu array: " + aleatorios1al1000;
	return texto;	
}

function ordenaAsc(){
	aleatorios1al1000.sort(function(a, b){return a - b});
	texto = "Este es tu array: " + aleatorios1al1000;
	return texto;
}

function ordenaDesc(){
	aleatorios1al1000.sort(function(a, b){return b - a});
	texto = "Este es tu array: " + aleatorios1al1000;
	return texto;
}

/* EJERCICIO 6 */

function primoONo(n){
	var primo = true;
	for(i = 2; i < n; i++){
		if(n % i == 0){
			primo = false;
		}
	}

	return primo;	
}

/* EJERCICIO 7 */

function restaPositiva(n1, n2){
	resta = 0;
	if(n1 >= n2){
		resta = n1 - n2;
	}else{
		resta = n2 - n1;
	}
	return "La diferencia es: " + resta;
}