<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t3-12.php</title>
</head>
<body>

<h1>Fibonacci</h1>

<p>How many Fibonacci numbers do you want?</p>

<form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="post">
    <input type="text" name="n" placeholder="integer positive number" />
    <input type="submit" name="send" value="Send" />
</form>

<?php

// If the user sent a number
if(isset($_POST['n'])){
    $n = $_POST['n'];
    $fibonacci = [0, 1];

    if($n > 0){
        // fibonacci
        while(count($fibonacci) < $n){
            array_push($fibonacci, $fibonacci[count($fibonacci)-1] + $fibonacci[count($fibonacci)-2]);
        }

        if($n == 1){
            echo '0';
        }else{
            foreach($fibonacci as $element) {
                echo $element, '<br>';
            }
        }

    }else{
        echo '<script>alert("Write a positive integer number, please.")</script>';
    }
}


?>

</body>
</html>