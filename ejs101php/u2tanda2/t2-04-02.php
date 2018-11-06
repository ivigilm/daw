<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t2-04-02.php</title>
</head>
<body>
<?php
$hours = $_POST['hours'];
$salary = 0;

    if($hours <= 40 && $hours >= 0){
        $salary = $hours * 12;
        echo 'Your salary is ' . $salary;
    }elseif($hours > 40){
        $salary = 40 * 12 + ($hours - 40) * 16;
        echo 'Your salary is ' . $salary;
    }else{
        echo 'Not a valid number.';
    }
?>

<br/><br/>

<a href="t2-04-01.php">Go back</a>
</body>
</html>