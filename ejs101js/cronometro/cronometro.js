var h = 0, m = 0, s = 0;
var intervalo;

function play(){
	intervalo = setInterval(enMarcha, 1000);
}

function enMarcha(){
	s++;
	
	if(s == 60){
		s = 0;
		m++;

		if(m == 60){
			m = 0;
			h++;
		}
	}

	document.getElementById("crono").innerHTML = 
	( h ? (h < 10 ? "0" + h : h) : "00" ) + ":" + 
	(m ? (m < 10 ? "0" + m : m) : "00") + ":" + 
	(s ? (s < 10 ? "0" + s : s) : "00");
}

function reiniciar(){
	document.getElementById("crono").innerHTML = "00:00:00";
	h = 0;
	m = 0;
	s = 0;
}

function parar(){
	clearInterval(intervalo);
}