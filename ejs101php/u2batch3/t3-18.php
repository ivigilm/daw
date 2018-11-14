<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t3-18.php</title>
</head>
<body>

<?php

if(isset($_POST['n1']) && isset($_POST['n2']) ){
    $n1 = floor($_POST['n1']);
    $n2 = floor($_POST['n2']);

    if($n1 != $n2){
        if($n1 < $n2){
            $low = $n1;
            $high = $n2;
        }else{
            $low = $n2;
            $high = $n1;
        }

        for($i = $low; $i <= $high; $i+= 7){
            echo $i, '<br/>';
        }
    }else{
        echo 'You must enter two different numbers.';
    }




}else{

?>

<form action="<?php echo $_SERVER['PHP_SELF'] ?>" method="post">
    <input type="number" name="n1" />
    <input type="number" name="n2" />
    <input type="submit" value="Submit" />
</form>

<?php

}

?>

</body>
</html>