/*
1. Seleccionar 7 palabras del diccionario, 
    de 10, 9, 8, 7, 6, 5, 4 y 3 letras. (Introducirlas en un array.)
2. Crear dinámicamente los contenedores para las palabras
    con las casillas correspondientes dentro (con la letra asociada)
    y la definición.
3. Juego: el usuario escribe una letra, si es cierta se rellenan todas,
    si no, se pone en rojo.
    Tras rellenar exitosamente una casilla, se comprueba si ganó.
*/

// Creo el array donde guardaré el diccionario
let midiccionario = [];

// Desordeno el abecedario, creando pares clave-valor aleatorios
let abecedario = ["a", "b", "c", "d", "e", "f", "g", "h", "i", "j", 
"k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" ];
abecedario.sort(function(a,b){return 0.5 - Math.random()});
    
// Agrego un elemento vacío al pricipio para cubrir el índice '0'
abecedario.unshift("");


$(document).ready(function(){
    // Creo el array donde guardaré las palabras elegidas
    let palabrasocultas = [];

    // Obtengo todas las palabras del json y las guardo en "midiccionario"
    $.ajax({
        url: 'algunaspalabras.json',
        success: function(resultado){
            midiccionario = resultado;
            palabrasocultas = eligePalabras(midiccionario);
            creaCasillas(palabrasocultas);
        }
    });    

});

// Selecciona 7 palabras del diccionario (de 4 a 10 caracteres, una de cada) al azar
function eligePalabras(diccionario){

    let palabras = [];

    // Encuentro una palabra para cada longitud y las guardo en un array en orden inverso
    for(let i = 4; i <= 10; i++){
        let aleatorio = Math.floor(Math.random() * diccionario.length);

        // Saco palabras aleatorias hasta que encuentro una de la longitud deseada
        while(diccionario[aleatorio].palabra.length != i){
            aleatorio = Math.floor(Math.random() * midiccionario.length);
        }

        // Cuando la tengo, la guardo al principio del array
        // (de forma que quede la de 10 caracteres al principio)
        palabras.unshift(diccionario[aleatorio]);
    }

    return palabras;
}

// Recibe un array de palabras y crea un contenedor para cada una 
// con inputs para las letras
function creaCasillas (palabras){
    // Para cada palabra
    for(let i = 0; i < palabras.length; i++){
        let contenedorpalabra = "<div class='adivinanza' id='palabra" + i + "'>";

        // Para cada letra de la palabra creo un input (placeholder: id de letra)
        for(let j = 0; j < palabras[i].palabra.length; j++){
            contenedorpalabra += "<input type='text' class='casilla' maxlength='1' oninput='comprueba(this)' placeholder='" + 
                                    abecedario.indexOf(palabras[i].palabra.charAt(j)) + 
                                    "' />";
        }

        // Muestro la definición de la palabra
        contenedorpalabra += "<p>" + palabras[i].definicion + "</p>";
        contenedorpalabra += "</div>";
        
        // Introduce todo en el contenedor del juego
        $("#juego").append(contenedorpalabra);
    }
}

// Cada vez que cambia el contenido de un input, se comprueba su validez
function comprueba(esteinput){

    let colcasillas = $('input'); // colección de objetos
    let miscasillas = Array.prototype.slice.call(colcasillas, 0); // array
    let posicionactual = miscasillas.indexOf(esteinput);
    let posicionanterior;
    let posicionfinal = miscasillas.indexOf(miscasillas[miscasillas.length - 1]);

    posicionanterior = anteriorCasilla(posicionactual);

    // Si es correcta
    if(esteinput.value === abecedario[esteinput.getAttribute('placeholder')]){
        let i;

        esteinput.disabled = true;

        // relleno las casillas correspondientes con esa letra
        for(i = 0; i < miscasillas.length; i++){
            if(miscasillas[i].getAttribute('placeholder') === esteinput.getAttribute('placeholder')){
                miscasillas[i].value = esteinput.value;
                miscasillas[i].style.backgroundColor = '#6ad361'; // verde
                miscasillas[i].disabled = true;
            }
        }

        //Y muevo el cursor a la siguiente casilla
        i = siguienteCasilla(posicionactual);
        // Hasta encontrar una que no sea verde o dar la vuelta completa al acertijo
        while(miscasillas[i].disabled === true && i != posicionanterior){
            i++;
        }
            
        // Cuando encuentro una casilla sin acertar le pongo el foco
        if(!miscasillas[i].disabled){
            miscasillas[i].focus();
        }


        // FALLA

        // Comprueba si se ha resuelto el juego
        if(compruebaFin()){
            alert('Felicidades');
        }

    }
    else if(esteinput.value == ""){
        esteinput.style.backgroundColor = 'white';
    }else{
        esteinput.style.backgroundColor = '#fa4f5c'; // rojo
    }

}

// Recibe la posición de la casilla actual y devuelve la posición de la anterior
function anteriorCasilla(casillaactual){
    let casillaanterior;

    if(casillaactual === 0){
        casillaanterior = $('input').length - 1;
    }else{
        casillaanterior = casillaactual - 1;
    }

    return casillaanterior;
}

// Recibe la posición de la casilla actual y devuelve la posición de la siguiente casilla
function siguienteCasilla(casillaactual){
    let casillasiguiente;

    if(casillaactual === $('input').length - 1){
        casillasiguiente = 0;
    }else{
        casillasiguiente = casillaactual + 1;
    }
    
    return casillasiguiente;
}

// Comprueba si el acertijo ha sido resuelto y devuelve true/false
function compruebaFin(){
    let todaslascasillas = $('input');
    let fin = true;
    for(i = 0; i < todaslascasillas.length; i++){
        if(!todaslascasillas[i].disabled){
            fin = false;
        }        
    }
    return fin;
    // todaslascasillas[i].value != abecedario[todaslascasillas[i].getAttribute('placeholder')]
    // !todaslascasillas[i].disabled
}