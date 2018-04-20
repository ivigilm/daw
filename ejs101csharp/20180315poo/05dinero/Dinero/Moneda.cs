using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinero
{
    /// <summary>
    /// Tipos de moneda predefinidos.
    /// </summary>
    enum TipoMoneda
    {
        Euro, Dolar, Yen
    }

    class Moneda
    {
        // Atributos

        private TipoMoneda tmoneda; // tipo de moneda: euro, etc. (enumerado)
        private int decimales; // cuántos decimales utiliza esa moneda
        private string simbolo; // símbolo q representa la moneda ($, €)
        private decimal cambioEuro; // cuántas monedas son 1€
        private string codigo; // código de la moneda (EUR, GBP, USD)

        // Constructores        

        /// <summary>
        /// Genera un nuevo objeto Moneda, dados sus cuatro atributos.
        /// </summary>
        /// <param name="tmoneda">Tipo de moneda (euro, dólar o yen).</param>
        /// <param name="decimales">Número de decimales de la moneda.</param>
        /// <param name="simbolo">Símbolo de la moneda.</param>
        /// <param name="cambioEuro">Cambio que corresponde a 1€.</param>
        public Moneda(TipoMoneda tmoneda, int decimales, string simbolo, decimal cambioEuro, string codigo)
        {
            this.tmoneda = tmoneda;
            this.codigo = codigo;

            if(decimales > 4)
            {
                throw new Exception("No creo que tu moneda utilice más de cuatro cifras decimales. Por favor, comprueba tus datos y comunica un bug si necesitas más.");
            }
            else
            {
                this.decimales = decimales;
            }

            if(simbolo == "")
            {
                throw new Exception("¡No puedo utilizar un símbolo inexistente!");
            }
            else
            {
                this.simbolo = simbolo;
            }

            if(cambioEuro < 0)
            {
                throw new Exception("No me creo que 1€ equivalga a una cifra negativa de tu moneda.");
            }
            else
            {
                this.cambioEuro = cambioEuro;
            }
        }

        // Propiedades: las propiedades deben empezar por mayúscula

        /// <summary>
        /// Devuelve el tipo de moneda.
        /// </summary>
        public TipoMoneda Tmoneda
        {
            get
            {
                return this.tmoneda;
            }
        }

        /// <summary>
        /// Devuelve el número de decimales que tiene la moneda.
        /// </summary>
        public int Decimales
        {
            get
            {
                return this.decimales;
            }
        }

        /// <summary>
        /// Devuelve el símbolo de la moneda.
        /// </summary>
        public string Simbolo
        {
            get
            {
                return this.simbolo;
            }
        }

        /// <summary>
        /// Devuelve el valor del cambio o lo modifica.
        /// </summary>
        public decimal CambioEuro
        {
            get
            {
                return this.cambioEuro;
            }
            set
            {
                if(value >= 0)
                {
                    this.cambioEuro = value;
                }
                else
                {
                    throw new Exception("El valor del cambio no puede ser negativo.");
                }
            }
        }

        /// <summary>
        /// Devuelve el código de la moneda.
        /// </summary>
        public string Codigo
        {
            get
            {
                return this.codigo;
            }
        }
    }
}
