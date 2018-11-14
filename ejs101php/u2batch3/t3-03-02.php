<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t3-03-02.php</title>
</head>
<body>

<?php

$i = 0;

do{
    if($i % 5 == 0){
        echo $i . '<br/>';
    }

    $i++;
} while($i <= 100);


?>

<br/><br/>

<a href="t3-03-01.php">Go back</a>

</body>
</html>