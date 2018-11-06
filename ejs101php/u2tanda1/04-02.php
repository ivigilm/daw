<?php

$addition = $_POST['n1'] + $_POST['n2'];
$subtraction = $_POST['n1'] - $_POST['n2'];
$multiplication = $_POST['n1'] * $_POST['n2'];
$division = round($_POST['n1'] / $_POST['n2'], 2);

echo $_POST['n1'] . ' + ' . $_POST['n2'] . ' = ' . $addition . '<br/>';
echo $_POST['n1'] . ' - ' . $_POST['n2'] . ' = ' . $subtraction . '<br/>';
echo $_POST['n1'] . ' x ' . $_POST['n2'] . ' = ' . $multiplication . '<br/>';
echo $_POST['n1'] . ' / ' . $_POST['n2'] . ' = ' . $division . '<br/>';