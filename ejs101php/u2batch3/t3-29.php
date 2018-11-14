<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t3-29.php</title>
</head>
<body>

<?php
if(isset($_POST['top']) && isset($_POST['divisor'])){
    $top = $_POST['top'];
    $divisor = $_POST['divisor'];

    for($i = 2; $i < $top; $i++){
        if($i % $divisor != 0){
            echo $i, '<br/>';
        }
    }
}else {

    ?>

    <form action="<?php echo $_SERVER['PHP_SELF'] ?>" method="post">
        <label>Top number:<br/><input type="number" name="top" min="3"/></label><br/>
        <label>Number which will not be a perfect divisor:<br/><input type="number" name="divisor"/></label>
        <input type="submit" value="Submit"/>
    </form>

    <?php
}
?>
</body>
</html>