<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>adivino.php</title>
</head>
<body>

<h1>El adivino</h1>

<p>Adivina un número entre 1 y 100.</p>

<?php

if(isset($_POST['submit'])) {
    $n = $_POST['n'];
    $mynumber = $_POST['mynumber'];
}else{
    $mynumber = rand(1, 100);
    $n = "";
}

if($n == $mynumber){
    echo "¡Felicidades!";
    echo "<a href='adivino.php'>Volver a jugar</a>";
}else {
    if (($n == "" || is_int($n)) && isset($_POST['submit'])) {
        echo "No ha escrito ningún número";
    } elseif ($n < $mynumber && isset($_POST['submit'])) {
        echo "Demasiado pequeño";
    } elseif ($n > $mynumber && isset($_POST['submit'])) {
        echo "Demasiado grande";
    }

    ?>

    <form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="post">
        <input type="number" name="n" min="1" max="100" />
        <input type="hidden" name="mynumber" value="<?php echo $mynumber; ?>">
        <input type="submit" name="submit" value="Comprobar número" />
    </form>
    <?php
}

?>

</body>
</html>