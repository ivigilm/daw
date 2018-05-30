using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ej5conversorpulgadas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool modificando = false;
               

        private void TBcm_TextChanged(object sender, EventArgs e)
        {
            if (!modificando)
            {
                modificando = true;

                // Cuando el usuario escribe un número de cm, se actualizan las pulgadas en el TBin
                // 1cm = 0,39in
                double centimetros, pulgadas;

                if (Double.TryParse(TBcm.Text, out centimetros)) // si se ha introducido un número
                {
                    pulgadas = centimetros * 0.39; // convierto la medida
                    TBin.Text = pulgadas.ToString(); // guardo/muestro el resultado en la casilla correspondiente 
                }
                else
                {
                    MessageBox.Show("¡Error! Debes introducir un número.");
                }

                modificando = false;
            }
        }

        private void TBin_TextChanged(object sender, EventArgs e)
        {
            if (!modificando)
            {
                modificando = true;

                double centimetros, pulgadas;

                if (Double.TryParse(TBin.Text, out pulgadas))
                {
                    centimetros = pulgadas / 0.39;
                    TBcm.Text = centimetros.ToString();
                }
                else
                {
                    MessageBox.Show("¡Error! Debes introducir un número.");
                }

                modificando = false;
            }

        }
    }
}
