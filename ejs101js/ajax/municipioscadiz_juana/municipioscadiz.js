
var municipios = [];

window.onload = function(){
	// Cargo las comarcas al cargarse la página
	var x = new XMLHttpRequest();
	x.onreadystatechange = function(){
		if(this.readyState == 4 && this.status == 200){
			// devuelve una cadena con aspecto de json
			var comarcas = JSON.parse(this.responseText);		// lo mismo que x.responseText
			CargaComarcas(comarcas);
		}
	};
	x.open("GET", "comarcas.php", true);
	x.send(); // no le tenemos que enviar nada

}


function CargaComarcas(comarcas){
	var texto = "<option value='0' selected='selected'>-- Elegir comarca --</option>";

	// recorro todas las comarcas y pongo las opciones
	for (var i = 0; i < comarcas.length; i++){
		texto += "<option value='" + comarcas[i].id + "'>" + 
		comarcas[i].nombre + "</option>";
	}

	document.getElementById("comarca").innerHTML = texto;
}


function CargaMunicipios(idComarca){
	// nos aseguramos de que haya seleccionada alguna comarca
	if(idComarca != -1){
		var x = new XMLHttpRequest();
		x.onreadystatechange = function(){
			if(x.readyState == 4 && x.status == 200){
				municipios = JSON.parse(x.responseText);
				var texto = "<option value='-1' selected='selected'>-- Elegir municipio --</option>";
				for(var i = 0; i < municipios.length; i++){
					texto += "<option value='" + i + "' >" + municipios[i].nombre + "</option>";
				}
				document.getElementById("municipio").innerHTML = texto;
			}
		}
		x.open("POST", "municipios.php", true);
		x.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");	// necesita que le indique que le mando datos
		x.send("comarca=" + idComarca);	// tengo que enviar el id de la comarca para obtener los municipios
			// como en el php recibe la variable "comarca" tengo que enviarle el dato guardado en la variable
	}
}

/*
	Como la variable "municipios" está creada dentro de una función, fuera de esta no se podrá acceder a ella.
	Para arreglarlo podemos:
		1. crear la variable de forma global
		2. en lugar de llamar a esta función desde #municipio con onchange llamarla desde 
		cada option con el evento correspondiente a la selección de la option
*/


function PresentaDatos(indice){
	if(indice > -1){
		var texto = "";
		texto += "Población: " + municipios[indice].poblacion + "<br/>" +
				 "Superficie: " + municipios[indice].superficie + "<br/>" +
				 "Densidad de población: " + municipios[indice].poblacion + "<br/>" +
				 "Altitud: " + municipios[indice].altitud + "<br/>" +
				 "Gentilicio: " + municipios[indice].gentilicio + "<br/>" +
				 "Pedanías: " + municipios[indice].pedanias;
		
		document.getElementById("datos").innerHTML = texto;

		console.log(municipios[indice].nombre);
		/*
		for(i = 0; i < municipio.length; i++){
			texto += municipio[i]
		}*/		
	}
}



/*


	for (var i = 0; i < comarcas.length; i++){
		texto += "<option value='" + municipio[i].id + "'>" + 
		comarcas[i].nombre + "</option>";
	}*/



/*	var xhrmunicipio = new XMLHttpRequest();
	xhrmunicipio.onreadystatechange = function(){};
	xhrmunicipio.open("POST", "municipios.php", true);
	xhrmunicipio.send();*/

/*
datos del municipio: nombre, 
población (número de habitantes), superficie (km2), 
densidad de población (habitantes por km2), altitud (m sobre el
 nivel del mar), gentilicio y pedanías que tiene.
Toda la información se solicitará mediante Ajax a los recursos 
comarcas.php (se solicita por GET) y municipios.php (se solicita 
por POST indicando el identificador de la comarca).
*/