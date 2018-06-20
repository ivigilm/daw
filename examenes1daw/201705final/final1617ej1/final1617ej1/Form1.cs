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

namespace final1617ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Ficheros: penta_palabras.txt, penta_texto.txt

        int i, j;

        /// <summary>
        /// Comprueba si una letra es vocal.
        /// </summary>
        /// <param name="letra">Letra que se quiere comprobar.</param>
        /// <returns>true si es vocal, false si no</returns>
        public bool EsVocal(char letra)
        {
            bool vocal;
            string vocales = "aeiouáéíóú";

            if (vocales.Contains(char.ToLower(letra)))
            {
                vocal = true;
            }
            else
            {
                vocal = false;
            }

            return vocal;
        }

        // Funciona para el primer fichero (una palabra por línea)

        private void BTcargar_Click(object sender, EventArgs e)
        {
            string[] linea;
            char letra;
            string contador = "";
            StreamReader sr = new StreamReader(TBcargar.Text, Encoding.Default);

            listBox1.Items.Clear(); // Vacío la lista

            while (!sr.EndOfStream)
            {
                linea = sr.ReadLine().Split(' '); // guardo las palabras de esta línea en un array

                for(i = 0; i < linea.Length; i++) // compruebo palabra a palabra
                {
                    for(j = 0; j < linea[i].Length; j++) // miro cada letra de la palabra
                    {
                        letra = char.ToLower(linea[i][j]); // guardo en la variable "letra" la letra actual convertida a minúscula

                        switch (letra) // si el caracter es igual a una vocal acentuada, lo sustituyo por esa vocal sin acentuar
                        {
                            case 'á':
                                letra = 'a';
                                break;
                            case 'é':
                                letra = 'e';
                                break;
                            case 'í':
                                letra = 'i';
                                break;
                            case 'ó':
                                letra = 'o';
                                break;
                            case 'ú':
                                letra = 'u';
                                break;
                            case 'ü':
                                letra = 'u';
                                break;
                            default:
                                break;
                        }

                        if (EsVocal(letra) && (!contador.Contains(letra))) // si la letra actual es una vocal y todavía no había aparecido
                        {
                            contador = contador + letra; // agrego la vocal al contador
                        }
                    }
                    
                    if(contador.Length == 5) // Si el contador tiene 5 vocales, es que la palabra contiene las cinco.
                    {
                        listBox1.Items.Add(linea[i]); // La añado al listBox
                    }

                    contador = "";
                }
            }

            sr.Close();
        }
    }
}
