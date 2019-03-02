/*
    1. Al pulsar el botón de 12/16/20 cartas, guardar en un array las seleccionadas desordenadas
    2. Crear 12 contenedores "carta" con ambas imágenes y mostrarlos (boca abajo)
    3. Al pulsar la primera carta, flip, al pulsar la segunda comprobar si son pareja
        3.1. Lo son: se quedan boca arriba y se comprueba si están todas boca arriba
        3.2. No: se dan la vuelta
*/


// Guardo las imágenes
let cartas = ['v1chandler.png', 'v1joey.png', 'v1monica.png', 'v1phoebe.png', 'v1rachel.png', 'v1ross.png', 'v1janice.png', 'v1richard.png', 'v1amy.png', 'v1gunther.png'];
let contador = 0; // no se ha pulsado ninguna carta
let primeracarta = "";
let posicionprimeracarta;

$(document).ready(function(){


});

// Muestra el número de cartas seleccionadas
function presentarCartas(boton){
    let mazo = [];
    let numerodecartas = boton.innerHTML;

    // Guardo las imágenes que utilizaré (de todas las posibles)
    let opciones = eligeNumCartas(cartas, numerodecartas);

    // Saco dos copias de cada carta y las barajo
    mazo = DesordenaCartas(opciones).slice();

    // Vacío el contenedor del juego
    $("#juego").html("");

    // Muestro las cartas
    for(let i = 0; i < mazo.length; i++){
        let miimagen = `<img src='friends/${mazo[i]}' width='170' height='210' alt='personaje de Friends' />`;

        let micarta = `<div class='cards' id='card${i}' onclick='giraCartas(this)'>
                    <div class='front' id='front${i}'>${miimagen}</div>
                    <div class='back' id='back${i}'><img src='friends/mirilla.png' width='170' height='210' alt='personaje de Friends'/></div>
                    </div>`; 
        
        // ORIGINAL: onclick='giraCartas(this)'
        // RECOMENDADO: onclick='giraCartas(event)'
        // micarta.addEventListener('click', giraCartas, false);

        $('#juego').append(micarta);
    }

    // Oculto el anverso de las cartas
    $('.front').hide();
}

// Dada una baraja y un número a elegir entre 12, 16 o 20, 
// devuelve un array con las cartas que aparecerán en el juego
function eligeNumCartas(baraja, numerodecartas){
    let misimagenes = [];

    for(let i = 0; i < numerodecartas/2; i++){
        misimagenes.push(baraja[i]);
    }

    return misimagenes;
}

// Recibe un array y devuelve otro con cada elemento de este repetido 
// y el conjunto desordenado
function DesordenaCartas(baraja){
    let cartasdesordenadas = [];
    // let aleatorio, cartasrestantes;
    cartasdesordenadas.push.apply(cartasdesordenadas, baraja);
    cartasdesordenadas.push.apply(cartasdesordenadas, baraja);
    cartasrestantes = cartasdesordenadas.length;

    // En este punto tengo 12 cartas: dos bloques de 6 en el orden en que aparecen en "cartas"
    // Queda desordenarlas

    cartasdesordenadas = cartasdesordenadas.sort(function(){return Math.random() - 0.5;});

    // while(cartasrestantes){
    //     aleatorio = Math.floor(Math.random() * cartasrestantes--);

    //     [cartasdesordenadas[cartasrestantes], cartasdesordenadas[aleatorio]] = 
    //     [cartasdesordenadas[aleatorio], cartasdesordenadas[cartasrestantes]];
    // }

    return cartasdesordenadas;
}

function giraCartas(estacarta){
    let findepartida = true; // comprueba si se ha ganado la partida
    
    // ORIGINAL: giraCartas(estacarta)
    // RECOMENDABLE pasar siempre el evento y recoger el disparador con event.target
    // event.target me devuelve el elemento que disparó el evento
    // envío el evento poniendo onclick='giraCartas(event)'
    // se recibe con giraCartas(e)

    // Si es la 1ª carta q se gira
    if(contador === 0){

        // Giro la carta: muestro el personaje, oculto el reverso de la carta
        $(estacarta).children().eq(0).show();
        $(estacarta).children().eq(1).hide();

        // Guardo el personaje: "friends/nombrepersonaje.png"
        primeracarta = $(estacarta).children().eq(0).children().eq(0).attr('src');
        posicionprimeracarta = $("div[id^=card]").index($(estacarta));
        
        contador++;

    }else{ // si es la 2ª carta

        let segundacarta = $(estacarta).children().eq(0).children().eq(0).attr('src');
        
        // Deshabilito los onclick de todas las cartas
        // $(`div[id^=card]`).prop("onclick", null).off('click');

        // Giro la carta
        $(estacarta).children().eq(0).show();
        $(estacarta).children().eq(1).hide();

        // Compruebo si coincide con la anterior
        // si no coinciden
        if(primeracarta != $(estacarta).children().eq(0).children().eq(0).attr('src')){
            // Giro la pareja de cartas (las vuelvo a poner boca abajo)
            var pausa = setTimeout(function(){
                $(`#card${posicionprimeracarta}`).children().eq(0).hide();
                $(`#card${posicionprimeracarta}`).children().eq(1).show();
                $(estacarta).children().eq(0).hide();
                $(estacarta).children().eq(1).show();
                // Habilito los onclick de las cartas boca abajo
                // for (let i; i < $("div:hidden").length; i++){
                //     $("div:hidden").eq(i).prop("onclick", giraCartas($("div:hidden").eq(i))).on('click');
                // }
            }, 1000);
                        
        }else{
            console.log("Coinciden");

            // Elimino el evento onclick de la pareja de cartas
            // (para que se queden boca arriba)
            $(`#card${posicionprimeracarta}`).prop("onclick", null).off('click');
            $(estacarta).prop("onclick", null).off('click');

            // Compruebo si se ha ganado el juego
            for (let i = 0; i < $("div[id^=card]").length; i++){
                if($(`#card${i}`).children().eq(0).is(":hidden")){
                    findepartida = false;
                }
            }

            if(findepartida){
                alert("¡Felicidades!");
                location.reload();
            }
        }

        contador = 0;
    }
}