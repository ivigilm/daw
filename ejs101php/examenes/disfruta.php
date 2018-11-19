<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>disfruta.html</title>
</head>
<body>

<h1>DisFruta con PHP</h1>

<p>Enunciado: Muestra entre 7 y 20 frutas al azar (códigos ASCII & #127815; a & #127827;).
    Contar cuántas veces sale cada fruta y mostrar la información.</p>
<!--


 -->

<?php

function contienepalabra($cadena, $subcadena){
    if (strpos($cadena, $subcadena) !== false) {
        return 'true';
    }
    return false;
}

$frutas = ["&#127815;", "&#127816;", "&#127817;", "&#127818;",  "&#127819;",  "&#127820;",  "&#127821;",  "&#127822;",  "&#127823;",  "&#127824;",  "&#127825;",  "&#127826;", "&#127827;" ];

$aleatoriocantidad = rand(7, 20);
$aleatoriostodasfrutas = array();
$descripcion = "";

echo "<p style=\"font-size: 7rem\">";
for($i = 0; $i < $aleatoriocantidad; $i++){
    $aleatoriofruta = rand(0, count($frutas) - 1);
    $aleatoriostodasfrutas[] = $aleatoriofruta;
    echo $frutas[$aleatoriofruta];
}
echo "</p>";
echo "<h2>", count($aleatoriostodasfrutas), " frutas</h2>";
echo '<br/>';

for($i = 0; $i < count($aleatoriostodasfrutas); $i++){
    $contador = 0;
    $mismafruta = array(); // guarda las posiciones de una fruta

    foreach($aleatoriostodasfrutas as $fruta) {
        if($fruta == $aleatoriostodasfrutas[$i]){
            $contador++;
        }
    }

    if(!contienepalabra($descripcion, $frutas[$aleatoriostodasfrutas[$i]])){
        if($contador == 1){
            $descripcion .= "<br/> La fruta <span style=\"font-size: 2rem\">" . $frutas[$aleatoriostodasfrutas[$i]] . "</span> está " . $contador . " vez en la lista.";
        }else{
            $descripcion .= "<br/> La fruta <span style=\"font-size: 2rem\">" . $frutas[$aleatoriostodasfrutas[$i]] . "</span> está " . $contador . " veces en la lista.";
        }
    }
}

echo $descripcion;

?>

<center><button onclick="location.reload()">¡¡¡ DisFruta otra vez !!!</button></center>

</body>
</html>