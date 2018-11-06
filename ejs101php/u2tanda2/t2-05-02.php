<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t2-05-02.php</title>
</head>
<body>
<?php
$a = $_POST['a'];
$b = $_POST['b'];
$x = -$b / $a;

echo 'The result of your linear equation (' . $a . 'x + ' . $b . ' = 0) is: x = ' . $x;
?>
<br/><br/>
<a href="t2-05-01.php">Go back</a>

</body>
</html>