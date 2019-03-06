
// Guardo las imágenes
let cartas = ['v1chandler.png', 'v1joey.png', 'v1monica.png', 'v1phoebe.png', 'v1rachel.png', 'v1ross.png', 'v1janice.png', 'v1richard.png', 'v1amy.png', 'v1gunther.png'];
let contador = 1; // nº de carta q se pulsa 
let primeracarta = "";
let posicionprimeracarta;
let acertadas = 0;
let tiempo = 0; // segundos q se tarda en resolver
let intentos = 0; // nº veces q se levanta una pareja de cartas
let intervalo;

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

        $('#juego').append(micarta);
    }
    // Oculto el anverso de las cartas
    $('.front').hide();
    
    // Inicio el cronómetro
    crono();

    // Oculto las opciones de nº cartas
    $("#numcartas").css("display", "none");
}

// Devuelve un array con las imágenes que se utilizarán en el juego
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

    cartasdesordenadas.push.apply(cartasdesordenadas, baraja);
    cartasdesordenadas.push.apply(cartasdesordenadas, baraja);

    cartasdesordenadas = cartasdesordenadas.sort(function(){return Math.random() - 0.5;});

    return cartasdesordenadas;
}

function giraCartas(estacarta){    
    // RECOMENDABLE pasar siempre el evento y recoger el disparador con event.target
    // event.target me devuelve el elemento que disparó el evento
    // envío el evento poniendo onclick='giraCartas(event)'
    // se recibe con giraCartas(e)

    // Si es la 1ª carta q se gira
    if(contador === 1){

        // Giro la carta: muestro el personaje, oculto el reverso de la carta
        $(estacarta).children().eq(0).show();
        $(estacarta).children().eq(1).hide();

        // Guardo el personaje: "friends/nombrepersonaje.png"
        primeracarta = $(estacarta).children().eq(0).children().eq(0).attr('src');
        posicionprimeracarta = $("div[id^=card]").index($(estacarta));
        
        contador++;

    }else if(contador > 2){ // si se ha intentado pinchar más de dos cartas
        console.log("No se pueden girar más de dos cartas a la vez.");
    }else{ // si es la 2ª carta
        let segundacarta = $(estacarta).children().eq(0).children().eq(0).attr('src');
        contador++;
        intentos++;
        
        // Giro la carta
        $(estacarta).children().eq(0).show();
        $(estacarta).children().eq(1).hide();

        // Compruebo si coincide con la anterior
        // si no coinciden
        if(primeracarta != segundacarta){
            // Giro la pareja de cartas (las vuelvo a poner boca abajo)
            var pausa = setTimeout(function(){
                $(`#card${posicionprimeracarta}`).children().eq(0).hide();
                $(`#card${posicionprimeracarta}`).children().eq(1).show();
                $(estacarta).children().eq(0).hide();
                $(estacarta).children().eq(1).show();

                contador = 1;
            }, 1000);
                        
        }else{ // si coinciden las cartas levantadas (¡acierto!)
            acertadas += 2;

            // Elimino el evento onclick de la pareja de cartas
            // (para que se queden boca arriba)
            $(`#card${posicionprimeracarta}`).prop("onclick", null).off('click');
            $(estacarta).prop("onclick", null).off('click');

            // Compruebo si se ha ganado el juego
            if(acertadas === $(".cards").length){
                alert(`¡Felicidades!
                        Intentos: ${intentos}
                        Tiempo: ${tiempo} sg`);
                location.reload();
            }

            contador = 1;
        }

    }
}

function crono(){
    intervalo = setInterval(function(){
        tiempo++;
    }, 1000);
}