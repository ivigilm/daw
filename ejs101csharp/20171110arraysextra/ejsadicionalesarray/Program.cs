using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejsadicionalesarray // Relación Ejercicios Adicionales de Arrays
{
    class Program
    {
        /// <summary>
        /// Escribe un array de tipo entero de x elementos pasado por parámetro en formato [a, b, c].
        /// </summary>
        /// <param name="a">Array introducido por parámetro.</param>
        static void EscribeArray(int[] a)
        {
            int i;

            Console.Write("[ ");

            for (i = 0; i < a.Length - 1; i++)
            {
                Console.Write(a[i] + ", ");
            }

            Console.Write(a[a.Length - 1]);

            Console.WriteLine("]");
        }

        /// <summary>
        /// Escribe un array de tipo booleano de x elementos pasado por parámetro en formato [a, b, c].
        /// </summary>
        /// <param name="a">Array introducido por parámetro.</param>
        static void EscribeArray(bool[] a)
        {
            int i;

            Console.Write("[ ");

            for (i = 0; i < a.Length - 1; i++)
            {
                Console.Write(a[i] + ", ");
            }

            Console.Write(a[a.Length - 1]);

            Console.WriteLine("]");
        }

        /// <summary>
        /// Escribe un array de tipo double de x elementos pasado por parámetro en formato [a, b, c].
        /// </summary>
        /// <param name="a">Array introducido por parámetro.</param>
        static void EscribeArray(double[] a)
        {
            int i;

            Console.Write("[ ");

            for (i = 0; i < a.Length - 1; i++)
            {
                Console.Write(a[i] + ", ");
            }

            Console.Write(a[a.Length - 1]);

            Console.WriteLine("]");
        }

        /// <summary>
        /// Copia un array en otro.
        /// </summary>
        /// <param name="a">Primer array introducido por parámetro, será el que se copie.</param>
        /// <param name="b">Segundo array introducido por parámetro, será donde se copie el primero.</param>
        static void CopiaArray(int[] a, int[] b)
        {
            int i;

            if (a.Length == b.Length)
            {
                for (i = 0; i < a.Length; i++)
                {
                    b[i] = a[i];
                }
            }
            else
            {
                Console.WriteLine("¿Cómo quieres que copie un array en otro si son de distinto tamaño? Vuelve a probar.");
            }
        }

        /// <summary>
        /// Calcula si un número introducido por parámetro es primo.
        /// </summary>
        /// <param name="numero">Número introducido por parámetro.</param>
        /// <returns>Devuelve "true" si el número es primo o "false" si no lo es.</returns>
        static bool Primo(int numero)
        {
            if (numero < 2)
            {
                return false;
            }
            else
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
        }

        /// <summary>
        /// Rellena un array con números enteros ascendentes, empezando por 1.
        /// </summary>
        /// <param name="a">Array introducido por parámetro para ser rellenado.</param>
        static void RellenaEnOrden(int[] a)
        {
            int i;

            for (i = 0; i < a.Length; i++)
            {
                a[i] = i + 1;
            }
        }

        /// <summary>
        /// Cambia el orden de los elementos de un array: los de las posiciones pares los pone en las posiciones impares y viceversa.
        /// </summary>
        /// <param name="array">Array introducido por parámetro.</param>
        static void IntercambiaParImpar(int[] array) // Ejercicio 1 
        {

            if (array.Length % 2 == 0 && array.Length != 0) // compruebo si el array proporcionado tiene un número par de elementos
            {
                int[] arrayauxiliar = new int[array.Length];

                int i;

                for (i = 0; i < array.Length; i++) // reordeno los elementos y los guardo en mi arrayauxiliar
                {
                    if (i % 2 == 0) // coloco los elementos de posiciones pares en el nuevo array
                    {
                        arrayauxiliar[i + 1] = array[i];
                    }
                    else // coloco los elementos de posiciones impares en el nuevo array
                    {
                        arrayauxiliar[i - 1] = array[i];
                    }
                }

                CopiaArray(arrayauxiliar, array);
            }
            else // si el array proporcionado no tiene un número par de elementos, no hago nada
            {
                Console.WriteLine("El array que me das no tiene un número par de elementos. No puedo trabajar así.");
            }

        }

        /// <summary>
        /// Comprueba si una tarjeta de crédito es válida mediante el siguiente algoritmo:
        /// se multiplican por 2 los valores de las posiciones pares (y 0) del array,
        /// y si alguna multiplicación da un número mayor que 9 se le resta 9 al resultado;
        /// una vez hecho esto, se suman los valores de los elementos impares del array con los valores 
        /// resultantes de estas operaciones para las posiciones pares: si la suma total es múltiplo de 10,
        /// la tarjeta es válida.
        /// </summary>
        /// <param name="array">Array contenedor de los dígitos de la tarjeta, introducido por parámetro.</param>
        /// <returns>true si la tarjeta es válida, false si no es válida</returns>
        static bool CompruebaTarjeta(int[] array) // Ejercicio 2 
        {
            bool valida;

            int suma, i, valor;
            suma = 0;

            valida = false;

            if (array.Length == 16) // si el número introducido es de 16 dígitos, compruebo su valía
            {
                for (i = 0; i < array.Length; i++)
                {
                    valor = array[i]; // las posiciones impares conservan su valor inicial

                    if (i % 2 == 0) // las posiciones pares y la 0 cambian su valor
                    {
                        valor = valor * 2;

                        if (valor >= 10)
                        {
                            valor = valor - 9;
                        }

                    }

                    suma = suma + valor; // voy sumando los valores finales de cada posición del array
                }

                if (suma % 10 == 0)
                {
                    valida = true;
                }
            }

            return valida;
        }

        /// <summary>
        /// Guarda en un nuevo array los valores correspondientes a los 'n' últimos elementos de un array.
        /// </summary>
        /// <param name="array">Array original introducido por parámetro.</param>
        /// <param name="numero">Número entero introducido por parámetro correspondiente al número de elementos del array que se quieren conservar.</param>
        /// <returns>Array contenedor de los 'n' últimos elementos del array original.</returns>
        static int[] TailArray(int[] array, int numero) // Ejercicio 3 
        {
            if (numero > 0 && numero <= array.Length)
            {
                int[] array2 = new int[numero];
                int i;
                int j;
                j = array.Length - numero;

                for (i = 0; i < array2.Length; i++)
                {
                    array2[i] = array[j];

                    j++;
                }

                return array2;
            }
            else
            {
                Console.WriteLine("No se puede completar la operación. Tu array original era:");

                return array;
            }
        }

        /// <summary>
        /// Comprueba si en un array de enteros hay una serie de 5 números consecutivos iguales.
        /// </summary>
        /// <param name="array">Array introducido por parámetro.</param>
        /// <returns>true si hay una serie de 5 números iguales consecutivos, false si no</returns>
        static bool Detecta5(int[] array) // Ejercicio 4 
        {
            bool consecutivos;
            consecutivos = false;

            int i;

            for (i = 4; i < array.Length; i++)
            {
                if (array[i] == array[i - 1] && array[i] == array[i - 2] && array[i] == array[i - 3] && array[i] == array[i - 4])
                {
                    consecutivos = true;
                }
            }


            return consecutivos;
        }

        /// <summary>
        /// Crea un array de booleanos que muestra como "true" las posiciones de los números primos, empezando por el 0.
        /// </summary>
        /// <param name="numerotope">Último número entero que queremos comprobar si es primo.</param>
        /// <returns>Array de booleanos con el resultado de la función Primo sobre los números enteros hasta "numerotope".</returns>
        static bool[] CalcunaNPrimos(int numerotope) // Ejercicio 5
        {
            bool[] resultado = new bool[numerotope + 1]; // creo el array del tamaño deseado

            int i;

            for (i = 0; i < resultado.Length; i++)
            {
                if (Primo(i) == true)
                {
                    resultado[i] = true;
                }
                else
                {
                    resultado[i] = false;
                }
            }

            return resultado;

        }

        /// <summary>
        /// Ordena un array de enteros mediante el médoto de la burbuja: se realizan elementos-1 pasadas ordenando cada pareja de elementos del array (posiciones 0 y 1, 1 y 2, etc.).
        /// </summary>
        /// <param name="array">Array introducido por parámetro.</param>
        static void BubbleSort(int[] array) // Ejercicio 6
        {
            int i, j, mayor;

            for (i = 0; i < array.Length - 1; i++) // hacemos array.Length - 1 pasadas
            {
                for (j = 0; j < array.Length - 1; j++) // en cada pasada recorro el array mirando las parejas
                {
                    if (array[j] > array[j + 1]) // pareja desordenada: los cambiamos
                    {
                        mayor = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = mayor;
                    }
                }

            }
        }

        /// <summary>
        /// Escribe por pantalla un array con notas destacando en verde los aprobados, en rojo los suspensos y escribiendo un mensaje de error si es una nota inválida.
        /// </summary>
        /// <param name="a">Array de tipo "double" introducido por parámetro, contenedor de las notas.</param>
        static void EscribeArrayNotas(double[] a) // Ejercicio 7
        {
            int i;

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("[ ");

            for (i = 0; i < a.Length - 1; i++)
            {
                if (a[i] >= 5 && a[i] <= 10) // en verde
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(a[i]);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(",");
                }
                else
                {
                    if (a[i] >= 0 && a[i] < 5) // en rojo
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(a[i]);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(",");
                    }
                    else // ERROR en amarillo
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("ERROR");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(",");
                    }
                }

            }

            if (a[i] >= 5 && a[i] <= 10) // en verde
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(a[a.Length - 1]);
            }
            else
            {
                if (a[i] >= 0 && a[i] < 5) // en rojo
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(a[a.Length - 1]);
                }
                else // ERROR en amarillo
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("ERROR");
                }
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("]");
        }

        /// <summary>
        /// Comprueba si un array de enteros contiene un número entero concreto.
        /// </summary>
        /// <param name="a">Array introducido por parámetro.</param>
        /// <param name="b">Número entero introducido por parámetro.</param>
        /// <returns></returns>
        static bool Contiene(int[] a, int b)
        {
            bool contienenumero;
            int i;
            contienenumero = false;

            for (i = 0; i < a.Length; i++)
            {
                if (a[i] == b)
                {
                    contienenumero = true;
                }
            }

            return contienenumero;
        }

        /// <summary>
        /// Comprueba si un valor del array se repite dentro del mismo array.
        /// </summary>
        /// <param name="array">Array introducido por parámetro</param>
        /// <param name="posicion">Posición del array que se quiere comprobar.</param>
        /// <returns></returns>
        static bool SeRepite(int[] array, int posicion)
        {
            bool contienenumero;
            int i;
            contienenumero = false;

            for (i = posicion + 1; i < array.Length; i++)
            {
                if (array[i] == array[posicion])
                {
                    contienenumero = true;
                }
            }

            return contienenumero;
        }

        /// <summary>
        /// Convierte en 0 los elementos de ambos arrays que no aparecen en el otro.
        /// </summary>
        /// <param name="array1">Primer array introducido por parámetro.</param>
        /// <param name="array2">Segundo array introducido por parámetro.</param>
        static void TachaElementosNoComunes(int[] array1, int[] array2) // Ejercicio 8
        {
            int i;

            int[] arraycopia = new int[array1.Length];

            CopiaArray(array1, arraycopia); // copio array1 en un nuevo array

            for (i = 0; i < array1.Length; i++) // recorro array1 comprobando las coincidencias con array2
            {
                if (Contiene(array2, array1[i]) == false) // si el valor de esta posición NO existe en array 2
                {
                    array1[i] = 0;
                }
            }

            for (i = 0; i < array2.Length; i++) // compruebo los valores de array2
            {
                if (Contiene(arraycopia, array2[i]) == false)
                {
                    array2[i] = 0;
                }
            }

        }

        /// <summary>
        /// Borra un valor de una posición dada de un array y desplaza los valores posteriores hacia atrás, restando 1 al tamaño del array.
        /// </summary>
        /// <param name="a">Array introducido por referencia.</param>
        /// <param name="posicion">Posición del array que se quiere eliminar.</param>
        static void BorraDeArray(ref int[] a, int posicion)
        {
            int i;

            for (i = posicion; i < a.Length - 1; i++)
            {
                a[i] = a[i + 1];
            }

            Array.Resize(ref a, a.Length - 1);
        }
                
        /// <summary>
        /// Inserta un elemento nuevo al final de un array, agrandando este en una posición.
        /// </summary>
        /// <param name="a">Array introducido por referencia.</param>
        /// <param name="elemento">Valor del elemento que se quiere añadir al array.</param>
        static void InsertaAlFinalArray(ref int[] a, int elemento)
        {
            Array.Resize(ref a, a.Length + 1);

            a[a.Length - 1] = elemento;
        }             
        
        /// <summary>
        /// Elimina los elementos repetidos de un array (solo deja un elemento de cada valor).
        /// </summary>
        /// <param name="array">Array</param>
        static void EliminaRepetidos(ref int[] array) // Ejercicio 9
        {
            int i, j;

            for (i = 0; i < array.Length; i++) // recorro el array
            {
                for (j = i + 1; j < array.Length; j++) // recorro el array desde la posición q estoy comprobando hasta el final
                {
                    if (array[j] == array[i]) // si coincide, elimino la posición y la vuelvo a comprobar
                    {
                        BorraDeArray(ref array, j);

                        j--;
                    }
                }
            }
        }

        /// <summary>
        /// Redondea los valores "double" de un array a enteros y los guarda en un nuevo array que devuelve.
        /// </summary>
        /// <param name="arrayinicial">Array con los valores iniciales (decimales).</param>
        /// <returns>Nuevo array creado con los valores enteros del array inicial.</returns>
        static double[] RedondeaArray(double[] arrayinicial) // Ejercicio 10.1
        {
            double[] arrayresultado = new double[arrayinicial.Length];

            int i;

            for (i = 0; i < arrayinicial.Length; i++)
            {
                arrayresultado[i] = Math.Truncate(arrayinicial[i]);
            }

            return arrayresultado;
        }

        /// <summary>
        /// Elimina la parte entera de los valores guardados en un array "double".
        /// </summary>
        /// <param name="arrayinicial">Array introducido inicialmente</param>
        /// <returns>Nuevo array con los valores del array inicial quitándoles su parte entera.</returns>
        static double[] DecimalesArray(double[] arrayinicial) // Ejercicio 10.2
        {
            double[] arrayresultado = new double[arrayinicial.Length];

            int i;

            for (i = 0; i < arrayinicial.Length; i++)
            {
                arrayresultado[i] = (arrayinicial[i] - Math.Truncate(arrayinicial[i]));
            }

            return arrayresultado;
        }

        /// <summary>
        /// Desordena los elementos de un array de enteros.
        /// </summary>
        /// <param name="arrayinicial">Array inicial</param>
        /// <returns>Nuevo array formado por los elementos del array inicial desordenados.</returns>
        static int[] DesordenaArray(int[] arrayinicial) // Ejercicio 11 
        {
            int i;

            int[] arrayfinal = new int[arrayinicial.Length];

            for (i = 0; i < arrayfinal.Length; i++)
            {
                Random rnd = new Random();
                int numero = rnd.Next(0, arrayinicial.Length - 1);

                arrayfinal[i] = arrayinicial[numero];

                BorraDeArray(ref arrayinicial, numero);
            }

            return arrayfinal;
        }

        /// <summary>
        /// Halla el valor mínimo de los contenidos en un array de enteros.
        /// </summary>
        /// <param name="a">Array introducido por parámetro.</param>
        /// <returns>Menor valor del array.</returns>
        static int MinArray(int[] a)
        {
            int i, min;

            min = a[0];

            for (i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }

            return min;
        }

        /// <summary>
        ///  Halla el valor máximo de los contenidos en un array de enteros
        /// </summary>
        /// <param name="a"Array introducido por parámetro.></param>
        /// <returns>Mayor valor del array</returns>
        static int MaxArray(int[] a)
        {
            int i, max;

            max = a[0];

            for (i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }

            return max;
        }

        /// <summary>
        /// Elimina el primer elemento que tenga un valor dado de un array.
        /// </summary>
        /// <param name="a">Array introducido por referencia</param>
        /// <param name="elemento">Valor del elemento a eliminar.</param>
        static void Elimina1ElementoArray(ref int[] a, int elemento)
        {
            int i, j;

            for (i = 0; i < a.Length; i++) // recorro el array hasta encontrar el elemento
            {
                if (a[i] == elemento)
                {
                    a[i] = 0;

                    for (j = i; j < a.Length - 1; j++) // recorro el resto del array recolocándolo para dejar vacía la última posición
                    {
                        a[j] = a[j + 1];
                    }

                    Array.Resize(ref a, a.Length - 1);
                }
            }
        }

        /// <summary>
        /// Ordena los valores de un array dado de menor a mayor.
        /// </summary>
        /// <param name="arrayinicial">Array</param>
        /// <returns>Nuevo array con los valores del array introducido por parámetro ordenados.</returns>
        static int[] MinMaxArray(int[] arrayinicial) // Ejercicio 12
        {
            int min, i;
            int[] arrayresultado = new int[arrayinicial.Length];

            for (i = 0; i < arrayresultado.Length; i++)
            {
                min = MinArray(arrayinicial);

                arrayresultado[i] = min;

                Elimina1ElementoArray(ref arrayinicial, min);
            }

            return arrayresultado;

        }

        /// <summary>
        /// Dibuja un gráfico de barras que ilustra los valores de un array de enteros.
        /// </summary>
        /// <param name="array">Array de enteros introducido por parámetro.</param>
        static void GraficaBarras(int[] array) // Ejercicio 13
        {
            int i, j;

            for (i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");

                for (j = 1; j <= array[i]; j++)
                {
                    Console.Write("█");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Comprueba las parejas de valores de un array con resultados de partidos y halla la mayor racha de victorias del equipo local.
        /// </summary>
        /// <param name="array">Array con los resultados</param>
        /// <returns>Número entero igual a la mayor racha de victorias consecutivas.</returns>
        static int MejorRacha(int[] array) // Ejercicio 14
        {
            int i, racha, mejorracha;
            racha = 0;
            mejorracha = 0;

            for (i = 0; i < array.Length; i = i + 2)
            {
                if (array[i] > array[i + 1])
                {
                    racha = racha + 1;

                    if (racha > mejorracha)
                    {
                        mejorracha = racha;
                    }
                }
                else
                {
                    racha = 0;
                }
            }

            return mejorracha;
        }

        /// <summary>
        /// Elimina el elemento "x" de un array de enteros.
        /// </summary>
        /// <param name="a">Array introducido por parámetro.</param>
        /// <param name="elemento">Valor numérico a eliminar del array.</param>
        static void EliminaElementosArray(ref int[] a, int elemento)
        {
            int i;

            for (i = 0; i < a.Length; i++)
            {
                if (a[i] == elemento)
                {
                    Elimina1ElementoArray(ref a, elemento);

                    i = i - 1;
                }
            }


        }

        /// <summary>
        /// Crea una lista con los números primos existentes hasta un número dado.
        /// </summary>
        /// <param name="numero">Número hasta donde se quiere obtener la lista de primos.</param>
        /// <returns>Array con la lista de números primos.</returns>
        static int[] NumerosPrimos(int numero) // Ejercicio 15
        {
            int[] array = new int[numero + 1];
            int[] arrayprimos = new int[numero + 1];
            int i, j;

            for (i = 2; i < array.Length; i++)
            {
                if(array[i] == 0)
                {
                    InsertaAlFinalArray(ref arrayprimos, i);

                    for (j = i; j < array.Length; j++)
                    {
                        if(j % i == 0)
                        {
                            array[j] = -1;
                        }
                    }
                }
            }

            EliminaElementosArray(ref arrayprimos, 0);

            return arrayprimos;

        }
                
    
    static void Main(string[] args)
        {       

            int opcion;

            Console.WriteLine("MENÚ DE ARRAYS");
            Console.WriteLine("==============");
            Console.WriteLine();
            Console.WriteLine(" 1- IntercambiaParImpar");
            Console.WriteLine(" 2- CompruebaTarjeta");
            Console.WriteLine(" 3- TailArray");
            Console.WriteLine(" 4- Detecta5");
            Console.WriteLine(" 5- CalculaNPrimos");
            Console.WriteLine(" 6- BubbleSort");
            Console.WriteLine(" 7- EscribeArrayNotas");
            Console.WriteLine(" 8- TachaElementosNoComunes");
            Console.WriteLine(" 9- EliminaRepetidos");
            Console.WriteLine(" 101- RedondeaArray");
            Console.WriteLine(" 102 - DecimalesArray");
            Console.WriteLine(" 11- DesordenaArray");
            Console.WriteLine(" 12- MinMaxArray");
            Console.WriteLine(" 13- GraficaBarras");
            Console.WriteLine(" 14- MejorRacha");
            Console.WriteLine(" 15- NumerosPrimos");
            Console.WriteLine();
            Console.WriteLine("Elige una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    {
                        int[] array1 = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };

                        IntercambiaParImpar(array1);

                        EscribeArray(array1);
                    }                    break;
                case 2:
                    {
                        int[] tarjeta = new int[16] { 4, 9, 2, 9, 9, 9, 6, 8, 6, 1, 5, 0, 1, 7, 5, 6 };

                        Console.WriteLine(CompruebaTarjeta(tarjeta));
                    }                    break;
                case 3:
                    {
                        int[] array = new int[5] { 1, 2, 3, 4, 5 };

                        EscribeArray(TailArray(array, 2));
                    }                    break;
                case 4:
                    {
                        int[] array = new int[9] { 1, 2, 3, 4, 5, 5, 5, 5, 5 };

                        Console.WriteLine(Detecta5(array));
                    }                    break;
                case 5:
                    {
                        EscribeArray(CalcunaNPrimos(10));
                    }                    break;
                case 6:
                    {
                        int[] array = new int[5] { 1, 7, 5, 3, -4 };

                        BubbleSort(array);

                        EscribeArray(array);
                    }                    break;
                case 7:
                    {
                        double[] array = new double[10] { 1, 7, 5, 182, 4, 3.6, 1.7, 8.5, 9.2, 3.5 };

                        EscribeArrayNotas(array);
                    }                    break;
                case 8:
                    {
                        int[] array = new int[5] { 1, 7, 5, 182, 4 };
                        int[] array2 = new int[5] { 33, 4, 5, 32, 9 };


                        TachaElementosNoComunes(array, array2);
                    }                    break;
                case 9:
                    {
                        int[] array = new int[6] { 1, 1, 1, 2, 2, 2 };

                        EliminaRepetidos(ref array);

                        EscribeArray(array);
                    }                    break;
                case 101:
                    {
                        double[] array = new double[5] { 1.5, 2.3, 7.2, 5.5, 10 };

                        EscribeArray(array);
                        EscribeArray(RedondeaArray(array));
                    }                    break;
                case 102:
                    {
                        double[] array = new double[5] { 1.5, 2.3, 7.2, 5.5, 10 };

                        EscribeArray(array);
                        EscribeArray(DecimalesArray(array));
                    }                    break;
                case 11:
                    {
                        int[] array = new int[7] { 1, 2, 3, 4, 5, 6, 7 };

                        EscribeArray(DesordenaArray(array));
                    }                    break;
                case 12:
                    {
                        int[] array = new int[7] { 5, 2, 3, 1, 4, 7, 6 };

                        EscribeArray(MinMaxArray(array));
                    }                    break;
                case 13:
                    {
                        int[] array = new int[4] { 1, 2, 3, 4 };

                        GraficaBarras(array);
                    }                    break;
                case 14:
                    {
                        int[] array = new int[20] { 1, 2, 4, 4, 8, 5, 0, 1, 2, 1, 3, 2, 4, 2, 0, 0, 3, 1, 2, 0 };

                        Console.WriteLine(MejorRacha(array));
                    }                    break;
                case 15:
                    {
                        EscribeArray(NumerosPrimos(1000));
                    }                    break;
                default:
                    Console.WriteLine("Este ejercicio no está en la relación de ejercicios adicionales de arrays.");
                    break;
            }

            Console.ReadKey();

        }
    }
}
