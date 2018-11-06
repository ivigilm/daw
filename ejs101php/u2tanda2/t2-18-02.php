<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t2-18-02.php</title>
</head>
<body>

<?php

$n = (string)$_POST['number'];

if($n[0] == '-' && strlen($n) <= 6 && strlen($n) >= 2){
    $digits = strlen($n) - 1;
}elseif(strlen($n) > 0 && strlen($n) < 6){
    $digits = strlen($n);
}

echo 'Your number has ' . $digits . ' digits.';

?>

<br/><br/>

<a href="t2-18-01.php">Go back</a>

</body>
</html>