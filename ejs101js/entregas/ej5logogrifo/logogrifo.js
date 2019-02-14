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

// Desordeno el abecedario, creando pares clave-valor aleatorios
let abecedario = ["a", "b", "c", "d", "e", "f", "g", "h", "i", "j", 
"k", "l", "m", "n", "ñ", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" ];
abecedario.sort(function(a,b){return 0.5 - Math.random()});
    
// Agrego un elemento vacío al pricipio para cubrir el índice '0'
abecedario.unshift("");


$(document).ready(function(){

    // 1. SELECCIONO LAS PALABRAS AL AZAR

    // Creo el array donde guardaré las palabras elegidas
    let palabrasocultas = [];
    let midiccionario;
        
    // Obtengo todas las palabras del json
    // $.ajax({
    //     url: 'algunaspalabras.json',
    //     success: function(resultado){
    //         midiccionario = resultado.slice();

    //         // midiccionario = resultado; // midiccionario contiene el json
    //         //midiccionario = Array.prototype.slice.call(resultado, 0);
    //         // $.each(resultado, function(indice,elemento){
    //         //     midiccionario.push(elemento);
    //         // });
    //     }
    // });

    // $.getJSON('algunaspalabras.json', function(resultado){
    //     $.each(resultado, function(indice, elemento){
    //         midiccionario.push(elemento);
    //     });
    // });
    
    // Provisional
    midiccionario = [
        { "palabra":"meta", "definicion":"objetivo" },
        { "palabra":"sefardi", "definicion":"Judío oriundo de la península Ibérica." },
        { "palabra":"segregar", "definicion":"Separar o apartar algo o a alguien de otra u otras cosas." },
        { "palabra":"separador", "definicion":"Lo que es la mampara de oficina respecto a otras salas." },
        { "palabra":"sepia", "definicion":"molusco" },
        { "palabra":"sepsis", "definicion":"Intoxicación de la sangre." },
        { "palabra":"septiembre", "definicion":"Noveno mes del calendario gregoriano." }
    ];

    // Selecciono 7 palabras del diccionario

    // Encuentro una palabra para cada longitud y las guardo en un array en orden inverso
    for(let i = 4; i <= 10; i++){
        // Busco la primera palabra
        let aleatorio = Math.floor((Math.random() * (midiccionario.length)));

        // saco palabras aleatorias hasta que encuentro una de la longitud deseada
        while(midiccionario[aleatorio].palabra.length != i){
            aleatorio = Math.floor((Math.random() * (midiccionario.length)));
        }
        
        // Cuando la tengo, la guardo al principio del array
        // (de forma que quede la de 10 caracteres al principio)
        palabrasocultas.unshift(midiccionario[aleatorio]);
    }

    // 2. CREO LAS CASILLAS CON EL CÓDIGO DE LA LETRA (Y LA DEFINICIÓN)
   
    // Para cada palabra
    for(let i = 0; i < palabrasocultas.length; i++){
        let contenedorpalabra = "<div class='adivinanza' id='palabra" + i + "'>";

        // Para cada letra de la palabra creo un input con placeholder la letra
        for(let j = 0; j < palabrasocultas[i].palabra.length; j++){
            contenedorpalabra += "<input type='text' class='casilla' maxlength='1' oninput='comprueba(this)' placeholder='" + 
                                    abecedario.indexOf(palabrasocultas[i].palabra.charAt(j)) + 
                                    "' />";            
        }
        // Muestro la definición de la palabra
        contenedorpalabra += "<p>" + palabrasocultas[i].definicion + "</p>";
        contenedorpalabra += "</div>";

        // Introduzco todo en el contenedor del juego
        $("#juego").append(contenedorpalabra);
    }


});

// 3. JUEGO

// Cada vez que cambia el contenido de un input, se comprueba su validez
function comprueba(esteinput){

    let colcasillas = $('input'); // colección de objetos
    let miscasillas = Array.prototype.slice.call(colcasillas, 0); // array
    let posicionactual = miscasillas.indexOf(esteinput);
    let posicionanterior;
    let posicionfinal = miscasillas.indexOf(miscasillas[miscasillas.length - 1]);

    if(posicionactual === 0){
        posicionanterior = posicionfinal;
    }else{
        posicionanterior = posicionactual - 1;
    }

    // Si es correcta, relleno todas las casillas de esa letra
    if(esteinput.value === abecedario[esteinput.getAttribute('placeholder')]){

        let i;

        for(let i = 0; i < miscasillas.length; i++){
            if(miscasillas[i].getAttribute('placeholder') == esteinput.getAttribute('placeholder')){
                miscasillas[i].value = esteinput.value;
                miscasillas[i].style.backgroundColor = '#6ad361'; // verde
            }
        }


        // FALLA:
            // solo salta una posición al colocar la letra, cuando llega a una q ya está verde se queda ahí
            // felicitar cuando se gane (solo haya casillas verdes)

        //Y muevo el cursor a la siguiente casilla q no sea verde
        do{
            if(posicionactual === posicionfinal){
                i = 0;
            }else{
                i = posicionactual + 1;
            }
        }while(miscasillas[i].style.backgroundColor === '#6ad361' && i != posicionanterior);
             
        // Cuando encuentro una casilla sin acertar le pongo el foco
        if(miscasillas[i].style.backgroundColor != '#6ad361'){
            miscasillas[i].focus();
        }else{  // si no la encuentro, es q está solucionado el acertijo
            alert("felicidades");
        }

    }
    else{
        esteinput.style.backgroundColor = '#fa4f5c';
    }

}