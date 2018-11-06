<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t2-16-02.php</title>
</head>
<body>

<?php

$number = $_POST['number'];
(string)$number;
$lastchar = $number[-1];

echo 'The last digit in your number is: ' . $lastchar;

?>

<br/><br/>

<a href="t2-16-01.php">Go back</a>
</body>
</html>