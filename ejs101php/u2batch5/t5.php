<?php
/**
 * Batch 5. Functions.
 */


//1. esCapicua: Devuelve verdadero si el número que se pasa como parámetro es capicúa y falso en caso contrario.

function esCapicua($n){
    $capicua = true;

    for($i = 0; $i < strlen($n); $i++){
        for($j = strlen($n) - 1; $j >= 0; $j--){
            if( $n[$i] != $n[$j]){
                $capicua = false;
            }
        }
    }
    return $capicua;
}



// 2 esPrimo: Devuelve verdadero si el número que se pasa como parámetro es primo y falso en caso contrario.
function esPrimo($n){

    $primo = true;

    for($i = 2; $i < $n; $i++){
        if($n % $i == 0) {
            $primo = false;
        }
    }

    return $primo;
}


// 3. siguientePrimo: Devuelve el menor primo que es mayor al número que se pasa como parámetro.

function siguientePrimo($n){

    for($i = $n + 1; ; $i++){
        if(esPrimo($i)){
            return $i;
        }
    }
}



// 4. potencia: Dada una base y un exponente devuelve la potencia.

function potencia($base, $exp){
    $result = $base;

    for($i = 1; $i <= $exp; $i++){
        $result *= $base;
    }

    return $result;
}



// 5. digitos: Cuenta el número de dígitos de un número entero.

function digitos($n){
    $digits = 0;

    for($i = 0; $i < strleng($n); $i++){
        $digits += 1;
    }

    if($n[0] == "-"){
        $digits--;
    }

    return $digits;
}



// 6. voltea: Le da la vuelta a un número.

function voltea($n){
    $newnumber = "";

    for($i = strlen($n) -1; $i >= 0; $i--){
        $newnumber .= $n[$i];
    }

    return $newnumber;
}


//  7. digitoN: Devuelve el dígito que está en la posición n de un número entero.
// Se empieza contando por el 0 y de izquierda a derecha.

function digitoN($number, $position){
    return $number[$position];
}


//  8. posicionDeDigito: Da la posición de la primera ocurrencia
// de un dígito dentro de un número entero. Si no se encuentra, devuelve -1.

function posicionDeDigito($n, $digit){
    for($i = 0; $i < strlen($n); $i++){
        if($n[$i] == $digit){
            return $i;
        }
    }

    return -1;
}



// 9. quitaPorDetras: Le quita a un número n dígitos por detrás (por la derecha).

function quitaPorDetras($number, $digits){
    return substr($number, 0, strlen($number) - $digits);
}



// 10. quitaPorDelante: Le quita a un número n dígitos por delante (por la izquierda).

function quitaPorDelante($number, $digits){
    return substr($number, $digits);
}



// 11. pegaPorDetras: Añade un dígito a un número por detrás.

function pegaPorDetras($number, $newdigit){
    return $number .= $newdigit;
}



// 12. pegaPorDelante: Añade un dígito a un número por delante.

function pegaPorDelante($number, $newdigit){
    return $number = $newdigit . $number;
}


//  13. trozoDeNumero: Toma como parámetros las posiciones inicial y final dentro de un número
// y devuelve el trozo correspondiente.

function trozoDeNumero($number, $start, $end){
    return substr($number, $start, $end - $start);
}



//   14. juntaNumeros: Pega dos números para formar uno.

function juntaNumeros($n1, $n2){
    return $n1 . $n2;
}



// 15. Muestra los números primos que hay entre 1 y 1000.

function primos1a1000(){
    for($i = 1; $i <= 1000; $i++){
        if(esPrimo($i)){
            echo $i, "<br/>";
        }
    }
}



// 16. Muestra los números capicúa que hay entre 1 y 99999.

function capicua1a99999(){
    for($i = 1; $i <= 99999; $i++){
        if(esCapicua($i)){
            echo $i, "<br/>";
        }
    }
}




// 17. Escribe un programa que pase de binario a decimal.




// 18. Escribe un programa que pase de decimal a binario.




// 19. Une y amplía los dos programas anteriores de tal forma que se permita convertir
// un número entre cualquiera de las siguientes bases: decimal, binario, hexadecimal y octal.





// 20. generaArrayInt: Genera un array de tamaño n con números aleatorios cuyo intervalo
// (mínimo y máximo) se indica como parámetro.
// Traducción: createNewArray

