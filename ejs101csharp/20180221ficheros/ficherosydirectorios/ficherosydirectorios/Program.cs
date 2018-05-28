using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ficherosydirectorios
{
    class Program
    {
        
        /// <summary>
        /// Da el número de ficheros con la extensión indicada contenidos en el directorio actual.
        /// </summary>
        /// <param name="extension">Extensión del tipo de fichero que queremos contar.</param>
        /// <returns>Número entero: número de ficheros con la extensión en el directorio actual.</returns>
        static int CuantosFicheros(string extension) // Ejercicio 1
        {
            int numeroficheros, i;
            string[] listaficheros;
            numeroficheros = 0;
            
            listaficheros = Directory.GetFiles(Directory.GetCurrentDirectory()); // lista los ficheros de mi ubicación

            for(i = 0; i < listaficheros.Length; i++)
            {
                if(Path.GetExtension(listaficheros[i]) == extension)
                {
                    numeroficheros = numeroficheros + 1;
                }
            }

            return numeroficheros;
        }

        /// <summary>
        /// Da el número de ficheros con la extensión indicada contenidos en el directorio indicado.
        /// </summary>
        /// <param name="extension">Extensión del tipo de fichero que queremos contar.</param>
        /// <param name="ubicacion">Ruta del directorio donde queremos contar ficheros.</param>
        /// <returns></returns>
        static int CuantosFicherosPro(string extension, string ubicacion) // Ejercicio 2
        {
            int numeroficheros, i;
            string[] listaficheros;
            numeroficheros = 0;

            listaficheros = Directory.GetFiles(ubicacion); // lista los ficheros de mi ubicación

            for (i = 0; i < listaficheros.Length; i++)
            {
                if (Path.GetExtension(listaficheros[i]) == extension)
                {
                    numeroficheros = numeroficheros + 1;
                }
            }

            return numeroficheros;
        }

        /// <summary>
        /// Hace una copia de un fichero (le añade .bak al nombre).
        /// </summary>
        /// <param name="ficheroinicial">Nombre del fichero que queremos copiar.</param> // Ejercicio 3
        static void CreaBackup(string ficheroinicial) // Ejercicio 3
        {
            string ficherocopia;
            ficherocopia = ficheroinicial + ".bak";
                  
            while (File.Exists(ficherocopia))
            {
                ficherocopia = ficherocopia + ".bak";
            }

            File.Copy(ficheroinicial, ficherocopia);
        }

        /// <summary>
        /// Cambia la extensión de los archivos del directorio actual del tipo indicado.
        /// </summary>
        /// <param name="extensioninicial">Extensión de los ficheros que se quieren modificar.</param>
        /// <param name="extensionfinal">Nueva extensión que tendrán estos ficheros tras el cambio.</param>
        static void RenombraMasivo(string extensioninicial, string extensionfinal) // Ejercicio 4
        {
            int i;
            string nombreficheroinicial, nombreficherofinal;
            string[] listaficheros;
            listaficheros = Directory.GetFiles(Directory.GetCurrentDirectory());

            for(i = 0; i < listaficheros.Length; i++)
            {
                if (Path.GetExtension(listaficheros[i]) == extensioninicial)
                {
                    nombreficheroinicial = Path.GetFileName(listaficheros[i]); // guardo el nombre de fichero inicial
                    nombreficherofinal = Path.ChangeExtension(nombreficheroinicial, extensionfinal); // le cambio la extensión
                    File.Move(nombreficheroinicial, nombreficherofinal);
                }
            }
        }

        /// <summary>
        /// Cuenta el número de líneas que tiene un fichero de texto.
        /// </summary>
        /// <returns>Número entero: total de líneas del fichero</returns>
        static int CuentaLineasFicheroTexto(string nombrefichero)
        {
            int numerodelineas;
            numerodelineas = 0;

            StreamReader sr = new StreamReader(nombrefichero, Encoding.Default);

            while (!sr.EndOfStream)
            {
                sr.ReadLine();
                numerodelineas = numerodelineas + 1;
            }

            sr.Close();

            return numerodelineas;
        }
        
        /// <summary>
        /// Cuenta las líneas de texto contenidas en todos los ficheros de la extensión indicada en el directorio actual.
        /// </summary>
        /// <param name="extension">Extensión de los ficheros cuyas líneas contaremos.</param>
        /// <returns>Número entero: total de líneas que hay en los ficheros indicados.</returns>
        static int CuentaLineasFicheros(string extension) // Ejercicio 5
        {
            string[] listaficheros = Directory.GetFiles(Directory.GetCurrentDirectory());
            int totallineas, i;
            totallineas = 0;

            for(i = 0; i < listaficheros.Length; i++) // para cada fichero
            {
                if(Path.GetExtension(listaficheros[i]) == extension)
                totallineas = totallineas + CuentaLineasFicheroTexto(listaficheros[i]); // cuento las líneas del fichero
            }

            return totallineas;
        }

        /// <summary>
        /// Halla el fichero de mayor tamaño de la carpeta actual.
        /// </summary>
        /// <returns>Nombre del fichero.</returns>
        static string FicheroMasGrande() // Ejercicio 6
        {
            string[] listaficheros = Directory.GetFiles(Directory.GetCurrentDirectory());
            string mayor; // fichero más grande
            int i;
            long tamanyoactual, tamanyomax;
            mayor = listaficheros[0];
            tamanyomax = 0;

            for (i = 0; i < listaficheros.Length; i++)
            {
                FileInfo fi = new FileInfo(listaficheros[i]);
                tamanyoactual = fi.Length; // guardo el tamño del fichero actual
                
                if ( tamanyoactual > tamanyomax ) // si el fichero actual es mayor que el guardado
                {
                    mayor = listaficheros[i];
                    tamanyomax = tamanyoactual;
                }
            }

            mayor = Path.GetFileName(mayor);

            return mayor;
        }

        /// <summary>
        /// Clasifica los ficheros del directorio actual según su extensión y cantidad de ficheros del mismo tipo.
        /// </summary>
        static void ClasificaFicheros() // Ejercicio 7
        {
            string[] listaficheros = Directory.GetFiles(Directory.GetCurrentDirectory());
            string[] listaextensiones = listaficheros;
            List<string> extensiones = new List<string> ();
            int i, contador;
            string extension;
            contador = 1;

            for(i = 0; i < listaficheros.Length; i++) // para cada fichero
            {
                extension = Path.GetExtension(listaficheros[i]); // ext del fichero actual
                listaextensiones[i] = extension; // la guardo en el string[] de ext
            }
                        
            for(i = 0; i < listaextensiones.Length; i++)
            {
                extensiones.Add(listaextensiones[i]); // paso el array de ext a lista
            }

            extensiones.Sort(); // ordeno alfabéticamente la lista
            
            for(i = 1; i < extensiones.Count; i++) // para cada elemento de la lista
            {
                if(extensiones[i] == extensiones[i - 1])
                {
                    contador = contador + 1; // si continúo con la misma extensión
                }
                else // cuando cambio de extensión
                {
                    Console.WriteLine(extensiones[i - 1] + " => " + contador); // imprimo las repeticiones de la extensión anterior
                    contador = 1; // reinicio el contador de repeticiones
                }
            }

            Console.WriteLine(extensiones[i - 1] + " => " + contador); // imprimo las repeticiones de la extensión anterior
        }

        static void Main(string[] args)
        {
            int opcion;
            

            Console.WriteLine();
            Console.WriteLine("MENÚ");
            Console.WriteLine("====");
            Console.WriteLine();
            Console.WriteLine("1.- CuantosFicheros");
            Console.WriteLine("2.- CuantosFicherosPro");
            Console.WriteLine("3.- CreaBackup");
            Console.WriteLine("4.- RenombraMasivo");
            Console.WriteLine("5.- CuentaLineasFicheros");
            Console.WriteLine("6.- FicheroMasGrande");
            Console.WriteLine("7.- ClasificaFicheros");
            Console.WriteLine();

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    {
                        string extension;
                        Console.WriteLine("¿Qué extensión quieres comprobar? ( .exe / .txt / etc)");

                        extension = Console.ReadLine();

                        if (CuantosFicheros(extension) == 1)
                        {
                            Console.WriteLine("En el directorio actual hay " + CuantosFicheros(extension) + " fichero con la extensión " + extension + ".");

                        }
                        else
                        {
                            Console.WriteLine("En el directorio actual hay " + CuantosFicheros(extension) + " ficheros con la extensión " + extension + ".");
                        }
                    }
                    break;
                case 2:
                    {
                        string extension, ubicacion;

                        Console.WriteLine("¿De qué extensión son los ficheros que quieres contar?");
                        extension = Console.ReadLine();
                        Console.WriteLine("¿Cuál es la ruta del directorio donde quieres contar los ficheros?");
                        ubicacion = Console.ReadLine();

                        CuantosFicherosPro(extension, ubicacion);
                    }
                    break;
                case 3:
                    {
                        string ficherooriginal;

                        Console.WriteLine("¿Cuál es el nombre del fichero que quieres copiar? (Dame la ruta completa del fichero si no está en tu directorio actual.)");
                        ficherooriginal = Console.ReadLine();

                        CreaBackup(ficherooriginal);
                    }
                    break;
                case 4:
                    {
                        string inicial, final;
                        Console.WriteLine("¿Qué extensión quieres cambiar?");
                        inicial = Console.ReadLine();
                        Console.WriteLine("¿A qué extensión quieres cambiar?");
                        final = Console.ReadLine();

                        RenombraMasivo(inicial, final);
                    }
                    break;
                case 5:
                    {
                        string extension;
                        int totallineas;
                        Console.WriteLine("¿De qué extensión quieres que te cuente las líneas?");
                        extension = Console.ReadLine();
                        totallineas = CuentaLineasFicheros(extension);
                        Console.WriteLine("Los ficheros de la extensión seleccionada suman un total de " + totallineas + " líneas en el directorio actual.");
                    }
                    break;
                case 6:
                    {
                        Console.WriteLine("El fichero de mayor tamaño del directorio de trabajo es: " + FicheroMasGrande());
                    }
                    break;
                case 7:
                    {
                        ClasificaFicheros();
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Ese ejercicio no existe.");
                    }
                    break;
            }

            Console.ReadKey();
        }
    }
}
