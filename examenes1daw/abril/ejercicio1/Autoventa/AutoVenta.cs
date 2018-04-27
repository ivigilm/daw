using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Autoventa
{
    class AutoVenta
    {
        // Atributos

        private List<Coche> listaCoches;

        // Constructor vacío

        public AutoVenta()
        {
            listaCoches = new List<Coche>();
        }

        // Métodos

        // línea csv: dato; dato; dato \n
        
        public void CargaCSV(string ficherocoches)
        {
            StreamReader sr = new StreamReader(ficherocoches, Encoding.Default);
            string linea;
            string[] datos;
            Coche c;

            // listaCoches.Clear(); -> es conveniente limpiar la lista para cargar los nuevos coches
            sr.ReadLine(); // lee la primera línea y no hace nada con ella (no son datos)

            while (!sr.EndOfStream)
            {
                linea = sr.ReadLine();
                datos = linea.Split(';');
                c = new Coche(datos[0], DateTime.Parse(datos[3]), datos[1], datos[2], decimal.Parse(datos[4]));
                listaCoches.Add(c);
            }

            sr.Close();
        }

        public void ImprimeListado()
        {
            int i;

            Console.WriteLine("Matrícula".PadRight(20) + "Marca".PadRight(20) + "Modelo".PadRight(20) + "Fecha Matr.".PadRight(20) + "Precio".PadRight(20));
            Console.WriteLine();

            for(i = 0; i < listaCoches.Count; i++)
            { // Aplico padding según la longitud de mis campos para que haya un pequeño margen entre columna y columna (si mi marca más larga ocupa 13, le pongo 16)
                Console.Write(listaCoches[i].Matricula.PadRight(20)); // PadRight(10)
                Console.Write(listaCoches[i].Marca.PadRight(20)); // PadRight(16)
                Console.Write(listaCoches[i].Modelo.PadRight(20)); // PadRight(11)
                Console.Write(listaCoches[i].FechaMatriculacion.ToShortDateString().PadRight(20)); // PadRight(8)
                Console.WriteLine(listaCoches[i].Precio.ToString().PadRight(20)); // PadLeft(9)
            }
        }

    }
}
