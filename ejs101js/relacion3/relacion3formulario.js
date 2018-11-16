/* FORMULARIO BÁSICO DE REGISTRO */

/*
Nombre: no vacío
Email: válido
Contraseña: al menos 8 caracteres, al menos 1 dígito, coincidentes
Captcha: operación matemática de suma entre dos números enteros de un dígito al azar, se solicitará el resultado de la suma
Verificación: hasta q se pinche no se habilitará el botón de envío

Validación individual: en el momento que se rellene uno y se abandone, se verificará y avisará del error
*/

/*document.formularioregistro.nombre.value

*/

function nombreUsuario(){
	if(document.getElementById('nombre').value == ""){
		document.getElementById('errornombre').innerHTML = "&nbsp; El nombre no puede estar vacío.";
		document.getElementById('nombre').focus();
	}else{
		document.getElementById('errornombre').innerHTML = "";
	}
}

function correo(){
	var emailintroducido = document.getElementById('email').value;
	var regex = /.+\@.+\..+/;
	if(!(regex.test(emailintroducido))){
		document.getElementById('erroremail').innerHTML = "&nbsp; El email debe ser válido.";
		document.getElementById('email').focus();
	}else{
		document.getElementById('erroremail').innerHTML = "";
	}
}

function contrasenia1(){
	var c1 = document.getElementById('pass1').value;
	if(c1.length < 8){
		document.getElementById('errorpass1').innerHTML = "&nbsp; La contraseña debe tener al menos 8 caracteres.";
		document.getElementById('pass1').focus();
	} else if(!/\d/.test(c1)){
		document.getElementById('errorpass1').innerHTML = "&nbsp; La contraseña debe tener al menos un dígito.";
		document.getElementById('pass1').focus();
	}else{
		document.getElementById('errorpass1').innerHTML = "";
	}
}

function contrasenia2(){
	var c1 = document.getElementById('pass1').value;
	var c2 = document.getElementById('pass2').value;
	if(c1 != c2 && (document.getElementById('errorpass1').innerHTML == "")){
		document.getElementById('errorpass2').innerHTML = "&nbsp; Ambas contraseñas deben coincidir.";
		document.getElementById('pass2').focus();
	}else{
		document.getElementById('errorpass2').innerHTML = "";
	}
}

var aleatorio1 = Math.floor((Math.random() * 9) + 1);;
var aleatorio2 = Math.floor((Math.random() * 9) + 1);;
var suma = aleatorio1 + aleatorio2;;

window.onload = function sumainicio(){
	document.getElementById('operacion').innerHTML += String(aleatorio1) + ' + ' + String(aleatorio2);
}

function sumatorio(){
	if(document.getElementById('captcha').value != suma){
		document.getElementById('errorcaptcha').innerHTML = "Respuesta incorrecta.";
		document.getElementById('captcha').focus();
	}else{
		document.getElementById('errorcaptcha').innerHTML = "";
	}
}

var e1 = document.getElementById('errornombre').innerHTML;
var e2 = document.getElementById('erroremail').innerHTML;
var e3 = document.getElementById('errorpass1').innerHTML;
var e4 = document.getElementById('errorpass2').innerHTML;
var e5 = document.getElementById('errorcaptcha').innerHTML;

function terminos(){
	document.getElementById('crear').disabled = false;

/*	if(e1 == "" && e2 == "" && e3 == "" && e4 == "" && e5 == ""){
		document.getElementById('crear').disabled = false;
	}else{
		document.getElementById('crear').disabled = true;
	}*/
}

/* NO HABILITA EL BOTÓN */

/*function antesDeEnviar(){
	if(!(e1 == "" && e2 == "" && e3 == "" && e4 == "" && e5 == "" && checkb == true)){
		alert('¡Comprueba los datos del formulario antes de enviarlo!');
		document.getElementById('crear').disabled = true;
	}
}*/