<?php
$comarca = $_POST['comarca'];
$c = new MySQLi("localhost","root","","cadiz");
$c->query("SET NAMES utf8");
$result = $c->query("SELECT municipio.nombre AS nombre, poblacion, superficie, altitud, gentilicio, GROUP_CONCAT(pedania.nombre ORDER BY pedania.nombre SEPARATOR ', ') AS pedanias FROM municipio LEFT JOIN pedania on municipio_id = municipio.id WHERE comarca_id = $comarca GROUP BY municipio.id ORDER BY municipio.nombre");
$outp = array();
$outp = $result->fetch_all(MYSQLI_ASSOC);
echo json_encode($outp);
$c->close();
?>