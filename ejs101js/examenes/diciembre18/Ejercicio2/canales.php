<?php
	require_once("conexion.inc.php");
	$c = new mysqli($h, $u, $p, $bd);
	$c->query("set names utf8");
	$resultado = $c->query("SELECT * FROM canal ORDER BY id ASC");
	if ($resultado == true){
		$salida = array("estado"=>200,"data"=>$resultado->fetch_all(MYSQLI_ASSOC));
	}else{
		$salida = $salida = array("estado"=>404);
	}
	echo json_encode($salida);
	$c->close();
?>