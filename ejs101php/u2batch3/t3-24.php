<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t3-24.php</title>
</head>
<body>

<?php
if(isset($_POST['rows'])){
    $rows = $_POST['rows'];
    for($i = 0; $i < $rows; $i++){
        echo '*' . str_repeat('*', (2 * $i)) . '<br/>';
    }
}else{

?>

<form action="<?php echo $_SERVER['PHP_SELF'] ?>" method="post">
    <input type="number" name="rows" min="1" max="9" placeholder="rows" />
    <input type="submit" value="Submit" />
</form>

<?php
}
?>

</body>
</html>