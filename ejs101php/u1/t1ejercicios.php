/* EJERCICIO 1:
Escribe un programa que muestre tu nombre por pantalla. 
*/

<!DOCTYPE html>
<html lang="es">
  <head>
    <meta charset="utf-8">
    <title></title>
  </head>
  <body>
	<?php echo 'Isabel'; ?>
  </body>
</html>


/* EJERCICIO 2
Modifica el programa anterior para que muestre tu dirección y tu número de teléfono. Cada dato se debe mostrar en una línea diferente. Mezcla de alguna forma las salidas por pantalla, utilizando tanto HTML como PHP.
*/

<!DOCTYPE html>
<html lang="es">
<head>
	<meta charset="UTF-8">
	<title>Ejercicios PHP</title>	
</head>
<body>
<?php echo 'Isabel' ?>
<br/>
<?php echo 'Dirección' <br/> 'Teléfono' ?>
</body>
</html>

/* EJERCICIO 3 
Escribe un programa que muestre por pantalla 10 palabras en inglés junto a su correspondiente traducción al castellano. Las palabras deben estar distribuidas en dos columnas. Utiliza la etiqueta `<table>` de HTML.*/

<!DOCTYPE html>
<html lang="es">
<head>
	<meta charset="UTF-8">
	<title>Ejercicios PHP</title>
</head>
<body>
	<?php
	echo '<table>';
	?>
		<tr>
			<th>Español</th>
			<th>English</th>
		</tr>
		<tr>
			<td>Unicornio</td>
			<td>Unicorn</td>
		</tr>
		<tr>
			<td>Pegaso</td>
			<td>Pegasus</td>
		</tr>
		<tr>
			<td>Ballena</td>
			<td>Whale</td>
		</tr>
		<tr>
			<td>Elefante de PHP</td>
			<td>PHP elefant</td>
		</tr>
		<tr>
			<td>Abejorro</td>
			<td>Bumblebee</td>
		</tr>
		<tr>
			<td>Abeja</td>
			<td>Bee</td>
		</tr>
		<tr>
			<td>Avispa malvada</td>
			<td>Evil wasp</td>
		</tr>
		<tr>
			<td>Caballo</td>
			<td>Horse</td>
		</tr>
		<tr>
			<td>Toro</td>
			<td>Bull</td>
		</tr>
		<tr>
			<td>Vaca</td>
			<td>Cow</td>
		</tr>
	<?php
	echo '</table>';
	?>
</body>
</html>


/*Ejercicio 4

Escribe un programa que muestre tu horario de clase mediante una tabla. Aunque se puede hacer íntegramente en HTML (igual que los ejercicios anteriores), ve intercalando código HTML y PHP para familiarizarte con éste último.*/

<!DOCTYPE html>
<html lang="es">
<head>
	<meta charset="UTF-8">
	<title>Ejercicios PHP</title>
</head>
<body>
	<?php 
	echo '<table>';	
	echo <tr><th>Lunes</th><th>Martes</th><th>Miércoles</th><th>Jueves</th><th>Viernes</th></tr>; ?>
	<tr><td>DWES</td><td>DIW</td><td>HLIB</td><td>DAW</td><td>EIE</td></tr>
	<tr><td>DWES</td><td>DIW</td><td>HLIB</td><td>DIW</td><td>DAW</td></tr>
	<tr><td>DWES</td><td>HLIB</td><td>DIW</td><td>DIW</td><td>DAW</td></tr>
	<tr><td>DWEC</td><td>EIE</td><td>DIW</td><td></td>DWES<td>DWEC</td></tr>
	<tr><td>DWEC</td><td>DWES</td><td>EIE</td><td>DWES</td><td>DWEC</td></tr>
	<tr><td>DWEC</td><td>DWES</td><td>EIE</td><td>DWES</td><td>DWEC</td></tr>
	<?php
	echo '</table>';
	?>
</body>
</html>


/* Ejercicio 5

Escribe un programa que utilice las variables $x y $y. Asignales los valores 144 y 999 respectivamente. A continuación, muestra por pantalla el valor de cada variable, la suma, la resta, la división y la multiplicación.*/

<!DOCTYPE html>
<html lang="es">
<head>
	<meta charset="UTF-8">
	<title>Ejercicios PHP</title>
