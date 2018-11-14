<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t3-08-02.php</title>
</head>
<body>

<table>
    <tr><th colspan="2">Multiplication</th></tr>
    <?php

    $n = $_POST['number'];

    for($i = 1; $i <=10; $i++){
        echo '<tr> <td>' . $n . ' x ' . $i . '</td>';
        echo '<td>' . $i * $n . '</td></tr>';
    }

    ?>

</table>

<br/><br/>

<a href="t3-08-01.php">Go back</a>

</body>
</html>