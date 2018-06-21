using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej4tribunalprofes
{
    class Program
    {
        static void Main(string[] args)
        {
            string fichero;
            Console.WriteLine("Dime el nombre del fichero de profesores");
            fichero = Console.ReadLine();

            Tribunal t = new Tribunal(fichero); // Creo un nuevo tribunal
            
            t.EligeTribunal();

            // t.EligeTribunalPro();

            Console.ReadLine();
        }
    }
}