function generaArrayInt($size, $min, $max){
    $newarray = array();

    for($i = 0; $i < $size; $i++){
        $newarray[$i] = rand($min, $max);
    }

    return $newarray;
}

//checking 20:
// echo implode(", ", generaArrayInt(7, 1, 1000));



// 21. minimoArrayInt: Devuelve el mínimo del array que se pasa como parámetro.

function minimoArrayInt($array){
    $min = $array[0];
    for($i = 0; $i < count($array); $i++){
        if($array[$i] < $min){
            $min = $array[$i];
        }
    }
    return $min;
}


// 22. maximoArrayInt: Devuelve el máximo del array que se pasa como parámetro.

function maximoArrayInt($array){
    $max = $array[0];
    for($i = 0; $i < count($array); $i++){
        if($array[$i] > $max){
            $max = $array[$i];
        }
    }
    return $max;
}



// 23. mediaArrayInt: Devuelve la media del array que se pasa como parámetro.

function mediaArrayInt($array){
    $count = 0;
    $sum = 0;
    for($i = 0; $i < count($array); $i++){
        $count++;
        $sum += $array[$i];
    }

    return $sum / $count;
}



// 24. estaEnArrayInt: Dice si un número está o no dentro de un array.

function estaEnArrayInt($array, $n){
    for($i = 0; $i < count($array); $i++){
        if($array[$i] == $n){
            return true;
        }
    }
    return false;
}




// 25. posicionEnArray: Busca un número en un array y devuelve la posición (el índice) en la que se encuentra.

function posicionEnArray($array, $n){
    for($i = 0; $i < count($array); $i++){
        if($array[$i] == $n){
            return $i;
        }
    }
    return -1;
}



// 26. volteaArrayInt: Le da la vuelta a un array.

function volteaArrayInt($array){
    $newarray = array();

    for($i = count($array); $i >= 0; $i--){
        $newarray[] = $array[$i];
    }

    return $newarray;
}




// 27. rotaDerechaArrayInt: Rota n posiciones a la derecha los números de un array.

function rotaDerechaArrayInt($array, $posiciones){
    $newarray = array();

    for($i = 0; $i < count($array); $i++){
        $newarray[] = $array[$i - $posiciones];
    }

    return $newarray;
}


// 28. rotaIzquierdaArrayInt: Rota n posiciones a la izquierda los números de un array.

function rotaIzquierdaArrayInt($array, $posiciones){
    $newarray = array();

    for($i = 0; $i < count($array); $i++){
        $newarray[] = $array[$i + $posiciones];
    }

    return $newarray;
}






// 29. generaArrayBiInt: Genera un array de tamaño n x m
// con números aleatorios cuyo intervalo (mínimo y máximo) se indica como parámetro.

function generaArrayBiInt($rows, $columns, $min, $max){
    $newarray = array();

    for($i = 0; $i < $rows; $i++){
        for($j = 0; $j < $columns; $j++){
            $newarray[$i][$j] = rand($min, $max);
        }
    }

    return $newarray;
}

/*checking 29:
 * $myarray = generaArrayBiInt(3, 2, 1, 50);

for($i = 0; $i < count($myarray); $i++){
    for($j = 0; $j < count($myarray[$i]); $j++){
        echo $myarray[$i][$j], ", ";
    }
    echo "<br/>";
}*/

// 30. filaDeArrayBiInt: Devuelve la fila i-ésima del array que se pasa como parámetro.

function filaDeArrayBiInt($array, $fila){
    $aux = array();

    for($j = 0; $j < count($array[$fila]); $j++){
        $aux[$j] = $array[$fila][$j];
    }

    return $aux;
}


/* checking 30
 * $myarray = generaArrayBiInt(3, 4, 1, 50);
for($i = 0; $i < count($myarray); $i++) {
    for ($j = 0; $j < count($myarray[$i]); $j++) {
        echo $myarray[$i][$j], ", ";
    }
    echo "<br/>";
}
echo "<br/>";

echo implode(",", filaDeArrayBiInt( $myarray, 1));
*/

// 31.  columnaDeArrayBiInt: Devuelve la columna j-ésima del array que se pasa como parámetro.

