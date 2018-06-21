using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ej2palindromos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static bool EsPalindromo(string a)
        {
            int i;
            bool palindromo = true;
            List<char> primeraparte, segundaparte;
            primeraparte = new List<char>();
            segundaparte = new List<char>();

            if(a.Length % 2 == 0) // nº par de caracteres
            {
                for(i = 0; i < a.Length/2; i++) // recorro la primera mitad de la cadena
                {
                    primeraparte.Add(a[i]); // y agrego sus componentes a la lista 1
                }

                for(i = a.Length/2; i < a.Length; i++)
                {
                    segundaparte.Add(a[i]); // agrego la segunda parte de la cadena a la lista 2
                }

                segundaparte.Reverse(); // le doy la vuelta a la segunda parte

                // Ahora debería tener dos listas idénticas para que sea palíndromo.

                for(i = 0; i < primeraparte.Count; i++)
                {
                    if(primeraparte[i] != segundaparte[i])
                    {
                        palindromo = false;
                    }
                }
            }
            else // nº impar de caracteres
            {
                for(i = 0; i < a.Length/2 - a.Length%2; i++)
                {
                    primeraparte.Add(a[i]);
                }

                for(i = (a.Length/2 + a.Length%2); i < a.Length; i++)
                {
                    segundaparte.Add(a[i]);
                }

                segundaparte.Reverse();

                for (i = 0; i < primeraparte.Count; i++)
                {
                    if (primeraparte[i] != segundaparte[i])
                    {
                        palindromo = false;
                    }
                }
            }

            return palindromo;
        }

        /// <summary>
        /// Resuelve si una cadena es palíndromo o no.
        /// </summary>
        /// <param name="a">Cadena introducida por parámetro.</param>
        /// <returns>Valor booleano que nos dice si la cadena es palíndromo o no.</returns>
        static bool EsPalindromo3(string a)
        {
            bool palindromo = true;
            int i, j, posicionmitad;

            j = a.Length - 1;

            posicionmitad = a.Length / 2 - a.Length % 2;

            for (i = 0; i <= posicionmitad; i++)
            {
                if (a[i] != a[j]) // out of range
                {
                    palindromo = false;
                    i = posicionmitad + 1; // sale del bucle
                }

                if(j <= posicionmitad)
                {
                    i = posicionmitad + 1;
                }
                else
                {
                    j = j - 1;
                }                
            }

            return palindromo;
        }

        private void abrirFicheroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i;
            string linea;
            string contenidofichero = "";
            string[] palabras;
            OpenFileDialog ofd = new OpenFileDialog();
            List<string> palindromos = new List<string>();

            ofd.ShowDialog();

            StreamReader sr = new StreamReader(ofd.FileName, Encoding.Default);

            while (!sr.EndOfStream) // guardo el contenido del fichero en una cadena
            {
                linea = sr.ReadLine(); // leo una línea
                linea.ToLower(); // la convierto en minúsculas
                
                for(i = 0; i < linea.Length; i++) // elimino caracteres extraños
                {
                    if (char.IsLetter(linea[i]) || linea[i] == ' ')
                    {
                        linea.Remove(i, 1);
                    }
                }
                
                // Tengo la cadena de una línea solo con letras (palabras) y espacios
                                
                contenidofichero = contenidofichero + linea + " "; // uno en una cadena las líneas del fichero de forma q solo haya palabras y espacios
            }
            
            sr.Close();

            // Meto las palabras en un array

            palabras = contenidofichero.Split(' '); // introduzco las palabras del fichero en el array de palabras

            for(i = 0; i < palabras.Length; i++) // recorro el array, palabra a palabra
            {                
                if (EsPalindromo(palabras[i]) && !palindromos.Contains(palabras[i])) // Si la palabra es un palíndromo y todavía no está en la lista
                {
                    palindromos.Add(palabras[i]); // la introduzo en la lista de palíndromos
                }
            }

            palindromos.Sort(); // ordeno alfabéticamente la lista

            // Muestro en la ListBox las palabras encontradas

            for(i = 0; i < palindromos.Count; i++)
            {
                LBpalin.Items.Add(palindromos[i]);
            }            
        }
    }
}
