<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t3-09-02.php</title>
</head>
<body>

<?php

$n = $_POST['number'];

echo 'Your number has ' . strlen((string)$n) . ' digits.';

?>

<br/><br/>

<a href="t3-09-01.php">Go back</a>
</body>
</html>