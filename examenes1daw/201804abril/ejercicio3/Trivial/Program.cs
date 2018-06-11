using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivial
{
    class Program
    {
        static void Main(string[] args)
        {
            // PRUEBAS VARIAS
            
            TarjetaPreguntas t = new TarjetaPreguntas();

            TarjetaPreguntas t2 = new TarjetaPreguntas("tarjeta1.trivial");
                        
            Console.WriteLine(t2.LeePregunta(Categoria.Geografia));
            Console.WriteLine(t2.LeeRespuesta(Categoria.Geografia));
            
            Trivial tri = new Trivial();

            string salir = "n";

            while(salir != "s")
            {
                TarjetaPreguntas t1 = tri.RobaTarjeta();
                Console.WriteLine(t1.LeePregunta(Categoria.Geografia));
                tri.DesordenaTarjetas();

                Console.WriteLine("s para salir");
                salir = Console.ReadLine();
            }

            Console.ReadKey();
        }
    }
}
