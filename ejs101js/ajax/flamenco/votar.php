<?php
	$id = $_POST['id'];
	require_once("conexion.inc.php");
	$c = new mysqli($h, $u, $p, $bd);
	$resultado = $c->query("SELECT idespectaculo FROM espectaculo WHERE idespectaculo = $id");
	if ($resultado->num_rows == 1){
		$c->query("UPDATE espectaculo SET votos = votos + 1 WHERE idespectaculo = $id");
		echo "200";
	}else{
		echo "404";
	}
	$c->close();
?>