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

namespace ej10creadiccionario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Aquí obtengo los datos del fichero y los cargo en la lista: esto cambia según si utilizo 1 o 2 columnas
            // Luego, en otro sitio (al cerrar el programa) tendré que guardar lo que hay en la lista en el fichero

            StreamReader sr = new StreamReader("midiccionario.txt", Encoding.Default);

            while (!sr.EndOfStream)
            {
                LiBcontenido.Items.Add(sr.ReadLine());             
            }

            sr.Close();
        }

        private void BTadd_Click(object sender, EventArgs e)
        {
            if(TBen.Text!="" && TBes.Text != "") // Una mejor comprobación sería comprobar que todos los caracteres son letras
            {
                // Agrego la pareja de palabras a la lista
                string linea = TBen.Text + "," + TBes.Text; // separadas únicamente por una coma

                LiBcontenido.Items.Add(linea);
            }

            TBen.Text = ""; // vacío de nuevo las casillas de introducción de datos
            TBes.Text = "";
        }
                
        private void LiBcontenido_SelectedIndexChanged(object sender, EventArgs e)
        {
            BTdel.Enabled = true; // habilito el botón para borrar una entrada
        }

        private void BTdel_Click(object sender, EventArgs e)
        {
            LiBcontenido.Items.RemoveAt(LiBcontenido.SelectedIndex);            

            if (LiBcontenido.SelectedIndices.Count == 0) // si no hay contenido
            {
                BTdel.Enabled = false; // deshabilito el botón "Borrar"
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = new StreamWriter("midiccionario.txt");
                        
            int i;
            string linea;

            for(i = 0; i < LiBcontenido.Items.Count; i++)
            {
                linea = LiBcontenido.Items[i].ToString(); // ¿Cómo guardar una línea?
                sw.WriteLine(linea);
            }

            // LiBcontenido.GetItemText(i)
            // sw.Write(LiBcontenido.Text);

            sw.Close();
        }
    }
}
