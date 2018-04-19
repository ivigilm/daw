using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    enum EspecieReptil
    {
        Tortuga, Iguana, DragonDeKomodo // tortuga: 0
    }

    class Reptil : Animal // heredada de Animal
    {
        // Atributos

        private EspecieReptil especie;
        private bool venenoso;

        // Constructor

        /// <summary>
        /// Crea un nuevo objeto de la clase Reptil.
        /// </summary>
        /// <param name="nombre">Nombre del reptil.</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento del reptil.</param>
        /// <param name="peso">Peso del reptil.</param>
        /// <param name="especie">Especie del reptil.</param>
        /// <param name="venenoso">"true" si el reptil es venenoso, "false" si no</param>
        public Reptil(string nombre, DateTime fechaNacimiento, double peso, EspecieReptil especie, bool venenoso) : base(nombre, fechaNacimiento, peso)
        {
            this.especie = especie;
            this.venenoso = venenoso;
        }

        // Propiedades

        /// <summary>
        /// Devuelve la especie del reptil.
        /// </summary>
        public EspecieReptil Especie
        {
            get
            {
                return this.especie;
            }
        }

        /// <summary>
        /// Devuelve "true" si el reptil es venenoso y "false" si no.
        /// </summary>
        public bool Venenoso
        {
            get
            {
                return this.venenoso;
            }
        }

        // Métodos

        /// <summary>
        /// Crea una cadena con los atributos del reptil.
        /// </summary>
        /// <returns>Cadena formateada para su impresión (un atributo por línea).</returns>
        public override string ToString()
        {
            string atributosreptil;

            atributosreptil = "Nombre: " + this.nombre + "\n" + "Fecha de nacimiento: " + this.fechaNacimiento + "\n" + "Peso: " + this.peso + "\n" + "Especie: " + this.especie + "\n" + "¿Es venenoso? " + this.venenoso + "\n" + "Comentarios: " + this.comentarios;

            return atributosreptil;
        }

    }
}
