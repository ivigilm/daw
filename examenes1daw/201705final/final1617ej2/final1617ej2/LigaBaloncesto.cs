using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace final1617ej2
{
    class LigaBaloncesto
    {
        // Atributos

        private List<EquipoBaloncesto> listaEquipos;

        // Constructores

        /// <summary>
        /// Inicializa la lista de equipos.
        /// </summary>
        public LigaBaloncesto()
        {
            this.listaEquipos = new List<EquipoBaloncesto>();
        }

        // Métodos

        /// <summary>
        /// Carga los datos del fichero en la lista de equipos.
        /// </summary>
        /// <param name="fichero">Nombre del fichero.</param>
        public void CargarLiga(string fichero)
        {
            string linea;
            string[] datosequipo;
            EquipoBaloncesto eb;
            StreamReader sr = new StreamReader(fichero, Encoding.Default);

            while (!sr.EndOfStream)
            {
                linea = sr.ReadLine(); // leo una línea
                datosequipo = linea.Split(';'); // guardo los datos del equipo
                // creo una instancia de la clase EquipoBaloncesto con los datos de la línea recién leída
                eb = new EquipoBaloncesto(datosequipo[0], Convert.ToInt32(datosequipo[1]), Convert.ToInt32(datosequipo[2]), Convert.ToInt32(datosequipo[3]), Convert.ToInt32(datosequipo[4]));
                listaEquipos.Add(eb); // agrego el equipo a la lista
            }

            sr.Close();
        }

        /// <summary>
        /// Guarda los datos de la lista de equipos en un fichero csv.
        /// </summary>
        /// <param name="fichero">Nombre del fichero.</param>
        public void GuardarLiga(string fichero)
        {
            StreamWriter sw = new StreamWriter(fichero, false, Encoding.Default);
            int i;
            string linea;

            for(i = 0; i < listaEquipos.Count; i++) // para cada equipo de la lista
            {
                linea = listaEquipos[i].Nombre + ';' + listaEquipos[i].Victorias + ';' + listaEquipos[i].Derrotas + ';' + listaEquipos[i].PuntosAnotados + ';' + listaEquipos[i].PuntosRecibidos;
                sw.WriteLine(linea);
                linea = "";
            }

            sw.Close();
        }

        // Propiedades

        /// <summary>
        /// Devuelve una cadena con la clasificación de la liga (por orden de victorias y a continuación diferencia de puntos).
        /// </summary>
        public string Clasificacion
        {
            get
            {
                string clasificacion = "";
                List<EquipoBaloncesto> copia = new List<EquipoBaloncesto>();
                List<EquipoBaloncesto> ordenada = new List<EquipoBaloncesto>(); // ordenaré la clasificación aquí
                int i, max, idxmax;

                copia.AddRange(listaEquipos); // Hago una copia de la lista de equipos

                while(copia.Count != 0)
                {
                    max = 0;
                    idxmax = 0;

                    for (i = 0; i < copia.Count; i++) // Recorro la lista de equipos
                    {
                        if (copia[i].Victorias > max) // si el equipo actual tiene más victorias que el máximo guardado
                        {
                            max = copia[i].Victorias; // el nuevo máximo de victorias es este
                            idxmax = i; // la posición del equipo con más victorias es esta
                        }
                        else
                        {
                            if (copia[i].Victorias == max) // si el equipo actual tiene las mismas victorias que el máximo
                            {
                                // comprobamos el balance de puntos

                                int difpuntosactual = copia[i].PuntosAnotados - copia[i].PuntosRecibidos;
                                int difpuntosmax = copia[idxmax].PuntosAnotados - copia[idxmax].PuntosRecibidos;

                                // si el equipo actual tiene mejor balance de puntos, se convierte en el máximo

                                if (difpuntosactual > difpuntosmax)
                                {
                                    max = copia[i].Victorias;
                                    idxmax = i;
                                }
                            }
                        }
                    }

                    // En este momento tengo en el máximo al equipo mejor clasificado de la lista

                    ordenada.Add(copia[idxmax]); // agrego el primer equipo a la clasificación

                    copia.RemoveAt(idxmax); // y lo elimino de la lista de la q estoy sacando los equipos                
                }
                
                for(i = 0; i < ordenada.Count; i++)
                {
                    // Agrego la línea correspondiente a cada equipo formateada para impresión

                    clasificacion = clasificacion + ordenada[i].DatosEquipo() + "\n";
                }

                return clasificacion;
            }
        }
    }
}
