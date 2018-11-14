<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t3-28.php</title>
</head>
<body>

<?php

if(isset($_POST['n'])){
    $factorial = 1;

    for($i = 1; $i <= $_POST['n']; $i++){
        $factorial *= $i;
    }

    echo $factorial;

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