using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej1mediana
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
        /// Crea un array de enteros a partir de una cadena.
        /// </summary>
        /// <param name="elementosarray">Cadena de enteros separados por espacio.</param>
        /// <returns>Array de enteros con los números introducidos en una cadena por el usuario.</returns>
        static int[] LeeArrayUnaLinea(string elementosarray)
        {
            int i, n;
            string[] valores;
            int[] resultado = new int[0];


            valores = elementosarray.Split(' '); // array de cadenas con los valores escritos                       

            for(i = 0; i < valores.Length; i++) // recorro el array de cadenas
            {
                // agrego el valor convertido a entero al array de números
                n = Convert.ToInt32(valores[i]);

                InsertaAlFinalArray(ref resultado, n);                
            }

            return resultado;
        }
        
        /// <summary>
        /// Ordena un array de enteros mediante el médoto de la burbuja: se realizan elementos-1 pasadas ordenando cada pareja de elementos del array (posiciones 0 y 1, 1 y 2, etc.).
        /// </summary>
        /// <param name="array">Array introducido por parámetro.</param>
        static void BubbleSort(int[] array)
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
        /// Halla la mediana de un array.
        /// </summary>
        /// <param name="serienumeros">Array desordenado.</param>
        /// <returns>Número que cardinalmente está en el medio.</returns>
        static int Mediana(int[] serienumeros)
        {
            int mediana;
            int[] copia = serienumeros; // hago una copia del array

            BubbleSort(copia); // ordeno los elementos

            mediana = (copia.Length / 2 + copia.Length % 2);

            return mediana;
        }

        static void Main(string[] args)
        {
            string elementosarray;
            int[] arraydelusuario;

            Console.WriteLine("Escribe los elementos del array separados por un espacio, por favor.");
            elementosarray = Console.ReadLine(); // cadena escrita por el usuario (con espacios)

            arraydelusuario = LeeArrayUnaLinea(elementosarray); //

            Console.WriteLine();
            Console.WriteLine("Tu array es:");
            EscribeArray(arraydelusuario);

            Console.WriteLine();
            Console.WriteLine("La mediana del array es: " + Mediana(arraydelusuario));
            Console.ReadKey();
        }
    }
}
