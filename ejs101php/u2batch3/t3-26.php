<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t3-26.php</title>
</head>
<body>

<?php

if(isset($_POST['n']) && isset($_POST['d'])){
    $n = $_POST['n'];
    $d = $_POST['d'];
    echo 'Positions of ', $n, ' where you can find ', $d, ': <br/>';
    for($i = 0; $i < strlen($n); $i++){
        if($n[$i] == $d){
            echo $i, '<br/>';
        }
    }
}else{
    echo 'You must enter two valid numbers.', '<br/>';

?>

<form action="<?php echo $_SERVER['PHP_SELF'] ?>" method="post">
    <input type="number" name="n" placeholder="number" />
    <input type="number" name="d" placeholder="digit" />
    <input type="submit" value="Submit" />
</form>

<?php
}
?>

</body>
</html>