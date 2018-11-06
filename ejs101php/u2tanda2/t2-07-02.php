<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t2-07-02.php</title>
</head>
<body>
<?php
$avg = round((($_POST['g1'] + $_POST['g2'] + $_POST['g3']) / 3), 2);
echo 'The class average grade is ' . $avg . '.';
?>
<br/><br/>
<a href="t2-07-02.php">Go back</a>

</body>
</html>