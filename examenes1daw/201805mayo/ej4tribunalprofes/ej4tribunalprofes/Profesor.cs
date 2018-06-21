using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej4tribunalprofes
{
    class Profesor
    {
        // Atributos

        string nombre;
        string dni;
        TipoGenero genero;

        // Constructor
        
        /// <summary>
        /// Crea un objeto Profesor a partir de sus datos (si son correctos).
        /// </summary>
        /// <param name="nombre">Nombre del profesor.</param>
        /// <param name="dni">DNI del profesor.</param>
        /// <param name="genero">Género del profesor (hombre/mujer)</param>
        public Profesor(string nombre, string dni, TipoGenero genero)
        {
            if(nombre != "")
            {
                this.nombre = nombre;
            }
            else
            {
                throw new Exception("El nombre del profesor no puede estar vacío.");
            }

            if(dni.Length == 9)
            {
                this.dni = dni;
            }
            else
            {
                throw new Exception("El DNI debe tener 9 caracteres.");
            }

            this.genero = genero;
        }

        // Propiedades

        /// <summary>
        /// Devuelve o modifica el nombre del profesor.
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }

            set
            {
                if (nombre != "")
                {
                    this.nombre = value;
                }
                else
                {
                    throw new Exception("El nombre del profesor no puede estar vacío.");
                }
            }
        }

        /// <summary>
        /// Devuelve o modifica el dni del profesor.
        /// </summary>
        public string Dni
        {
            get
            {
                return this.dni;
            }

            set
            {
                if (dni.Length == 9)
                {
                    this.dni = value;
                }
                else
                {
                    throw new Exception("El DNI debe tener 9 caracteres.");
                }
            }
        }

        /// <summary>
        /// Devuelve o modifica el género del profesor.
        /// </summary>
        public TipoGenero Genero
        {
            get
            {
                return this.genero;
            }

            set
            {
                this.genero = value;
            }
        }

        // Métodos

        /// <summary>
            /// Muestra el nombre y el dni del profesor.
            /// </summary>
            /// <returns>Cadena con los datos del profesor.</returns>
        public override string ToString()
        {
            string profesorcondni = this.nombre + " - " + this.dni;

            return profesorcondni;
        }
    }
}
