var m = 0, s = 0, d = 0;
var intervalo;

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
	document.getElementById("crono").innerHTML = "00:00<span>.00</span>";
	m = 0;
	s = 0;
	d = 0;
}

function pause(){
	clearInterval(intervalo);
}