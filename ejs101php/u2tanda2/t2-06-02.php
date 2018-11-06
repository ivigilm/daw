<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t2-06-02.php</title>
</head>
<body>
<?php
$h =  $_POST['h'];
$g = 9.81;
$t = round(sqrt(2*$h/$g), 2);

echo 'Your object will stop falling after ' . $t . ' seconds. It will hit the ground and probably break.';
?>
<br/><br/>
<a href="t2-06-01.php">Go back</a>

</body>
</html>