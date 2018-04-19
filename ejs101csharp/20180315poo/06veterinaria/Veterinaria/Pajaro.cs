using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    enum EspeciePajaro
    {
        Canario, Periquito, Agapornis // canario: 0
    }

    class Pajaro : Animal
    {
        // Atributos

        private EspeciePajaro especie;
        private bool cantor;

        // Constructor

        /// <summary>
        /// Crea un nuevo objeto de la clase Pajaro.
        /// </summary>
        /// <param name="nombre">Nombre del pájaro.</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento del pájaro.</param>
        /// <param name="peso">Peso del pájaro.</param>
        /// <param name="especie">Especie del pájaro.</param>
        /// <param name="cantor">"true" si el pájaro canta mucho, "false" si no</param>
        public Pajaro(string nombre, DateTime fechaNacimiento, double peso, EspeciePajaro especie, bool cantor) : base(nombre, fechaNacimiento, peso)
        {
            this.especie = especie;
            this.cantor = cantor;
        }

        // Propiedades

        /// <summary>
        /// Devuelve la especie del pájaro.
        /// </summary>
        public EspeciePajaro Especie
        {
            get
            {
                return this.especie;
            }
        }

        /// <summary>
        /// Devuelve "true" si el pájaro canta mucho, "false" si no.
        /// </summary>
        public bool Cantor
        {
            get
            {
                return this.cantor;
            }
        }

        // Métodos

        /// <summary>
        /// Crea una cadena con los atributos del pájaro.
        /// </summary>
        /// <returns>Cadena formateada para su impresión (un atributo por línea).</returns>
        public override string ToString()
        {
            string atributospajaro;

            atributospajaro = "Nombre: " + this.nombre + "\n" + "Fecha de nacimiento: " + this.fechaNacimiento + "\n" + "Peso: " + this.peso + "\n" + "Especie: " + this.especie + "\n" + "¿Es cantor? " + this.cantor + "\n" + "Comentarios: " + this.comentarios;

            return atributospajaro;
        }

    }
}
