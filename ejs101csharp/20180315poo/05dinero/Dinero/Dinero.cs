using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net; // para trabajar con páginas web (y sacar el cambio actual)


namespace Dinero
{

    class Dinero
    {
        // ------------------------- PARTE ESTÁTICA -------------------------------

        // Atributo estático

        private static List<Moneda> lista_monedas;

        // Constructor estático

        /// <summary>
        /// Introduce los datos de las monedas (euro, dólar, yen) en el programa.
        /// </summary>
        static Dinero()
        {
            lista_monedas = new List<Moneda>();

            Moneda euros = new Moneda(TipoMoneda.Euro, 2, "€", 1, "EUR");
            lista_monedas.Add(euros);

            Moneda dolares = new Moneda(TipoMoneda.Dolar, 2, "$", 1.2382m, "USD");
            lista_monedas.Add(dolares);

            Moneda yens = new Moneda(TipoMoneda.Yen, 0, "¥", 132.2363m, "JPY");
            lista_monedas.Add(yens);
        }

        // Métodos estáticos (independientes de los objetos)

        /// <summary>
        /// Actualiza el valor del cambio de una moneda con respecto al euro.
        /// </summary>
        /// <param name="tipo">Tipo de moneda cuyo valor se quiere cambiar.</param>
        /// <param name="nuevovalor">Nuevo valor que se adjudica al cambio.</param>
        public static void ActualizaCambio(TipoMoneda tipo, decimal nuevovalor)
        {
            int i;

            for(i = 0; i < lista_monedas.Count; i++)
            {
                if(lista_monedas[i].Tmoneda == tipo)
                {
                    lista_monedas[i].CambioEuro = nuevovalor; // utilizo el "set" de la propiedad CambioEuro de la clase Moneda
                }
            }
        }

        /// <summary>
        /// Actualiza el cambio de las diferentes monedas consultando el actual en internet.
        /// </summary>
        public static void ActualizaListaInternet()
        {
            int i, j;
            decimal nuevocambio;
            string url, pagina, cambio, paginarecortada, primeraparte, segundaparte;
            // url original: https://www.x-rates.com/calculator/?from=EUR&to=USD&amount=1
            url = "https://www.x-rates.com/calculator/?from=EUR&to=";
            WebClient wc = new WebClient();

            for(i = 0; i < lista_monedas.Count; i++) // para cada moneda cambio la url: https://www.x-rates.com/calculator/?from=EUR&to=USD&amount=1
            {
                url = url + lista_monedas[i].Codigo; // sustituyo el USD por el código de la moneda cuyo cambio estamos actualizando
                pagina = wc.DownloadString(url); // guardo el código fuente de la página en una cadena

                paginarecortada = pagina.Substring(pagina.IndexOf("ccOutputRslt")); // elimino la parte de la página anterior al cambio q me interesa
                paginarecortada = paginarecortada.Substring(paginarecortada.IndexOf(">")+1); // me quedo con la cadena q empieza después del primer >

                primeraparte = paginarecortada.Remove(paginarecortada.IndexOf("<")); // elimina desde < hasta el final = se queda con el 1.229

                segundaparte = paginarecortada.Substring(paginarecortada.IndexOf(">") + 1); // me quedo con la cadena a partir de la 2ª parte del cambio
                segundaparte = paginarecortada.Remove(paginarecortada.IndexOf("<")); // me quedo con el 799

                cambio = primeraparte + segundaparte;

                // Ahora mi variable "cambio" guarda la cadena de texto "1.229799"
                nuevocambio = decimal.Parse(cambio); // guardo el cambio como variable decimal

                lista_monedas[i].CambioEuro = nuevocambio; // actualizo el cambio de la moneda
            }
        }

        // otros métodos privados para acceder a la info de la lista (debería ser privado, pero lo pongo público para probarla)

