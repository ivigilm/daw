using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fracciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            opcion = -1;

            Console.WriteLine("MENÚ");
            Console.WriteLine("====");
            Console.WriteLine();
            Console.WriteLine("1.- Crea una fracción a partir del numerador y denominador");
            Console.WriteLine("2.- Crea una fracción a partir de su valor (un número entero)");
            Console.WriteLine("3.- Crea una fracción a partir de su valor (un número real)");
            Console.WriteLine("4.- Simplifica una fracción");
            Console.WriteLine("5.- Obtener el cociente de la división numerador/denominador");
            Console.WriteLine("6.- Consultar/modificar el numerador de una fracción");
            Console.WriteLine("7.- Consultar/modificar el denominador de una fracción");
            Console.WriteLine("8.- Suma de dos fracciones");
            Console.WriteLine("9.- Resta de dos fracciones");
            Console.WriteLine("10.- Producto de dos fracciones");
            Console.WriteLine("11.- División de dos fracciones");
            Console.WriteLine("12.- Comprueba si una fracción es menor que otra");
            Console.WriteLine("13.- Comprueba si una fracción es mayor que otra");
            Console.WriteLine("14.- Comprueba si dos fracciones son iguales");
            Console.WriteLine("15.- Comprueba si una fracción es mayor o igual que otra");
            Console.WriteLine("16.- Comprueba si una fracción es menor o igual que otra");
            Console.WriteLine("17.- Comprueba si una fracción es distinta de otra");
            Console.WriteLine("18.- Suma una fracción y un número entero");
            Console.WriteLine();

            while (opcion != 0) // evita que el programa se cierre tras acabar de ejecutar un ejercicio
            {
                Console.WriteLine();
                Console.WriteLine("Elige una opción. (0 para salir)");
                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        {
                            int n, d; // creo dos nuevas variables de enteros
                            Fraccion c; // creo un nuevo objeto de la clase Fraccion

                            Console.WriteLine("¡Vamos a crear una fracción!");
                            Console.WriteLine("¿Cuál es el numerador?");
                            n = int.Parse(Console.ReadLine()); // guardo el numerador en una variable
                            Console.WriteLine("¿Cuál es el denominador?");
                            d = int.Parse(Console.ReadLine()); // guardo el denominador en una variable

                            c = new Fraccion(n, d); // inicializo mi objeto "c" con estos valores (mi fracción "c" será igual a 1/4)
                                                    // utilizando el constructor de la clase Fraccion: public Fraccion(int numerador, int denominador)

                            Console.WriteLine("¡Fracción creada! Aquí la tienes: " + c.ToString()); // muestro por pantalla la fracción recién creada
                        }
                        break;
                    case 2:
                        {
                            int v;
                            Fraccion c;

                            Console.WriteLine("¿Cuál es el valor de la fracción? (debe ser un número entero)");
                            v = int.Parse(Console.ReadLine());

                            c = new Fraccion(v); // inicializo mi objeto "c" con este valor (mi fracción "c" será igual a 1/4)
                                                 // utilizando el constructor de la clase Fraccion: public Fraccion(int cociente)
                            Console.WriteLine("¡Fracción creada! Aquí la tienes: " + c.ToString());
                        }
                        break;
                    case 3:
                        { // 3,45
                            double v;
                            Fraccion c;

                            Console.WriteLine("¿Cuál es el valor de la fracción? (pon los decimales con ',' por favor)");
                            v = double.Parse(Console.ReadLine());

                            c = new Fraccion(v); // inicializo mi objeto "c" con este valor (mi fracción "c" será igual a 1/4)
                                                 // utilizando el constructor de la clase Fraccion: public Fraccion(int cociente)
                            Console.WriteLine("¡Fracción creada! Aquí la tienes: " + c.ToString());
                        }
                        break;
                    case 4:
                        {
                            int n, d;
                            Fraccion c;                            
                            Console.WriteLine("Dame el numerador y el denominador de la fracción que quieres simplificar, por favor.");
                            n = int.Parse(Console.ReadLine());
                            d = int.Parse(Console.ReadLine());
                            c = new Fraccion(n, d);

                            c.Simplificar();
                            Console.WriteLine("¡Fracción simplificada! Aquí la tienes: " + c.ToString());
                        }
                        break;
                    case 5:
                        {
                            int n, d;
                            Fraccion c;
                            Console.WriteLine("Dame el numerador y el denominador de la fracción que quieres dividir, por favor.");
                            n = int.Parse(Console.ReadLine());
                            d = int.Parse(Console.ReadLine());
                            c = new Fraccion(n, d);

                            Console.WriteLine("Valor de la fracción: " + c.ValorDouble);
                        }
                        break;
                    case 6:
                        {
                            int n, d, nuevovalor;
                            Fraccion c;
                            Console.WriteLine("Dame el numerador y el denominador de la fracción original, por favor.");
                            n = int.Parse(Console.ReadLine());
                            d = int.Parse(Console.ReadLine());
                            c = new Fraccion(n, d);

                            Console.WriteLine("El numerador de esta fracción es: " + c.Numerador);
                            Console.WriteLine("Dime el nuevo valor que quieres utilizar como numerador.");
                            nuevovalor = int.Parse(Console.ReadLine());
                            c.Numerador = nuevovalor;
                            Console.WriteLine("La nueva fracción es: " + c.ToString());
                        }
                        break;
                    case 7:
                        {
                            int n, d, nuevovalor;
                            Fraccion c;
                            Console.WriteLine("Dame el numerador y el denominador de la fracción original, por favor.");
                            n = int.Parse(Console.ReadLine());
                            d = int.Parse(Console.ReadLine());
                            c = new Fraccion(n, d);

                            Console.WriteLine("El denominador de esta fracción es: " + c.Denominador);
                            Console.WriteLine("Dime el nuevo valor que quieres utilizar como denominador.");
                            nuevovalor = int.Parse(Console.ReadLine());
                            c.Denominador = nuevovalor;
                            Console.WriteLine("La nueva fracción es: " + c.ToString());
                        }
                        break;
                    case 8:
                        {
                            int n1, n2, d1, d2;
                            Fraccion f1, f2, fsuma;

                            Console.WriteLine("Dame, en este orden, numerador y denominador de la primera fracción y numerador y denominador de la segunda.");
                            n1 = int.Parse(Console.ReadLine());
                            d1 = int.Parse(Console.ReadLine());
                            n2 = int.Parse(Console.ReadLine());
                            d2 = int.Parse(Console.ReadLine());

                            f1 = new Fraccion(n1, d1);
                            f2 = new Fraccion(n2, d2);

                            fsuma = f1 + f2;

                            Console.WriteLine(f1.ToString() + " + " + f2.ToString() + " = " + fsuma.ToString());
                        }
                        break;
                    case 9:
                        {
                            int n1, n2, d1, d2;
                            Fraccion f1, f2, fresta;

                            Console.WriteLine("Dame, en este orden, numerador y denominador de la primera fracción y numerador y denominador de la segunda.");
                            n1 = int.Parse(Console.ReadLine());
                            d1 = int.Parse(Console.ReadLine());
                            n2 = int.Parse(Console.ReadLine());
                            d2 = int.Parse(Console.ReadLine());

                            f1 = new Fraccion(n1, d1);
                            f2 = new Fraccion(n2, d2);

                            fresta = f1 - f2;

                            Console.WriteLine(f1.ToString() + " - " + f2.ToString() + " = " + fresta.ToString());
                        }
                        break;
                    case 10:
                        {
                            int n1, n2, d1, d2;
                            Fraccion f1, f2, fproducto;

                            Console.WriteLine("Dame, en este orden, numerador y denominador de la primera fracción y numerador y denominador de la segunda.");
                            n1 = int.Parse(Console.ReadLine());
                            d1 = int.Parse(Console.ReadLine());
                            n2 = int.Parse(Console.ReadLine());
                            d2 = int.Parse(Console.ReadLine());

                            f1 = new Fraccion(n1, d1);
                            f2 = new Fraccion(n2, d2);

                            fproducto = f1 * f2;

                            Console.WriteLine(f1.ToString() + " * " + f2.ToString() + " = " + fproducto.ToString());
                        }
                        break;
                    case 11:
                        {
                            int n1, n2, d1, d2;
                            Fraccion f1, f2, fdivision;

                            Console.WriteLine("Dame, en este orden, numerador y denominador de la primera fracción y numerador y denominador de la segunda.");
                            n1 = int.Parse(Console.ReadLine());
                            d1 = int.Parse(Console.ReadLine());
                            n2 = int.Parse(Console.ReadLine());
                            d2 = int.Parse(Console.ReadLine());

                            f1 = new Fraccion(n1, d1);
                            f2 = new Fraccion(n2, d2);

                            fdivision = f1 / f2;

                            Console.WriteLine(f1.ToString() + " / " + f2.ToString() + " = " + fdivision.ToString());
                        }
                        break;
                    case 12:
                        {
                            int n1, n2, d1, d2;
                            Fraccion f1, f2;
                            bool esmenorono;

                            Console.WriteLine("Dame, en este orden, numerador y denominador de la primera fracción y numerador y denominador de la segunda.");
                            n1 = int.Parse(Console.ReadLine());
                            d1 = int.Parse(Console.ReadLine());
                            n2 = int.Parse(Console.ReadLine());
                            d2 = int.Parse(Console.ReadLine());

                            f1 = new Fraccion(n1, d1);
                            f2 = new Fraccion(n2, d2);

                            esmenorono = f1 < f2;

                            if (esmenorono)
                            {
                                Console.WriteLine("La fracción " + f1.ToString() + " es menor que la fracción " + f2.ToString() + ".");
                            }
                            else
                            {
                                Console.WriteLine("La fracción " + f1.ToString() + " NO es menor que la fracción " + f2.ToString() + ".");
                            }
                        }
                        break;
                    case 13:
                        {
                            int n1, n2, d1, d2;
                            Fraccion f1, f2;
                            bool esmayorono;

                            Console.WriteLine("Dame, en este orden, numerador y denominador de la primera fracción y numerador y denominador de la segunda.");
                            n1 = int.Parse(Console.ReadLine());
                            d1 = int.Parse(Console.ReadLine());
                            n2 = int.Parse(Console.ReadLine());
                            d2 = int.Parse(Console.ReadLine());

                            f1 = new Fraccion(n1, d1);
                            f2 = new Fraccion(n2, d2);

                            esmayorono = f1 > f2;

                            if (esmayorono)
                            {
                                Console.WriteLine("La fracción " + f1.ToString() + " es mayor que la fracción " + f2.ToString() + ".");
                            }
                            else
                            {
                                Console.WriteLine("La fracción " + f1.ToString() + " NO es mayor que la fracción " + f2.ToString() + ".");
                            }
                        }
                        break;
                    case 14:
                        {
                            int n1, n2, d1, d2;
                            Fraccion f1, f2;
                            bool esigualono;

                            Console.WriteLine("Dame, en este orden, numerador y denominador de la primera fracción y numerador y denominador de la segunda.");
                            n1 = int.Parse(Console.ReadLine());
                            d1 = int.Parse(Console.ReadLine());
                            n2 = int.Parse(Console.ReadLine());
                            d2 = int.Parse(Console.ReadLine());

                            f1 = new Fraccion(n1, d1);
                            f2 = new Fraccion(n2, d2);

                            esigualono = f1 == f2;

                            if (esigualono)
                            {
                                Console.WriteLine("Las fracciones " + f1.ToString() + " y " + f2.ToString() + " son iguales.");
                            }
                            else
                            {
                                Console.WriteLine("Las fracciones " + f1.ToString() + " y " + f2.ToString() + " NO son iguales.");
                            }
                        }
                        break;
                    case 15:
                        {
                            int n1, n2, d1, d2;
                            Fraccion f1, f2;
                            bool mayoroigual;

                            Console.WriteLine("Dame, en este orden, numerador y denominador de la primera fracción y numerador y denominador de la segunda.");
                            n1 = int.Parse(Console.ReadLine());
                            d1 = int.Parse(Console.ReadLine());
                            n2 = int.Parse(Console.ReadLine());
                            d2 = int.Parse(Console.ReadLine());

                            f1 = new Fraccion(n1, d1);
                            f2 = new Fraccion(n2, d2);

                            mayoroigual = f1 >= f2;

                            if (mayoroigual)
                            {
                                Console.WriteLine("La fracción " + f1.ToString() + " es mayor o igual que la fracción " + f2.ToString() + ".");
                            }
                            else
                            {
                                Console.WriteLine("La fracción " + f1.ToString() + "no es mayor o igual que la fracción " + f2.ToString() + ".");
                            }
                        }
                        break;
                    case 16:
                        {
                            int n1, n2, d1, d2;
                            Fraccion f1, f2;
                            bool menoroigual;

                            Console.WriteLine("Dame, en este orden, numerador y denominador de la primera fracción y numerador y denominador de la segunda.");
                            n1 = int.Parse(Console.ReadLine());
                            d1 = int.Parse(Console.ReadLine());
                            n2 = int.Parse(Console.ReadLine());
                            d2 = int.Parse(Console.ReadLine());

                            f1 = new Fraccion(n1, d1);
                            f2 = new Fraccion(n2, d2);

                            menoroigual = f1 <= f2;

                            if (menoroigual)
                            {
                                Console.WriteLine("La fracción " + f1.ToString() + " es menor o igual que la fracción " + f2.ToString() + ".");
                            }
                            else
                            {
                                Console.WriteLine("La fracción " + f1.ToString() + "no es menor o igual que la fracción " + f2.ToString() + ".");
                            }
                        }
                        break;
                    case 17:
                        {
                            int n1, n2, d1, d2;
                            Fraccion f1, f2;
                            bool esdistinta;

                            Console.WriteLine("Dame, en este orden, numerador y denominador de la primera fracción y numerador y denominador de la segunda.");
                            n1 = int.Parse(Console.ReadLine());
                            d1 = int.Parse(Console.ReadLine());
                            n2 = int.Parse(Console.ReadLine());
                            d2 = int.Parse(Console.ReadLine());

                            f1 = new Fraccion(n1, d1);
                            f2 = new Fraccion(n2, d2);

                            esdistinta = f1 != f2;

                            if (esdistinta)
                            {
                                Console.WriteLine("Las fracciones " + f1.ToString() + " y " + f2.ToString() + " NO son iguales.");
                            }
                            else
                            {
                                Console.WriteLine("Las fracciones " + f1.ToString() + " y " + f2.ToString() + " son iguales.");
                            }
                        }
                        break;
                    case 18:
                        {
                            int n1, d1, entero1;
                            Fraccion f1, fsuma;

                            Console.WriteLine("Dame, en este orden, numerador y denominador de la fracción y el número entero que le quieres sumar.");
                            n1 = int.Parse(Console.ReadLine());
                            d1 = int.Parse(Console.ReadLine());
                            entero1 = int.Parse(Console.ReadLine());

                            f1 = new Fraccion(n1, d1);

                            fsuma = f1 + entero1;

                            Console.WriteLine(f1.ToString() + " + " + entero1.ToString() + " = " + fsuma.ToString());
                        }
                        break;
                    default:
                        Console.WriteLine("Este ejercicio no existe.");
                        break;
                }
                
            }


            Console.ReadKey();

        }
    }
}
