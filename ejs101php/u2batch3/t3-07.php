<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t3-07b.php</title>
</head>
<body>

<?php

    $combinacion = 1234;

    if(!isset($_POST['counter'])){
        $counter = 4;
        $pin = "";
    }else{
        $counter = $_POST['counter'];
        $pin = $_POST['pin'];
    }

    if($combinacion == $pin){
        echo 'The safe is open.';
    }else if($counter == 0){
        echo 'The safe will stay locked.';
    }else {
        echo 'You have ', $counter, ' chances left.';
        $counter--;

        echo '<form action="t3-07.php" method="post">';
        echo '<input type="number" min=0 max=9999 placeholder="enter PIN" name="pin" autofocus/>';
        echo '<input type="hidden" name="counter" value="', $counter, '"/>';
        echo '<input type="submit" value="Submit" />';
        echo '</form>';
    }
?>


</body>
</html>