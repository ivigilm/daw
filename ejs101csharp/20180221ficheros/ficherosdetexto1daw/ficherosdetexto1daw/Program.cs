
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Importo la librería input/output

using System.IO;

namespace ficherosdetexto1daw
{
    class Program
    {
        /// <summary>
        /// Crea un fichero con diez números aleatorios, cada uno en una línea.
        /// </summary>
        /// <param name="nombredefichero">Nombre del fichero que ha de crear.</param>
        static void EscribeFicheroNumRandom10(string nombredefichero) // Ejercicio 1
        {            
            StreamWriter fichero = new StreamWriter(nombredefichero); // creo el fichero
            int i, numero;
            Random r = new Random(); // inicializo la generación de números aleatorios

            for(i = 0; i < 10; i++)
            {
                numero = r.Next(1, 101); // calculo un número aleatorio del 1 al 100
                fichero.WriteLine(numero); // escribo un número aleatorio nuevo en una nueva línea
            }

            fichero.Close(); // tras 10 líneas, cierro el fichero para que se guarde

        }

        /// <summary>
        /// Suma los enteros contenidos en un fichero de diez líneas (cada una con un entero).
        /// </summary>
        /// <param name="nombredefichero">Nombre del fichero.</param>
        /// <returns>Suma de los números enteros contenidos en el fichero.</returns>
        static int SumaFicheroInt10(string nombredefichero) // Ejercicio 2
        {
            int i, suma, numero;
            suma = 0;
            StreamReader sr = new StreamReader(nombredefichero);

            for(i = 0; i < 10; i++)
            {
                numero = int.Parse(sr.ReadLine());
                suma = suma + numero;
            }

            sr.Close();

            return suma;
        }

        /// <summary>
        /// Crea un fichero con varios números aleatorios, cada uno en una línea.
        /// </summary>
        /// <param name="nombredefichero">Nombre del fichero que ha de crear.</param>
        /// <param name="numerodelineas">Número de enteros aleatorios que se guardarán en el fichero.</param>
        static void EscribeFicheroNumRandom(string nombredefichero, int numerodelineas) // Ejercicio 3
        {
            int i, numero;
            StreamWriter sw = new StreamWriter(nombredefichero);
            Random r = new Random();

            for(i = 0; i < numerodelineas; i++)
            {
                numero = r.Next(1, 101);
                sw.WriteLine(numero);
            }

            sw.Close();
        }

        /// <summary>
        /// Suma los enteros contenidos en un fichero (cada línea con un entero).
        /// </summary>
        /// <param name="nombredefichero">Nombre del fichero.</param>
        /// <returns>Suma de los números enteros contenidos en el fichero.</returns>
        static int SumaFicheroInt(string nombredefichero) // Ejercicio 4
        {
            int suma, numero;
            suma = 0;
            StreamReader sr = new StreamReader(nombredefichero);

            while(!sr.EndOfStream) // hasta que llegue al final del archivo
            {
                numero = int.Parse(sr.ReadLine());
                suma = suma + numero;
            }            

            sr.Close();

            return suma;
        }

        /// <summary>
        /// Guarda líneas de texto introducidas por el usuario en el fichero. Deja de hacerlo cuando se introduce una línea vacía.
        /// </summary>
        /// <param name="nombredefichero">Nombre del fichero.</param>
        static void EscribeFicheroTexto(string nombredefichero) // Ejercicio 5
        {
            string linea;
            linea = "a";

            StreamWriter sw = new StreamWriter(nombredefichero);

            while (linea != "")
            {
                Console.WriteLine("Escribe una línea de texto y la introduciré en tu fichero.");
                linea = Console.ReadLine();
                sw.WriteLine(linea);
            }

            sw.Close();
            
        }

        /// <summary>
        /// Muestra el contenido de un fichero por pantalla.
        /// </summary>
        /// <param name="nombredefichero">Nombre del fichero.</param>
        static void LeeFicheroTexto(string nombredefichero) // Ejercicio 6
        {
            StreamReader sr = new StreamReader(nombredefichero); // abro el fichero para leerlo
            string linea;
            
            while (!sr.EndOfStream)
            {
                linea = sr.ReadLine(); // leo una línea
                Console.WriteLine(linea);
            }            

            sr.Close();
        }

