using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace alumnoygrupo
{
    /// <summary>
    /// Grupo de alumnos
    /// Atributo: lista de alumnos
    /// Métodos: InsertaAlumnoLista(a), InsertaAlumnoLista(nombre, edad, calificacion),
    /// Imprime(), EscribeFichero(string f), LeeFichero(string f), EscribeFicheroTXT(string f),
    /// EscribeFicheroCSV(string f), LeeFicheroCSV(string f).
    /// </summary>
    class Grupo
    {
        // Atributos

        private List<Alumno> listaAlumnos;

        // Constructor

        /// <summary>
        /// Constructor vacío que inicializa la lista de objetos de la clase Alumno.
        /// </summary>
        public Grupo()
        {
            this.listaAlumnos = new List<Alumno>();
        }

        // Métodos

        /// <summary>
        /// Inserta un nuevo alumno en la lista pasándole el objeto alumno.
        /// </summary>
        /// <param name="a">Alumno introducido por parámetro.</param>
        public void InsertaAlumnoLista(Alumno a)
        {
            listaAlumnos.Add(a);
        }

        /// <summary>
        /// Inserta un nuevo alumno en la lista pasándole el nombre, la edad y la calificación
        /// </summary>
        /// <param name="nombre">Nombre del alumno introducido por parámetro.</param>
        /// <param name="edad">Edad del alumno introducido por parámetro.</param>
        /// <param name="calificacion">Calificación del alumno introducida por parámetro.</param>
        public void InsertaAlumnoLista(string nombre, int edad, decimal calificacion)
        {
            Alumno a = new Alumno(nombre, edad, calificacion);
            listaAlumnos.Add(a);
        }

        /// <summary>
        /// Nos devolverá un listado de toda la lista en un string.
        /// </summary>
        /// <returns></returns>
        public string Imprime()
        {
            int i;
            string impresion = "";

            for (i = 0; i < listaAlumnos.Count; i++)
            {
                impresion = impresion + listaAlumnos[i].Imprime(); // utilizo el método Imprime() de la clase Alumno
                impresion = impresion + "\n";
            }

            return impresion;
        }

        /// <summary>
        /// Guarda los datos de la lista (el grupo de alumnos) en un fichero binario.
        /// </summary>
        /// <param name="fichero"></param>
        public void EscribeFichero(string fichero)
        {          
            int i;

            FileStream fs = new FileStream(fichero, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            bw.Write(listaAlumnos.Count);

            for (i = 0; i < listaAlumnos.Count; i++) // cada objeto de la lista (cada alumno)
            {
                bw.Write(listaAlumnos[i].Nombre);
                bw.Write(listaAlumnos[i].Edad);
                bw.Write(listaAlumnos[i].Calificacion);                
            }

            bw.Close();
            fs.Close();            
        }

        /// <summary>
        /// Guarda los datos leídos de un fichero binario en una lista de alumnos (un grupo).
        /// </summary>
        /// <param name="fichero">Nombre del fichero.</param>
        public void LeeFichero(string fichero)
        {
            int i, edad;
            string nombre;
            decimal calificacion;           
            FileStream fs = new FileStream(fichero, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            listaAlumnos.Clear(); // vacío la lista donde guardaré los datos del fichero

            int numero = br.ReadInt32(); // cantidad de "alumnos" que habíamos guardado en el fichero (la primera línea contiene este número)

            for(i = 0 ; i < numero; i++) // recorro el flujo de datos de tres en tres (una vuelta del for, un alumno)
            {
                nombre = br.ReadString();
                edad = br.ReadInt32();
                calificacion = br.ReadDecimal();
                Alumno nuevo = new Alumno(nombre, edad, calificacion);
                listaAlumnos.Add(nuevo);
            }

            br.Close();
            fs.Close();
        }

        /// <summary>
        /// Guarda los datos leídos de un fichero de texto en una lista de alumnos (un grupo).
        /// </summary>
        /// <param name="fichero">Nombre del fichero.</param>
        public void EscribeFicheroTXT(string fichero)
        {             // StreamWriter(fichero) o StreamWriter(fichero, false, Encoding.Default);
            StreamWriter sw = new StreamWriter(fichero, false, Encoding.Default);
            int i;

            sw.WriteLine(listaAlumnos.Count);

            for(i = 0; i < listaAlumnos.Count; i++)
            {
                sw.WriteLine(listaAlumnos[i].Nombre);
                sw.WriteLine(listaAlumnos[i].Edad);
                sw.WriteLine(listaAlumnos[i].Calificacion);
            }

            sw.Close();            
        }

        /// <summary>
        /// Guarda los datos leídos de un fichero de texto en una lista de alumnos (un grupo).
        /// </summary>
        /// <param name="fichero">Nombre del fichero.</param>
        public void LeeFicheroTXT(string fichero)
        {
            StreamReader sr = new StreamReader(fichero, Encoding.Default);
            listaAlumnos.Clear();
            string nombre;
            int edad;
            decimal nota;

            while (!sr.EndOfStream)
            {
                nombre = sr.ReadLine();
                edad = int.Parse(sr.ReadLine());
                nota = decimal.Parse(sr.ReadLine());
                Alumno nuevo = new Alumno(nombre, edad, nota);
                listaAlumnos.Add(nuevo);
            }

            sr.Close();            
        }

        /// <summary>
        /// Guarda los datos leídos de un fichero csv en una lista de alumnos (un grupo).
        /// </summary>
        /// <param name="fichero">Nombre de fichero.</param>
        public void EscribeFicheroCSV(string fichero)
        {
             StreamWriter sw = new StreamWriter(fichero, false, Encoding.Default);
            int i;
            for (i = 0; i < listaAlumnos.Count; i++)
            {
                sw.Write(listaAlumnos[i].Nombre);
                sw.Write(";");
                sw.Write(listaAlumnos[i].Edad);
                sw.Write(";");
                sw.WriteLine(listaAlumnos[i].Calificacion);
            }

            sw.Close();
        }

        /// <summary>
        /// Guarda los datos leídos de un fichero de texto en una lista de alumnos (un grupo).
        /// </summary>
        /// <param name="fichero">Nombre del fichero.</param>
        public void LeeFicheroCSV(string fichero)
        {
             StreamReader sr = new StreamReader(fichero, Encoding.Default);
            listaAlumnos.Clear();
            string linea, nombre;
            string[] palabras;
            int edad;
            decimal calificacion;

            while (!sr.EndOfStream)
            {
                linea = sr.ReadLine();
                palabras = linea.Split(';');

                nombre = palabras[0];
                edad = int.Parse(palabras[1]);
                calificacion = decimal.Parse(palabras[2]);
                Alumno nuevo = new Alumno(nombre, edad, calificacion);

                listaAlumnos.Add(nuevo);
            }

            sr.Close();

        }

    }
}