function columnaDeArrayBiInt($array, $columna){
    $aux = array();

    for($i = 0; $i < count($array); $i++){
        $aux[$i] = $array[$i][$columna];
    }

    return $aux;
}

/*checking 31
$myarray = generaArrayBiInt(3, 4, 1, 50);
for($i = 0; $i < count($myarray); $i++) {
    for ($j = 0; $j < count($myarray[$i]); $j++) {
        echo $myarray[$i][$j], ", ";
    }
    echo "<br/>";
}
echo "<br/>";

echo implode(",", columnaDeArrayBiInt( $myarray, 1));*/



// 32. coordenadasEnArrayBiInt: Devuelve la fila y la columna (en un array con dos elementos) de la primera ocurrencia de un número dentro de un array bidimensional. Si el número no se encuentra en el array, la función devuelve el array {-1, -1}.

function coordenadasEnArrayBiInt($array, $number){
    $coincidences = array();

    for($i = 0; $i < count($array); $i++){
        for($j = 0; $j < count($array[$i]); $j++){
            if($array[$i][$j] == $number){
                $coincidences[] = [$i, $j];     // return breaks the loops
            }
        }
    }

    if (count($coincidences) == 0){
        $coincidences[0] = [-1, -1];
    }

    return $coincidences[0];
}

// checking 32
/*$myarray = generaArrayBiInt(3, 4, 1, 3);
for($i = 0; $i < count($myarray); $i++) {
    for ($j = 0; $j < count($myarray[$i]); $j++) {
        echo $myarray[$i][$j], ", ";
    }
    echo "<br/>";
}
echo "<br/>";

echo implode(",", coordenadasEnArrayBiInt($myarray, 3));*/

// 33. esPuntoDeSilla: Dice si un número es o no punto de silla, es decir, mínimo en su fila y máximo en su columna.

function esPuntoDeSilla($array, $row, $column){
    $espunto = true;

    // checking row
    for($j = 0; $j < count($array[$row]); $j++){
        if($array[$row][$j] < $array[$row][$column]){
            $espunto = false;
        }
    }

    // checking column
    for($i = 0; $i < count($array); $i++){
        if($array[$i][$column] > $array[$row][$column]){
            $espunto = false;
        }
    }

    return $espunto;
}

/* checking 33
$myarray = generaArrayBiInt(3, 4, 1, 50);
for($i = 0; $i < count($myarray); $i++) {
    for ($j = 0; $j < count($myarray[$i]); $j++) {
        echo $myarray[$i][$j], ", ";
    }
    echo "<br/>";
}
echo "<br/>";

$myboolean = (esPuntoDeSilla($myarray, 0, 0)) ? 'true' : 'false';

echo $myboolean;*/



// 34. diagonal: Devuelve un array que contiene una de las diagonales del array bidimensional
// que se pasa como parámetro. Se pasan como parámetros fila, columna y dirección.
// La fila y la columna determinan el número que marcará las dos posibles diagonales dentro del array.
// La dirección es una cadena de caracteres que puede ser “nose” o “neso”.
// La cadena “nose” indica que se elige la diagonal que va del noroeste hacia el sureste,
// mientras que la cadena “neso” indica que se elige la diagonal que va del noreste hacia el suroeste.

function diagonal($arraybi, $row, $column, $direction){
    // $direction can be:
    //  · nose: top left corner to bottom right
    //  · neso: top right to bottom left

    $diagonal = array();

    for($i = 0; $i < count($arraybi); $i++){
        for($j = 0; $j < count($arraybi[$i]); $j++){
            if($direction == "nose" && ($row - $i == $column - $j)){
                $diagonal[] = $arraybi[$i][$j];
            }elseif( ($direction == "neso") && ($row - $i == -($column - $j))){
                $diagonal[] = $arraybi[$i][$j];
            }
        }
    }

    return $diagonal;
}

/* checking 34
 * $myarray = generaArrayBiInt(5, 5, 1, 50);

for($i = 0; $i < count($myarray); $i++) {
    for ($j = 0; $j < count($myarray[$i]); $j++) {
        echo $myarray[$i][$j], ", ";
    }
    echo "<br/>";
}

echo "<br/>";

echo implode(", ", diagonal($myarray, 2, 3, "nose"));
echo "<br/>";
echo implode(", ", diagonal($myarray, 2, 3, "neso"));*/