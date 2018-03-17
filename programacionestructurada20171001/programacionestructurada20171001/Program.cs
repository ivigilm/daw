using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Mis primeros ejercicios de programación.

 En estos primeros ejercicios solo se practican las instrucciones indicadas (if/else, while, etc.),
 por eso se escribe por pantalla el resultado en lugar de devolverlo.

     */

namespace programacionestructurada20171001
{
    class Program
    {
        // Ejercicios de condicionales (if/else)
                
        /// <summary>
        /// Resta dos números enteros dados (el mayor menos el menor)  e imprime el resultado por pantalla.
        /// </summary>
        static void RestaAbsolutaDeDosNumerosEnteros() // 1 
        {
            // Declaramos las variables

            int a, b, resta;

            // Le pedimos los valores al usuario y los introducimos en las variables

            Console.WriteLine("Dime un número.");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime otro número.");
            b = int.Parse(Console.ReadLine());
            
            // Realizamos la operación de resta

            if (a >= b)
            {
                resta = a - b;
            }
            else
            {
                resta = b - a;
            }

            Console.WriteLine("La resta es " + resta + ".");
        }

        /// <summary>
        /// Comprueba si un año dado es bisiesto e imprime la información por pantalla.
        /// </summary>
        static void EsBisiestoONo() // 2 
        {
            // Declaramos las variables

            int year;

            // Le pedimos el año al usuario y lo guardamos en la variable

            Console.WriteLine("Dame el año.");
            year = int.Parse(Console.ReadLine());

            // Condicional

            if ( ( (year % 4 == 0) && (year % 100 == 0) && (year % 400 == 0) ) || ( (year % 4 == 0) && (year % 100 != 0) ) )
            {
                Console.WriteLine("El año " + year + " es bisiesto.");
            }
            else
            {
                Console.WriteLine("El año " + year + " no es bisiesto.");
            }
        }

        /// <summary>
        /// Convierte una cantidad de euros a pesetas o viceversa.
        /// </summary>
        static void ConversorEurosPesetas() // 3 
        {
            // Declaramos las variables
            double numero, conversion;
            string moneda;

            // Pedimos los datos
            Console.WriteLine("¿Cuánto dinero tienes? Pon el decimal con ',' por favor.");
            numero = double.Parse(Console.ReadLine());

            Console.WriteLine("¿A qué moneda lo quieres convertir? (euro/peseta)");
            moneda = Console.ReadLine();

            //Hacemos el cambio: 1€ = 166,386 pesetas

            if (moneda == "peseta")
            {
                conversion = numero * 166.386;
                Console.WriteLine(numero + " euros son " + conversion + " pesetas.");
            }
            else
            {
                conversion = numero / 166.386;
                Console.WriteLine(numero + " pesetas son " + conversion + " euros.");
            }
        }

        /// <summary>
        /// Dados tres números enteros, comprueba si están ordenados de menor a mayor.
        /// </summary>
        static void TresEnterosOrdenados() // 4 
        {
            // Definimos las variables

            int x, y, z;

            // Pedimos los datos y los guardamos en las variables

            Console.WriteLine("Dime el primer número entero.");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime el segundo número entero.");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime el tercer número entero.");
            z = int.Parse(Console.ReadLine());

            // Condicionales: comprobamos si están ordenados de menor a mayor

            if ( (x <= y) && (x <= z) && (y <= z) )
            {                
                Console.WriteLine("Los números están ordenados de menor a mayor.");                
            }
            else
            {
                Console.WriteLine("Los números no están ordenados de menor a mayor.");
            }
        }

        /// <summary>
        /// Comprueba si tres números enteros dados son consecutivos.
        /// </summary>
        static void TresEnterosConsecutivos() // 5 
        {
            // Declaramos las variables

            int x, y, z;

            // Pedimos los datos

            Console.WriteLine("Dime el primer número entero.");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime el segundo número entero.");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Dime el tercer número entero.");
            z = int.Parse(Console.ReadLine());

            // Condicionales: 

