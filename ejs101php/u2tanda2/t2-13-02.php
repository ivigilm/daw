<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t2-13-02.php</title>
</head>
<body>

<?php

$sortednumbers =  [$_POST['n1'], $_POST['n2'], $_POST['n3']];
sort($sortednumbers);
$numstring = '';

for($i = 0; $i < count($sortednumbers); $i++){
    $numstring .= $sortednumbers[$i] . ' ';
}

echo $numstring;

?>

<br/><br/>

<a href="t2-13-01.php">Go back</a>

</body>
</html>