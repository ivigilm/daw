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

    echo 'Has acertado: ' . $puntuacion . '/10 preguntas.';
?>
<br/><br/>
<a href="t2-12-01.php">Volver.</a>

</body>
</html>