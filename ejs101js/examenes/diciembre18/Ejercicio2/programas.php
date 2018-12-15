<?php
	$id = $_REQUEST['id'];
	$fecha = $_REQUEST['fecha'];
	require_once("conexion.inc.php");
	$c = new mysqli($h, $u, $p, $bd);
	$c->query("SET NAMES utf8");
	$sql = "SELECT DATE_FORMAT(hora,'%H:%i') as hora,nombre,descripcion FROM programa WHERE idcanal = $id AND fecha='$fecha' ORDER BY RAND()";
	$resultado = $c->query($sql);
	if ($resultado->num_rows > 0){
		$salida = array();
		$salida = $resultado->fetch_all(MYSQLI_ASSOC);
		echo json_encode($salida);
	}else{
		echo "error";
	}
	$c->close();
?>