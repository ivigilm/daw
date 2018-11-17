<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t3-13.php</title>
</head>
<body>

<?php
if(isset($_POST['n'])){
    $n = $_POST['n'];
    $positive = $_POST['positive'];
    $negative = $_POST['negative'];
    $counter = $_POST['counter'];
}else{
    $n = 0;
    $positive = 0;
    $negative = 0;
    $counter = 0;
}

if($n > 0){
    $positive++;
    $counter++;
}else if($n < 0){
    $negative++;
    $counter++;
}

if($counter == 10){
    echo 'Positive numbers: ', $positive, '<br/>';
    echo 'Negative numbers: ', $negative, '<br/>';
    echo '<a href="t3-13.php">Go back</a>';
}else{

?>

<form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="post">
    <input type="number" name="n" autofocus />
    <input type="hidden" name="positive" value="<?php echo $positive ;?>" />
    <input type="hidden" name="negative" value="<?php echo $negative ;?>" />
    <input type="hidden" name="counter" value="<?php echo $counter ;?>" />
    <input type="submit" name="send" value="Send" />
</form>

<?php
}
?>

</body>
</html>