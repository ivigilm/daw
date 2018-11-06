<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t2-09-02.php</title>
</head>
<body>
<?php
$a = $_POST['a'];
$b = $_POST['b'];
$c = $_POST['c'];
$x1 = (-$b + ( sqrt( pow($b, 2) - (4*$a*$c) ) ) ) / (2*$a);
$x2 = (-$b - ( sqrt( pow($b, 2) - (4*$a*$c) ) ) ) / (2*$a);

echo 'The result of your quadratic equation (' . $a . 'x<sup>2</sup> + ' . $b . 'x + ' . $c . ' = 0) is:<br/>
 x1 = ' . $x1 . '<br/>
 x2 = ' . $x2;
?>
<br/><br/>
<a href="t2-09-01.php">Go back</a>

</body>
</html>