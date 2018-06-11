using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio5
{
    class Program
    {    
        static int[,] LeeMatrizFichero(string fichero)
        {
            // Compruebo que están bien los datos
            int[,] matriz = new int[0,0];
            string linea;
            //  COMPROBACIÓN DE ERRORES: int longituddelinea;
            StreamReader sr = new StreamReader(fichero);
            int i, j;

            while (!sr.EndOfStream)
            {
                for(i = 0;  ; i++)
                {
                    linea = sr.ReadLine(); // leo una línea
                    string[] valores = linea.Split(','); //guardo los valores en un array

                    // COMPROBACIÓN DE ERRORES: longituddelinea = valores.Length; // nº valores que hay en esa línea

                    for (j = 0; j < valores.Length; j++) // recorro una línea
                    {
                        matriz[i, j] = int.Parse(valores[j]); // guardo el valor correspondiente en la matriz
                    }
                }
                
            }

            sr.Close();

            return matriz;
        }

        /// <summary>
        /// Escribe un array bidimensional por pantalla.
        /// </summary>
        /// <param name="array">Array introducido por parámetro.</param>
        static void EscribeArrayBi(int[,] array)
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

        static void Main(string[] args)
        {
            string tresporcinco = "array3x5.csv";
            string mal = "arraymal.csv";
            string magico = "cuadradomagico4x4.csv";

            EscribeArrayBi(LeeMatrizFichero(tresporcinco));

            Console.ReadKey();
        }
    }
}
