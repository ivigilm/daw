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

    // loop through each row
    for($i = 1; $i <= $_POST['height']; $i++){
        $line = '';
        // loop drawing left side symbols
        for($symbol = 0; $symbol < ($_POST['height']) - $i; $symbol++){
            $line .= $_POST['icon'];
        }
        // loop drawing spaces (pyramid)
        for($j = 1; $j <= $i; $j++){
            $line .= '&nbsp;';
        }
        // loop through right side symbols
        for($symbol = 0; $symbol < ($_POST['height']) - $i; $symbol++){
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