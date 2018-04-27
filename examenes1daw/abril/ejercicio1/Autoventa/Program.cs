using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoventa
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pruebas

            AutoVenta a = new AutoVenta();

            a.CargaCSV("Coches.csv");
            a.ImprimeListado();

            Console.ReadKey();

        }
    }
}
