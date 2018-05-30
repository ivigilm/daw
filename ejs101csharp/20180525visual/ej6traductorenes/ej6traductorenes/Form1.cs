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

namespace ej6traductorenes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Cargo el fichero diccionario.txt en dos listas de string

            GuardaDiccionarioListas("diccionario.txt", spanish, english);
        }

        List<string> spanish = new List<string>(); // Creo las listas del diccionario aquí para que las vea todo el mundo.
        List<string> english = new List<string>();

        /// <summary>
        /// Guarda en dos listas preexistentes (spanish, english) las palabras contenidas en un fichero.
        /// </summary>
        /// <param name="nombredefichero">Nombre del fichero que contiene las palabras.</param>
        /// <param name="spanish">Lista de palabras españolas.</param>
        /// <param name="english">Lista de palabras inglesas.</param>
        static void GuardaDiccionarioListas(string nombredefichero, List<string> spanish, List<string> english)
        {
            StreamReader sr = new StreamReader(nombredefichero);
            string linea;
            string[] palabras;

            while (!sr.EndOfStream)
            {
                linea = sr.ReadLine();
                palabras = linea.Split(','); // Es muy importante
                spanish.Add(palabras[0]);
                english.Add(palabras[1]);
            }

            sr.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
        }

        private void BTenes_Click(object sender, EventArgs e)
        {
            // Busca la palabra en la lista EN y se traduce con la palabra correspondiente (misma posición) de la otra lista
            int i;

            for (i = 0; i < english.Count; i++)
            {
                if (TBen.Text == english[i]) // si la palabra está en el diccionario (y se ha escrito en su casilla correspondiente)
                {
                    TBes.Text = spanish[i];
                }
            }
        }

        private void BTesen_Click(object sender, EventArgs e)
        {
            int i;

            for (i = 0; i < spanish.Count; i++)
            {
                if (TBes.Text == spanish[i])
                {
                    TBen.Text = english[i];
                }
            }
        }
    }
}
