using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Dinero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // cambio la codificación de la consola para que me acepte el símbolo "€"
            /*          
            WebClient wc = new WebClient(); // prueba de webclient

            string pagina;
            pagina = wc.DownloadString("https://www.x-rates.com/calculator/?from=EUR&to=USD&amount=1"); // guardo el código fuente de la web
            */

            // PRUEBAS (las que yo quiera)
            int opcion;
            
            Console.WriteLine("MENÚ");
            Console.WriteLine("====");
            Console.WriteLine();
            Console.WriteLine("1.- Actualiza el cambio de una moneda"); // Prueba ActualizaCambio y DevuelveMoneda
            Console.WriteLine("2.- Muestra mi dinero bonito"); // Prueba ToString()
            Console.WriteLine("3.- Muestra mi dinero en otra moneda"); // Prueba ValorEn y ToString(TipoMoneda)
            Console.WriteLine("4.- Conversor de moneda"); // Prueba ConvierteEn y ToString()
            Console.WriteLine("5.- Suma dinero"); // Prueba el operador suma
            Console.WriteLine(); // Me falta probar otros operadores y cosillas menos importantes xD
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("20.- Obtén el cambio actualizado de una moneda"); // Prueba ActualizaListaInternet
            
            opcion = int.Parse(Console.ReadLine());
            
            switch (opcion)
            {
                case 1:
                    {
                        int idmoneda;
                        TipoMoneda tipo;
                        decimal nuevocambio;
                        Console.WriteLine("¿De qué moneda quieres actualizar el cambio? (0: euro, 1: dólar, 2: yen)");
                        string[] simbolos = { "€", "$", "¥" };
                        idmoneda = int.Parse(Console.ReadLine()); // guardo el código de la moneda
                        tipo = (TipoMoneda)idmoneda; // convierto el código de la moneda en el tipo de moneda
                        Moneda m = Dinero.DevuelveMoneda(tipo); // guardo en "m" los valores de la moneda elegida (ej. yen)
                        //m.simbolo
                        
                        Console.WriteLine("El cambio actual del " + tipo + " es de: " + m.CambioEuro + " euros");
                        Console.WriteLine("¿Cuál es la nueva cantidad de euros que nos darán al cambio por 1 " + simbolos[idmoneda] + "?");
                        nuevocambio = decimal.Parse(Console.ReadLine());

                        Dinero.ActualizaCambio(tipo, nuevocambio);

                        m = Dinero.DevuelveMoneda(tipo); // debo volver a guardar los datos del yen en "m" porque si no cogerá el cambio que tenía guardado de antes
                        Console.WriteLine();
                        Console.WriteLine("El cambio actual del " + tipo + " es de: " + m.CambioEuro + " euros");
                    }                    
                    break;
                case 2:
                    {
                        decimal cantidad;
                        int moneda;
                        TipoMoneda tipo;
                        Console.WriteLine("¿Cuánto dinero tienes? (Dame un número.)");
                        cantidad = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("¿En qué moneda lo tienes? (0: euro, 1: dólar, 2: yen)");
                        moneda = int.Parse(Console.ReadLine());
                        tipo = (TipoMoneda)moneda; // meto el 0/1/2 en el enumerado y saco la moneda
                        Dinero d = new Dinero(cantidad, tipo);
                        Console.WriteLine("Tienes: " + d.ToString());
                    }
                    break;
                case 3:
                    {
                        decimal cantidad;
                        int moneda, monedafinal;
                        TipoMoneda tipo, tipofinal;
                        Console.WriteLine("¿Cuánto dinero tienes? (Dame un número.)");
                        cantidad = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("¿En qué moneda lo tienes? (0: euro, 1: dólar, 2: yen)");
                        moneda = int.Parse(Console.ReadLine());
                        tipo = (TipoMoneda)moneda;
                        Dinero d = new Dinero(cantidad, tipo);
                        Console.WriteLine("¿En qué moneda lo quieres ver? (0: euro, 1: dólar, 2: yen)");
                        monedafinal = int.Parse(Console.ReadLine());
                        tipofinal = (TipoMoneda)monedafinal;
                        Console.WriteLine("Tienes: " + d.ToString(tipofinal));
                    }
                    break;
                case 4:
                    {
                        Dinero d;
                        decimal cantidadinicial, cantidadfinal;
                        int monedainicial, monedafinal;
                        TipoMoneda tipoinicial, tipofinal;                      
                        Console.WriteLine("¿Cuánto dinero tienes? (Dame un número.)");
                        cantidadinicial = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("¿En qué moneda lo tienes? (0: euro, 1: dólar, 2: yen)");
                        monedainicial = int.Parse(Console.ReadLine());
                        tipoinicial = (TipoMoneda)monedainicial;
                        d = new Dinero(cantidadinicial, tipoinicial);
                        Console.WriteLine("Tienes: " + d.ToString());
                        Console.WriteLine("¿A qué moneda lo quieres convertir? (0: euro, 1: dólar, 2: yen)");
                        monedafinal = int.Parse(Console.ReadLine());
                        tipofinal = (TipoMoneda)monedafinal;
                        cantidadfinal = d.ValorEn(tipofinal);

                        d = d.ConvierteEn(tipofinal); // guardo el dinero convertido

                        Console.WriteLine("Tienes: " + d.ToString());
                    }
                    break;
                case 5:
                    {
                        // Guardo las dos cantidades de dinero con su moneda
                        Dinero d1, d2, dfinal;
                        decimal cantidad1, cantidad2;
                        int moneda1, moneda2;
                        TipoMoneda tipo1, tipo2;
                        Console.WriteLine("Dime, por este orden, cantidad de dinero, moneda de la primera hucha y cantidad de dinero y moneda de la segunda.");
                        Console.WriteLine("Para indicar la moneda utiliza el siguiente código: (0: euro, 1: dólar, 2: yen)");
                        cantidad1 = decimal.Parse(Console.ReadLine());
                        moneda1 = int.Parse(Console.ReadLine());
                        tipo1 = (TipoMoneda)moneda1;
                        cantidad2 = decimal.Parse(Console.ReadLine());
                        moneda2 = int.Parse(Console.ReadLine());
                        tipo2 = (TipoMoneda)moneda2;
                        d1 = new Dinero(cantidad1, tipo1);
                        d2 = new Dinero(cantidad2, tipo2);

                        // Las sumo
                        dfinal = d1 + d2;
                        Console.WriteLine("Tu saldo es de: " + dfinal.ToString());
                    }
                    break;
                case 20:
                    {
                        Dinero.ActualizaListaInternet(); // actualizo el cambio
                        Moneda t = Dinero.DevuelveMoneda(TipoMoneda.Dolar); // guardo una moneda en mi variable
                        Console.WriteLine("1€ son " + t.CambioEuro + " dólares.");
                    }
                    break;
                default: break;
            }

            Console.ReadKey();
        }
    }
}
