using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ej21compruebatarjeta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar)) // Sólo permite introducir números
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 4) // Tras introducir cuatro dígitos
            {
                textBox2.Focus(); // el foco pasa al siguiente TextBox.
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 4)
            {
                textBox3.Focus();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length == 4)
            {
                textBox4.Focus();
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Comprueba si una tarjeta de crédito es válida.
        /// </summary>
        /// <param name="numerotarjeta">Cadena con 16 dígitos que forma el número de la tarjeta de crédito.</param>
        /// <returns>true si es válida, false si no</returns>
        private bool TarjetaValida(string numerotarjeta)
        {
            int i, valor, suma;
            bool esvalida;
            suma = 0;

            for (i = 0; i < numerotarjeta.Length; i++)
            {
                valor = Convert.ToInt32(numerotarjeta[i]);

                if(i % 2 == 0)
                {
                    valor = valor * 2;

                    if(valor >= 10)
                    {
                        valor = valor - 9;
                    }
                }

                suma = suma + valor;
            }

            if(suma % 10 == 0)
            {
                esvalida = true;
            }
            else
            {
                esvalida = false;
            }

            return esvalida;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string tarjetacredito;

            if(textBox4.Text.Length == 4)
            {
                tarjetacredito = textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text;

                if (TarjetaValida(tarjetacredito))
                {
                    MessageBox.Show("La tarjeta introducida es válida.");
                }
                else
                {
                    MessageBox.Show("La tarjeta introducida no es válida.");
                }
            }  
        }

    }
}
