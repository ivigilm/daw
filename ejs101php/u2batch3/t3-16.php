<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t3-16.php</title>
</head>
<body>

<?php
if(isset($_POST['n'])){
    $esprimo = true;
    for($i = 2; $i < $_POST['n']; $i++){
        if($_POST['n'] % $i == 0){
            $esprimo = false;
        }
    }

    if($esprimo){
        echo 'Your number is a prime number.';
    }else{
        echo 'Your number is not a prime number.';
    }
}else{

?>

    <form action="<?php echo $_SERVER['PHP_SELF'] ?>" method="post">
        <input type="number" min="1" name="n" />
        <input type="submit" value="Submit" />
    </form>

<?php

}
?>

</body>
</html>