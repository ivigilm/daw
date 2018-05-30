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

namespace ej14generadortitulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            RellenaCombo1();
            RellenaCombo2();
        }

        Random r = new Random();

        /// <summary>
        /// Rellena el ComboBox "lista1" con los elementos del fichero "lista1.txt".
        /// </summary>
        private void RellenaCombo1()
        {
            StreamReader sr = new StreamReader("lista1.txt", Encoding.Default);

            while (!sr.EndOfStream)
            {
                string linea = sr.ReadLine();

                CBlista1.Items.Add(linea);
            }            

            sr.Close();
        }

        /// <summary>
        /// Rellena el ComboBox "lista2" con los elementos del fichero "lista2.txt".
        /// </summary>
        private void RellenaCombo2()
        {
            StreamReader sr = new StreamReader("lista2.txt", Encoding.Default);

            while (!sr.EndOfStream)
            {
                CBlista2.Items.Add(sr.ReadLine());
            }

            sr.Close();
        }

        /* Borrar la siguiente función: */
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTejecutar_Click(object sender, EventArgs e)
        {
            string palabra1 = CBlista1.SelectedItem.ToString();
            string palabra2 = CBlista2.SelectedItem.ToString();                       

            LABtitulo.Text = palabra1 + " " + palabra2;
            LABtitulo.Width = 400; // no cambia el tamaño
            LABtitulo.Height = 40;
            LABtitulo.ForeColor = Color.Lime;
        }

        private void BTrandom_Click(object sender, EventArgs e)
        {
            string palabra1, palabra2;
            
            palabra1 = CBlista1.Items[r.Next(0, CBlista1.Items.Count)].ToString();
            palabra2 = CBlista2.Items[r.Next(0, CBlista2.Items.Count)].ToString();

            LABtitulo.Text = palabra1 + " " + palabra2;
            LABtitulo.ForeColor = Color.Red;
        }
    }
}
