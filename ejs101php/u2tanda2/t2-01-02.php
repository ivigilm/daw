<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t2-01-02.php</title>
</head>
<body>

<?php

    $day = $_POST['day'];
    $subject = "";

    switch($day){
        case "Monday":
            $subject = 'DWES';
            break;
        case "Tuesday":
            $subject = 'DIW';
            break;
        case "Wednesday":
            $subject = 'HLIB';
            break;
        case "Thursday":
            $subject = 'DAW';
            break;
        case "Friday":
            $subject = 'EIE';
            break;
        default:
            echo 'Not an option.';
    }

    if($day == "Monday" || $day == "Tuesday" || $day == "Wednesday" || $day == "Thursday" || $day == "Friday"){
        echo 'Today is ' . $day . ', so your first class is ' . $subject . '.';
    }
?>
<br/><br/>
<a href="t2-01-01.php">Go back</a>

</body>
</html>