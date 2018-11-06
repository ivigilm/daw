<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t2-14-02.php</title>
</head>
<body>

<?php

if($_POST['number'] % 2 == 0){
    echo 'Your number is even';
}else{
    echo 'Your number is odd';
}


if($_POST['number'] % 5 == 0){
    echo ' and a multiple of 5.';
}else{
    echo ' and not a multiple of 5.';
}

?>

<br/><br/>

<a href="t2-14-01.php">Go back</a>

</body>
</html>