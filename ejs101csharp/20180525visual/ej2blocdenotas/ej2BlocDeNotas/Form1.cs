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

namespace ej2BlocDeNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Limpia el cuadro de texto (lo vacía de contenido).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Nuevo_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "") // si el bloc de notas tiene contenido
            {
                textBox1.Text = ""; // lo vacío
            }
        }

        /// <summary>
        /// Guarda el contenido del cuadro de texto en un fichero de texto de nombre "bloc.txt".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Guardar_Click(object sender, EventArgs e)
        {
            int i;
            string[] lineasdelbloc = textBox1.Text.Split('\n'); // guardo las líneas del bloc de notas en un array
            StreamWriter sw = new StreamWriter("bloc.txt");

            for(i = 0; i < lineasdelbloc.Length; i++) // voy leyendo las líneas
            {
                sw.WriteLine(lineasdelbloc[i]);
            }
            
            sw.Close();
        }

        // ERROR: no lee los saltos de línea bien
        /// <summary>
        /// Lee el contenido del fichero de texto "bloc.txt" (si existe) y lo muestra.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Abrir_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("bloc.txt");
            textBox1.Text = ""; // vacío el bloc de notas por si tenía algo

            textBox1.Text = sr.ReadToEnd(); // lee el fichero entero y lo guarda en una cadena (con saltos de línea incluidos)

            sr.Close();
        }
    }
}
