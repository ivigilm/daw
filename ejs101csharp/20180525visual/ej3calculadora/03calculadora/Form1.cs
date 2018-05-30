using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
                
        private void BTsuma_Click(object sender, EventArgs e)
        {
            int n1, n2, resultado;

            if (Int32.TryParse(TBoperador1.Text, out n1) && Int32.TryParse(TBoperador2.Text, out n2))
            {
                resultado = n1 + n2;
                TBresultado.Text = resultado.ToString();
                LBoperador.Text = "+";
            }
            else // si no se han introducido dos números da error
            {
                MessageBox.Show("¡Error! Debes introducir dos números con los que operar.");
            }
        }
                
        private void BTresta_Click(object sender, EventArgs e)
        {
            int n1, n2, resultado;

            if(Int32.TryParse(TBoperador1.Text, out n1) && Int32.TryParse(TBoperador2.Text, out n2))
            {
                resultado = n1 - n2;
                TBresultado.Text = resultado.ToString();
                LBoperador.Text = "-";
            }
            else // si no se han introducido dos números da error
            {
                MessageBox.Show("¡Error! Debes introducir dos números con los que operar.");
            }
            
        }

        private void BTproducto_Click(object sender, EventArgs e)
        {
            int n1, n2, resultado;

            if (Int32.TryParse(TBoperador1.Text, out n1) && Int32.TryParse(TBoperador2.Text, out n2))
            {
                resultado = n1 * n2;
                TBresultado.Text = resultado.ToString();
                LBoperador.Text = "x";
            }
            else // si no se han introducido dos números da error
            {
                MessageBox.Show("¡Error! Debes introducir dos números con los que operar.");
            }
        }

        private void BTdivision_Click(object sender, EventArgs e)
        {
            int n1, n2, resultado;

            if (Int32.TryParse(TBoperador1.Text, out n1) && Int32.TryParse(TBoperador2.Text, out n2))
            {
                resultado = n1 / n2;
                TBresultado.Text = resultado.ToString();
                LBoperador.Text = "/";
            }
            else // si no se han introducido dos números da error
            {
                MessageBox.Show("¡Error! Debes introducir dos números con los que operar.");
            }
        }
    }
}
