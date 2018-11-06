<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>t2-12-01.php</title>
</head>
<body>
    <h1>Cuestionario DAW</h1>

    <form action="t2-12-02.php" method="post">
        <ol>
        <li>La cuota de mercado es...<br/>
            <input type="radio" name="p1" value="1" />a) El porcentaje del mercado que tiene una empresa como cliente.<br/>
            <input type="radio" name="p1" value="0" />b) El porcentaje del mercado que tiene una empresa como proveedor.<br/>
            <input type="radio" name="p1" value="0" />c) El tanto por mil del mercado que tiene una empresa como proveedor.<br/>
            <input type="radio" name="p1" value="0" />d) El tanto por mil del mercado que tiene una empresa como cliente.<br/>
        </li><br/>
        <li>Los puertos lógicos bien conocidos se encuentran entre...<br/>
            <input type="radio" name="p2" value="1" />a) 0 y 1023<br/>
            <input type="radio" name="p2" value="0" />b) 1 y 1023<br/>
            <input type="radio" name="p2" value="0" />c) 1 y 1024<br/>
            <input type="radio" name="p2" value="0" />d) 0 y 1024<br/>
        </li><br/>
        <li>En una guía de estilo indica...<br/>
            <input type="radio" name="p3" value="1" />a) Los colores que se utilizarán en una web.<br/>
            <input type="radio" name="p3" value="0" />b) Los colores que se llevarán esta temporada.<br/>
            <input type="radio" name="p3" value="0" />c) Los colores que mejor te sientan.<br/>
            <input type="radio" name="p3" value="0" />d) Los colores del arcoiris.<br/>
        </li><br/>
        <li>En las expresiones regulares el asterisco (*) indica que el carácter precedente se buscará...<br/>
            <input type="radio" name="p4" value="1" />a) 0 o más veces<br/>
            <input type="radio" name="p4" value="0" />b) 1 o más veces<br/>
            <input type="radio" name="p4" value="0" />c) 0 o 1 veces<br/>
            <input type="radio" name="p4" value="0" />d) 1 vez<br/>
        </li><br/>
        <li>El código PHP se encierra entre...<br/>
            <input type="radio" name="p5" value="1" />a) < ?php y ?><br/>
            <input type="radio" name="p5" value="0" />b) < ?php y php?><br/>
            <input type="radio" name="p5" value="0" />c) < ?php> y </?php><br/>
            <input type="radio" name="p5" value="0" />d) < php y php><br/>
        </li><br/>
        <li>Las variables en PHP se indican antecediendo a su nombre...<br/>
            <input type="radio" name="p6" value="1" />a) $<br/>
            <input type="radio" name="p6" value="0" />b) €<br/>
            <input type="radio" name="p6" value="0" />c) ?<br/>
            <input type="radio" name="p6" value="0" />d) #<br/>
        </li><br/>
        <li>En PHP la función <em>isset</em> indica que...<br/>
            <input type="radio" name="p7" value="1" />a) una variable está definida y no es nula.<br/>
            <input type="radio" name="p7" value="0" />b) una variable está definida, pudiendo ser nula.<br/>
            <input type="radio" name="p7" value="0" />c) una variable no está definida.<br/>
            <input type="radio" name="p7" value="0" />d) una variable es una variable.<br/>
        </li><br/>
        <li>En PHP la función <em>empty</em> indica que...<br/>
            <input type="radio" name="p8" value="1" />a) una variable está vacía.<br/>
            <input type="radio" name="p8" value="0" />b) una variable está vacía o es nula.<br/>
            <input type="radio" name="p8" value="0" />c) una variable es nula.<br/>
            <input type="radio" name="p8" value="0" />d) una variable no existe.<br/>
        </li><br/>
        <li>La variable $_POST contiene la variable que...<br/>
            <input type="radio" name="p9" value="1" />a) llega al script actual mediante el método POST.<br/>
            <input type="radio" name="p9" value="0" />b) llega al script actual mediante el método GET.<br/>
            <input type="radio" name="p9" value="0" />c) llega al script actual mediante el método COOKIE.<br/>
            <input type="radio" name="p9" value="0" />d) llega al script actual mediante el método POST, GET o COOKIE.<br/>
        </li><br/>
        <li>$_SERVER['SERVER_ADDR'] indica...<br/>
            <input type="radio" name="p10" value="1" />a) la IP del servidor web.<br/>
            <input type="radio" name="p10" value="0" />b) la IP del cliente.<br/>
            <input type="radio" name="p10" value="0" />c) la IP del servidor de correo.<br/>
            <input type="radio" name="p10" value="0" />d) la IP del modelo cliente-servidor.<br/>
        </li>
        </ol>

        <input type="submit" value="Enviar" />
    </form>

</body>
</html>