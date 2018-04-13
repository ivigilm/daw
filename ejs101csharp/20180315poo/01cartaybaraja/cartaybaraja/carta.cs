using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cartaybaraja
{
    /// <summary>
    /// Información relativa a una carta de la baraja española.
    /// </summary>
    class Carta
    {
        // Atributos

        private int numero; // representa el número de la carta (8: sota, 9: caballo, 10: rey)
        private int palo; // representa el palo de la carta (0: oros, 1: copas, 2: espadas, 3: bastos)

        // Constructores

        /// <summary>
        /// Nos crea una carta con el número y el palo que le pasamos.
        /// </summary>
        /// <param name="numero">Un valor entero entre 1 y 10 (8=sota, 9=caballo, 10=rey).</param>
        /// <param name="palo">Un valor entero entre 0 y 3 (0=oros, 1=copas, 2=espadas, 3=bastos).</param>
        public Carta(int numero, int palo) // crea una carta, dados el palo y el número
        {
            if(numero > 0 && numero <= 10 && palo >= 0 && palo <= 3) // compruebo que los valores introducidos son correctos
            {
                this.numero = numero; // this.numero es el atributo "numero" definido en la presente clase ("Carta")
                this.palo = palo; // = palo es el parámetro introducido por el usuario al utilizar el constructor Carta
            }
            else // en caso de valor incorrecto, lanzo una excepción
            {
                throw new Exception("Los valores introducidos para la nueva carta son incorrectos.");
            }
        }

        /// <summary>
        /// Crea una carta de la baraja española dada su posición (de la 1 a la 40).
        /// </summary>
        /// <param name="id">Valor entero entre el 1 y el 40 (1: as de oros, 40: rey de bastos).</param>
        public Carta(int id) // crea una carta, dado el id de esta
        {
            if(id >= 1 && id <= 40) // compruebo que el número introducido como id es correcto
            {
                this.palo = ( (id-1)/10 ); // fórmula para hallar el palo
                this.numero = id - 10 * this.palo; // fórmula para hallar el número

                /* Mejor esta forma de obtener el número porque no depende del palo:
                this.numero = ((id - 1) % 10) + 1;
                */
            }
            else
            {
                throw new Exception("Esta carta no existe en la baraja española (solo hay 40 cartas).");
            }
        }

        // Propiedades
        // para utilizar una propiedad de un objeto de la clase Carta: micarta.nombredelapropiedad (ej: trespicas.NombreNumero)

        /// <summary>
        /// Devuelve el número de la carta (1 al 10).
        /// </summary>
        public int Numero
        {
            get
            {
                return this.numero;
            }
        }

        /// <summary>
        /// Devuelve el número que representa al palo de la carta (0 al 3).
        /// </summary>
        public int Palo
        {
            get
            {
                return this.palo;
            }
        }

        /// <summary>
        /// Devuelve el número de la carta en formato texto.
        /// </summary>
        public string NombreNumero
        {
            get
            {
                string nombre = "";
                
                switch (this.numero)
                {
                    case 1: nombre = "as"; break;
                    case 2: nombre = "dos"; break;
                    case 3: nombre = "tres"; break;
                    case 4: nombre = "cuatro"; break;
                    case 5: nombre = "cinco"; break;
                    case 6: nombre = "seis"; break;
                    case 7: nombre = "siete"; break;
                    case 8: nombre = "sota"; break;
                    case 9: nombre = "caballo"; break;
                    case 10: nombre = "rey"; break;
                }

                return nombre;

            }
        }

        /// <summary>
        /// Devuelve el nombre del palo.
        /// </summary>
        public string NombrePalo
        {
            get
            {
                string[] palos = { "oros", "copas", "espadas", "bastos" };

                return palos[this.palo];
            }
        }

        /// <summary>
        /// Devuelve el nombre de la carta.
        /// </summary>
        public string NombreCarta
        {
            get
            {
                return NombreNumero + " de " + NombrePalo;
            }
        }

        /// <summary>
        /// Devuelve el valor de la carta en el tute.
        /// </summary>
        public int ValorTute
        {
            get
            {
                int valor;

                switch (this.numero)
                {
                    case 1: valor = 11; break;
                    case 3: valor = 10; break;
                    case 8: valor = 2; break;
                    case 9: valor = 3; break;
                    case 10: valor = 4; break;
                    default: valor = 0; break;
                }

                return valor;
            }
        }

        /// <summary>
        /// Devuelve el valor de la carta en el mus.
        /// </summary>
        public int ValorMus
        {
            get
            {
                int valor;

                switch (this.numero)
                {
                    case 2: valor = 1; break;
                    case 3: valor = 10; break;
                    case 8: valor = 10; break;
                    case 9: valor = 10; break;
                    default: valor = this.numero; break;
                }

                return valor;
            }
        }

        /// <summary>
        /// Devuelve el valor de la carta en el juego de las 7 y media.
        /// </summary>
        public double Valor7ymedia
        {
            get
            {
                double valor;

                switch (this.numero)
                {
                    case 8: valor = 0.5; break;
                    case 9: valor = 0.5; break;
                    case 10: valor = 0.5; break;
                    default: valor = this.numero; break;
                }

                return valor;
            }
        }

        /// <summary>
        /// Sustituye el tradicional ToString() (que devolvería "Carta.carta32").
        /// </summary>
        /// <returns>Cadena con el nombre de la carta (ej. "tres de tréboles").</returns>
        public override string ToString()
        {
            return NombreCarta;
        }

        
    }
}
