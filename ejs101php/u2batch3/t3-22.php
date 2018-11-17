<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t3-22.php</title>
</head>
<body>

<?php

for($i = 2; $i <= 100; $i++){
    $prime = true;
    for($j = 2; $j < $i; $j++){
        if($i % $j == 0){
            $prime = false;
        }
    }

    if($prime){
       echo $i . '<br/>';
    }
}
?>

</body>
</html>