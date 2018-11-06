<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t2-17-02.php</title>
</head>
<body>

<?php

$firstchar = (string)$_POST['number'];

if(strlen($firstchar) > 5 || strlen($firstchar) < 1){
    echo 'Not a valid number';
}else{
    $firstchar = $firstchar[0];

    echo 'The first digit in your number is: ' . $firstchar;
}

?>

<br/><br/>

<a href="t2-17-01.php">Go back</a>

</body>
</html>