        /// <summary>
        /// Copia el contenido de un fichero en otro.
        /// </summary>
        /// <param name="ficherooriginal">Fichero original con datos.</param>
        /// <param name="ficherocopia">Fichero donde se guardará una copia del fichero original.</param>
        static void CopiaFicheroTexto(string ficherooriginal, string ficherocopia) // Ejercicio 7
        {
            StreamReader sr = new StreamReader(ficherooriginal); // abro el original
            StreamWriter sw = new StreamWriter(ficherocopia); // abro la copia
            string linea;

            while (!sr.EndOfStream)
            {
                linea = sr.ReadLine(); // leo una línea de la original
                sw.WriteLine(linea); // copio la línea
            }

            sr.Close();
            sw.Close();
        }

        /// <summary>
        /// Invierte los caracteres de una cadena (el primero pasará a ser el último, etc.).
        /// </summary>
        /// <param name="cadena">Cadena introducida por parámetro.</param>
        /// <returns>Copia de la cadena original con el contenido invertido.</returns>
        static string InvierteCadena(string cadena)
        {
            string resultado;
            resultado = "";
            int i;

            for (i = cadena.Length - 1; i >= 0; i--)
            {
                resultado = resultado + cadena.Substring(i, 1);
            }

            return resultado;
        }

        /// <summary>
        /// Copia el contenido de un fichero en otro invirtiendo los caracteres de las líneas.
        /// </summary>
        /// <param name="original">Fichero que se quiere copiar.</param>
        /// <param name="copia">Fichero donde se guardará la copia.</param>
        static void InvierteLineasFichero(string original, string copia) // Ejercicio 8
        {
            StreamReader sr = new StreamReader(original); // abro el original
            StreamWriter sw = new StreamWriter(copia); // abro la copia
            string linea;

            while (!sr.EndOfStream)
            {
                linea = sr.ReadLine(); // leo una línea de la original
                linea = InvierteCadena(linea);
                sw.WriteLine(linea); // copio la línea
            }

            sr.Close();
            sw.Close();
        }

        /// <summary>
        /// Invierte las líneas de un fichero de orden (la primera será la última, etc.)
        /// </summary>
        /// <param name="nombredefichero">Fichero</param>
        static void InvierteFicheroTexto(string nombredefichero) // Ejercicio 9
        {           
            StreamReader sr = new StreamReader(nombredefichero, Encoding.Default); // abro el fichero para su lectura
            
            List<string> lineasdelfichero = new List<string>();
            string linea;
            int i;

            while (!sr.EndOfStream)
            {
                linea = sr.ReadLine(); // leo una línea
                lineasdelfichero.Add(linea); // agrego la línea a mi lista
            }
            sr.Close();

            StreamWriter sw = new StreamWriter(nombredefichero, false, Encoding.Default); // abro el fichero para su edición
            // tengo la lista "lineasdelfichero" con las líneas ordenadas

            lineasdelfichero.Reverse(); // le doy la vuelta

            for (i = 0; i < lineasdelfichero.Count; i++)
            {
                sw.WriteLine(lineasdelfichero[i]);
            }
            
            sw.Close();

        }

        /// <summary>
        /// Separa las palabras contenidas en un fichero y las copia, una por línea, en otro fichero.
        /// </summary>
        /// <param name="original">Fichero original.</param>
        /// <param name="copia">Fichero donde se copiarán las palabras del original.</param>
        static void SeparaPalabrasFichero(string original, string copia) // Ejercicio 10
        {
            StreamReader sr = new StreamReader(original, Encoding.Default); // abro el original
            StreamWriter sw = new StreamWriter(copia); // abro la copia
            string linea;
            string[] palabras = new string[0];
            int i;

            while (!sr.EndOfStream)
            {
                linea = sr.ReadLine(); // leo una línea de la original
                palabras = linea.Split(' '); // paso la línea a un array de cadenas
                for (i = 0; i < palabras.Length; i++)
                {
                    sw.WriteLine(palabras[i]); // copio la palabra en el nuevo archivo y la escribo en una línea nueva
                }                
            }

            sr.Close();
            sw.Close();
        }