</head>
<body>
<?php
$x = 144;
$y = 999;
echo 'x = ', $x;
echo '<br/>y = ', $y;
echo '<br/> x + y = ', $x + $y;
echo '<br/> x - y = ', $x - $y;
echo '<br/> x / y = ', $x / $y;
echo '<br/> x * y = ', $x * $y;
?>
</body>
</html>


/*Ejercicio 6

Crea la variable $nombre y asígnale tu nombre completo. Muestra su valor por pantalla de tal forma que el resultado sea el mismo que el del ejercicio 1.*/

<!DOCTYPE html>
<html lang="es">
<head>
	<meta charset="UTF-8">
	<title>Ejercicios PHP</title>
</head>
<body>
	<?php
		$nombre = 'Isabel';
		echo $nombre;
	?>
</body>
</html>


/*Ejercicio 7

Crea las variables $nombre, $direccion y $telefono y asígnales los valores adecuados. Muestra los valores por pantalla de tal forma que el resultado sea el mismo que el del ejercicio 2.*/

<!DOCTYPE html>
<html lang="es">
<head>
	<meta charset="UTF-8">
	<title>Ejercicios PHP</title>
</head>
<body>
	<?php
		$nombre = 'Isabel';
		$direccion = 'mi dirección';
		$telefono = '555'
		echo $nombre . $direccion .$telefono;
	?>
</body>
</html>


/* Ejercicio 8

Realiza un conversor de euros a pesetas. La cantidad en euros que se quiere convertir deberá estar almacenada en una variable.*/

<!DOCTYPE html>
<html lang="es">
<head>
	<meta charset="UTF-8">
	<title>Ejercicios PHP</title>
</head>
<body>
	<?php
		$miseuros = 10;
		$uneurocuantaspesetas = 166;
		$mispesetas = $miseuros * $uneurocuantaspesetas;
		echo 'Si tengo ', $miseuros, ' €, tengo ', $mispesetas, ' pesetas.';
	?>
</body>
</html>

/*Ejercicio 9

Realiza un conversor de pesetas a euros. La cantidad en pesetas que se quiere convertir deberá estar almacenada en una variable.*/

<!DOCTYPE html>
<html lang="es">
<head>
	<meta charset="UTF-8">
	<title>Ejercicios PHP</title>
</head>
<body>
	<?php
		$mispesetas = 10000;
		$uneurocuantaspesetas = 166;
		$miseuros = round($mispesetas / $uneurocuantaspesetas);
		echo 'Tengo ', $mispesetas, ' pesetas, luego tengo ', $miseuros, ' euros.';
	?>
</body>
</html>

/*Ejercicio 10

Escribe un programa que pinte por pantalla una pirámide rellena a base de asteriscos. La base de la pirámide debe estar formada por 9 asteriscos.*/

<!DOCTYPE html>
<html lang="es">
<head>
	<meta charset="UTF-8">
	<title>Ejercicios PHP</title>
</head>
<body>
	<?php
      echo "<pre>";
      echo "    *<br />";
      echo "   ***<br />";
      echo "  *****<br />";
      echo " *******<br />";
      echo "*********<br />";
      echo "</pre>";
	?>
</body>
</html>
   

/*Ejercicio 11

Igual que el programa anterior, pero esta vez la pirámide estará hueca (se debe ver únicamente el contorno hecho con asteriscos).*/

<!DOCTYPE html>
<html lang="es">
<head>
	<meta charset="UTF-8">
	<title>Ejercicios PHP</title>
</head>
<body>
    <?php
      echo "<pre>";
      echo "    * <br />";
      echo "   * *<br />";
      echo "  *   *<br />";
      echo " *     *<br />";
      echo "*********<br />";
      echo "</pre>";
    ?>
</body>
</html>

/* Ejercicio 12

Igual que el programa anterior, pero esta vez la pirámide debe aparecer invertida, con el vértice hacia abajo.
*/

<!DOCTYPE html>
<html lang="es">
<head>
	<meta charset="UTF-8">
	<title>Ejercicios PHP</title>
</head>
<body>
    <?php
      echo "<pre>";
      echo "*********<br />";
      echo " *     *<br />";
      echo "  *   *<br />";
      echo "   * *<br />";
      echo "    *<br />";
      echo "</pre>";
    ?>
</body>
</html>