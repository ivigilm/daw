using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final1617ej2
{
    class EquipoBaloncesto
    {
        // Atributos

        private string nombre;
        private int victorias;
        private int derrotas;
        private int puntosAnotados;
        private int puntosRecibidos;

        // Propiedades

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        public int Victorias
        {
            get
            {
                return victorias;
            }

        }

        public int Derrotas
        {
            get
            {
                return derrotas;
            }

        }

        public int PuntosAnotados
        {
            get
            {
                return puntosAnotados;
            }
        }

        public int PuntosRecibidos
        {
            get
            {
                return puntosRecibidos;
            }
        }

        // Constructores

        /// <summary>
        /// Crea una nueva instancia de la clase con el nombre del equipo.
        /// </summary>
        /// <param name="nombre">Nombre del equipo.</param>
        public EquipoBaloncesto(string nombre)
        {
            this.nombre = nombre;
            this.victorias = 0;
            this.derrotas = 0;
            this.puntosAnotados = 0;
            this.puntosRecibidos = 0;
        }

        /// <summary>
        /// Crea una nueva instancia con todos los datos posibles.
        /// </summary>
        /// <param name="nombre">Nombre del equipo.</param>
        /// <param name="victorias">Número de victorias.</param>
        /// <param name="derrotas">Número de derrotas.</param>
        /// <param name="puntosAnotados">Número de puntos anotados.</param>
        /// <param name="puntosRecibidos">Número de puntos recibidos.</param>
        public EquipoBaloncesto(string nombre, int victorias, int derrotas, int puntosAnotados, int puntosRecibidos)
        {
            this.nombre = nombre;
            this.victorias = victorias;
            this.derrotas = derrotas;
            this.puntosAnotados = puntosAnotados;
            this.puntosRecibidos = puntosRecibidos;
        }

        // Métodos

        /// <summary>
        /// Devuelve el nombre del equipo.
        /// </summary>
        /// <returns>Nombre del equipo.</returns>
        public override string ToString()
        {
            return this.nombre;
        }

        /// <summary>
        /// Devuelve una cadena con los datos del equipo preparados para imprimir en la clasificación.
        /// </summary>
        /// <returns>Nombre del equipo + espacio + nºvictorias/nºderrotas + diferencia de puntos anotados y recibidos.</returns>
        public string DatosEquipo()
        {
            string datos, puntos;
            int puntuacion = puntosAnotados - puntosRecibidos;

            if(puntuacion > 0)
            {
                puntos = "+" + puntuacion.ToString();
            }
            else
            {
                puntos = puntuacion.ToString();
            }

            datos = nombre.PadRight(30) + victorias.ToString() + "-" + derrotas.ToString().PadRight(10) + puntos;

            return datos;
        }

    }
}
