using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        /// <summary>
        /// Escribe el contenido de una lista de enteros por pantalla.
        /// </summary>
        /// <param name="milista">Lista introducida por parámetro.</param>
        static void EscribeLista(List<int> milista)
        {
            int i;

            if(milista.Count > 0)
            {
                Console.Write("<");

                for (i = 0; i < milista.Count - 1; i++)
                {
                    Console.Write(milista[i] + ", ");
                }

                Console.WriteLine(milista[milista.Count - 1] + ">");
            }          
                        
        }

        /// <summary>
        /// Dada una lista con valores correspondientes a fichas de dominó, halla las fichas dobles.
        /// </summary>
        /// <param name="fichas">Lista de enteros que representan fichas del dominó (por parejas).</param>
        /// <returns>Lista de enteros que representa las fichas dobles que había en la primera lista.</returns>
        static List<int> ListaDominoDobles(List<int> fichas)
        {
            List<int> dobles = new List<int>(); // lista donde guardaré las fichas dobles
            int i;

            if(fichas.Count % 2 != 0) // si no hay un número par de elementos
            {
                Console.WriteLine("No has introducido un número par de enteros.");
            }
            else // Si el tamaño de la lista introducida es correcto (2n elementos)
            {       
                for (i = 0; i < fichas.Count; i = i + 2) // recorro las posiciones de la lista de fichas de dos en dos
                {
                    if( (fichas[i] > 6 || fichas[i] < 0) || (fichas[i+1] > 6 || fichas[i+1] < 0) ) // Valor incorrecto en i o i+1
                    {
                        dobles.Clear();
                        Console.WriteLine("Valor incorrecto.");
                        i = fichas.Count; // salgo del for
                    }
                    else // si todo va bien, hallo las fichas dobles
                    {
                        if(fichas[i] == fichas[i + 1]) // agrego la pareja a la lista de dobles
                        {
                            dobles.Add(fichas[i]);
                            dobles.Add(fichas[i]);
                        }
                    }
                }
            }

            return dobles;
            
        }

        static void Main(string[] args)
        {
            List<int> mano = new List<int>(10) { 1, 1, 0, 3, 2, 1, 5, 6, 6, 6 };
            
            EscribeLista(ListaDominoDobles(mano));

            Console.ReadKey();
        }
    }
}
