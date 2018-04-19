using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    enum RazaGato
    {
        Comun = 1, Siames, Persa, Angora, ScottishFold
    }

    class Gato : Animal // heredada de la clase Animal
    {
        // Atributos

        private RazaGato raza;
        private string microchip;

        // Constructor

        /// <summary>
        /// Crea un nuevo objeto de la clase Gato.
        /// </summary>
        /// <param name="nombre">Nombre del gato.</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento del gato.</param>
        /// <param name="peso">Peso del gato.</param>
        /// <param name="raza">Raza del gato.</param>
        /// <param name="microchip">Microchip del gato.</param>
        public Gato(string nombre, DateTime fechaNacimiento, double peso, RazaGato raza, string microchip) :base(nombre, fechaNacimiento, peso)
        {
            this.raza = raza;
            this.microchip = microchip;
        }

        // Propiedades

        /// <summary>
        /// Devuelve la raza del gato.
        /// </summary>
        public RazaGato Raza
        {
            get
            {
                return this.raza;
            }
        }

        /// <summary>
        /// Devuelve el microchip del gato.
        /// </summary>
        public string Microchip
        {
            get
            {
                return this.microchip;
            }
        }

        // Métodos

        /// <summary>
        /// Crea una cadena con los atributos del gato.
        /// </summary>
        /// <returns>Cadena formateada con un atributo por línea.</returns>
        public override string ToString()
        {
            string atributosgato;

            atributosgato = "Nombre: " + this.nombre + "\n" + "Fecha de nacimiento: " + this.fechaNacimiento + "\n" + "Peso: " + this.peso + "\n" + "Raza: " + this.raza + "\n" + "Microchip: " + this.microchip + "\n" + "Comentarios: " + this.comentarios;

            return atributosgato;
        }
    }
}
