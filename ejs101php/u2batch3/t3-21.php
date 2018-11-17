<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t3-21.php</title>
</head>
<body>

<?php
if(!isset($_POST['n'])){
    $n = 0;
    $count = 0;
    $oddsum = 0; // odd numbers sum
    $evenmax = 0; // even numbers max; Paco mete -PHP_INT_MAX
}else{
    $n = $_POST['n'];
    $count = $_POST['count'];
    $oddsum = $_POST['oddsum'];
    $evenmax = $_POST['evenmax'];
}

if($n >= 0){
    if($n > 0){
        $count++;
    }

    if($n % 2 != 0){
        $oddsum += $n;
    }else if($n > $evenmax){
        $evenmax = $n;
    }

?>


<form action="<?php echo $_SERVER['PHP_SELF'] ?>" method="post">
    <input type="number" name="n" />
    <input type="hidden" name="count" value="<?php echo $count ?>" />
    <input type="hidden" name="oddsum" value="<?php echo $oddsum ?>" />
    <input type="hidden" name="evenmax" value="<?php echo $evenmax ?>" />
    <input type="submit" name="send" value="Send" />
</form>

<?php

}else{
    echo 'Numbers counter: ', $count, '<br/>';
    echo 'Even numbers max: ', $evenmax, '<br/>';
    echo 'Odd numbers sum: ', $oddsum, '<br/>';

    echo '<a href="t3-21.php">Go back</a>';
}
?>

</body>
</html>