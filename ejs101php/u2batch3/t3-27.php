<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t3-27.php</title>
</head>
<body>

<?php

if(isset($_POST['n'])){
    $counter = 0;
    $sum = 0;
    for($i = 1; $i <= $_POST['n']; $i++){
        if($i % 3 == 0){
            echo $i, '<br/>';
            $counter++;
            $sum += $i;
        }
    }

    echo 'Counter: ', $counter, '<br/>';
    echo 'Sum: ', $sum;
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