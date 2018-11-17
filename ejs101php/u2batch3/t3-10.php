<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t3-10.php</title>
</head>
<body>

<h1>Average of several numbers</h1>

<?php

if(!isset($_POST['n'])){
    $n = 0;
    $sum = 0;
    $counter = 0;
}else{
    $n = $_POST['n'];
    $sum = $_POST['sum'];
    $counter = $_POST['counter'];
}

if($n >= 0){
    $sum += $n;
    $counter++;
    ?>

    <form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="post">
        <input type="number" name="n" autofocus />
        <input type="hidden" name="sum" value="<?php echo $sum; ?>" />
        <input type="hidden" name="counter" value="<?php echo $counter ?>">
        <input type="submit" name="send" value="Send" />
    </form>

    <?php

}else{
    $avg = $sum / ($counter -1);
    echo 'The average of those numbers is ', $avg;
}
?>
<br/><br/>
<a href="t3-10.php">Go back</a>

</body>
</html>