<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t3-19.php</title>
</head>
<body>

<?php

if(isset($_POST['height'])){

    $pyramid = '';

    for($i = 1; $i <= $_POST['height']; $i++){
        $line = '';
        for($espacio = 0; $espacio < ($_POST['height']) - $i; $espacio++){
            $line .= '&nbsp;';
        }
        for($j = 1; $j <= $i; $j++){
            $line .= $_POST['icon'];
        }
        $pyramid .= $line . '<br/>';
    }

    echo $pyramid;
}else{


?>

    <form action="<?php echo $_SERVER['PHP_SELF'] ?>" method="post">
        <input type="number" name="height" placeholder="pyramid height" />
        <select name="icon">
            <option value="*">Asterisk</option>
            <option value="·">Disc</option>
            <option value="#">Hash</option>
            <option value="o">Circle</option>
        </select>
        <input type="submit" value="Submit" />
    </form>

<?php

}

?>

</body>
</html>