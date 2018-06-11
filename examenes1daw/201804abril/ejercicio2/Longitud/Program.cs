using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longitud
{
    class Program
    {
        static void Main(string[] args)
        {
            Longitud l = new Longitud(3, UnidadLongitud.yardas);
            Console.WriteLine("Longitud original: " + l.ToString());
            Console.WriteLine("Cantidad: " + l.Cantidad.ToString());
            Console.WriteLine("Unidades: " + l.Unidad.ToString());
            Console.WriteLine();
            Longitud l2 = l.ValorEnMetros;
            Console.WriteLine("Longitud en metros: " + l2.ToString());
            Console.WriteLine();

            Longitud uno = new Longitud(55, UnidadLongitud.pies);
            Longitud dos = new Longitud(200, UnidadLongitud.pulgadas);
            Console.WriteLine("Longitud uno: " + uno.ToString());
            Console.WriteLine("Longitud dos: " + dos.ToString());
            Console.WriteLine("Suma: " + (uno+dos).ToString() );
            Console.WriteLine("Resta: " + (uno-dos).ToString());
            Console.WriteLine("Multiplicación (uno * 5): " + (uno * 5).ToString());
            Console.WriteLine("División (uno / 5): " + (uno / 5).ToString());
            Console.WriteLine("¿Es uno igual a dos? " + (uno == dos));
            Console.WriteLine("¿Es uno distinto de dos? " + (uno != dos));
            Console.WriteLine("¿Es uno mayor que dos? " + (uno > dos));
            Console.WriteLine("¿Es uno menor que dos? " + (uno < dos));
            Console.WriteLine("¿Es uno mayor o igual que dos? " + (uno >= dos));
            Console.WriteLine("¿Es uno menor o igual que dos? " + (uno <= dos));
            Longitud prueba = new Longitud(1, UnidadLongitud.metros);
            Console.WriteLine("¿Cuánto es 1m más 8? " + (prueba+8).ToString());
            Console.WriteLine("¿Cuánto es 1m más 8.1? " + (prueba + 8.1).ToString());

            Console.WriteLine();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
