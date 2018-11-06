<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t2-02-02.php</title>
</head>
<body>
<?php
    $hour = $_POST['hour'];
    $hi = "";

    if($hour >= 6 && $hour <= 12){
        $hi = "Good morning!";
    }elseif($hour >= 13 && $hour <= 20){
        $hi = "Good afternoon/evening!";
    }elseif( ($hour >= 21 && $hour <= 23) || ($hour >= 0 && $hour <= 5) ){
        $hi = "Good night!";
    }else{
        $hi = "Not a valid time.";
    }

    echo $hi;
?>

<a href="t2-02-01.php">Go back</a>
</body>
</html>