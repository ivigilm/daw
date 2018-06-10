using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysmultidimensionales
{
    class Program // Ejercicios de arrays multidimensionales
    {
        /// <summary>
        /// Escribe por pantalla un array de 3x3.
        /// </summary>
        /// <param name="array">Array introducido por parámetro.</param>
        static void Array3x3(int[,] array) // Ejercicio 1
        {
            int i, j;
            for(i = 0; i < 3; i++) // recorro las filas
            {
                Console.Write("(  ");

                for(j = 0; j < 2; j++) // recorro cada elemento de una fila
                {
                    Console.Write(array[i, j] + "  ");
                }

                Console.WriteLine(array[i, 2] + "  )");
            }
        }

        /// <summary>
        /// Rellena un array de 3x3 con números del 1 al 9.
        /// </summary>
        /// <param name="array">Array vacío introducido por parámetro.</param>
        static void Rellena3x3(int[,] array) // Ejercicio 2
        {
            int i, j, valor;
            valor = 1;

            for (i = 0; i < 3; i++)
            {
                for(j = 0; j < 3; j++)
                {
                    array[i, j] = valor;
                    valor = valor + 1;
                }
            }            
        }

        /// <summary>
        /// Rellena un array de 3x3 con números aleatorios del 1 al 100.
        /// </summary>
        /// <param name="array">Array vacío introducido por parámetro.</param>
        static void RellenaAleatorio3x3(int[,] array) // Ejercicio 3
        {
            int i, j, valor;
            valor = 1;
            Random r = new Random();

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    valor = r.Next(1, 101);
                    array[i, j] = valor;
                }
            }
        }

        /// <summary>
        /// Suma los elementos de un array.
        /// </summary>
        /// <param name="array">Array de 3x3 introducido por parámetro.</param>
        /// <returns>Número entero que es el resultado de sumar todos los elementos del array.</returns>
        static int SumaArray3x3(int[,] array) // Ejercicio 4
        {
            int i, j, suma;
            suma = 0;

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    suma = suma + array[i, j];   
                }
            }

            return suma;
        }

        /// <summary>
        /// Escribe un array bidimensional por pantalla.
        /// </summary>
        /// <param name="array">Array introducido por parámetro.</param>
        static void EscribeArrayBi(int[,] array) // Ejercicio 5
        {
            int i, j;
            for (i = 0; i < array.GetLength(0); i++) // recorro las filas
            {
                Console.Write("(");

                for (j = 0; j < array.GetLength(1); j++) // recorro cada elemento de una fila
                {
                    Console.Write(array[i, j].ToString().PadLeft(3)); // pad para alinear bien los números de 1 y 2 cifras
                }

                Console.WriteLine(" )");
            }
        }

        /// <summary>
        /// Rellena con números aleatorios del 1 al 100 un array bidimensional.
        /// </summary>
        /// <param name="array">Array vacío introducido por parámetro.</param>
        static void RellenaAleatorioBi(int[,] array) // Ejercicio 6
        {
            int i, j, valor;
            valor = 1;
            Random r = new Random();

            for (i = 0; i < array.GetLength(0); i++)
            {
                for (j = 0; j < array.GetLength(1); j++)
                {
                    valor = r.Next(1, 101);
                    array[i, j] = valor;
                }
            }
        }

        /// <summary>
        /// Rellena un array con valores enteros ascendentes, empezando por el 1.
        /// </summary>
        /// <param name="array">Array vacío introducido por parámetro.</param>
        static void RellenaEnOrdenBi(int[,] array) // Ejercicio 7
        {
            int i, j, valor;
            valor = 1;

            for (i = 0; i < array.GetLength(0); i++)
            {
                for (j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = valor;
                    valor = valor + 1;
                }
            }
        }

        /// <summary>
        /// Suma los elementos de un array de enteros.
        /// </summary>
        /// <param name="array">Array introducido por parámetro.</param>
        /// <returns>Número entero, resultado de la suma.</returns>
        static int SumaArrayBi(int[,] array) // Ejercicio 8
        {
            int i, j, suma;
            suma = 0;

            for(i = 0; i < array.GetLength(0); i++)
            {
                for (j = 0; j < array.GetLength(1); j++)
                {
                    suma = suma + array[i, j];
                }
            }

            return suma;
        }

        /// <summary>
        /// Suma los elementos de dos arrays de enteros en un tercero.
        /// </summary>
        /// <param name="array1">Primer array con datos inroducido por parámetro.</param>
        /// <param name="array2">Segundo array con datos introducido por parámetro.</param>
        /// <param name="resultado">Array donde se guardará el resultado de la suma, introducido por parámetro.</param>
        static void Suma2ArraysBi (int[,]array1, int[,]array2, int[,] resultado) // Ejercicio 9
        {
            int i, j;

            for(i = 0; i < array1.GetLength(0); i++)
            {
                for(j = 0; j < array2.GetLength(1); j++)
                {
                    resultado[i, j] = array1[i, j] + array2[i, j];
                }
            }
        }

        /// <summary>
        /// Copia un array bidimensional de enteros en otro.
        /// </summary>
        /// <param name="original">Array original introducido por parámetro.</param>
        /// <param name="copia">Array vacío donde se copiará el primero, introducido por parámetro.</param>
        static void CopiaArrayBi(int[,]original, int[,] copia) // Ejercicio 10
        {
            int i, j;

            for (i = 0; i < original.GetLength(0); i++)
            {
                for(j = 0; j < original.GetLength(1); j++)
                {
                    copia[i, j] = original[i, j];
                }
            }
        }

        /// <summary>
        /// Crea una copia de un array bidimensional.
        /// </summary>
        /// <param name="original">Array original introducido por parámetro.</param>
        /// <returns>Array copia.</returns>
        static int[,] CopiaArrayBiPro(int[,] original) // Ejercicio 11
        {
            int i, j;
            int[,] copia;
            copia = new int[original.GetLength(0), original.GetLength(1)];

            for (i = 0; i < original.GetLength(0); i++)
            {
                for (j = 0; j < original.GetLength(1); j++)
                {
                    copia[i, j] = original[i, j];
                }
            }

            return copia;
        }

        /// <summary>
        /// Crea y rellena un array de 8x8 , dibujando un tablero de ajedrez.
        /// </summary>
        /// <returns>Array de 8x8 con casillas de 1s (blancas) y 0s (casillas negras) alternos.</returns>
        static int[,] RellenaArrayAjedrez() // Ejercicio 12
        {
            int i, j;
            int[,] vacio;
            vacio = new int[8, 8];

            for (i = 0; i < vacio.GetLength(0); i++)
            {
                for(j = 0; j < vacio.GetLength(1); j++)
                {
                    if( ( (i % 2 == 0) && (j % 2 == 0) ) || ( (i % 2 != 0) && (j % 2 != 0) ) ) // casillas negras
                    {
                        vacio[i, j] = 1;
                    }
                    else // casillas blancas
                    {
                        vacio[i, j] = 0;
                    }
                }
            }

            return vacio;

        }

        /// <summary>
        /// Rellena un array cuadrado con los siguientes valores: 1 en la diagonal, 2 por encima y 3 por debajo.
        /// </summary>
        /// <param name="cuadrado">Array vacío introducido por parámetro.</param>
        static void RellenaDiagonal(int[,]cuadrado) // Ejercicio 13
        {
            int i, j;

            for(i = 0; i < cuadrado.GetLength(0); i++)
            {
                for (j = 0; j < cuadrado.GetLength(1); j++)
                {
                    if (i == j) // diagonal = 1
                    {
                        cuadrado[i, j] = 1;
                    }
                    else
                    {
                        if (j > i) // 2 por encima
                        {
                            cuadrado[i, j] = 2;
                        }
                        else // 3 por debajo (j < i)
                        {
                            cuadrado[i, j] = 3;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Rellena un array cuadrado con 1s en las diagonales y 2s en el resto de posiciones.
        /// </summary>
        /// <param name="cuadrado">Array cuadrado vacío introducido por parámetro.</param>
        static void RellenaX(int[,] cuadrado) // Ejercicio 14
        {
            int i, j;

            for (i = 0; i < cuadrado.GetLength(0); i++)
            {
                for (j = 0; j < cuadrado.GetLength(1); j++)
                {
                    if ( (i == j) || (i + j == 4) ) // diagonales = 1
                    {
                        cuadrado[i, j] = 1;
                    }
                    else // demás = 2
                    {
                        cuadrado[i, j] = 2;
                    }
                }
            }
        }

        /// <summary>
        /// Rellena un array con 1, 2, 3, 4 dependiendo del cuadrante (se divide el array en 4 esquinas).
        /// </summary>
        /// <param name="cuadradopar">Array bidimensional cuadrado de dimensiones par (ej. 2x2, 4x4).</param>
        static void RellenaCuadros(int[,] cuadradopar) // Ejercicio 15
        {
            int i, j;

            for (i = 0; i < cuadradopar.GetLength(0); i++)
            {
                for(j = 0; j < cuadradopar.GetLength(1); j++)
                {
                    if( i < (cuadradopar.GetLength(0) / 2)) // recuadros 1 y 2
                    {
                        if( j < (cuadradopar.GetLength(1) / 2)) // recuadro 1
                        {
                            cuadradopar[i, j] = 1;
                        }
                        else // recuadro 2
                        {
                            cuadradopar[i, j] = 2;
                        }
                    }
                    else // recuadros 3 y 4
                    {
                        if (j < (cuadradopar.GetLength(1) / 2)) // recuadro 3
                        {
                            cuadradopar[i, j] = 3;
                        }
                        else // recuadro 4
                        {
                            cuadradopar[i, j] = 4;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Invierte los elementos de un array cuadrado bidimensional con respecto a la diagonal principal.
        /// </summary>
        /// <param name="cuadrado">Array cuadrado bidimensional introducido por parámetro.</param>
        static void InvierteBi(int[,] cuadrado) // Ejercicio 16: traspuesta
        {
            int i, j, valor;

            for (i = 0; i < cuadrado.GetLength(0); i++)
            {
                for (j = 0; j < cuadrado.GetLength(1); j++)
                {
                    if (j > i)
                    {
                        valor = cuadrado[i, j];
                        cuadrado[i, j] = cuadrado[j, i];
                        cuadrado[j, i] = valor;
                    }

                }
            }

        }

        /// <summary>
        /// Calcula el determinante de una matriz (array) de 3x3.
        /// </summary>
        /// <param name="tresportres">Array de 3x3 introducido por parámetro</param>
        /// <returns>Número entero resultado del determinante.</returns>
        static int CalculaDeterminante(int[,] tresportres) // Ejercicio 17
        {
            int determinante;

            determinante = (tresportres[0, 0] * tresportres[1, 1] * tresportres[2, 2] + tresportres[0, 1] * tresportres[1, 2] * tresportres[2, 0] + tresportres[0, 2] * tresportres[1, 0] * tresportres[2, 1]) - ((tresportres[0, 2] * tresportres[1, 1] * tresportres[2, 0]) + (tresportres[0, 0] * tresportres[2, 1] * tresportres[1, 2]) + (tresportres[2, 2] * tresportres[0, 1] * tresportres[1, 0]));

            return determinante;
        }

        /// <summary>
        /// Comprueba si un array cuadrado es un cuadrado mágico (la suma de cada fila, cada columna y cada diagonal da lo mismo).
        /// </summary>
        /// <param name="nueve">Array cuadrado introducido por parámetro para ser comprobado.</param>
        /// <returns>Devuelve "true" si el array es un cuadrado mágico, "false" si no.</returns>
        static bool CuadradoMagico(int[,] nueve) // Ejercicio 18
        {
            int i, j, suma, anterior;
            bool esmagico;
            esmagico = true;
            suma = 0;

            for (i = 0; i < nueve.GetLength(0); i++)
            {
                for (j = 0; j < nueve.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        suma = suma + nueve[i, j];
                    }
                }

            }

            anterior = suma; // valor inicial de suma: diagonal principal

            for (i = 0; i < nueve.GetLength(0); i++) // compruebo las filas
            {
                suma = 0; // inicializo el valor del sumatorio de fila

                for (j = 0; j < nueve.GetLength(1); j++) // sumo las posiciones de la fila actual
                {
                    suma = suma + nueve[i, j];
                } // suma = sumatorio de la fila actual

                if (suma != anterior) // si hay dos sumas que no coinciden, me salgo y declaro el booleano falso
                {
                    esmagico = false;
                    i = nueve.GetLength(0);
                }

            }

            for (j = 0; j < nueve.GetLength(1); j++) // compruebo columnas
            {
                suma = 0;

                for (i = 0; i < nueve.GetLength(0); i++)
                {
                    suma = suma + nueve[i, j];
                }

                if (suma != anterior)
                {
                    esmagico = false;
                    j = nueve.GetLength(1);
                }

            }

            suma = 0;

            for (i = 0; i < nueve.GetLength(0); i++) // diagonal secundaria
            {
                for (j = 0; j < nueve.GetLength(1); j++)
                {
                    if (i + j == 2)
                    {
                        suma = suma + nueve[i, j];
                    }
                }
            }

            if (suma != anterior)
            {
                esmagico = false;
                j = nueve.GetLength(1);
            }

            return esmagico;
        }

        /// <summary>
        /// Comprueba si en un array de 9 números enteros aparecen los números del 1 al 9 sin repetir.
        /// </summary>
        /// <param name="nueveint">Array introducido por parámetro.</param>
        /// <returns>"true" si aparecen los números del 1 al 9 sin repetir, "false" si no.</returns>
        static bool CompruebaArray19(int[] nueveint)
        {
            bool unoalnueve;
            int i;
            List<int> copia;
            copia = new List<int> { };

            unoalnueve = true;

            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (i = 0; i < nueveint.Length; i++) // copio el array en una lista
            {
                copia.Add(nueveint[i]);
            }

            for (i = 0; i < copia.Count; i++)
            {
                if (numeros.Contains(copia[i])) // si el elemento actual de "copia" aparece en "numeros"
                {
                    numeros.Remove(copia[i]); // lo elimino de "numeros"
                }
                else // si el elemento actual no aparece en "numeros"
                {
                    unoalnueve = false;
                    i = copia.Count;
                }
            }

            return unoalnueve;
        }

        /// <summary>
        /// Comprueba si el array de 9x9 forma un sudoku.
        /// </summary>
        /// <param name="candidatoasudoku">Array de 9x9 introducido por parámetro para ser comprobado.</param>
        /// <returns>Devuelve "true" si el array es un sudoku y "false" si no.</returns>
        static bool CompruebaSudoku(int[,] candidatoasudoku) // Ejercicio 19
        {
            int i, j;
            int[] arraylineal;
            List<int> fila = new List<int>();
            bool essudoku;
            essudoku = true;

            for (i = 0; i < candidatoasudoku.GetLength(0); i++) // recorro las 9 filas
            {
                for (j = 0; j < candidatoasudoku.GetLength(1); j++) // recorro los elementos de una fila
                {
                    fila.Add(candidatoasudoku[i, j]);
                }

                // fila = lista con los elementos de una fila de 9

                arraylineal = fila.ToArray(); // "arraylineal" contiene ahora los elementos de la fila actual
                if (CompruebaArray19(arraylineal) == false)
                {
                    essudoku = false;
                    i = candidatoasudoku.GetLength(0);
                }

                fila.Clear();
            }


            for (j = 0; j < candidatoasudoku.GetLength(1); j++) // columnas
            {
                for (i = 0; i < candidatoasudoku.GetLength(0); i++)
                {
                    fila.Add(candidatoasudoku[i, j]);
                }

                arraylineal = fila.ToArray();

                if (CompruebaArray19(arraylineal) == false)
                {
                    essudoku = false;
                    i = candidatoasudoku.GetLength(0);
                }

                fila.Clear();

            }

            for (i = 0; j < 9; i = i + 3) // me muevo de 1ª a 1ª posición de cada submatriz
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    for (int j2 = 0; j2 < 3; j2++)
                    {
                        fila.Add(candidatoasudoku[i + i2, j + j2]);
                    }
                }

                arraylineal = fila.ToArray();

                if (i == 6) // salto a la siguiente fila de submatrices cuando llego al final de una fila de submatrices
                {
                    i = 0;
                    j = j + 3;
                }

                if (CompruebaArray19(arraylineal) == false)
                {
                    essudoku = false;
                    i = candidatoasudoku.GetLength(0); // salgo del bucle
                }

                fila.Clear();

            }

            return essudoku;
        }

        static void Main(string[] args)
        {
            int opcion;

            {
                int[,] sudoku = { { 4, 5, 3, 7, 8, 9, 1, 2, 6 }, { 1, 2, 6, 4, 3, 5, 9, 8, 7 }, { 8, 7, 9, 1, 6, 2, 4, 3, 5 }, { 5, 3, 8, 9, 4, 6, 2, 7, 1 }, { 6, 9, 4, 2, 7, 1, 8, 5, 3 }, { 7, 1, 2, 3, 5, 8, 6, 4, 9 }, { 9, 8, 1, 5, 2, 3, 7, 6, 4 }, { 3, 6, 7, 8, 9, 4, 5, 1, 2 }, { 2, 4, 5, 6, 1, 7, 3, 9, 8 } };

                Console.WriteLine(CompruebaSudoku(sudoku));
                /*
                 int[,] tresportres;
                 tresportres = new int[3, 3] {}
                 
                int[] array = {1, 2, 3}; también funciona para declarar y crearlo, no hace falta new int
                 
                PRUEBA DE CompruebaArray19:

                int[] prueba = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                Console.WriteLine(CompruebaArray19(prueba));
                */

            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("MENÚ");
            Console.WriteLine("====");
            Console.WriteLine();
            Console.WriteLine("1.- Array 3x3");
            Console.WriteLine("2.- Rellena 3x3");
            Console.WriteLine("3.- Rellena aleatorio 3x3");
            Console.WriteLine("4.- Suma array 3x3");
            Console.WriteLine("5.- Escribe array bi");
            Console.WriteLine("6.- Rellena aleatorio bi");
            Console.WriteLine("7.- Rellena en orden bi");
            Console.WriteLine("8.- Suma array bi");
            Console.WriteLine("9.- Suma dos arrays bi");
            Console.WriteLine("10.- Copia array bi");
            Console.WriteLine("11.- Copia array bi pro");
            Console.WriteLine("12.- Rellena array ajedrez");
            Console.WriteLine("13.- Rellena diagonal");
            Console.WriteLine("14.- Rellena X");
            Console.WriteLine("15.- Rellena cuadros");
            Console.WriteLine();
            Console.WriteLine();

            opcion = int.Parse(Console.ReadLine());

            Console.WriteLine();

            switch (opcion)
            {
                case 1:
                    {
                        Console.WriteLine("Aquí tienes el array bidimensional de ejemplo:");

                        int[,] tresportres;
                        tresportres = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
                        Array3x3(tresportres);
                    }
                    break;
                case 2:
                    {
                        int[,] vacio = new int[3, 3];

                        Console.WriteLine("Array vacío:");
                        Console.WriteLine();
                        Array3x3(vacio);
                        Console.WriteLine();
                        Console.WriteLine();

                        Rellena3x3(vacio);

                        Console.WriteLine("Array relleno:");
                        Console.WriteLine();
                        Array3x3(vacio);
                    }
                    break;
                case 3:
                    {
                        int[,] vacio = new int[3, 3];

                        Console.WriteLine("Array vacío:");
                        Console.WriteLine();
                        Array3x3(vacio);
                        Console.WriteLine();
                        Console.WriteLine();

                        RellenaAleatorio3x3(vacio);

                        Console.WriteLine("Array relleno:");
                        Console.WriteLine();
                        Array3x3(vacio);
                    }
                    break;
                case 4:
                    {
                        int[,] tresportres;
                        tresportres = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

                        Console.WriteLine("La suma de los elementos del array 1-9 es: " + SumaArray3x3(tresportres));
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("Aquí tienes el array bidimensional de ejemplo:");

                        int[,] tresportres;
                        tresportres = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
                        EscribeArrayBi(tresportres);
                    }
                    break;
                case 6:
                    {
                        int[,] vacio = new int[3, 3];

                        Console.WriteLine("Array vacío:");
                        Console.WriteLine();
                        EscribeArrayBi(vacio);
                        Console.WriteLine();
                        Console.WriteLine();

                        RellenaAleatorioBi(vacio);

                        Console.WriteLine("Array relleno:");
                        Console.WriteLine();
                        EscribeArrayBi(vacio);
                    }
                    break;
                case 7:
                    {
                        int[,] vacio = new int[4, 4];

                        Console.WriteLine("Array vacío:");
                        Console.WriteLine();
                        EscribeArrayBi(vacio);
                        Console.WriteLine();
                        Console.WriteLine();

                        RellenaEnOrdenBi(vacio);

                        Console.WriteLine("Array relleno:");
                        Console.WriteLine();
                        EscribeArrayBi(vacio);
                    }
                    break;
                case 8:
                    {
                        int[,] ejemplo;
                        ejemplo = new int[3, 2] { { 1, 1 }, { 2, 2 }, { 3, 3 } };
                        Console.WriteLine("Array:");
                        EscribeArrayBi(ejemplo);
                        Console.WriteLine();
                        Console.WriteLine("Suma de los elementos del array: " + SumaArrayBi(ejemplo));
                    }
                    break;
                case 9:
                    {
                        int[,] unos, doses, suma;
                        unos = new int[2, 2] { { 1, 1 }, { 1, 1 } };
                        doses = new int[2, 2] { { 2, 2 }, { 2, 2 } };
                        suma = new int[2, 2];
                        Suma2ArraysBi(unos, doses, suma);

                        EscribeArrayBi(unos);
                        Console.WriteLine();
                        EscribeArrayBi(doses);
                        Console.WriteLine("Suma:");
                        EscribeArrayBi(suma);
                    }
                    break;
                case 10:
                    {
                        int[,] original, copia;
                        original = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
                        copia = new int[2, 3];

                        Console.WriteLine("Array original:");
                        EscribeArrayBi(original);
                        Console.WriteLine();

                        CopiaArrayBi(original, copia);

                        Console.WriteLine("Array copia:");
                        EscribeArrayBi(copia);
                    }
                    break;
                case 11:
                    {
                        int[,] original;
                        original = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };


                        Console.WriteLine("Array original:");
                        EscribeArrayBi(original);
                        Console.WriteLine();

                        Console.WriteLine("Array copia:");
                        EscribeArrayBi(CopiaArrayBiPro(original));
                    }
                    break;
                case 12:
                    {
                        Console.WriteLine("Aquí está tu tablero de ajedrez:");
                        Console.WriteLine();
                        EscribeArrayBi(RellenaArrayAjedrez());
                    }
                    break;
                case 13:
                    {
                        int[,] cuadrado;
                        cuadrado = new int[5, 5];

                        RellenaDiagonal(cuadrado);
                        EscribeArrayBi(cuadrado);
                    }
                    break;
                case 14:
                    {
                        int[,] cincoporcinco;
                        cincoporcinco = new int[5, 5];
                        RellenaX(cincoporcinco);
                        EscribeArrayBi(cincoporcinco);
                    }
                    break;
                case 15:
                    {
                        int[,] cuatroporcuatro;
                        cuatroporcuatro = new int[4, 4];
                        RellenaCuadros(cuatroporcuatro);
                        EscribeArrayBi(cuatroporcuatro);
                    }
                    break;
                default:
                    {
                        Console.WriteLine("No existe ese ejercicio.");
                    }
                    break;
            }


            Console.ReadKey();
        }
    }
}
