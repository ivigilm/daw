<?php

$h = $_POST['height'];
$r = $_POST['radius'];
$volume = PI() * $h * pow($r, 2) / 3;

echo 'Cone volume: ' . round($volume, 2);