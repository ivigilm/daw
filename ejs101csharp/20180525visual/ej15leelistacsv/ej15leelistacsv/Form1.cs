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

namespace ej15leelistacsv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTcargar_Click(object sender, EventArgs e)
        {
            LBficherocargado.Clear(); // Vacío el contenido de la tabla.

            int numcolumnas, i;
            string fichero, linea;
            string[] palabras;

            // Mirar el número de columnas del csv
            fichero = TBcargar.Text;
            StreamReader sr = new StreamReader(fichero, Encoding.Default);
            linea = sr.ReadLine(); // leo la primera línea
            palabras = linea.Split(','); // guardo las palabras en un array
            numcolumnas = palabras.Length; // hallo el número de columnas

            // Inserto datos

            for(i = 0; i < palabras.Length; i++)
            {
                LBficherocargado.Columns.Add(palabras[i], 150);
            }

            while (!sr.EndOfStream)
                {
                    linea = sr.ReadLine();
                    palabras = linea.Split(',');
                    ListViewItem ln = new ListViewItem(palabras);
                    LBficherocargado.Items.Add(ln);
                }
                
            sr.Close();
        }

        private void TBcargar_TextChanged(object sender, EventArgs e)
        {
            // Habilito el botón de carga

            if (TBcargar.Text != "")
            {
                BTcargar.Enabled = true; // entiendo que si no está vacío el campo, habrán introducido un nombre correcto
            }                          
        }
    }
}
