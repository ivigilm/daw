<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t3-17.php</title>
</head>
<body>

<?php

if(isset($_POST['n'])){
    $n = $_POST['n'];

    if($n > 0 && $n == round($n)){
        $sum = 0;
        for($i = $n; $i < $n + 100; $i++){
            $sum += $i;
        }

        echo 'The sum of 100 integer numbers starting on ', $n, ' is ', $sum, '.';
    }else{
        echo 'Invalid number. It must be a positive integer number.';
    }
}else{

?>

    <form action="<?php echo $_SERVER['PHP_SELF'] ?>" method="post">
        <input type="number" name="n" />
        <input type="submit" value="Submit" />
    </form>

<?php

}

?>

</body>
</html>