        /// <summary>
        /// Devuelve el objeto Moneda correspondiente a la moneda indicada.
        /// </summary>
        /// <param name="tipo">Tipo de moneda.</param>
        /// <returns>Objeto moneda (con sus cuatro características).</returns>
        public static Moneda DevuelveMoneda(TipoMoneda tipo)
        {
            Moneda buscada = null;
            int i;
            for(i = 0; i < lista_monedas.Count; i++)
            {
                if(lista_monedas[i].Tmoneda == tipo)
                {
                    buscada = new Moneda(lista_monedas[i].Tmoneda, lista_monedas[i].Decimales, lista_monedas[i].Simbolo, lista_monedas[i].CambioEuro, lista_monedas[i].Codigo);
                }
            }
            return buscada; // de esta forma devuelvo la moneda y con .simbolo, etc tendré la característica q quiera de la moneda
        }
        


        // ------------------------------- FIN PARTE ESTÁTICA -------------------------^

        // Atributos

        private decimal cantidad; // cantidad exacta de dinero (independiente del nº dec. de la moneda)
        private TipoMoneda moneda; // tipo de moneda que corresponde a esta cantidad de dinero

        // Constructores

        /// <summary>
        /// Inicializa (les da un valor) a los atributos.
        /// </summary>
        /// <param name="cantidad">Cantidad de dinero.</param>
        /// <param name="moneda">Tipo de moneda.</param>
        public Dinero(decimal cantidad, TipoMoneda moneda)
        {
            this.cantidad = cantidad;
            this.moneda = moneda;
        }

        /// <summary>
        /// Inicializa (les da un valor) a los atributos.
        /// </summary>
        /// <param name="cantidad">Cantidad de dinero.</param>
        /// <param name="moneda">Tipo de moneda.</param>
        public Dinero(int cantidad, TipoMoneda moneda)
        {
            this.cantidad = Convert.ToDecimal(cantidad);
            this.moneda = moneda;
        }

        /// <summary>
        /// Inicializa (les da un valor) a los atributos.
        /// </summary>
        /// <param name="cantidad">Cantidad de dinero.</param>
        /// <param name="moneda">Tipo de moneda.</param>
        public Dinero(double cantidad, TipoMoneda moneda)
        {
            this.cantidad = Convert.ToDecimal(cantidad);
            this.moneda = moneda;
        }

        // Propiedades        

        /// <summary>
        /// Devuelve o modifica la cantidad de dinero.
        /// </summary>
        public decimal Cantidad
        {
            get
            {
                return this.cantidad;
            }
            set
            {
                this.cantidad = value;
            }
        }

        /// <summary>
        /// Devuelve o modifica el tipo de moneda.
        /// </summary>
        public TipoMoneda Moneda
        {
            get
            {
                return this.moneda;
            }
            set
            {
                this.moneda = value;
            }
        }

        /// <summary>
        /// Devuelve la cantidad como double.
        /// </summary>
        public double ADouble
        {
            get
            {
                return Convert.ToDouble(this.cantidad);
            }
        }

        /// <summary>
        /// Devuelve la cantidad como entero.
        /// </summary>
        public int AEntero
        {
            get
            {
                return Convert.ToInt32(this.cantidad);
            }
        }

        // Métodos

        /// <summary>
        /// Muestra el valor contenido en cantidad con el número de decimales y el símbolo correspondientes.
        /// </summary>
        /// <returns>Cadena con la cantidad de dinero y el símbolo de la moneda.</returns>
        public override string ToString()
        {
            string dineroformateado;
            int i;
            dineroformateado = "";

            for(i = 0; i < lista_monedas.Count; i++)
            {
                //si mi tipo de moneda (el que tendré en la variable a la que le hago ToString()) es igual al elemento de la lista.
                if (lista_monedas[i].Tmoneda == this.moneda)
                {
                    if (moneda == TipoMoneda.Dolar) // si es dólar, el símbolo va delante
                    {
                        dineroformateado = lista_monedas[i].Simbolo + Math.Round(cantidad, lista_monedas[i].Decimales);
                    }
                    else // si no, va detrás
                    {
                        dineroformateado = Math.Round(cantidad, lista_monedas[i].Decimales) + lista_monedas[i].Simbolo;
                    }
                }

            }            

            return dineroformateado;
        }

