using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        struct DatoPrecipitacion
        {
            public string ciudad;
            public double[] litrosHora; // 7 doubles
        }
        
        /// <summary>
        /// Escribe un array de tipo double de x elementos pasado por parámetro en formato [a, b, c].
        /// </summary>
        /// <param name="a">Array introducido por parámetro.</param>
        static void EscribeArray(double[] a)
        {
            int i;

            Console.Write("[ ");

            for (i = 0; i < a.Length - 1; i++)
            {
                Console.Write(a[i] + ", ");
            }

            Console.Write(a[a.Length - 1]);

            Console.WriteLine("]");
        }

        /// <summary>
        /// Inserta un elemento nuevo al final de un array, agrandando este en una posición.
        /// </summary>
        /// <param name="a">Array introducido por referencia.</param>
        /// <param name="elemento">Valor del elemento que se quiere añadir al array.</param>
        static void InsertaAlFinalArray(ref double[] a, double elemento)
        {
            Array.Resize(ref a, a.Length + 1);

            a[a.Length - 1] = elemento;
        }

        /// <summary>
        /// Lee un dato introducido por teclado y lo añade a la lista de struct de precipitaciones.
        /// </summary>
        /// <param name="ppts">Lista de structs con datos de precipitaciones.</param>
        static void LeeDatoPrecipitacion(List<DatoPrecipitacion> ppts)
        {
            DatoPrecipitacion nuevodato; // nueva ocurrencia del struct
            int i;

            Console.WriteLine("Dime la ciudad de la muestra.");
            nuevodato.ciudad = Console.ReadLine();
            Console.WriteLine("Introduce los valores de precipitación de la semana.");
            nuevodato.litrosHora = new double[0];

            for(i = 0; i < 7; i++)
            {
                InsertaAlFinalArray(ref nuevodato.litrosHora, double.Parse(Console.ReadLine()));                
            }

            ppts.Add(nuevodato);

        }

        /// <summary>
        /// Imprime por pantalla la lista DatoPrecipitacion.
        /// </summary>
        /// <param name="lista_alumno">Lista contenedora de los elementos del struct DatoPrecipitacion.</param>
        static void ImprimePrecipitaciones(List<DatoPrecipitacion> ppts)
        {
            int i, j;
            
            for (i = 0; i < ppts.Count; i++) // para cada struct (elemento de la lista)
            {
                Console.Write("Ciudad: ".PadRight(5));
                Console.Write("Lun.".PadLeft(7));
                Console.Write("Mar.".PadLeft(9));
                Console.Write("Mier.".PadLeft(11));
                Console.Write("Jue.".PadLeft(13));
                Console.Write("Vie.".PadLeft(15));
                Console.Write("Sab.".PadLeft(17));
                Console.Write("Dom.".PadLeft(19));
                Console.WriteLine();
                Console.Write(ppts[i].ciudad.PadRight(5));
                
                /*
                 * YO QUERÍA PONER ESTO, PERO DA UN ERROR QUE NO ENTIENDO:
                 * 
                for(j = 0; j < 7; j++)
                {
                    Console.WriteLine(ppts.[i].litrosHora[j].ToString().PadLeft(2 + j));

                }
                
                */

                Console.Write(ppts[i].litrosHora[0].ToString().PadLeft(7));
                Console.Write(ppts[i].litrosHora[1].ToString().PadLeft(9));
                Console.Write(ppts[i].litrosHora[2].ToString().PadLeft(11));
                Console.Write(ppts[i].litrosHora[3].ToString().PadLeft(13));
                Console.Write(ppts[i].litrosHora[4].ToString().PadLeft(15));
                Console.Write(ppts[i].litrosHora[5].ToString().PadLeft(17));
                Console.Write(ppts[i].litrosHora[6].ToString().PadLeft(19));

            }    
            
        }        

        static void Main(string[] args)
        {
            List<DatoPrecipitacion> ppts = new List<DatoPrecipitacion>();
            
            int opcion = -1;
            
            while (opcion != 0)
            {
                Console.Clear();
                Console.WriteLine("MENU");
                Console.WriteLine("====");
                Console.WriteLine();
                Console.WriteLine("0.- Salir del programa");
                Console.WriteLine("1.- Añadir datos de precipitaciones");
                Console.WriteLine("2.- Imprimir los datos recogidos");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: LeeDatoPrecipitacion(ppts); break;
                    case 2: ImprimePrecipitaciones(ppts); break;
                    default: Console.WriteLine("error"); break;
                }

                Console.ReadKey();
            }

            Console.ReadKey();
        }
    }
}
