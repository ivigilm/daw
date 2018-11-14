<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t3-14.php</title>
</head>
<body>

<?php

if(isset($_POST['submit'])){

    // calculate and show
    $newnumber = pow($_POST['base'], $_POST['exp']);
    echo $_POST['base'], ' raised to the power of ', $_POST['exp'], ' is ', $newnumber;

}else{
?>

    <form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="post">
        <input type="number" name="base" placeholder="base" /><br/>
        <input type="number" name="exp" placeholder="exponent" /><br/>
        <input type="submit" name="submit" value="Submit" />
    </form>

<?php
}

?>

</body>
</html>