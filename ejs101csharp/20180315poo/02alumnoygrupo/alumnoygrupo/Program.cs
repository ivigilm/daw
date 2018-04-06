using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alumnoygrupo
{
    class Program
    {
        static void Main(string[] args)
        {
            Grupo g = new Grupo();

            int opcion = -1;

            while (opcion != 0)
            {
                Console.WriteLine();
                Console.WriteLine("MENÚ");
                Console.WriteLine("====");
                Console.WriteLine();
                Console.WriteLine("1.- InsertaAlumnoLista");
                Console.WriteLine("2.- Imprime");
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
                            string nombre;
                            int edad;
                            decimal nota;
                            Console.WriteLine();
                            Console.WriteLine("Has indicado que quieres introducir los datos de un estudiante nuevo. Dime su nombre.");
                            Console.WriteLine();
                            nombre = Console.ReadLine();
                            Console.WriteLine("Dime su edad.");
                            edad = int.Parse(Console.ReadLine());
                            Console.WriteLine("Dime su nota.");
                            nota = decimal.Parse(Console.ReadLine());
                            g.InsertaAlumnoLista(nombre, edad, nota);
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
                            Console.WriteLine(g.Imprime());
                        }
                        break;
                    case 3:
                        {
                            string alumnos;
                            alumnos = "data.bin";

                            g.EscribeFichero(alumnos);
                        }
                        break;
                    case 32:
                        {
                            string fichero = "estudiantes.txt";

                            g.EscribeFicheroTXT(fichero);
                        }
                        break;
                    case 33:
                        {
                            string fichero = "estudiantes.csv";

                            g.EscribeFicheroCSV(fichero);
                        }
                        break;
                    case 4:
                        {
                            string alumnos;
                            alumnos = "data.bin";

                            g.LeeFichero(alumnos);
                        }
                        break;
                    case 42:
                        {
                            string fichero = "estudiantes.txt";

                            g.LeeFicheroTXT(fichero);
                        }
                        break;
                    case 43:
                        {
                            string fichero = "estudiantes.csv";

                            g.LeeFicheroCSV(fichero);
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
