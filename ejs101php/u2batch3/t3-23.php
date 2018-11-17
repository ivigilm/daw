<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t3-23.php</title>
</head>
<body>

<?php
if(!isset($_POST['n'])){
    $n = 0;
    $sum = 0;
    $count = 0;
}else{
    $n = $_POST['n'];
    $sum = $_POST['sum'];
    $count = $_POST['count'];
}

if($sum > 10000){
    echo 'Numbers count: ', $count, '<br/>';
    echo 'Numbers sum: ', $sum, '<br/>';
    echo 'Numbers average: ', round($sum / $count, 2), '<br/>';

    echo '<a href="t3-23.php">Go back</a>';
}else{

    $sum += $n;
    $count++;

?>

<form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="post">
    <input type="number" name="n" autofocus/>
    <input type="hidden" name="sum" value="<?php echo $sum; ?>" />
    <input type="hidden" name="count" value="<?php echo $count; ?>" />
    <input type="submit" name="send" value="Send" />
</form>

<?php
}
?>

</body>
</html>