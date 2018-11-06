<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t2-08-02.php</title>
</head>
<body>
<?php
$avg = round((($_POST['g1'] + $_POST['g2'] + $_POST['g3']) / 3), 2);
$avggrade = '';

if($avg < 5){
    $avggrade = 'Fail';
}elseif($avg < 6.8){
    $avggrade = 'Pass';
}elseif($avg < 8){
    $avggrade = 'Good';
}elseif($avg < 8.5){
    $avggrade = 'Very good';
}else{
    $avggrade = 'Outstanding';
}

echo 'The class average grade is ' . $avg . ', which means: ' . $avggrade;

?>
<br/><br/>
<a href="t2-08-01.php">Go back</a>

</body>
</html>