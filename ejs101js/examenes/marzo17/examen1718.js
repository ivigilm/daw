var categorias = ["", "Javascript", "jQuery", "AngularJS", "PHP", "SQL"];
var preguntas = [];

$(document).ready(function(){
    // La página se ha cargado
    // Cargamos las preguntas mediante Ajax: usaremos GET para facilitarlo
    // Pedimos el recurso
    $.ajax({
        url : "test.json",
        type : "GET",
        dataType : "json",
        success: function(data){
            preguntas = data;
        }
    });

    $("#generar").click(function(){
        Generar( $("#categoria").val(), $("#cantidad").val() );
    });

    $("#corregir").click(function(){
        Corregir();
    });

    // Preparar los botones y la categoría seleccionada
    $("#corregir").attr("disabled", true);
           
    $("option").eq(1).attr("selected",true);
    // Otra forma: $("option[value='2']").attr("selected",true); 
});

function Generar(categoria, cantidad){
    // Las preguntas de esa categoría
    var preguntasCategoria = [];
    for(var i = 0; i < preguntas.length; i++){
        if(preguntas[i].categoria == categoria){
            preguntasCategoria.push(preguntas[i]);
        }
    }
    // Comprobamos cuántas preguntas hay en la categoría y mostramos
    if(preguntasCategoria.length == 0){
        alert("No hay ninguna pregunta de esa categoría.");
    }else{        
        // Ordenamos al azar
        preguntasCategoria.sort(function(){return 0.5 - Math.random() });
        
        // Controlamos el máximo de preguntas
        cantidad = cantidad > preguntasCategoria.length ? preguntasCategoria.length : cantidad;
        // Actualizo el valor del input #cantidad
        $("#cantidad").val(cantidad);

        // Eliminamos las preguntas que sobren
        preguntasCategoria.splice(cantidad, preguntasCategoria.length - cantidad);

        // Presentamos
        PresentarTest(preguntasCategoria);
    }
}

function PresentarTest(p){

    // Habilito el botón de corregir
    $("#corregir").attr("disabled", false);

    // Vaciamos las (posibles) preguntas del test anterior.
    $("#contenedor").html("");

    // Colocamos las preguntas
    for(var i = 0; i < p.length; i++){

        // Desordenamos las respuestas
        p[i].respuestas.sort(function(){return Math.random() - 0.5});

        $("#contenedor").append( (i+1) + "." + p[i].pregunta + "<br/>");
        // Colocamos las respuestas
        for(var j = 0; j < p[i].respuestas.length; j++){
            $("#contenedor").append("<input type='radio' name='p" + i + "' value='" +
                            // Esto es terrible: si le doy valor 0/1 a la respuesta según si es correcta o no el usuario podrá verlo en el código
                            (p[i].correcta == p[i].respuestas[j].idrespuesta ? 1 : 0) + "' />")
                            .append(p[i].respuestas[j].respuesta + "<br/>")
            ;
        }
    }
}

function Corregir(){
    // Obtenemos todos los radiobutton seleccionados
        // $(":radio") selecciona todos los radiobutton
        // $("input[type=radio]:checked")
    var aciertos = $(":radio:checked[value='1']").length;
    var fallos = $(":radio:checked[value='0']").length;
    var blancos = $("#cantidad").val() - (aciertos + fallos);
    var nota = (aciertos + fallos) * 10 / $("#cantidad").val();

        // .text para escribir solo texto
        // .html para incluir etiquetas
    $("#resultado").html("Aciertos: " + aciertos + 
                    "<br/> Fallos: " + fallos + 
                    "<br/> En blanco: " + blancos +
                    "<br/> Nota: " + nota);
}