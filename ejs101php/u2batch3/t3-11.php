<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t3-11.php</title>
</head>
<body>

<h1>Square and cube pows</h1>

<?php

    // If a number has been sent
    if(isset($_POST['n']) && is_integer((int)$_POST['n'])){
        echo '<table><th>Number</th><th>Square</th><th>Cube</th>';

        for($i = 0; $i < 5; $i++){
            echo '<tr><td>' , $_POST['n'] + $i , '</td><td>' , ($_POST['n'] + $i) * ($_POST['n'] + $i) , '</td><td>' , pow($_POST['n'] + $i, 3) , '</td></tr>';
        }
        echo '</table>';
    }
    else{
        if(isset($_POST['n']) && !is_integer((int)$_POST['n'])){
            echo 'Input must be an integer number!';
        }

?>

<p>Enter a number and I'll show you the following square and cubes!</p>

<form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="post">
     <input type="text" name="n" placeholder="integer number" />
     <input type="submit" name="send" value="Send" />
</form>

<?php

    }
?>

</body>
</html>