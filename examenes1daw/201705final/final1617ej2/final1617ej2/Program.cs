using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final1617ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            LigaBaloncesto miliga = new LigaBaloncesto();

            miliga.CargarLiga("liga.csv");
            
            Console.Write(miliga.Clasificacion);

            Console.ReadKey();
        }
    }
}
