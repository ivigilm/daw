<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t2-19-02.php</title>
</head>
<body>

<?php

$n = (string)$_POST['number'];
$capicua = false;

if(strlen($n) <= 5 && strlen($n) > 0 && $n[0] != '-'){
    if($n == strrev($n) ){
        $capicua = true;
    }

    if($capicua){
        echo 'Your number is capicúa.';
    }else{
        echo 'Your number is not capicúa.';
    }
}else{
    echo 'Not a valid number.';
}

?>

<br/><br/>

<a href="t2-19-01.php">Go back</a>

</body>
</html>