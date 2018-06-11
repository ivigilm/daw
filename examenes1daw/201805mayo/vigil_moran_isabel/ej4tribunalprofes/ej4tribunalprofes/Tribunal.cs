using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ej4tribunalprofes
{
    enum TipoGenero
    {
        Hombre, Mujer
    }

    class Tribunal
    {
        Random r = new Random();

        // Atributos

        private static List<Profesor> lista_profesores;

        // Constructor

        /// <summary>
        /// Carga los datos de los profesores desde un fichero a la lista.
        /// </summary>
        /// <param name="fichero">Nombre del fichero.</param>
        public Tribunal(string fichero)
        {
            Profesor p;
            string nombre, dni;
            int genero;
            FileStream fs = new FileStream(fichero, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            lista_profesores = new List<Profesor>();

            lista_profesores.Clear(); // Limpio la lista por si tuviera datos.

            while (fs.Position < fs.Length)
            {
                nombre = br.ReadString(); // string: nombre
                dni = br.ReadString(); // string: dni
                genero = br.ReadInt32(); // int: genero (0:h, 1:m)
                
                p = new Profesor(nombre, dni, (TipoGenero)genero); // Creo un nuevo profesor con los datos leídos.

                lista_profesores.Add(p); // Y lo agrego a la lista de profesores.
            }

            br.Close();
            fs.Close();
        }

        // Métodos

        /// <summary>
        /// Muestra por pantalla la lista de profesores.
        /// </summary>
        public void EscribeLista(List<Profesor> lista)
        {
            int i;

            for(i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i].ToString());
            }
        }

        /// <summary>
        /// Elige y muestra un tribunal de oposiciones.
        /// </summary>
        public void EligeTribunal()
        {
            int hombres, mujeres, i, posicion;
            List<Profesor> vocales = new List<Profesor>();
            hombres = 0;
            mujeres = 0;
            posicion = r.Next(0, lista_profesores.Count - 1);

            Console.WriteLine();
            Console.WriteLine("Aquí tienes la lista de profesores convocables:");
            Console.WriteLine();
            EscribeLista(lista_profesores);
            Console.WriteLine();
            Console.WriteLine("En el sorteo ha salido la posición: " + (posicion + 1).ToString());
            Console.WriteLine();
            Console.WriteLine("Vocales elegidos en el sorteo: ");
            Console.WriteLine();

            for(i = posicion; i < lista_profesores.Count; i++)
            {
                if(((int)lista_profesores[i].Genero == 0) && (hombres < 2)) // si es hombre
                {
                    vocales.Add(lista_profesores[i]); // Lo añado a la lista de vocales
                    hombres = hombres + 1; // subo el contador                    
                }
                else // si es mujer
                {
                    if(mujeres < 2)
                    {
                        vocales.Add(lista_profesores[i]);
                        mujeres = mujeres + 1;
                    }
                }

                // Si se acaba la lista y no tenemos a los vocales, volvemos al principio.

                if ((i == lista_profesores.Count - 1) && ( (hombres != 2) || (mujeres != 2) ) )
                {
                    i = 0;
                }                
            }

            EscribeLista(vocales);
        }
        
        /// <summary>
        /// Invierte los caracteres de una cadena (el primero pasará a ser el último, etc.).
        /// </summary>
        /// <param name="cadena">Cadena introducida por parámetro.</param>
        /// <returns>Copia de la cadena original con el contenido invertido.</returns>
        static string InvierteCadena(string cadena)
        {
            string resultado;
            resultado = "";
            int i;

            for (i = cadena.Length - 1; i >= 0; i--)
            {
                resultado = resultado + cadena.Substring(i, 1);
            }

            return resultado;
        }

        /// <summary>
        /// Ordena una lista por dni al revés.
        /// </summary>
        /// <param name="lista"></param>
        /// <returns></returns>
        public List<Profesor> OrdenaListaPorDNIAlReves(List<Profesor> lista)
        {
            int i;
            List<string> dnis = new List<string>();
            List<Profesor> resultado = new List<Profesor>();
            List<Profesor> copia = lista; // copia de la "lista" original

            for(i = 0; i < copia.Count; i++)
            {
                dnis.Add(copia[i].Dni); // Agrego los dnis de mi lista a la lista de dnis
            }

            for(i = 0; i < dnis.Count; i++) // Para cada dni, le doy la vuelta
            {
                InvierteCadena(dnis[i]);
            }

            dnis.Sort(); // Ordeno la lista de dnis girados

            for (i = 0; i < dnis.Count; i++) // Vuelvo a invertir cada elemento (para compararlo más tarde con los dnis originales)
            {
                InvierteCadena(dnis[i]);
            }

            while(resultado.Count != lista.Count) // Vuelvo a recorrer el for hasta tener mis 4 vocales.
            {
                for (i = 0; i < copia.Count; i++) // Vuelvo a mi lista original
                {
                    if (copia[i].Dni == dnis[0]) // cuando encuentro el elemento que está en primer lugar en la lista "dnis"
                    {
                        resultado.Add(copia[i]); // lo agrego a la lista resultado
                        copia.RemoveAt(i); // elimino la primera posición de la lista de profesores
                        dnis.RemoveAt(0); // elimino el dni de su lista para q pase al primer lugar el siguiente profesor q tengo q añadir
                    }
                }
            }

            return copia;
        }

        /// <summary>
        /// Elige y muestra el tribunal de oposiciones alfabéticamente.
        /// </summary>
        public void EligeTribunalPro()
        {
            int hombres, mujeres, i, posicion;
            List<Profesor> vocales = new List<Profesor>();
            List<Profesor> vocalesordenados = new List<Profesor>();
            hombres = 0;
            mujeres = 0;
            posicion = r.Next(0, lista_profesores.Count - 1);

            Console.WriteLine();
            Console.WriteLine("Aquí tienes la lista de profesores convocables:");
            Console.WriteLine();
            EscribeLista(lista_profesores);
            Console.WriteLine();
            Console.WriteLine("En el sorteo ha salido la posición: " + (posicion + 1).ToString());
            Console.WriteLine();
            Console.WriteLine("Vocales elegidos en el sorteo: ");
            Console.WriteLine();

            for (i = posicion; i < lista_profesores.Count; i++)
            {
                if (((int)lista_profesores[i].Genero == 0) && (hombres < 2)) // si es hombre
                {
                    vocales.Add(lista_profesores[i]); // Lo añado a la lista de vocales
                    hombres = hombres + 1; // subo el contador                    
                }
                else // si es mujer
                {
                    if (mujeres < 2)
                    {
                        vocales.Add(lista_profesores[i]);
                        mujeres = mujeres + 1;
                    }
                }

                // Si se acaba la lista y no tenemos a los vocales, volvemos al principio.

                if ((i == lista_profesores.Count - 1) && ((hombres != 2) || (mujeres != 2)))
                {
                    i = 0;
                }
            }

            // Ordenar la lista por DNI leído de derecha a izquierda

            vocalesordenados = OrdenaListaPorDNIAlReves(vocales);

            EscribeLista(vocalesordenados);
        }

        
    }
}
