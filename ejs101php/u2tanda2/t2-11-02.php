<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t2-11-02.php</title>
</head>
<body>
<?php
    $h = $_POST['h'];
    $m = $_POST['m'];
    $sgrestantes = 3600 * 24 - (3600*$h + 60*$m);

    echo 'You still need to get through ' . $sgrestantes . ' seconds to end the day.';
?>
<br/><br/>
<a href="t2-11-01.php">Go back</a>

</body>
</html>