            if ((y == (x + 1)) && (z == (y + 1)))
            {
                Console.WriteLine("Los números son consecutivos.");
            }
            else
            {

                Console.WriteLine("Los números no son consecutivos.");
            }
        }

        /// <summary>
        /// Comprueba cuántas cifras tiene un número entero de entre una y cinco cifras.
        /// </summary>
        static void CuantasCifrasTieneElEntero15() // 6 
        {
            // Declaramos la variable

            int numero;

            // Pedimos el número

            Console.WriteLine("Dime un número entero de entre una y cinco cifras.");
            numero = int.Parse(Console.ReadLine());

            // Comprobamos cuántas cifras tiene e imprimimos el resultado

            if ((numero >= -9) && (numero <= 9))
            {
                Console.WriteLine("Tu número tiene una cifra.");
            }
            else
            {
                if ((numero >= -99) && (numero <= 99))
                {
                    Console.WriteLine("Tu número tiene dos cifras.");
                }
                else
                {
                    if ((numero >= -999) && (numero <= 999))
                    {
                        Console.WriteLine("Tu número tiene tres cifras.");
                    }
                    else
                    {
                        if ((numero >= -9999) && (numero <= 9999))
                        {
                            Console.WriteLine("Tu número tiene cuatro cifras.");
                        }
                        else
                        {
                            Console.WriteLine("Tu número tiene cinco cifras.");
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Resuelve una ecuación de segundo grado (a*x^2 + b*x + c = 0).
        /// </summary>
        static void EcuacionSegundoGrado() // 7 
        {
            // La fórmula para hallar las dos soluciones de una ecuación de segundo grado es:
            // x = ( -b + Sqrt( b^2 - 4*a*c ) ) / (2*a)
            // x = ( -b - Sqrt( b^2 - 4*a*c ) ) / (2*a)             

            // Declaramos las variables

            int a, b, c;
            double solucion1, solucion2;

            // Pedimos las variables y las asignamos

            Console.WriteLine("¿Cuánto vale la variable a?");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Cuánto vale la variable b?");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Cuánto vale la variable c");
            c = int.Parse(Console.ReadLine());

            // Condicional: si tiene solución real, calculamos las soluciones y las mostramos.

            if ( (b * b) >= (4 * a * c) )
            {
                solucion1 = (-b + (Math.Sqrt((b * b) - (4 * a * c)))) / (2 * a);
                solucion2 = (-b - (Math.Sqrt((b * b) - (4 * a * c)))) / (2 * a);

                if (solucion1 == solucion2)
                {
                    Console.WriteLine("La solución de la ecuación es " + solucion1 + ".");
                }
                else
                {
                    Console.WriteLine("Las soluciones de la ecuación son " + solucion1 + " y " + solucion2 + ".");
                }

            }
            else
            {
                Console.WriteLine("La ecuación no tiene solución real.");
            }
        }

        /// <summary>
        /// Ordena tres números enteros de mayor a menor.
        /// </summary>
        static void OrdenaTresEnteros() // 8 
        {
            // Declaramos las variables

            int a, b, c;

            // Pedimos al usuario que introduzca los números y los introducimos en las variables

            Console.WriteLine("Escribe un número entero.");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Escribe otro número entero.");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Escribe otro número entero.");
            c = int.Parse(Console.ReadLine());

            // Condicionales: determinamos en qué orden van de mayor a menor

            if ((a >= b) && (a >= c))
            {
                Console.WriteLine(a + " es el mayor de los tres.");

                if (b >= c)
                {
                    Console.WriteLine(b + " es el de en medio. " + c + " es el menor.");
                }
                else
                {
                    Console.WriteLine(c + " es el de en medio. " + b + " es el menor.");
                }
            }
            else
            {
                if ((b >= a) && (b >= c))
                {
                    Console.WriteLine(b + " es el mayor de los tres.");

                    if (a >= c)
                    {
                        Console.WriteLine(a + " es el de en medio. " + c + " es el menor.");
                    }
                    else
                    {

                        Console.WriteLine(c + " es el de en medio. " + a + " es el menor.");
                    }
                }
                else
                {
                    Console.WriteLine(c + " es el mayor de los tres.");

                    if (a >= b)
                    {
                        Console.WriteLine(a + " es el de en medio. " + b + " es el menor.");
                    }
                    else
                    {
                        Console.WriteLine(b + " es el de en medio. " + a + " es el menor.");
                    }
                }

            }
        }

        // Ejercicios de bucles (while)

        /// <summary>
        /// Imprime por pantalla los números enteros del 10 al 20.
        /// </summary>
        static void Escribe10al20() // 9 
        {
            // Declaramos la variable.

            int i;

            // Inicializamos la variable.

            i = 10;

            while (i <= 20) // Mientras la variable sea menor o igual a 20.
            {
                Console.WriteLine(i); // Escribimos el valor de la variable.
                i = i + 1; // Y continuamos con el siguiente número.
            }
        }

        /// <summary>
        /// Imprime por pantalla los números enteros impares entre el 1 y el 10.
        /// </summary>
        static void EscribeImpares1al10() // 10 
        {
            // Declaramos la variable.

            int i;

            // Inicializamos la variable.

            i = 1;

            while (i <= 10) // Mientras la variable sea menor o igual a 10
            {
                if (i % 2 != 0) // si es impar
                {
                    Console.WriteLine(i); // se imprime por pantalla
                }

                i = i + 1; // sea o no impar, se aumenta en uno su valor antes de continuar el bucle

            }
        }

        /// <summary>
        /// Imprime por pantalla los primeros diez números pares.
        /// </summary>
        static void EscribeDiezPrimerosPares() // 11 
        {
            // Declaramos las variables

            int i, contadorPares;

            // Inicializamos las variables
            i = 1;
            contadorPares = 0;

            while (contadorPares < 10) // Mientras no lleguemos a tener 10 números pares
            {
                if (i % 2 == 0) // si el número es par lo escribimos
                {
                    Console.WriteLine(i);
                    contadorPares = contadorPares + 1; // y sumamos 1 al contador de pares impresos
                }

                i = i + 1; // continuamos examinando el siguiente número en la próxima vuelta del bucle

            }
        }

        /// <summary>
        /// Imprime por pantalla los números pares/impares del 1 al 10 (a petición del usuario).
        /// </summary>
        static void ParesOImpares1al10() // 12 
        {
            // Declaramos e inicializamos las variables

            int i;
            i = 1;
            string paridad;

            Console.WriteLine("¿Quieres números pares o impares? (par/impar)");
            paridad = Console.ReadLine();

            // Según la petición del usuario (números pares o impares), imprimimos la elección.

            if (paridad == "par")
            {
                while (i <= 10)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }

                    i = i + 1;
                }
            }
            else
            {
                while (i <= 10)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }

                    i = i + 1;
                }
            }
        }

        /// <summary>
        /// Imprime por pantalla la tabla de multiplicar del número deseado.
        /// </summary>
        static void TablaDeMultiplicar() // 13 
        {
            // Declaramos e inicializamos las variables

            int i, numero, resultado;
            i = 1;
            
            Console.WriteLine("¿De qué número quieres obtener la tabla de multiplicación?");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Aquí tienes tu tabla:");

            // Imprimimos la tabla de multiplicar del 1 al 10

            while (i <= 10)
            {
                resultado = numero * i;

                Console.WriteLine(numero + " x " + i + " = " + resultado);

                i = i + 1;
            }
        }

        /// <summary>
        /// Imprime por pantalla los números enteros comprendidos en un intervalo. El usuario debe dar primero el número menor.
        /// </summary>
        static void EscribeNumerosIntervalo() // 14 
        {
            // Declaramos e inicializamos las variables

            int numero1, numero2, i;

            Console.WriteLine("Dime dos números: el segundo mayor que el primero.");
            numero1 = int.Parse(Console.ReadLine());
            numero2 = int.Parse(Console.ReadLine());

            i = numero1;

            // Compruebamos que los datos son correctos

            while (numero2 <= numero1)
            {
                Console.WriteLine("Escribe un número que sea mayor que " + numero1 + " , por favor.");
                numero2 = int.Parse(Console.ReadLine());
            }

            // Una vez tenemos los datos correctos, escribimos el intervalo.

            Console.WriteLine("Estos son los números del intervalo " + numero1 + " - " + numero2 + ".");

            while (i <= numero2)
            {
                Console.WriteLine(i);
                i = i + 1;
            }
        }

        /// <summary>
        /// Imprime por pantalla los números enteros comprendidos en un intervalo.
        /// </summary>
        static void EscribeNumerosIntervaloPro() // 15 
        {
            // Declaramos e inicializamos las variables

            int num1, num2;

            Console.WriteLine("Dime dos números enteros.");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            // Comprobamos cuál es menor y escribimos el intervalo desde el menor al mayor

            Console.WriteLine("Este es tu intervalo:");

            if (num1 <= num2)
            {
                while (num1 <= num2)
                {
                    Console.WriteLine(num1);
                    num1 = num1 + 1;
                }

            }
            else // num1 > num2
            {
                while (num1 >= num2)
                {
                    Console.WriteLine(num1);
                    num1 = num1 - 1;
                }
            }
        }

        /// <summary>
        /// Imprime por pantalla los números impares comprendidos en un intervalo.
        /// </summary>
        static void EscribeImparesIntervalo() // 16 
        {
            // Declaramos e inicializamos las variables

            int numero1, numero2;

            Console.WriteLine("Escribe dos números enteros.");
            numero1 = int.Parse(Console.ReadLine());
            numero2 = int.Parse(Console.ReadLine());

            // Comprobamos cuál es menor y los escribimos en orden ascendente

            if (numero1 < numero2)
            {
                Console.WriteLine("Los números impares de este intervalo son:");

                while (numero1 <= numero2)
                {
                    if (numero1 % 2 != 0)
                    {
                        Console.WriteLine(numero1);
                    }

                    numero1 = numero1 + 1;

                }
            }
            else
            {
                if (numero1 > numero2) // num1 > num2
                {
                    Console.WriteLine("Los números impares de este intervalo son:");

                    while (numero2 <= numero1)
                    {
                        if (numero2 % 2 != 0)
                        {
                            Console.WriteLine(numero2);
                        }

                        numero2 = numero2 + 1;
                    }

                }
                else // num1 == num2
                {
                    if (numero1 % 2 == 0)
                    {
                        Console.WriteLine("Solo has escrito un número, ¡y encima es par!");
                    }
                    else
                    {
                        Console.WriteLine("El único número entero que hay en este intervalo es impar. ¡Felicidades!");
                    }
                }
            }
        }

        /// <summary>
        /// Calcula la suma de los números pares entre 1 y 1000.
        /// </summary>
        static void SumaPares1a1000() // 17 
        {
            // Declaramos e inicializamos variables

            int i, suma;
            i = 1;
            suma = 0;

            while (i <= 1000) // Entre el 1 y el 1000
            {
                if (i % 2 == 0) // si es par
                {
                    suma = suma + i; // lo sumamos
                }

                i = i + 1; // y pasamos a comprobar el siguiente número.
            }

            Console.WriteLine(suma); // Solución: 250.500
        }

        /// <summary>
        /// Calcula el valor medio de una serie de valores enteros positivos introducidos por teclado.
        /// Para terminar de introducir valores el usuario debe escribir un número negativo.
        /// </summary>
        static void Media() // 18 
        {
            // Declaramos e inicializamos las variables.

            int i, n, suma, media;

            i = 0;

            Console.WriteLine("Escribe un número.");
            n = int.Parse(Console.ReadLine());

            suma = 0;

            if (n >= 0)
            {
                while (n >= 0)
                {
                    i = i + 1; // contamos la cantidad de números introducidos

                    suma = suma + n; // los vamos sumando

                    Console.WriteLine("Escribe un número.");
                    n = int.Parse(Console.ReadLine()); // pedimos un nuevo número (que solo reiniciará el bucle si es positivo)
                }

                // Una vez finalizada la introducción de datos, calculamos la media

                media = suma / i;

                Console.WriteLine("La media de tus números es " + media + ".");
            }
            else // n < 0
            {
                Console.WriteLine("No se puede realizar la operación.");
            }
        }

        /// <summary>
        /// Programa para profesor con 30 alumnos. Introduce las notas de una en una y le diremos cuántos aprobados y suspensos tiene.
        /// </summary>
        static void NumerodeAprobadosYSuspensos() // 19 
        {
            // Declaramos e inicializamos variables

            int i, aprobados;
            double nota;
            i = 0;
            aprobados = 0;

            while (i < 30) // hasta que haya introducido 30 notas
            {
                i = i + 1;

                Console.WriteLine("Introduce una nota.");
                nota = double.Parse(Console.ReadLine());

                if (nota >= 5)
                {
                    aprobados = aprobados + 1; // sumamos los aprobados
                }
            }

            Console.WriteLine("Tienes " + aprobados + " aprobados y " + (30 - aprobados) + " suspensos.");

        }

        /// <summary>
        /// Calcula el máximo de una serie de 10 números introducidos por teclado.
        /// </summary>
        static void Maximo10Numeros() // 20 
        {
            // Declaramos e inicializamos variables

            int max, i, n;
            i = 0;

            Console.WriteLine("Introduce el primer número.");
            max = int.Parse(Console.ReadLine()); // Tras introducir un número, este es el máximo.

            while (i < 9) // Quedan 9 números por introducir.
            {
                i = i + 1;

                Console.WriteLine("Introduce otro número.");
                n = int.Parse(Console.ReadLine());

                // Tras introducir un nuevo número, comprobamos si es mayor que el anterior máximo.

                if (n > max)
                {
                    max = n;
                }
            }

            // Una vez comparados los 10 números entre sí, el máximo es:

            Console.WriteLine("El máximo de tu serie es " + max + ".");
        }

        /// <summary>
        /// Halla el máximo, mínimo y la media de una serie de diez números enteros introducidos por teclado.
        /// </summary>
        static void MaximoMinimoMedia10Numeros() // 21
        {
            // Declaramos e inicializamos variables

            int i, n, max, min, media, suma;
            i = 0;

            Console.WriteLine("Introduce un número.");
            n = int.Parse(Console.ReadLine());
            max = n;
            min = n;
            media = n;
            suma = n;

            // (Tras introducir el primer número, tanto el máximo como el mínimo, la media y la suma coinciden.)

            while (i < 9)
            {
                i = i + 1; // Contamos los valores introducidos para salir del bucle al llegar a 10.

                Console.WriteLine("Introduce otro número.");
                n = int.Parse(Console.ReadLine());

                if (n >= max) // Comparamos el nuevo número con el máximo y mínimo guardados
                {
                    max = n;
                }
                else
                {
                    min = n;
                }

                suma = suma + n; // Sumamos los valores introducidos
            }

            media = suma / 10;

            Console.WriteLine("El número máximo es " + max + ". El número mínimo es " + min + ". La media es " + media + ".");
        }

        /// <summary>
        /// Calcula el factorial de una serie de números enteros.
        /// </summary>
        static void Factorial() // 22 
        {
            // Declaramos e inicializamos variables

            int i, n, factorial;

            Console.WriteLine("Dime un número entero positivo.");
            n = int.Parse(Console.ReadLine());

            factorial = n;
            i = n - 1;

            // Recorremos el bucle desde el número introducido hacia abajo

            while (i >= 1)
            {
                factorial = factorial * i; // multiplicando por cada número hasta el 1

                i = i - 1;
            }

            Console.WriteLine("El factorial de " + n + " es " + factorial + ".");
        }
        
        // Ejercicios de bucles (for)

        /// <summary>
        /// Imprime por pantalla los números enteros del 10 al 20.
        /// </summary>
        static void Escribe10al20For() // 23 
        {
            int i;
            i = 10;

            for (i = 10; i <= 20; i = i + 1)
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Imprime por pantalla los números enteros impares entre el 1 y el 10.
        /// </summary>
        static void EscribeImpares1al10For() // 24 
        {
            int i;

            i = 1;

            for (i = 1; i <= 10; i = i + 1)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }

            }
        }

        /// <summary>
        /// Imprime por pantalla los primeros diez números pares.
        /// </summary>
        static void EscribeDiezPrimerosParesFor() // 25 
        {
            int i, j;

            i = 1;
            j = 0;

            for (i = 1; j < 10; i = i + 1)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);

                    j = j + 1;
                }

            }
        }

        /// <summary>
        /// Imprime por pantalla los números pares/impares del 1 al 10 (a petición del usuario).
        /// </summary>
        static void ParesOImpares1al10For() // 26 
        {
            int i;
            string peticion;

            i = 1;

            Console.WriteLine("¿Quieres pares o impares? (par/impar)");
            peticion = Console.ReadLine();

            for (i = 1; i <= 10; i = i + 1)
            {
                if (peticion == "par")
                {
                    if (i % 2 == 0)
                        Console.WriteLine(i);
                }
                else // pide impar
                {
                    if (i % 2 != 0)
                        Console.WriteLine(i);
                }
            }
        }

        /// <summary>
        /// Imprime por pantalla la tabla de multiplicar del número deseado.
        /// </summary>
        static void TablaDeMultiplicarFor() // 27 
        {
            int i, numero;

            i = 1;

            Console.WriteLine("Introduce un número entero.");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("La tabla de multiplicar de " + numero + " es la siguiente:");

            for (i = 1; i <= 10; i = i + 1)
            {
                Console.WriteLine(numero + " x " + i + " = " + numero * i);
            }
        }

        /// <summary>
        /// Imprime por pantalla la serie de números comprendidos entre dos dados (del primero al segundo).
        /// </summary>
        /// <param name="n1">Primer número introducido por parámetro.</param>
        /// <param name="n2">Segundo número introducido por parámetro.</param>
        static void EscribeNumerosIntervaloFor() // 28 
        {            
            int i, num1, num2;

            Console.WriteLine("Dame dos números.");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("El intervalo de números enteros entre " + num1 + " y " + num2 + " es:");

            if (num1 >= num2)
            {
                for (i = num1; i >= num2; i--)
                {
                    Console.WriteLine(i);
                }
            }
            else // num2 > num1
            {
                for (i = num1; i <= num2; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }

        /// <summary>
        /// Escribir los impares entre dos números introducidos por teclado, del menor al mayor.
        /// </summary>
        /// <param name="num1">Primer número introducido por parámetro.</param>
        /// <param name="num2">Segundo número introducido por parámetro.</param>
        static void EscribeImparesIntervaloFor() // 29 
        {            
            int i, max, min, num1, num2;

            Console.WriteLine("Dame dos números.");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            if (num1 <= num2) // la variable  será igual al número menor de entre num1 y num2
            {
                min = num1;
                max = num2;
            }
            else
            {
                min = num2;
                max = num1;
            }
            //min = Math.Min(num1, num2);

            for (i = min; i <= max; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }

            }
        }

        /// <summary>
        /// Calcula la suma de todos los números pares entre 1 y 1000.
        /// </summary>
        static void SumaPares1a1000For() // 30 
        {
            int i, suma;

            suma = 0;

            for (i = 1; i <= 1000; i++)
            {
                if (i % 2 == 0)
                {
                    suma = suma + i;
                }
            }

            Console.WriteLine("La suma de los números pares entre 1 y 1000 es " + suma + ".");

        }

        /// <summary>
        /// El  usuario  de  este  programa  será  un  profesor,  que  introducirá  las  notas  de  sus  30 
        ///  alumnos de  una en  una. El algoritmo  debe decirle  cuántos suspensos  y cuántos aprobados hay.
        /// </summary>
        static void NumerodeAprobadosYSuspensosFor() // 31 
        {
            double nota, i, aprobados;

            aprobados = 0;

            for (i = 0; i < 30; i++)
            {
                Console.WriteLine("Introduce una nota.");
                nota = int.Parse(Console.ReadLine());

                if (nota >= 5)
                {
                    aprobados = aprobados + 1;
                }
            }

            Console.WriteLine("Han aprobado " + aprobados + " personas.");
            Console.WriteLine("Han suspendido " + (30 - aprobados) + " personas. ¡Hazles trabajar más!");

        }

        /// <summary>
        /// Calcula el valor máximo de una serie de 10 números introducidos por teclado.
        /// </summary>
        static void Maximo10NumerosFor() // 32 
        {           
            int n, i, max;

            Console.WriteLine("Dime un número");
            max = int.Parse(Console.ReadLine());

            for (i = 0; i < 9; i++)
            {
                Console.WriteLine("Dime un número.");
                n = int.Parse(Console.ReadLine());

                if (n > max)
                {
                    max = n;
                }
            }

            Console.WriteLine("El valor máximo de la serie es " + max + ".");
        }

        /// <summary>
        /// Calcula el valor máximo, mínimo y la media de una serie de 10 números introducidos por teclado.
        /// </summary>
        static void MaximoMinimoMedia10NumerosFor() // 33 
        {
            int n, m, i, max, min, suma;
            double media;

            Console.WriteLine("Dime un número.");
            m = int.Parse(Console.ReadLine());
            max = m;
            min = m;
            suma = m;

            for (i = 0; i < 9; i++)
            {
                Console.WriteLine("Dime otro número.");
                n = int.Parse(Console.ReadLine());

                suma = (suma + n);

                if (n >= max)
                {
                    max = n;
                }
                else
                {
                    min = n;
                }

            }

            media = (suma / (i + 1));

            Console.WriteLine("El número máximo de tu serie es " + max + ".");
            Console.WriteLine("El número mínimo de tu serie es " + min + ".");
            Console.WriteLine("La media de tu serie es " + media + ".");

        }

        /// <summary>
        /// Halla el factorial de un número dado.
        /// </summary>
        static void FactorialFor() // 34 
        {
            int n, i, factorial;

            Console.WriteLine("Dime un número.");
            n = int.Parse(Console.ReadLine());

            factorial = n;

            for (i = n - 1; i > 0; i--)
            {
                factorial = factorial * i;
            }

            Console.WriteLine("El factorial de tu número es " + factorial + ".");
        }

        // Más ejercicios de bucles

        /// <summary>
        /// Dada una nota, escribe suspenso (0-5), suficiente (5-6), bien (6-7),
        /// notable (7-9) o sobresaliente (9-10). Si la nota no es válida, el programa nos vuelve a
        /// pedir un valor hasta que introduzcamos una nota correcta.
        /// </summary>
        static void EscribeNota() // 35 
        {         
            double nota;

            Console.WriteLine("Dame una nota.");
            nota = double.Parse(Console.ReadLine());


            while (nota > 10 || nota < 0)
            {
                Console.WriteLine("No te equivoques al introducir la nota, por favor: debe de ser un valor entre 0 y 10. Dame una nota válida.");
                nota = double.Parse(Console.ReadLine());
            }

            if (nota >= 5) // aprobado
            {
                if (nota < 6)
                {
                    Console.WriteLine("¡Tu alumno favorito tiene un Suficiente!");
                }
                else // nota >= 6
                {
                    if (nota < 7)
                    {
                        Console.WriteLine("¡Tu alumno favorito tiene un Bien!");
                    }
                    else // nota >= 7
                    {
                        if (nota < 9)
                        {
                            Console.WriteLine("¡Tu alumno favorito tiene un Notable!");
                        }
                        else // nota >= 9
                        {
                            Console.WriteLine("¡Tu alumno favorito tiene un Sobresaliente!");
                        }
                    }
                }
            }
            else // suspenso
            {
                Console.WriteLine("¡Tu alumno favorito está suspenso!");
            }

        }

        /// <summary>
        /// Escribe los 10 primeros números que no son múltiplos ni de 2 ni de 3.
        /// </summary>
        static void NoMultiplos2ni3() // 36 
        {
            int n, i;
            i = 0;
            n = 1;

            while (i < 10)
            {

                if ((n % 2 != 0) && (n % 3 != 0))
                {
                    Console.WriteLine(n);

                    i = i + 1;
                }

                n = n + 1;
            }
        }

        /// <summary>
        /// Escribe los múltiplos de 11, 17 o 23 (a elección) entre 1 y 100.
        /// </summary>
        static void Multiplos111723() // 37 
        {
            int i;
            string opcion;

            Console.WriteLine("¿Qué quieres: múltiplos de 11, 17 o 23?");
            opcion = Console.ReadLine();

            if (opcion == "11") // Múltiplos de 11
            {
                for (i = 1; i <= 100; i++)
                {
                    if (i % 11 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }

                /* Otra forma de hacerlo:
                 * 
                for (n = 1; n * 11 <= 100; n++)
                {
                    Console.WriteLine(n * 11);
                }
                */
            }
            else
            {
                if (opcion == "17") // Múltiplos de 17
                {
                    for (i = 1; i <= 100; i++)
                    {
                        if (i % 17 == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }

                }
                else // Múltiplos de 23
                {
                    for (i = 1; i <= 100; i++)
                    {
                        if (i % 23 == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }

                }
            }
        }

        /// <summary>
        /// Calcula el máximo común divisor de dos números introducidos por teclado.
        /// </summary>
        static void MaximoComunDivisor() // 38 
        {
            int num1, num2, menor, i, mcd;
            mcd = -1;

            Console.WriteLine("Dime dos números.");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            if (num1 >= num2) // Calculo cuál es el menor de los dos números
            {
                menor = num2;
            }
            else
            {
                menor = num1;
            }
                        
            for (i = menor; (num1 % i != 0) || (num2 % i != 0); i--)
            {
                if((num1 % i != 0) || (num2 % i != 0))
                {
                    mcd = i;
                }
            }
            
            Console.WriteLine("El MCD es " + mcd + ".");
        }

        /// <summary>
        /// Calcula el mínimo común múltiplo de dos números.
        /// </summary>
        static void MinimoComunMultiplo() // 39 
        {
            int num1, num2, mayor, i;

            Console.WriteLine("Dame dos números.");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            
            if (num1 >= num2) // Hallamos el mayor de los dos
            {
                mayor = num1;
            }
            else
            {
                mayor = num2;
            }

            i = mayor;

            // Si llega al MCM sale un mensaje diciendo cuál es.

            while ((i % num1 != 0) || (i % num2 != 0))
            {
                i = i + 1;
            }

            Console.WriteLine("El MCM es " + i + ".");

            /* Otra forma de hacerlo:
             * 
             for(i = mayor; i <= num1*num2; i++)
                {
                    if( (i % num1 == 0) && (i % num2 == 0))
                    {
                        Console.WriteLine("MCM es " + i);

                        i = num1 * num2 + 1;
                    }
                }
             */
        }

        /// <summary>
        /// Comprueba si un número es primo.
        /// </summary>
        static void EsPrimo() // 40 
        {
            // Declaro variables y les doy un valor

            int numero, i, contador;

            Console.WriteLine("Dime un número.");
            numero = int.Parse(Console.ReadLine());

            i = numero - 1;
            contador = 0;

            // Mientras i esté entre mi número y 1 (num, num-1, num-2... 1)

            while (i > 1)
            {
                if (numero % i == 0)
                {
                    contador = contador + 1;
                }

                i--;
            }
            
            if (contador > 0)
            {
                Console.WriteLine("Tu número no es primo.");
            }
            else
            {
                Console.WriteLine("Tu número es primo.");
            }
        }

        /// <summary>
        /// Escribe los números primos que hay entre 2 y 1000.
        /// </summary>
        static void PrimosEntre2y1000() // 41 
        {
            // Variables

            int i, j, contador;

            for (i = 2; i <= 1000; i++) // Recorro los números del 2 al 1000
            {

                j = i - 1;
                contador = 0;

                while (j > 1)
                {
                    if (i % j == 0) // Para cada i, compruebo si es primo
                    {
                        contador = contador + 1;
                    }

                    j = j - 1;
                }

                if (contador == 0)
                {
                    Console.WriteLine(i);
                }

            }
        }

        /// <summary>
        /// Juego del número secreto: el usuario deberá adivinar un número entre 1 y 100.
        /// </summary>
        static void NumeroSecreto() // 42 
        {
            // Variables

            int aleatorio, n, intentos, a;

            // Obtengo el número aleatorio

            Random r = new Random();
            aleatorio = r.Next(1, 101);
            intentos = 1;

            // Juego

            Console.WriteLine("Intenta adivinar mi número.");
            n = int.Parse(Console.ReadLine());

            while (n != aleatorio) // Mientras no acierte
            {
                if (n < aleatorio)
                {
                    Console.WriteLine("Mi número es mayor.");
                }
                else // n > aleatorio
                {
                    Console.WriteLine("Mi número es menor.");
                }

                intentos = intentos + 1;

                Console.WriteLine("Escribe otro número.");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("¡Felicidades! Has tardado " + intentos + " intentos.");

        }

        static void Main(string[] args)
        {
            int opcion;

            Console.WriteLine("MENÚ");
            Console.WriteLine("====");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Condicionales: if/else");
            Console.WriteLine("-------------");
            Console.WriteLine("");
            Console.WriteLine("1.- Resta absoluta de dos números enteros");
            Console.WriteLine("2.- Comprueba si un año es bisiesto o no");
            Console.WriteLine("3.- Conversor euros/pesetas");
            Console.WriteLine("4.- Comprueba si tres números enteros están ordenados");
            Console.WriteLine("5.- Comprueba si tres números enteros dados son consecutivos");
            Console.WriteLine("6.- Comprueba el número de cifras de un entero de 1-5 cifras.");
            Console.WriteLine("7.- Resuelve una ecuación de segundo grado");
            Console.WriteLine("8.- Ordena tres números enteros de mayor a menor");
            Console.WriteLine("");
            Console.WriteLine("Bucles: while");
            Console.WriteLine("------");
            Console.WriteLine("");
            Console.WriteLine("9.- Escribe los números del 10 al 20");
            Console.WriteLine("10.- Escribe los números impares del 1 al 10");
            Console.WriteLine("11.- Escribe los diez primeros pares");
            Console.WriteLine("12.- Escribe los números pares o impares del 1 al 10");
            Console.WriteLine("13.- Escribe la tabla de multiplicar de un número.");
            Console.WriteLine("14.- Escribe los números de un intervalo. (v 1.0)");
            Console.WriteLine("15.- Escribe los números de un intervalo. (v 2.0)");
            Console.WriteLine("16.- Escribe los impares de un intervalo.");
            Console.WriteLine("17.- Suma los números pares del 1 al 1000.");
            Console.WriteLine("18.- Media de una serie de números enteros positivos");
            Console.WriteLine("19.- Número de aprobados y suspensos");
            Console.WriteLine("20.- Máximo de diez números");
            Console.WriteLine("21.- Máximo, mínimo y media de diez números.");
            Console.WriteLine("22.- Factorial de un número entero positivo.");
            Console.WriteLine("");
            Console.WriteLine("Bucles: for");
            Console.WriteLine("------");
            Console.WriteLine("");
            Console.WriteLine("23.- Escribe los números del 10 al 20");
            Console.WriteLine("24.- Escribe los números impares del 1 al 10");
            Console.WriteLine("25.- Escribe los diez primeros pares");
            Console.WriteLine("26.- Escribe los números pares o impares del 1 al 10");
            Console.WriteLine("27.- Escribe la tabla de multiplicar de un número.");
            Console.WriteLine("28.- Escribe los números de un intervalo.");
            Console.WriteLine("29.- Escribe los impares de un intervalo.");
            Console.WriteLine("30.- Suma los números pares del 1 al 1000.");
            Console.WriteLine("31.- Número de aprobados y suspensos.");
            Console.WriteLine("32.- Máximo de diez números.");
            Console.WriteLine("33.- Máximo, mínimo y media de diez números.");
            Console.WriteLine("34.- Factorial de un número");
            Console.WriteLine("");
            Console.WriteLine("Más bucles");
            Console.WriteLine("------");
            Console.WriteLine("35.- Escribe una nota");
            Console.WriteLine("36.- Escribe los 10 primeros no múltiplos de 2 ni 3.");
            Console.WriteLine("37.- Escribe los múltiplos de 11, 17 o 23 entre 1 y 100.");
            Console.WriteLine("38.- Máximo común divisor de dos números.");
            Console.WriteLine("39.- Mínimo común múltiplo.");
            Console.WriteLine("40.- Comprueba si un número es primo.");
            Console.WriteLine("41.- Escribe los primos entre 2 y 1000.");
            Console.WriteLine("42.- Juego del número secreto");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("------");
            Console.WriteLine("");
            Console.WriteLine("");

            // A continuación se utiliza un switch para poder acceder a los ejercicios a través de un menú.

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    RestaAbsolutaDeDosNumerosEnteros();
                    break;
                case 2:
                    EsBisiestoONo();
                    break;
                case 3:
                    ConversorEurosPesetas();
                    break;
                case 4:
                    TresEnterosOrdenados();
                    break;
                case 5:
                    TresEnterosConsecutivos();
                    break;
                case 6:
                    CuantasCifrasTieneElEntero15();
                    break;
                case 7:
                    EcuacionSegundoGrado();
                    break;
                case 8:
                    OrdenaTresEnteros();
                    break;
                case 9:
                    Escribe10al20();
                    break;
                case 10:
                    EscribeImpares1al10();
                    break;
                case 11:
                    EscribeDiezPrimerosPares();
                    break;
                case 12:
                    ParesOImpares1al10();
                    break;
                case 13:
                    TablaDeMultiplicar();
                    break;
                case 14:
                    EscribeNumerosIntervalo();
                    break;
                case 15:
                    EscribeNumerosIntervaloPro();
                    break;
                case 16:
                    EscribeImparesIntervalo();
                    break;
                case 17:
                    SumaPares1a1000();
                    break;
                case 18:
                    Media();
                    break;
                case 19:
                    NumerodeAprobadosYSuspensos();
                    break;
                case 20:
                    Maximo10Numeros();
                    break;
                case 21:
                    MaximoMinimoMedia10Numeros();
                    break;
                case 22:
                    Factorial();
                    break;
                case 23:
                    Escribe10al20For();
                    break;
                case 24:
                    EscribeImpares1al10For();
                    break;
                case 25:
                    EscribeDiezPrimerosParesFor();
                    break;
                case 26:
                    ParesOImpares1al10For();
                    break;
                case 27:
                    TablaDeMultiplicarFor();
                    break;
                case 28:
                    EscribeNumerosIntervaloFor();
                    break;
                case 29:                  
                    EscribeImparesIntervaloFor();
                    break;
                case 30:
                    SumaPares1a1000For();
                    break;
                case 31:
                    NumerodeAprobadosYSuspensosFor();
                    break;
                case 32:
                    Maximo10NumerosFor();
                    break;
                case 33:
                    MaximoMinimoMedia10NumerosFor();
                    break;
                case 34:
                    FactorialFor();
                    break;
                case 35:
                    EscribeNota();
                    break;
                case 36:
                    NoMultiplos2ni3();
                    break;
                case 37:
                    Multiplos111723();
                    break;
                case 38:
                    MaximoComunDivisor();
                    break;
                case 39:
                    MinimoComunMultiplo();
                    break;
                case 40:
                    EsPrimo();
                    break;
                case 41:
                    PrimosEntre2y1000();
                    break;
                case 42:
                    NumeroSecreto();
                    break;
                default:
                    Console.WriteLine("Operación no disponible.");
                    break;
            }
                        
            Console.ReadKey(); // para que la consola no desaparezca nada más procesar los datos (y poder ver el resultado)
        }
    }
}
