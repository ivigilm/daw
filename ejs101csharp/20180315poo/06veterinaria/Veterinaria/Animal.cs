using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    abstract class Animal
    {
        // Atributos (protegidos)

        protected string nombre;
        protected DateTime fechaNacimiento;
        protected double peso;
        protected string comentarios;

        // Constructor

        /// <summary>
        /// Crea un nuevo objeto de la clase Animal.
        /// </summary>
        /// <param name="nombre">Nombre del animal.</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento del animal.</param>
        /// <param name="peso">Peso del animal.</param>
        public Animal(string nombre, DateTime fechaNacimiento, double peso)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.peso = peso;
            this.comentarios = ""; // es necesario inicializarlo aunque esté vacío, porque si no luego da error cuando se quiera usar el atributo sin inicializar
        }

        // Propiedades (públicas)

        /// <summary>
        /// Devuelve el nombre del animal.
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        /// <summary>
        /// Devuelve la fecha de nacimiento del animal.
        /// </summary>
        public DateTime FechaNacimiento
        {
            get
            {
                return this.fechaNacimiento;
            }
        }

        /// <summary>
        /// Devuelve o modifica el peso del animal.
        /// </summary>
        public double Peso
        {
            get
            {
                return this.peso;
            }
            set
            {
                this.peso = value;
            }
        }

        /// <summary>
        /// Devuelve o modifica los comentarios sobre el animal.
        /// </summary>
        public string Comentarios
        {
            get
            {
                return this.comentarios;
            }
            set
            {
                this.comentarios = value;
            }
        }

        // Método (abstracto) -> obligará a las clases hijas a implementar un nuevo método ToString()

        /// <summary>
        /// Obliga a que las clases hijas de la clase Animal implementen un método que sustituya al ToString() original.
        /// </summary>
        /// <returns>Nada.</returns>
        public override abstract string ToString();

    }
}
