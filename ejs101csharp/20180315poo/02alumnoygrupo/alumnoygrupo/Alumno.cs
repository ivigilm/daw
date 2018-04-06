using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alumnoygrupo
{
    /// <summary>
    ///  Clase basada en el struct ficha_alumno construido con anterioridad.
    ///  Atributos (privados) ...
    ///  Propiedades de acceso a los atributos (de lectura libre y escritura sujeta a comprobaciones:
    ///  nombre no cadena vacía, edad 17-100, calificación 0-10).
    /// </summary>
    class Alumno
    {
        // Atributos

        private string nombre;
        private int edad;
        private decimal calificacion;

        // Constructores

        /// <summary>
        /// Inicializa un objeto de la clase Alumno.
        /// </summary>
        public Alumno(string nombre, int edad, decimal calificacion)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.calificacion = calificacion;
        }

        // Propiedades

        /// <summary>
        /// Devuelve el valor guardado o lo sustituye por el indicado por el usuario.
        /// </summary>
        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                if(value != "") // value = valor q me pasan
                {
                    nombre = value;
                }
                else
                {
                    throw new Exception("¡El nombre del alumno no puede estar vacío!");
                }
            }
        }

        /// <summary>
        /// Devuelve el valor guardado o lo sustituye por el indicado por el usuario.
        /// </summary>
        public int Edad
        {
            get
            {
                return edad;
            }

            set
            {
                if(value >= 17 && value <= 100)
                {
                    edad = value;
                }
                else
                {
                    throw new Exception("¡La edad debe estar entre 17 y 100!");
                }
            }
        }

        /// <summary>
        /// Devuelve el valor guardado o lo sustituye por el indicado por el usuario.
        /// </summary>
        public decimal Calificacion
        {
            get
            {
                return calificacion;
            }

            set
            {
                if (value >= 0 && value <= 10)
                {
                    calificacion = value;
                }
                else
                {
                    throw new Exception("La calificación debe estar entre 0 y 10.");
                }                    
            }
        }

        // Métodos

        /// <summary>
        /// Devuelve una cadena con el contenido de la lista, con el fin de imprimirla.
        /// </summary>
        /// <returns>Cadena con el contenido de la lista</returns>
        public string Imprime()
        {
            string atributos;
            atributos = nombre + ", " + edad + ", " + calificacion;
            return atributos;
        }
    }
}
