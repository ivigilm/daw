using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ej3pokemon
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

            Console.Write("<");

            for (i = 0; i < milista.Count - 1; i++)
            {
                Console.Write(milista[i] + ", ");
            }

            Console.WriteLine(milista[milista.Count - 1] + ">");
        }

        static void Main(string[] args)
        {
            int opcion = -1;

            Pokedex pd = new Pokedex("pokemon.csv");
            
            Console.WriteLine("MENÚ");
            Console.WriteLine("====");
            Console.WriteLine("");
            Console.WriteLine("1.- Capturar Pokemon");
            Console.WriteLine("2.- Ver Pokemon");
            Console.WriteLine("3.- Mostrar porcentaje de capturas");
            Console.WriteLine("");
            Console.WriteLine("0.- Salir");
            Console.WriteLine("");

            while (opcion != 0)
            {
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        {
                            string nombre;
                            Console.WriteLine("Dime el nombre del bicho que quieres capturar. (Ej. venusaur, butterfree)");
                            nombre = Console.ReadLine();
                            pd.CapturaPokemon(nombre);
                        }
                        break;
                    case 2:
                        {
                            string nombre;
                            Console.WriteLine("Dime el nombre del pokemon que quieres ver.");
                            nombre = Console.ReadLine();
                            Console.WriteLine(pd.BuscaPokemon(nombre).ToString());
                        }
                        break;
                    case 3:
                        {
                            Console.Write("Porcentaje de capturas: ");
                            Console.Write(pd.PorcentajeCapturas());
                            Console.WriteLine("%");
                        }
                        break;
                    default:
                        break;
                }
            }
            

            Console.ReadKey();

        }
    }
}
