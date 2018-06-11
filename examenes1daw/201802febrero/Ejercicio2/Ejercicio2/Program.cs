using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio2
{
    class Program
    {
        /// <summary>
        /// Escribe el contenido de una lista de cadenas por pantalla.
        /// </summary>
        /// <param name="milista">Lista introducida por parámetro.</param>
        static void EscribeLista(List<string> milista)
        {
            int i;

            Console.Write("<");

            for (i = 0; i < milista.Count - 1; i++)
            {
                Console.Write(milista[i] + ", ");
            }

            Console.WriteLine(milista[milista.Count - 1] + ">");
        }
        
        /// <summary>
        /// Extrae las palabras de cierta longitud de una cadena de palabras y las guarda en una lista.
        /// </summary>
        /// <param name="palabras">Cadena de palabras.</param>
        /// <param name="longitudminima">Longitud mínima de las palabras que queremos extraer de la cadena.</param>
        /// <returns>Lista de palabras con la longitud mínima contenidas en la cadena.</returns>
        static List<string> ListaPalabrasLargas(string palabras, int longitudminima)
        {
            string abecedarioplus = "aábcdeéfghiíjklmnñoópqrstuúvwxyzAÁBCDEÉFGHIÍJKLMNÑOÓPQRSTÚUVWXYZ "; // caracteres q me interesan para separar las palabras
            List<string> palabrasmayores = new List<string>(); // creo lista vacía
            string[] palabraslargas = new string[0];
            int i;

            for(i = 0; i < palabras.Length; i++) // recorro la cadena caracter a caracter
            {
                if(!abecedarioplus.Contains(palabras[i])) // si el caracter "i" es un caracter extraño
                {
                    palabras = palabras.Remove(i, 1); // lo elimino de la cadena original
                    i = i - 1;
                }
            }

            // Una vez tengo mi cadena solo con palabras y espacios:

            palabraslargas = palabras.Split(' '); // guardo las palabras en un array

            for(i = 0; i < palabraslargas.Length; i++)
            {
                if(palabraslargas[i].Length >= longitudminima)
                {
                    palabrasmayores.Add(palabraslargas[i]); // añado las palabras del array a la lista
                }

            }

            return palabrasmayores;
        }
        

        static void Main(string[] args)
        {
            string mispalabras = "Si llueve, te mojas. Pero, ¿cuánto?";
            int longitudminima;

            Console.WriteLine("¿De qué longitud mínima quieres las palabras?");
            longitudminima = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Cadena original:");
            Console.WriteLine(mispalabras);
            Console.WriteLine();
            Console.WriteLine("Lista de palabras mayores de " + longitudminima + " caracteres:");
            EscribeLista(ListaPalabrasLargas(mispalabras, longitudminima));


            Console.ReadKey();
        }
    }
}
