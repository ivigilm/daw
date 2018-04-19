using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    enum RazaPerro
    {
        PastorAleman=1, Husky, FoxTerrier, Dalmata, SanBernardo
    }

    class Perro : Animal // de esta forma indico que Perro es hija de Animal
    {
        // Atributos

        private RazaPerro raza;
        private string microchip;

        // Constructor

        /// <summary>
        /// Crea un nuevo objeto de la clase Perro.
        /// </summary>
        /// <param name="nombre">Nombre del perro.</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento del perro.</param>
        /// <param name="peso">Peso del perro.</param>
        /// <param name="raza">Raza del perro.</param>
        /// <param name="microchip">Microchip del perro.</param>
        public Perro(string nombre, DateTime fechaNacimiento, double peso, RazaPerro raza, string microchip) :base(nombre, fechaNacimiento, peso)
        {
            this.raza = raza;
            this.microchip = microchip;
        }

        // Propiedades

        /// <summary>
        /// Devuelve la raza del perro.
        /// </summary>
        public RazaPerro Raza
        {
            get
            {
                return this.raza;
            }
        }

        /// <summary>
        /// Devuelve el microchip del perro.
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
        /// Crea una cadena con los atributos del perro.
        /// </summary>
        /// <returns>Cadena formateada con un atributo por línea.</returns>
        public override string ToString()
        {
            string atributosperro;

            atributosperro = "Nombre: " + this.nombre + "\n" + "Fecha de nacimiento: " + this.fechaNacimiento + "\n" + "Peso: " + this.peso + "\n" + "Raza: " + this.raza + "\n" + "Microchip: " + this.microchip + "\n" + "Comentarios: " + this.comentarios;

            return atributosperro;
        }
    }
}
