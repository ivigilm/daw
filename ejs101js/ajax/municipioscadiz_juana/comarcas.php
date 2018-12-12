<?php
$c = new MySQLi("localhost","root","","cadiz");
$c->query("SET NAMES utf8");
$result = $c->query("SELECT * from comarca ORDER BY nombre");
$outp = array();
$outp = $result->fetch_all(MYSQLI_ASSOC);
echo json_encode($outp);
$c->close();
?>