<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t2-10-02.php</title>
</head>
<body>
<?php
    $day = $_POST['day'];
    $month = $_POST['month'];
    $horoscope = '';

    switch($month){
        case 1:
            if($day < 21){
                $horoscope = 'capricornio';
            }else{
                $horoscope = 'acuario';
            }
            break;
        case 2:
            if($day < 20){
                $horoscope = 'acuario';
            }else{
                $horoscope = 'piscis';
            }
            break;
        case 3:
            if($day < 21){
                $horoscope = 'piscis';
            }else{
                $horoscope = 'aries';
            }
            break;
        case 4:
            if($day < 21){
                $horoscope = 'aries';
            }else{
                $horoscope = 'tauro';
            }
            break;
        case 5:
            if($day < 20){
                $horoscope = 'tauro';
            }else{
                $horoscope = 'géminis';
            }
            break;
        case 6:
            if($day < 22){
                $horoscope = 'géminis';
            }else{
                $horoscope = 'cáncer';
            }
            break;
        case 7:
            if($day < 22){
                $horoscope = 'cáncer';
            }else{
                $horoscope = 'Leo';
            }
            break;
        case 8:
            if($day < 24){
                $horoscope = 'leo';
            }else{
                $horoscope = 'virgo';
            }
            break;
        case 9:
            if($day < 23){
                $horoscope = 'virgo';
            }else{
                $horoscope = 'libra';
            }
            break;
        case 10:
            if($day < 23){
                $horoscope = 'libra';
            }else{
                $horoscope = 'escorpio';
            }
            break;
        case 11:
            if($day < 23){
                $horoscope = 'escorpio';
            }else{
                $horoscope = 'sagitario';
            }
            break;
        case 12:
            if($day < 21){
                $horoscope = 'sagitario';
            }else{
                $horoscope = 'capricornio';
            }
            break;
        default:
            break;
    }

    echo 'Your horoscope is ' . $horoscope . '.';
?>

<br/><br/>
<a href="t2-10-01.php">Go back</a>

</body>
</html>