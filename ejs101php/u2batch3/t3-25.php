<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t3-25.php</title>
</head>
<body>

<?php
if(isset($_POST['n'])){
    $n = $_POST['n'];
    $nbackwards = '';
    for($i = strlen($n) - 1; $i >= 0; $i-- ){
        $nbackwards .= $n[$i];
    }
    echo $nbackwards;
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