        /// <summary>
        /// Convierte una cantidad de dinero de una moneda a otra.
        /// </summary>
        /// <param name="">Tipo de moneda a la que queremos convertir nuestra cantidad de dinero.</param>
        /// <returns>Número de tipo decimal correspondiente a nuestro dinero en la moneda dada.</returns>
        public decimal ValorEn(TipoMoneda monedafinal)
        {
            decimal miseuros, dinerofinal;
            int i;
            miseuros = 0;
            dinerofinal = 0;

            for(i = 0; i < lista_monedas.Count; i++)
            {
                if(this.moneda == lista_monedas[i].Tmoneda) // al encontrar en la lista la moneda q le paso
                {
                    miseuros = this.cantidad / lista_monedas[i].CambioEuro; // convierto la moneda a euros
                }
            }

            for(i = 0; i < lista_monedas.Count; i++)
            {
                if(monedafinal == lista_monedas[i].Tmoneda) // cuando encuentre la moneda a la q quiero cambiarla
                {
                    dinerofinal = miseuros * lista_monedas[i].CambioEuro;
                }
            }

            return dinerofinal;
        }

        /// <summary>
        /// Convierte una cantidad de dinero de una moneda a otra.
        /// </summary>
        /// <param name="nuevamoneda">Moneda a la que se convierte el dinero dado.</param>
        /// <returns>Objeto del tipo Dinero con el dinero dado convertido a la moneda dada.</returns>
        public Dinero ConvierteEn(TipoMoneda nuevamoneda)
        {
            Dinero d = new Dinero(this.cantidad, this.moneda);            
            Dinero f = new Dinero(d.ValorEn(nuevamoneda), nuevamoneda);
            return f;
        }

        /// <summary>
        /// Escribe la cantidad representada en la moneda dada.
        /// </summary>
        /// <param name="">Tipo de moneda a la que se quiere pasar la moneda.</param>
        /// <returns>Cadena con la cantidad de dinero en la moneda dada (con símbolo incluido).</returns>
        public string ToString(TipoMoneda nuevamoneda)
        { // le pasamos un objeto Dinero (cantidad, moneda)
            Dinero d = new Dinero(this.cantidad, this.moneda);

            Dinero f = new Dinero(d.ValorEn(nuevamoneda), nuevamoneda); // dinero convertido

            return f.ToString();
        }
        


        // Operadores

        /// <summary>
        /// Suma dos cantidades de dinero, sin importar si están expresadas en la misma moneda..
        /// </summary>
        /// <param name="d1">Primera cantidad de dinero.</param>
        /// <param name="d2">Segunda cantidad de dinero.</param>
        /// <returns>Suma de ambas cantidades en la moneda de la primera.</returns>
        public static Dinero operator +(Dinero d1, Dinero d2)
        {
            Dinero suma, d2convertido;

            if(d1.moneda == d2.moneda)
            {
                suma = new Dinero(d1.cantidad + d2.cantidad, d1.moneda);
            }
            else // son diferentes monedas
            {
                d2convertido = d2.ConvierteEn(d1.moneda);
                suma = new Dinero(d1.cantidad + d2convertido.cantidad, d1.moneda);
            }

            return suma;
        }

        /// <summary>
        /// Resta de dos cantidades de dinero, sin importar si están expresadas en la misma moneda.
        /// </summary>
        /// <param name="d1">Primera cantidad de dinero.</param>
        /// <param name="d2">Segunda cantidad de dinero.</param>
        /// <returns>Resta de ambas cantidades en la moneda de la primera.</returns>
        public static Dinero operator -(Dinero d1, Dinero d2)
        {
            Dinero resta, d2convertido;

            if(d1.moneda == d2.moneda)
            {
                resta = new Dinero(d1.cantidad - d2.cantidad, d1.moneda);
            }
            else
            {
                d2convertido = d2.ConvierteEn(d1.moneda);
                resta = new Dinero(d1.cantidad - d2convertido.cantidad, d1.moneda);
            }

            return resta;
        }

        /// <summary>
        /// Producto de una cantidad de dinero por un número decimal.
        /// </summary>
        /// <param name="d">Cantidad de dinero.</param>
        /// <param name="factor">Número por el que se multiplicará el dinero.</param>
        /// <returns>Cantidad de dinero resultante.</returns>
        public static Dinero operator *(Dinero d, decimal factor)
        {
            Dinero producto;

            producto = new Dinero(d.cantidad * factor, d.moneda);
            return producto;
        }