        static void Main(string[] args)
        {
            int opcion;

            Console.WriteLine("MENÚ: EJERCICIOS DE FICHEROS DE TEXTO");
            Console.WriteLine("=====================================");
            Console.WriteLine("");
            Console.WriteLine("1.- EscribeFicheroNumRandom10");
            Console.WriteLine("2.- SumaFicheroInt10");
            Console.WriteLine("3.- EscribeFicheroNumRandom");
            Console.WriteLine("4.- SumaFicheroInt");
            Console.WriteLine("5.- EscribeFicheroTexto");
            Console.WriteLine("6.- LeeFicheroTexto");
            Console.WriteLine("7.- CopiaFicheroTexto");
            Console.WriteLine("8.- InvierteLineasFichero");
            Console.WriteLine("9.- InvierteFicheroTexto");
            Console.WriteLine("10.- SeparaPalabrasFichero");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    {
                        string nombre;
                        Console.WriteLine("¿Qué nombre quieres que tenga tu fichero? (con extensión incluida)");
                        nombre = Console.ReadLine();

                        EscribeFicheroNumRandom10(nombre);

                        Console.WriteLine();
                        Console.WriteLine("Este el el contenido del nuevo fichero:");
                        Console.WriteLine();

                        StreamReader lectura = new StreamReader(nombre); // le pido permiso al sistema para abrir el fichero
                        Console.WriteLine(lectura.ReadToEnd()); // leo el fichero y hago que me lo muestre por pantalla
                        lectura.Close();
                    }
                    break;
                case 2:
                    {
                        string nombre;
                        Console.WriteLine("¿Cuál es el nombre de tu fichero? (con extensión incluida)");
                        nombre = Console.ReadLine();

                        Console.WriteLine(SumaFicheroInt10(nombre));
                    }
                    break;
                case 3:
                    {
                        string nombre;
                        int numerodelineas;
                        Console.WriteLine("¿Qué nombre quieres que tenga tu fichero? (con extensión incluida)");
                        nombre = Console.ReadLine();
                        Console.WriteLine("¿Cuántas líneas quieres que tenga el fichero?");
                        numerodelineas = int.Parse(Console.ReadLine());

                        EscribeFicheroNumRandom(nombre, numerodelineas);

                        Console.WriteLine();
                        Console.WriteLine("Este el el contenido del nuevo fichero:");
                        Console.WriteLine();

                        StreamReader lectura = new StreamReader(nombre); // le pido permiso al sistema para abrir el fichero
                        Console.WriteLine(lectura.ReadToEnd()); // leo el fichero y hago que me lo muestre por pantalla
                        lectura.Close();
                    }
                    break;
                case 4:
                    {
                        string nombre;
                        Console.WriteLine("¿Cuál es el nombre de tu fichero? (con extensión incluida)");
                        nombre = Console.ReadLine();

                        Console.WriteLine(SumaFicheroInt(nombre));
                    }
                    break;
                case 5:
                    {
                        string nombre;
                        Console.WriteLine("¿Cuál es el nombre de tu fichero? (con extensión incluida)");
                        nombre = Console.ReadLine();

                        EscribeFicheroTexto(nombre);
                    }
                    break;
                case 6:
                    {
                        string nombre;
                        Console.WriteLine("¿Cuál es el nombre de tu fichero? (con extensión incluida)");
                        nombre = Console.ReadLine();

                        LeeFicheroTexto(nombre);
                    }
                    break;
                case 7:
                    {
                        string original, copia;
                        Console.WriteLine("¿Cuál es el nombre del fichero que quieres copiar? (con extensión incluida)");
                        original = Console.ReadLine();
                        Console.WriteLine("¿Cuál es el nombre del fichero donde quieres hacer la copia? (con extensión incluida)");
                        copia = Console.ReadLine();

                        CopiaFicheroTexto(original, copia);


                    }
                    break;
                case 8:
                    {
                        string original, copia;
                        Console.WriteLine("¿Cuál es el nombre del fichero que quieres copiar? (con extensión incluida)");
                        original = Console.ReadLine();
                        Console.WriteLine("¿Cuál es el nombre del fichero donde quieres hacer la copia? (con extensión incluida)");
                        copia = Console.ReadLine();

                        InvierteLineasFichero(original, copia);
                    }
                    break;
                case 9:
                    {
                        string nombre;
                        Console.WriteLine("¿Cuál es el nombre de tu fichero? (con extensión incluida)");
                        nombre = Console.ReadLine();
                        
                        InvierteFicheroTexto(nombre);
                    }
                    break;
                case 10:
                    {
                        string original, copia;
                        Console.WriteLine("¿Cuál es el nombre del fichero que quieres copiar? (con extensión incluida)");
                        original = Console.ReadLine();
                        Console.WriteLine("¿Cuál es el nombre del fichero donde quieres hacer la copia? (con extensión incluida)");
                        copia = Console.ReadLine();

                        SeparaPalabrasFichero(original, copia);
                    }
                    break;
            }


            Console.ReadKey();

        }
    }
}
