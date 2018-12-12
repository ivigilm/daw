<?php
	require_once("conexion.inc.php");
	$c = new mysqli($h, $u, $p, $bd);
	$salida = array();
	$c->query("set names utf8");
	$resultado = $c->query("SELECT * FROM espectaculo ORDER BY votos DESC");
	$salida = $resultado->fetch_all(MYSQLI_ASSOC);
	echo json_encode($salida);
	$c->close();
?>