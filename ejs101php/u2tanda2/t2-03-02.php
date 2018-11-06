<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t2-03-02.php</title>
</head>
<body>

<?php
$n = $_POST['n'];
$day = "";

switch($n){
    case 1:
        $day = "Sunday";
        break;
    case 2:
        $day = "Monday";
        break;
    case 3:
        $day = "Tuesday";
        break;
    case 4:
        $day = "Wednesday";
        break;
    case 5:
        $day = "Thursday";
        break;
    case 6:
        $day = "Friday";
        break;
    case 7:
        $day = "Saturday";
        break;
    default:
}

echo 'Day number ' . $n . ' is ' . $day;
?>
<br/><br/>
<a href="t2-03-01.php">Go back</a>

</body>
</html>