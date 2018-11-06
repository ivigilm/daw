<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t2-12-02.php</title>
</head>
<body>

<?php
$puntuacion = 0;
$pregunta = 'p';

for($i = 1; $i <= 10; $i++){

    $pregunta = 'p' . (string)$i;

    $puntuacion += $_POST[$pregunta];
}

if($puntuacion <= 10){
    echo '¡Enhorabuena! tu pareja parece ser totalmente fiel.';
}elseif($puntuacion >= 11 && $puntuacion <= 22){
    echo 'Quizás exista el peligro de otra persona en su vida o en su mente, aunque seguramente será algo sin importancia. No bajes la guardia.';
}else{
    echo 'Tu pareja tiene todos los ingredientes para estar viviendo un romance con otra persona. Te aconsejamos que indagues un poco más y averigües qué es lo que está pasando por su cabeza.';
}

?>
<br/><br/>
<a href="t2-12-01.php">Volver.</a>

</body>
</html>