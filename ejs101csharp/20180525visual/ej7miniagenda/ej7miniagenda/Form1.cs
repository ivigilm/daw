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

namespace ej7miniagenda
{
    public partial class MiniAgenda : Form
    {
        public MiniAgenda() // Form1: Inicializa y pone la fecha de hoy
        {
            InitializeComponent();

            fecha = DateTime.Today; // fecha de hoy

            TBday.Text = fecha.ToString("dd");
            TBmonth.Text = fecha.ToString("MM"); // mes => MM ("mm" son minutos)
            TByear.Text = fecha.ToString("yyyy");
        }

        bool modificando = false;

        DateTime fecha;

        private void TBcontenido_TextChanged(object sender, EventArgs e)
        {
            if (!modificando)
            {
                modificando = true;
            }
        }

        /// <summary>
        /// Carga el contenido del fichero de la fecha indicada o vacía el cuadro de texto si no existe este fichero.
        /// </summary>
        private void CambioFecha()
        {
            if (!modificando)
            {
                modificando = true;

                // Busca fichero con la nueva fecha (DDMMYYYY.txt)

                string fechaindicada = TBday.Text + TBmonth.Text + TByear.Text + ".txt";

                // Si existe, carga el contenido en TBcontenido.Text

                if (File.Exists(fechaindicada))
                {
                    StreamReader sr = new StreamReader(fechaindicada, Encoding.Default);

                    while (!sr.EndOfStream)
                    {
                        TBcontenido.Text = TBcontenido.Text + sr.ReadLine();
                    }

                    sr.Close();
                }
                else
                {
                    TBcontenido.Clear();

                    // TBcontenido.Text = "";
                }

                modificando = false;
            }
        }

        private void TBday_TextChanged(object sender, EventArgs e)
        {
            CambioFecha();
        }

        private void TBmonth_TextChanged(object sender, EventArgs e)
        {
            CambioFecha();
        }

        private void TByear_TextChanged(object sender, EventArgs e)
        {
            CambioFecha();
        }

        private void ActualizaFecha()
        {
            TBday.Text = fecha.ToString("dd");
            TBmonth.Text = fecha.ToString("MM");
            TByear.Text = fecha.ToString("yyyy");
        }

        private void GuardaFichero(string nombrefichero) // falla: al escribir, se guarda un fichero sin extensión q se copia a todas las fechas por las que paso
        {
            StreamWriter sw = new StreamWriter(nombrefichero);

            sw.Write(TBcontenido.Text);

            sw.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {     
            if(TBcontenido.Text != "")
            {
                string fichero = fecha.ToString("dd") + fecha.ToString("MM") + fecha.ToString("yyyy");

                GuardaFichero(fichero);
            }            

            fecha = fecha.AddDays(-1); // Un día menos

            ActualizaFecha();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TBcontenido.Text != "")
            {
                string fichero = fecha.ToString("dd") + fecha.ToString("MM") + fecha.ToString("yyyy");

                GuardaFichero(fichero);
            }

            fecha = fecha.AddDays(1); // Un día más

            ActualizaFecha();
        }

        private void MiniAgenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            string fichero = fecha.ToString("dd") + fecha.ToString("MM") + fecha.ToString("yyyy");

            GuardaFichero(fichero);
        }
    }
}
