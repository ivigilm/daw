using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace ficherosbinarios
{
    class Program
    {
        /// <summary>
        /// Escribe en un fichero dado los cien primeros números enteros (1 al 100).
        /// </summary>
        /// <param name="fichero">Fichero introducido por parámetro.</param>
        static void EscribeFichero1_100(string fichero) // Ejercicio 1
        {
            FileStream fs = new FileStream(fichero, FileMode.Create); // abro el archivo para modificarlo
            BinaryWriter bw = new BinaryWriter(fs); // abro el proceso de escritura
            int i;

            for (i = 1; i <= 100; i++)
            {
                bw.Write(i);
            }

            bw.Close();
            fs.Close();
            
        }

        /// <summary>
        /// Lee los cien primeros valores enteros de un fichero.
        /// </summary>
        /// <param name="fichero">Fichero introducido por parámetro.</param>
        static void LeeFicheroInt100(string fichero) // Ejercicio 2
        {
            FileStream fs2 = new FileStream(fichero, FileMode.Open);
            BinaryReader br = new BinaryReader(fs2);
            int i;

            for(i = 0; i < 100; i++)
            {
                br.ReadInt32();
            }

            fs2.Close();
        }
        
        /// <summary>
        /// Escribe números aleatorios entre 1 y 100 en un fichero.
        /// </summary>
        /// <param name="fichero">Fichero introducido por parámetro.</param>
        /// <param name="numeroregistros">Número de enteros que se quieren escribir en el fichero.</param>
        static void EscribeFicheroIntAleatorio(string fichero, int numeroregistros) // Ejercicio 3
        {
            FileStream fs = new FileStream(fichero, FileMode.Create); // abro el archivo para modificarlo
            BinaryWriter bw = new BinaryWriter(fs); // abro el proceso de escritura
            int i, aleatorio;

            Random r = new Random();

            for (i = 0; i < numeroregistros; i++)
            {
                aleatorio = r.Next(1, 101); // obtengo un aleatorio
                bw.Write(aleatorio);
            }

            bw.Close();
            fs.Close();
        }

        /// <summary>
        /// Escribe números aleatorios entre dos valores dados en un fichero.
        /// </summary>
        /// <param name="fichero">Fichero introducido por parámetro.</param>
        /// <param name="numeroregistros">Número de enteros que se quieren escribir en el fichero.</param>
        /// <param name="minimo">Valor inicial del intervalo de donde se obtendrán los números aleatorios.</param>
        /// <param name="maximo">Valor final del intervalo de donde se obtendrán los números aleatorios.</param>
        static void EscribeFicheroIntAleatorioPro(string fichero, int numeroregistros, int minimo, int maximo) // Ejercicio 4
        {
            FileStream fs = new FileStream(fichero, FileMode.Create); // abro el archivo para modificarlo
            BinaryWriter bw = new BinaryWriter(fs); // abro el proceso de escritura
            int i, aleatorio;

            Random r = new Random();

            for (i = 0; i < numeroregistros; i++)
            {
                aleatorio = r.Next(minimo, maximo + 1); // obtengo un aleatorio
                bw.Write(aleatorio);
            }

            bw.Close();
            fs.Close();
        }

        /// <summary>
        /// Lee todos los números enteros que contiene un fichero.
        /// </summary>
        /// <param name="fichero">Fichero introducido por parámetro.</param>
        static void LeeFicheroInt(string fichero) // Ejercicio 5
        {
            FileStream fs = new FileStream(fichero, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            
            while (fs.Position < fs.Length)
            {
                br.ReadInt32();
            }

            br.Close();
            fs.Close();
        }

        /// <summary>
        /// Lee todos los números enteros de un fichero y los suma.
        /// </summary>
        /// <param name="fichero">Fichero introducido por parámetro.</param>
        /// <returns>Resultado de la suma de todos los enteros contenidos en el fichero.</returns>
        static int SumaFicheroInt(string fichero) // Ejercicio 6
        {
            int suma, lectura;
            FileStream fs = new FileStream(fichero, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            suma = 0;

            while (fs.Position < fs.Length)
            {
                lectura = br.ReadInt32();
                suma = suma + lectura;

            }

            fs.Close();

            return suma;
        }

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

        /// <summary>
        /// Lee los enteros de un fichero y los almacena en una lista.
        /// </summary>
        /// <param name="fichero">Fichero introducido por parámetro.</param>
        /// <returns>Lista con los números enteros que había en el fichero.</returns>
        static List<int> LeeFicheroIntLista(string fichero) // Ejercicio 7
        {
            List<int> enteros = new List<int>(0); // lista donde guardaré los enteros del fichero
            int numero;

            FileStream fs = new FileStream(fichero, FileMode.Open); // abro el archivo
            BinaryReader br = new BinaryReader(fs); // comienzo la lectura del archivo

            while (fs.Position < fs.Length)
            {
                numero = br.ReadInt32(); // leo los enteros
                enteros.Add(numero); // y los agrego a mi lista
            }

            fs.Close();

            return enteros;
        }

        /// <summary>
        /// Ordena los números enteros contenidos en un fichero y los guarda ordenados en este fichero.
        /// </summary>
        /// <param name="fichero">Fichero introducido por parámetro.</param>
        static void OrdenaFicheroInt(string fichero) // Ejercicio 8
        {
            int i;
            List<int> enteros = new List<int>(0);
            enteros = LeeFicheroIntLista(fichero); // guardon en la lista "enteros" los números enteros de mi fichero

            enteros.Sort(); // ordeno la lista

            FileStream fs = new FileStream(fichero, FileMode.Create); // abro el fichero para su modificación
            BinaryWriter bw = new BinaryWriter(fs); // abro el proceso de escritura en el fichero

            for (i = 0; i < enteros.Count; i++)
            {
                bw.Write(enteros[i]);
            }            

            bw.Close();
            fs.Close();

        }

        /// <summary>
        /// Separa los enteros de un fichero en dos ficheros nuevos: positivos y negativos.
        /// </summary>
        /// <param name="fichero">Fichero introducido por parámetro.</param>
        static void SeparaFicheroInt(string fichero) // Ejercicio 9
        {
            int numero;
            FileStream fs = new FileStream(fichero, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            FileStream fspositivos = new FileStream("positivos.bin", FileMode.Create); // creo el fichero de números positivos
            FileStream fsnegativos = new FileStream("negativos.bin", FileMode.Create); // creo el fichero de números negativos
            BinaryWriter bwpositivos = new BinaryWriter(fspositivos);
            BinaryWriter bwnegativos = new BinaryWriter(fsnegativos);
            
            while (fs.Position < fs.Length)
            {
                numero = br.ReadInt32();

                if(numero >= 0)
                {
                    bwpositivos.Write(numero);
                }
                else // numero < 0
                {
                    bwnegativos.Write(numero);
                }                
                
            }

            bwnegativos.Close();
            bwpositivos.Close();
            fsnegativos.Close();
            fspositivos.Close();
            br.Close();
            fs.Close();

        }

        /// <summary>
        /// Invierte la posición de los valores dentro del fichero.
        /// </summary>
        /// <param name="fichero">Nombre del fichero.</param>
        static void InvierteFicheroInt(string fichero) // Ejercicio 10
        {
            int i;
            List<int> enteros = new List<int>();
            enteros = LeeFicheroIntLista(fichero);

            enteros.Reverse();

            FileStream fs = new FileStream(fichero, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            for(i = 0; i < enteros.Count; i++)
            {
                bw.Write(enteros[i]);
            }
            bw.Close();
            fs.Close();
        }

        static void Main(string[] args)
        {
            int opcion;


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("MENÚ: EJERCICIOS DE FICHEROS BINARIOS");
            Console.WriteLine("=====================================");
            Console.WriteLine("");
            Console.WriteLine("1.- EscribeFichero1_100");
            Console.WriteLine("2.- LeeFicheroInt100");
            Console.WriteLine("3.- EscribeFicheroIntAleatorio");
            Console.WriteLine("4.- EscribeFicheroIntAleatorioPro");
            Console.WriteLine("5.- LeeFicheroInt");
            Console.WriteLine("6.- SumaFicheroInt");
            Console.WriteLine("7.- LeeFicheroIntLista");
            Console.WriteLine("8.- OrdenaFicheroInt");
            Console.WriteLine("9.- SeparaFicheroInt");
            Console.WriteLine("10.- InvierteFicheroInt");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    {
                        string mifichero;
                        mifichero = "mifichero.bin";
                        FileStream fs = new FileStream(mifichero, FileMode.Create);
                        fs.Close();

                        EscribeFichero1_100(mifichero);
                        
                        Console.WriteLine("Este es el contenido del fichero tras la modificación:");
                        Console.WriteLine();

                        FileStream fs2 = new FileStream(mifichero, FileMode.Open);
                        BinaryReader br = new BinaryReader(fs2);
                        int i;

                        for (i = 0; i < 100; i++)
                        {
                            Console.WriteLine(br.ReadInt32());
                        }

                        fs2.Close();

                    }
                    break;
                case 2:
                    {
                        string mifichero;
                        mifichero = "mifichero.bin";
                        FileStream fs = new FileStream(mifichero, FileMode.Create);
                        fs.Close();

                        EscribeFichero1_100(mifichero);

                        Console.WriteLine("Este es el contenido del fichero que he leído:");
                        Console.WriteLine();

                        FileStream fs2 = new FileStream(mifichero, FileMode.Open);
                        BinaryReader br = new BinaryReader(fs2);
                        int i;

                        for (i = 0; i < 100; i++)
                        {
                            Console.WriteLine(br.ReadInt32());
                        }

                        fs2.Close();
                    }
                    break;
                case 3:
                    {
                        string mifichero;
                        int repeticiones;
                        mifichero = "mifichero.bin";
                        FileStream fs = new FileStream(mifichero, FileMode.Create);
                        fs.Close();

                        Console.WriteLine("¿Cuántos números quieres que te escriba?");
                        repeticiones = int.Parse(Console.ReadLine());

                        EscribeFicheroIntAleatorio(mifichero, repeticiones);

                        Console.WriteLine();
                        Console.WriteLine("Este es el contenido del fichero tras la modificación:");
                        Console.WriteLine();

                        FileStream fs2 = new FileStream(mifichero, FileMode.Open);
                        BinaryReader br = new BinaryReader(fs2);
                        int i;

                        for (i = 0; i < repeticiones; i++)
                        {
                            Console.WriteLine(br.ReadInt32());
                        }

                        fs2.Close();
                    }
                    break;
                case 4:
                    {
                        string mifichero;
                        int repeticiones, min, max;
                        mifichero = "mifichero.bin";
                        FileStream fs = new FileStream(mifichero, FileMode.Create);
                        fs.Close();

                        Console.WriteLine("¿Cuántos números quieres que te escriba?");
                        repeticiones = int.Parse(Console.ReadLine());
                        Console.WriteLine("Dime entre qué valores quieres que te genere números. (Primer número + intro + segundo número + intro)");
                        min = int.Parse(Console.ReadLine());
                        max = int.Parse(Console.ReadLine());

                        EscribeFicheroIntAleatorioPro(mifichero, repeticiones, min, max);

                        Console.WriteLine();
                        Console.WriteLine("Este es el contenido del fichero tras la modificación:");
                        Console.WriteLine();

                        FileStream fs2 = new FileStream(mifichero, FileMode.Open);
                        BinaryReader br = new BinaryReader(fs2);
                        int i;

                        for (i = 0; i < repeticiones; i++)
                        {
                            Console.WriteLine(br.ReadInt32());
                        }

                        fs2.Close();
                    }
                    break;
                case 5:
                    {
                        string mifichero;
                        mifichero = "mifichero.bin";
                        FileStream fs = new FileStream(mifichero, FileMode.Create);
                        fs.Close();

                        EscribeFichero1_100(mifichero);

                        Console.WriteLine("Este es el contenido del fichero que he leído:");
                        Console.WriteLine();

                        FileStream fs2 = new FileStream(mifichero, FileMode.Open);
                        BinaryReader br = new BinaryReader(fs2);

                        while (fs2.Position < fs2.Length)
                        {
                            Console.WriteLine(br.ReadInt32());
                        }

                        fs2.Close();
                    }
                    break;
                case 6:
                    {
                        string mifichero;
                        int suma;
                        mifichero = "mifichero.bin";
                        FileStream fs = new FileStream(mifichero, FileMode.Create);
                        fs.Close();

                        EscribeFichero1_100(mifichero);

                        suma = SumaFicheroInt(mifichero);
                        Console.WriteLine("La suma de los números enteros del fichero es: " + suma);

                    }
                    break;
                case 7:
                    {
                        string mifichero;
                        mifichero = "mifichero.bin";
                        FileStream fs = new FileStream(mifichero, FileMode.Create);
                        fs.Close();

                        EscribeFichero1_100(mifichero);

                        EscribeLista(LeeFicheroIntLista(mifichero));

                    }
                    break;
                case 8:
                    {
                        string mifichero;
                        mifichero = "mifichero.bin";
                        FileStream fs = new FileStream(mifichero, FileMode.Create);
                        BinaryWriter bw = new BinaryWriter(fs);

                        bw.Write(25);
                        bw.Write(7);

                        bw.Close();
                        fs.Close();                        

                        OrdenaFicheroInt(mifichero);

                        Console.WriteLine("Este es el contenido del fichero que he leído:");
                        Console.WriteLine();

                        FileStream fs2 = new FileStream(mifichero, FileMode.Open);
                        BinaryReader br = new BinaryReader(fs2);

                        while (fs2.Position < fs2.Length)
                        {
                            Console.WriteLine(br.ReadInt32());
                        }

                        fs2.Close();
                    }
                    break;
                case 9:
                    {
                        string fichero;

                        Console.WriteLine("¿Cuál es el nombre de tu fichero?");
                        fichero = Console.ReadLine();

                        SeparaFicheroInt(fichero);
                    }
                    break;
                case 10:
                    {
                        string fichero;

                        Console.WriteLine("¿Cuál es el nombre de tu fichero?");
                        fichero = Console.ReadLine();

                        InvierteFicheroInt(fichero);
                    }
                    break;
            }


            Console.ReadKey();


        }
    }
}
