<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t3-15.php</title>
</head>
<body>

<?php

if(isset($_POST['submit'])){

    $base = $_POST['base'];
    $exp = $_POST['exp'];

    for($i = 1; $i <= $exp; $i++){
        echo $base, '<sup>', $i, '</sup> = ', pow($base, $i), '<br/>';
    }

}else {

    echo '<form action="t3-15.php" method="post">';
    echo '<input type="number" name="base" placeholder="base" />
    <input type="number" name="exp" placeholder="exp" />
    <input type="submit" name="submit" value="Submit" />
</form>';

}

?>


</body>
</html>