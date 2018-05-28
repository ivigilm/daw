using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace structalumnos
{
    class Program // Struct Alumnos
    {
        struct ficha_alumno
        {
            public string nombre;
            public int edad;
            public decimal calificacion;
        }

        /// <summary>
        /// Lee los datos de un nuevo alumno introducidos por teclado y los añade a la lista de alumnos.
        /// </summary>
        /// <param name="lista_alumno">Lista contenedora de los elementos del struct ficha_alumno.</param>
        static void LeeAlumnoLista(List<ficha_alumno> lista_alumno) // Ejercicio 1
        {
            ficha_alumno nuevo;

            Console.WriteLine("Dime el nombre.");
            nuevo.nombre = Console.ReadLine();
            Console.WriteLine("Dime la edad.");
            nuevo.edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime la calificación.");
            nuevo.calificacion = decimal.Parse(Console.ReadLine());

            lista_alumno.Add(nuevo);
        }

        /// <summary>
        /// Imprime por pantalla la lista lista_alumno.
        /// </summary>
        /// <param name="lista_alumno">Lista contenedora de los elementos del struct ficha_alumno.</param>
        static void ImprimeListaAlumnos(List<ficha_alumno> lista_alumno) // Ejercicio 2
        {
            int i;

            for(i = 0; i < lista_alumno.Count; i++)
            {
                Console.WriteLine("Nombre: " + lista_alumno[i].nombre);
                Console.WriteLine("Edad: " + lista_alumno[i].edad);
                Console.WriteLine("Calificación: " + lista_alumno[i].calificacion);
            }
        }

        /// <summary>
        /// Escribe la lista de alumnos en un fichero binario.
        /// </summary>
        /// <param name="lista_alumno">Lista de alumnos (structs).</param>
        /// <param name="nombrefichero">Nombre del fichero.</param>
        static void EscribeFicheroAlumnos(List<ficha_alumno> lista_alumno, string nombrefichero) // Ejercicio 3
        {
            int i;

            FileStream fs = new FileStream(nombrefichero, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            bw.Write(lista_alumno.Count);

            for (i = 0; i < lista_alumno.Count; i++)
            {                
                bw.Write(lista_alumno[i].nombre);
                bw.Write(lista_alumno[i].edad);
                bw.Write(lista_alumno[i].calificacion);
            }

            bw.Close();
            fs.Close();
        }

        /// <summary>
        /// Escribe la lista de alumnos en un fichero de texto.
        /// </summary>
        /// <param name="lista_alumno">Lista de alumnos (structs).</param>
        /// <param name="nombrefichero">Nombre del fichero.</param>
        static void EscribeFicheroAlumnosTXT(List<ficha_alumno> lista_alumno, string nombrefichero) // Ejercicio 3.2
        {
            StreamWriter sw = new StreamWriter(nombrefichero); // abro en modo escritura
            int i;

            sw.WriteLine(lista_alumno.Count);

            for(i = 0; i < lista_alumno.Count; i++)
            {
                sw.WriteLine(lista_alumno[i].nombre);
                sw.WriteLine(lista_alumno[i].edad);
                sw.WriteLine(lista_alumno[i].calificacion);
            }

            sw.Close();
        }

        /// <summary>
        /// Escribe la lista de alumnos en un fichero csv.
        /// </summary>
        /// <param name="lista_alumno">Lista de alumnos (structs).</param>
        /// <param name="nombrefichero">Nombre del fichero.</param>
        static void EscribeFicheroAlumnosCSV(List<ficha_alumno> lista_alumno, string nombrefichero) // Ejercicio 3.3
        {
            StreamWriter sw = new StreamWriter(nombrefichero);
            int i;
            for (i = 0; i < lista_alumno.Count; i++)
            {
                sw.Write(lista_alumno[i].nombre);
                sw.Write(";");
                sw.Write(lista_alumno[i].edad);
                sw.Write(";");
                sw.WriteLine(lista_alumno[i].calificacion);
            }

            sw.Close();
        }

        /// <summary>
        /// Guarda los datos de un fichero binario en una lista.
        /// </summary>
        /// <param name="lista_alumno">Lista de datos donde se guardarán los datos de los ficheros.</param>
        /// <param name="nombrefichero">Fichero con datos.</param>
        static void LeeFicheroAlumnos(List<ficha_alumno> lista_alumno, string nombrefichero) // Ejercicio 4
        {
            int i;
            ficha_alumno nuevo;            
            FileStream fs = new FileStream(nombrefichero, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            lista_alumno.Clear(); // vacío la lista donde guardaré los datos del fichero

            int numero = br.ReadInt32(); // cantidad de "alumnos" que habíamos guardado en el fichero (la primera línea contiene este número)

            for(i = 0 ; i < numero; i++) // recorro el flujo de datos de tres en tres (una vuelta del for, un alumno)
            {
                nuevo.nombre = br.ReadString();
                nuevo.edad = br.ReadInt32();
                nuevo.calificacion = br.ReadDecimal();
                lista_alumno.Add(nuevo);
            }

            br.Close();
            fs.Close();
        }

        /// <summary>
        /// Guarda los datos de un fichero de texto en una lista.
        /// </summary>
        /// <param name="lista_alumno">Lista de datos donde se guardarán los datos de los ficheros.</param>
        /// <param name="nombrefichero">Fichero con datos.</param>
        static void LeeFicheroAlumnosTXT(List<ficha_alumno> lista_alumno, string nombrefichero) // Ejercicio 4.2
        {
            StreamReader sr = new StreamReader(nombrefichero, Encoding.Default);
            lista_alumno.Clear();

            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }

            sr.Close();
        }

        /// <summary>
        /// Guarda los datos de un fichero csv en una lista.
        /// </summary>
        /// <param name="lista_alumno">Lista de datos donde se guardarán los datos de los ficheros.</param>
        /// <param name="nombrefichero">Fichero con datos.</param>
        static void LeeFicheroAlumnosCSV(List<ficha_alumno> lista_alumno, string nombrefichero) // Ejercicio 4.3
        {
            StreamReader sr = new StreamReader(nombrefichero, Encoding.Default);
            lista_alumno.Clear();
            string linea;
            string[] palabras;
            int i;
            ficha_alumno nuevo;

            while (!sr.EndOfStream)
            {
                linea = sr.ReadLine(); // guardo en una cadena la línea del archivo
                palabras = linea.Split(';'); // separo los elementos de la línea y los guardo en un array

                nuevo.nombre = palabras[0];
                nuevo.edad = int.Parse(palabras[1]);
                nuevo.calificacion = decimal.Parse(palabras[2]);

                lista_alumno.Add(nuevo);
            }

            sr.Close();
        }

        static void Main(string[] args)
        {
            List<ficha_alumno> lista_alumno = new List<ficha_alumno>();
            int opcion = -1;
          

            while (opcion != 0)
            {
                Console.WriteLine();
                Console.WriteLine("MENÚ");
                Console.WriteLine("====");
                Console.WriteLine();
                Console.WriteLine("1.- LeeAlumnoLista");
                Console.WriteLine("2.- ImprimeListaAlumnos");
                Console.WriteLine("3.- EscribeFicheroAlumnos");
                Console.WriteLine("32.- EscribeFicheroAlumnosTXT");
                Console.WriteLine("33.- EscribeFicheroAlumnosCSV");
                Console.WriteLine("4.- LeeFicheroAlumnos");
                Console.WriteLine("42.- LeeFicheroAlumnosTXT");
                Console.WriteLine("43.- LeeFicheroAlumnosCSV");
                Console.WriteLine("0.- Salir");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        {
                            Console.WriteLine();
                            Console.WriteLine(); Console.WriteLine("Has indicado que quieres introducir los datos de un estudiante nuevo.");
                            Console.WriteLine();
                            LeeAlumnoLista(lista_alumno);
                            Console.WriteLine();
                            Console.WriteLine("Estudiante grabado. Gracias por utilizar nuestros servicios.");
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine();
                            Console.WriteLine("Aquí tienes la lista de estudiantes contenidos en la BD:");
                            Console.WriteLine();
                            ImprimeListaAlumnos(lista_alumno);
                        }
                        break;
                    case 3:
                        {
                            string alumnos;
                            alumnos = "data.bin";

                            EscribeFicheroAlumnos(lista_alumno, alumnos);

                        }
                        break;
                    case 32:
                        {
                            string fichero = "estudiantes.txt";
                            EscribeFicheroAlumnosTXT(lista_alumno, fichero);
                        }
                        break;
                    case 33:
                        {
                            string fichero = "estudiantescsv.txt";
                            EscribeFicheroAlumnosCSV(lista_alumno, fichero);
                        }
                        break;
                    case 4:
                        {
                            string alumnos;
                            alumnos = "data.bin";

                            LeeFicheroAlumnos(lista_alumno, alumnos);

                            ImprimeListaAlumnos(lista_alumno);
                        }
                        break;
                    case 42:
                        {
                            string fichero = "estudiantes.txt";

                            LeeFicheroAlumnosTXT(lista_alumno, fichero);
                        }
                        break;
                    case 43:
                        {
                            string fichero = "estudiantescsv.txt";

                            LeeFicheroAlumnosCSV(lista_alumno, fichero);
                        }
                        break;
                    case 0:
                        {
                            Console.WriteLine("Gracias por utilizar nuestro programa.");
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Te has equivocado al pulsar los números. Vuelve a intentarlo.");
                        }
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
