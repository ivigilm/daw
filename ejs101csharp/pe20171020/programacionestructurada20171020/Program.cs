using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacionestructurada20171020 /* Más ejercicios iniciales. */
{
    class Program
    {
        /// <summary>
        /// Dice si un número es par o no.
        /// </summary>
        /// <param name="numero">Número que se introduce para saber si es par.</param>
        /// <returns>Es par / no es par.</returns>
        static bool Par(int numero) // Ejercicio 1 
        {
            bool par;

            if (numero % 2 == 0)
            {
                par = true;
            }
            else
            {
                par = false;
            }

            return par;
        }

        /// <summary>
        /// Determina si un año es bisiesto (múltiplo de 4).
        /// </summary>
        /// <param name="year">Año cuya cualidad de bisiesto se duda.</param>
        /// <returns>Valor de bisiesto del año: verdadero o falso.</returns>
        static bool Bisiesto(int year) // Ejercicio 2 
        {
            bool bisiesto;

            if (year % 4 == 0)
            {
                bisiesto = true;
            }
            else
            {
                bisiesto = false;
            }

            return bisiesto;

        }
        
        /// <summary>
        /// Imprime la tabla de multiplicar del número introducido por teclado.
        /// </summary>
        /// <param name="n">Número introducido por teclado del que queremos obtener la tabla de multiplicar.</param>
        static void TablaMultiplicar(int n) // Ejercicio 3 
        {
            int resultado, i;

            for (i = 1; i <= 10; i++)
            {
                resultado = i * n;
                Console.WriteLine(n + " x " + i + " = " + resultado);
            }

        }

        /// <summary>
        /// Imprime el intervalo de números enteros comprendido entre dos introducidos por teclado.
        /// </summary>
        /// <param name="a">Primer número introducido por teclado.</param>
        /// <param name="b">Segundo número introducido por teclado.</param>
        static void ImprimeSerie(int a, int b) // Ejercicio 4 
        {
            int menor, mayor, i;

            if (a >= b)
            {
                menor = b;
                mayor = a;
            }
            else
            {
                menor = a;
                mayor = b;
            }

            for (i = menor + 1; i < mayor; i++)
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Signo de un número
        /// </summary>
        /// <param name="n">Número introducido por parámetro.</param>
        /// <returns>Devuelve el signo (positivo, negativo o 0) del número introducido.</returns>
        static int Signo(int n) // Ejercicio 5 
        {
            int resultado;

            if (n == 0)
            {
                resultado = 0;
            }
            else
            {
                if (n < 0)
                {
                    resultado = -1;
                }
                else
                {
                    resultado = 1;
                }
            }

            return resultado;
        }
        
        /// <summary>
        /// Máximo de dos números
        /// </summary>
        /// <param name="a">Primer número introducido por parámetro.</param>
        /// <param name="b">Segundo número introducido por parámetro.</param>
        /// <returns>Devuelve el máximo de los dos números introducidos por parámetro.</returns>
        static int Max(int a, int b) // Ejercicio 6 
        {
            int maximo;
            if (a >= b)
            {
                maximo = a;
            }
            else
            {
                maximo = b;
            }

            return maximo;
        }

        /// <summary>
        /// Mínimo de dos números.
        /// </summary>
        /// <param name="a">Uno de los números dados.</param>
        /// <param name="b">Uno de los números dados.</param>
        /// <returns>Devuelve el valor mínimo de dos números dados.</returns>
        static int Min(int a, int b) // Ejercicio 7 
        {
            int minimo;
            if (a <= b)
            {
                minimo = a;
            }
            else
            {
                minimo = b;
            }

            return minimo;
        }

        /// <summary>
        /// Máximo común divisor de dos números.
        /// </summary>
        /// <param name="a">Uno de los dos números dados.</param>
        /// <param name="b">Uno de los dos números dados.</param>
        /// <returns>Devuelve el máximo común divisor de dos números dados.</returns>
        static int Mcd(int a, int b) // Ejercicio 8 
        {
            int menor, i;

            if (a >= b)
            {
                menor = b;
            }
            else
            {
                menor = a;
            }

            i = menor;

            while ((a % i != 0) || (b % i != 0))
            {

                i = i - 1;

            }

            return i;
        }

        /// <summary>
        /// Mínimo común múltiplo
        /// </summary>
        /// <param name="a">Primer parámetro introducido.</param>
        /// <param name="b">Segundo parámetro introducido.</param>
        /// <returns>Devuelve el mínimo común múltiplo de los dos parámetros introducidos.</returns>
        static int Mcm(int a, int b) // Ejercicio 9 
        {
            int mayor, i;

            if (a >= b)
            {
                mayor = a;
            }
            else
            {
                mayor = b;
            }

            i = mayor;

            while ((i % a != 0) || (i % b != 0))
            {
                i = i + 1;
            }

            return i;
        }

        /// <summary>
        /// Calcula si un número introducido por parámetro es primo.
        /// </summary>
        /// <param name="numero">Número introducido por parámetro.</param>
        /// <returns>Devuelve "true" si el número es primo o "false" si no lo es.</returns>
        static bool Primo(int numero) // Ejercicio 10 
        {
            int i, contador;
            bool resultado;

            i = numero - 1;
            contador = 0;

            while (i > 1)
            {
                if (numero % i == 0)
                {
                    contador = contador + 1;
                }

                i--;
            }

            if (contador == 0)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            return resultado;

        }

        /// <summary>
        /// Área de un triángulo.
        /// </summary>
        /// <param name="b">Valor de la base del triángulo introducido por parámetro.</param>
        /// <param name="h">Valor de la altura del triángulo introducida por parámetro.</param>
        /// <returns>Devuelve el área del triángulo.</returns>
        static double AreaTriangulo(int b, int h) // Ejercicio 11 
        {
            double resultado;
            double producto = b * h;

            resultado = producto / 2;

            return resultado;
        }

        /// <summary>
        /// Convierte pulgadas a centímetros.
        /// </summary>
        /// <param name="n">Valor en pulgadas introducido por teclado para convertir.</param>
        /// <returns>Valor en centímetros de la medida introducida por teclado en pulgadas.</returns>
        static double PulgadasACm(double n) // Ejercicio 12 
        {
            double resultado;

            resultado = n * 2.54;

            return resultado;
        }

        /// <summary>
        /// Convierte centímetros a pulgadas.
        /// </summary>
        /// <param name="n">Valor en centímetros introducido por teclado para convertir.</param>
        /// <returns>Valor en pulgadas de la medida introducida por teclado en centímetros.</returns>
        static double CmAPulgadas(double n) // Ejercicio 12 
        {
            double resultado;

            resultado = n / 2.54;

            return resultado;
        }

        /// <summary>
        /// Pasa la nota numérica de un alumno a su valor correspondiente en una escala de notas.
        /// </summary>
        /// <param name="n">Nota del alumno introducida por teclado.</param>
        /// <returns>Valor en formato texto de la nota (suspenso, suficiente, bien, notable o sobresaliente)</returns>
        static string NotaEnTexto(double n) // Ejercicio 13 
        {
            string nota;

            if (n < 5)
            {
                nota = "suspenso";
            }
            else
            {
                if (n < 6)
                {
                    nota = "suficiente";
                }
                else
                {
                    if (n < 7)
                    {
                        nota = "bien";
                    }
                    else
                    {
                        if (n < 9)
                        {
                            nota = "notable";
                        }
                        else
                        {
                            nota = "sobresaliente";
                        }
                    }
                }
            }

            return nota;
        }

        /// <summary>
        /// Lee un número natural introducido por consola.
        /// </summary>
        static void LeeNatural() // Ejercicio 14 
        {
            int numero;
            numero = 0;

            while (numero <= 0)
            {
                Console.WriteLine("Dime un número natural, por favor.");
                numero = int.Parse(Console.ReadLine());
            }

        }

        /// <summary>
        /// Pide un número comprendido entre un intervalo hasta que se le dé una respuesta correcta.
        /// </summary>
        /// <param name="a">Primer número introducido por teclado para definir el intervalo.</param>
        /// <param name="b">Segundo número introducido por teclado para definir el intervalo.</param>
        static void LeeNumero(double a, double b) // Ejercicio 15
        {
            double valor, menor, mayor;

            if (a <= b)
            {
                menor = a;
                mayor = b;
            }
            else
            {
                menor = b;
                mayor = a;
            }

            valor = menor - 1;

            while ((valor < menor) || (valor > mayor))
            {
                Console.WriteLine("Dime un número comprendido entre " + a + " y " + b + " (ambos incluidos).");
                valor = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("¡Gracias!");


        }

        /// <summary>
        /// Potencia de un número elevado a un exponente.
        /// </summary>
        /// <param name="a">Base del número cuya potencia calculamos.</param>
        /// <param name="b">Exponente del número cuya potencia estamos calculando.</param>
        /// <returns>Potencia de "a" elevado a "b".</returns>
        static int Elevado(int a, int b) // Ejercicio 16 
        {
            int resultado, i;


            if (b == 0)
            {
                resultado = 1;
            }
            else
            {
                if (b == 1)
                {
                    resultado = a;
                }
                else
                {
                    resultado = a * a;
                    i = 2;

                    while (i < b)
                    {
                        resultado = resultado * a;
                        i = i + 1;
                    }
                }
            }



            return resultado;
        }

        /// <summary>
        /// Factorial de un número introducido por teclado.
        /// </summary>
        /// <param name="n">Número introducido por teclado.</param>
        /// <returns>Factorial de "n".</returns>
        static int Factorial(int n) // Ejercicio 17 
        {
            int factorial, i;

            factorial = n;

            for (i = n - 1; i > 0; i--)
            {
                factorial = factorial * i;
            }

            return factorial;
        }

        static void Main(string[] args)
        {
            int opcion;

            Console.WriteLine();
            Console.WriteLine("MENÚ");
            Console.WriteLine("====");
            Console.WriteLine();
            Console.WriteLine("1.- ¿Es par o no?");
            Console.WriteLine("2.- ¿Es bisiesto?");
            Console.WriteLine("3.- Tabla de multiplicar");
            Console.WriteLine("4.- Imprime intervalo");
            Console.WriteLine("5.- Signo de un número");
            Console.WriteLine("6.- Máximo de dos números");
            Console.WriteLine("7.- Mínimo de dos números");
            Console.WriteLine("8.- Máximo común divisor");
            Console.WriteLine("9.- Mínimo común múltiplo");
            Console.WriteLine("10.- ¿Primo?");
            Console.WriteLine("11.- Área de un triángulo");
            Console.WriteLine("12.- Conversor cm/in");
            Console.WriteLine("13.- Nota en formato texto");
            Console.WriteLine("14.- Lee un número");
            Console.WriteLine("15.- Lee número de intervalo");
            Console.WriteLine("16.- Potencia");
            Console.WriteLine("17.- Factorial");
            Console.WriteLine();
            Console.WriteLine();

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    {
                        int n;

                        Console.WriteLine("Dime un número");
                        n = int.Parse(Console.ReadLine());

                        Console.WriteLine("¿Es " + n + " par?");

                        if (Par(n) == true)
                        {
                            Console.WriteLine("Sí");
                        }
                        else
                        {
                            Console.WriteLine("No");
                        }
                    }
                    break;
                case 2:
                    {
                        int anio;

                        Console.WriteLine("¿Qué año eliges?");
                        anio = int.Parse(Console.ReadLine());

                        if (Bisiesto(anio) == true)
                        {
                            Console.WriteLine("¡Es bisiesto!");
                        }
                        else
                        {
                            Console.WriteLine("¡No es bisiesto!");
                        }

                    }
                    break;
                case 3:
                    {
                        int a;

                        a = 9;

                        Console.WriteLine("Tabla de multiplicar del " + a + ":");
                        Console.WriteLine();

                        TablaMultiplicar(a);

                        Console.ReadKey();
                    }
                    break;
                case 4:
                    {
                        int n1, n2;

                        Console.WriteLine("Dame dos números.");
                        n1 = int.Parse(Console.ReadLine());
                        n2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("El intervalo de números enteros entre " + n1 + " y " + n2 + " en sentido ascendente es:");

                        ImprimeSerie(n1, n2);
                    }
                    break;
                case 5:
                    {
                        int numero;

                        Console.WriteLine("Dime un número entero");
                        numero = int.Parse(Console.ReadLine());

                        Console.WriteLine("El signo de tu número es: ");

                        if (Signo(numero) == 1)
                        {
                            Console.WriteLine("positivo");
                        }
                        else
                        {
                            if (Signo(numero) == -1)
                            {
                                Console.WriteLine("negativo");
                            }
                            else
                            {
                                Console.WriteLine("Tu número es el 0. No tiene signo.");
                            }

                        }
                    }
                    break;
                case 6:
                    {
                        int n1, n2, resultado;
                        Console.WriteLine("Dame dos números.");
                        n1 = int.Parse(Console.ReadLine());
                        n2 = int.Parse(Console.ReadLine());

                        resultado = Max(n1, n2);

                        Console.WriteLine("El máximo de los números que me has dado es " + resultado + ".");

                    }
                    break;
                case 7:
                    {
                        int n1, n2, resultado;
                        Console.WriteLine("Dame dos números.");
                        n1 = int.Parse(Console.ReadLine());
                        n2 = int.Parse(Console.ReadLine());

                        resultado = Min(n1, n2);

                        Console.WriteLine("El minimo de los números que me has dado es " + resultado + ".");

                    }
                    break;
                case 8:
                    {
                        int n1, n2, resultado;

                        Console.WriteLine("Dime dos números.");
                        n1 = int.Parse(Console.ReadLine());
                        n2 = int.Parse(Console.ReadLine());

                        resultado = Mcd(n1, n2);

                        Console.WriteLine("El máximo común divisor de estos números es " + resultado + ".");

                    }
                    break;
                case 9:
                    {
                        int num1, num2, resultado;

                        Console.WriteLine("Dame dos números.");
                        num1 = int.Parse(Console.ReadLine());
                        num2 = int.Parse(Console.ReadLine());

                        resultado = Mcm(num1, num2);


                        Console.WriteLine("El MCM es " + resultado + ".");

                    }
                    break;
                case 10:
                    {
                        int n;

                        Console.WriteLine("Dime un número.");
                        n = int.Parse(Console.ReadLine());

                        if (Primo(n) == true)
                        {
                            Console.WriteLine("Tu número es primo.");
                        }
                        else
                        {
                            Console.WriteLine("Tu número no es primo.");
                        }
                    }
                    break;
                case 11:
                    {
                        int b, h;
                        double area;

                        Console.WriteLine("Dame los valores de base y altura (en este orden) del triángulo.");
                        b = int.Parse(Console.ReadLine());
                        h = int.Parse(Console.ReadLine());

                        area = AreaTriangulo(b, h);

                        Console.WriteLine("El área del triángulo es: " + area);

                    }
                    break;
                case 12: {
                        double numero, resultado;
                        string unidad;

                        Console.WriteLine("¿Qué valor quieres convertir? (Dime la cifra.)");
                        numero = double.Parse(Console.ReadLine());

                        Console.WriteLine("¿A qué lo quieres convertir? (cm/pulgadas)");
                        unidad = Console.ReadLine();

                        if (unidad == "cm")
                        {
                            resultado = PulgadasACm(numero);
                            Console.WriteLine("Tu resultado:");
                            Console.WriteLine(numero + " pulgadas " + "= " + resultado + " " + unidad);
                        }
                        else
                        {
                            resultado = CmAPulgadas(numero);
                            Console.WriteLine("Tu resultado:");
                            Console.WriteLine(numero + " cm " + "= " + resultado + " " + unidad);
                        }
                    }
                    break;
                case 13: {
                        double nota;

                        Console.WriteLine("Dime la nota del alumno.");
                        nota = double.Parse(Console.ReadLine());

                        Console.WriteLine("Este alumno tiene un: " + NotaEnTexto(nota) + ".");
                    }
                    break;
                case 14: {
                        LeeNatural();

                        Console.WriteLine("¡Gracias!");
                    }
                    break;
                case 15: {
                        double n1, n2;

                        Console.WriteLine("Dime dos números.");
                        n1 = double.Parse(Console.ReadLine());
                        n2 = double.Parse(Console.ReadLine());

                        LeeNumero(n1, n2);
                    }
                    break;
                case 16: {
                        int a, b, potencia;

                        Console.WriteLine("Dime un número y el valor al que lo quieres elevar.");
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());

                        potencia = Elevado(a, b);

                        Console.WriteLine(a + " elevado a " + b + " es " + potencia + ".");
                    }
                    break;
                case 17:
                    {
                        int n, factorial;

                        Console.WriteLine("Dime un número.");
                        n = int.Parse(Console.ReadLine());

                        factorial = Factorial(n);

                        Console.WriteLine("El factorial de tu número es " + factorial + ".");

                    }
                    break;
                default:
                    {
                        Console.WriteLine("No existe el ejercicio.");
                    }
                    break;
            }




            Console.ReadKey();
        }
    }
}