        /// <summary>
        /// División de una cantidad de dinero entre un número decimal.
        /// </summary>
        /// <param name="d">Cantidad de dinero.</param>
        /// <param name="factor">Número por el que se dividirá el dinero.</param>
        /// <returns>Cantidad de dinero resultante.</returns>
        public static Dinero operator /(Dinero d, decimal divisor)
        {
            Dinero cociente;
            cociente = new Dinero(d.cantidad / divisor, d.moneda);
            return cociente;
        }

        /// <summary>
        /// Calcula si las cantidades de dinero son iguales.
        /// </summary>
        /// <param name="d1">Primera cantidad de dinero.</param>
        /// <param name="d2">Segunda cantidad de dinero.</param>
        /// <returns>Devuelve "true" si es el mismo dinero, "false" si no.</returns>
        public static bool operator ==(Dinero d1, Dinero d2)
        {
            bool igual = false;

            if(d1.cantidad == d2.ConvierteEn(d1.moneda).cantidad)
            {
                igual = true;
            }

            return igual;
        }

        /// <summary>
        /// Calcula si las cantidades de dinero son distintas.
        /// </summary>
        /// <param name="d1">Primera cantidad de dinero.</param>
        /// <param name="d2">Segunda cantidad de dinero.</param>
        /// <returns>Devuelve "true" si no es el mismo dinero, "false" si sí.</returns>
        public static bool operator !=(Dinero d1, Dinero d2)
        {
            bool distinto = false;

            if (d1.cantidad != d2.ConvierteEn(d1.moneda).cantidad)
            {
                distinto = true;
            }

            return distinto;
        }

        /// <summary>
        /// Calcula si la primera cantidad de dinero es menor que la segunda.
        /// </summary>
        /// <param name="d1">Primera cantidad de dinero.</param>
        /// <param name="d2">Segunda cantidad de dinero.</param>
        /// <returns>Devuelve "true" si la primera cantidad de dinero es menor que la segunda, "false" si no.</returns>
        public static bool operator <(Dinero d1, Dinero d2)
        {
            bool menor = false;

            if(d1.cantidad < d2.ConvierteEn(d1.moneda).cantidad)
            {
                menor = true;
            }

            return menor;
        }

        /// <summary>
        /// Calcula si la primera cantidad de dinero es mayor que la segunda.
        /// </summary>
        /// <param name="d1">Primera cantidad de dinero.</param>
        /// <param name="d2">Segunda cantidad de dinero.</param>
        /// <returns>Devuelve "true" si la primera cantidad de dinero es mayor que la segunda, "false" si no.</returns>
        public static bool operator >(Dinero d1, Dinero d2)
        {
            bool mayor = false;

            if(d1.cantidad > d2.ConvierteEn(d1.moneda).cantidad)
            {
                mayor = true;
            }

            return mayor;
        }

        /// <summary>
        /// Calcula si la primera cantidad de dinero es menor o igual que la segunda.
        /// </summary>
        /// <param name="d1">Primera cantidad de dinero.</param>
        /// <param name="d2">Segunda cantidad de dinero.</param>
        /// <returns>Devuelve "true" si la primera cantidad de dinero es menor o igual que la segunda, "false" si no.</returns>
        public static bool operator <=(Dinero d1, Dinero d2)
        {
            bool menoroigual = false;

            if(d1.cantidad <= d2.ConvierteEn(d1.moneda).cantidad)
            {
                menoroigual = true;
            }

            return menoroigual;
        }

        /// <summary>
        /// Calcula si la primera cantidad de dinero es mayor o igual que la segunda.
        /// </summary>
        /// <param name="d1">Primera cantidad de dinero.</param>
        /// <param name="d2">Segunda cantidad de dinero.</param>
        /// <returns>Devuelve "true" si la primera cantidad de dinero es mayor o igual que la segunda, "false" si no.</returns>
        public static bool operator >=(Dinero d1, Dinero d2)
        {
            bool mayoroigual = false;

            if(d1.cantidad >= d2.ConvierteEn(d1.moneda).cantidad)
            {
                mayoroigual = true;
            }

            return mayoroigual;
        }

        //
    }
}
