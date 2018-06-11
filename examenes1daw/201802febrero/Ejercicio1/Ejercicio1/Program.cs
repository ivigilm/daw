using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio1
{
    class Program
    {
        /// <summary>
        /// Imprime por pantalla el texto contenido en un fichero binario con los colores indicados en este.
        /// </summary>
        /// <param name="fichero">Fichero binario con formato cadena/entero/cadena/entero. Los enteros representan colores.</param>
        static void TextoMulticolorFichero(string fichero)
        {
            string palabra;
            int color;

            FileStream fs = new FileStream(fichero, FileMode.Open); // abro el fichero para su lectura
            BinaryReader br = new BinaryReader(fs); // comienzo la lectura

            while (fs.Position < fs.Length) // leo hasta el final del fichero
            {
                palabra = br.ReadString();
                color = br.ReadInt32();

                if (palabra == "" && color == -1) // salto de línea
                {
                    Console.WriteLine();
                }
                else // para cada palabra
                {
                    switch (color) // cambio el color de escritura
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case 5:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                    }

                    Console.Write(palabra);
                }
            }

            br.Close();
            fs.Close();
        }

        // Console.ForegroundColor = ConsoleColor.white

        static void Main(string[] args)
        {
            int opcion;

            string andalucia = "Andalucia.multicolor";
            string espanya = "España.multicolor";
            string quijote = "Quijote.multicolor";

            Console.WriteLine();
            Console.WriteLine("MENÚ");
            Console.WriteLine("====");
            Console.WriteLine();
            Console.WriteLine("1.- Himno de Andalucía");
            Console.WriteLine("2.- Himno de España");
            Console.WriteLine("3.- Fragmento del Quijote");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("¿Qué texto quieres leer hoy?");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    TextoMulticolorFichero(andalucia);
                    break;
                case 2:
                    TextoMulticolorFichero(espanya);
                    break;
                case 3:
                    TextoMulticolorFichero(quijote);
                    break;
                default:
                    Console.WriteLine("Texto no disponible.");
                    break;
            }




            Console.ReadKey();
        }
    }
}
