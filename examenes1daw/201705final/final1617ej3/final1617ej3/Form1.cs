using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final1617ej3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TBcontrasena1.PasswordChar = '*';
            TBcontrasena2.PasswordChar = '*';
        }

        int i;
        string[] nuevafila = new string[4];
        ListViewItem lvi;

        // Validación del nombre de usuario
        private void BTnombre_Click(object sender, EventArgs e)
        {
            bool ocupado = false;
            bool sololetras = true;

            if(TBnombre.Text.Length >= 4 && TBnombre.Text.Length <= 20) // el nombre tiene 4-20 caracteres
            {
                for(i = 0; i < TBnombre.Text.Length; i++)
                {
                    if (!char.IsLetter(TBnombre.Text[i]))
                    {
                        sololetras = false;
                    }
                }

                if (sololetras)
                {
                    for(i = 0; i < listView1.Items.Count; i++)
                    {
                        if(listView1.Items[i].Text == TBnombre.Text)
                        {
                            ocupado = true;
                        }
                    }

                    if (ocupado)
                    {
                        MessageBox.Show("El nombre de usuario no está disponible.");
                        TBnombre.Focus();
                    }
                    else
                    {
                        nuevafila[0] = TBnombre.Text;
                        TBnombre.Enabled = false;
                        BTnombre.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("El nombre de usuario solo puede llevar letras.");
                    TBnombre.Focus();
                }
            }
            else // el nombre tiene menos de 4 o más de 20 caracteres
            {
                MessageBox.Show("El nombre de usuario debe tener entre 4 y 20 caracteres.");
                TBnombre.Focus();
            }
        }

        // Validación de la contraseña
        private void BTcontrasena_Click(object sender, EventArgs e)
        {
            if(TBcontrasena1.Text.Length >= 8 && TBcontrasena1.Text.Length <= 16)
            {
                if(TBcontrasena1.Text == TBcontrasena2.Text)
                {
                    nuevafila[1] = TBcontrasena1.Text;
                    BTcontrasena.Enabled = false;
                    TBcontrasena1.Enabled = false;
                    TBcontrasena2.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Las contraseñas deben coincidir.");
                    TBcontrasena1.Focus();
                }
            }
            else
            {
                MessageBox.Show("La contraseña debe tener entre 8 y 16 caracteres.");
                TBcontrasena1.Focus();
            }
        }

        // Validación de la edad
        private void BTedad_Click(object sender, EventArgs e)
        {
            try
            {
                int edad = Convert.ToInt32(TBedad.Text);

                if(edad >= 18 && edad <= 100)
                {
                    nuevafila[2] = TBedad.Text;
                    BTedad.Enabled = false;
                    TBedad.Enabled = false;
                }
                else
                {
                    MessageBox.Show("La edad debe estar comprendida entre 18 y 100 años.");
                    TBedad.Focus();
                }
            }
            catch
            {
                throw new Exception("Solo se pueden introducir números en el campo Edad.");
                TBedad.Focus();
            }
        }

        // Validación del correo electrónico
        private void BTemail_Click(object sender, EventArgs e)
        {
            int arrobas = 0;
            bool caracteresprohibidos = false;

            for(i = 0; i < TBemail1.Text.Length; i++)
            {
                if(TBemail1.Text[i] == '@')
                {
                    arrobas = arrobas + 1;
                }
                else
                {
                    if(TBemail1.Text[i] != '.' && !char.IsLetter(TBemail1.Text[i]) && !char.IsNumber(TBemail1.Text[i]))
                    {
                        caracteresprohibidos = true;
                    }
                }
            }

            if(arrobas == 1)
            {
                if (!caracteresprohibidos)
                {
                    if(TBemail1.Text == TBemail2.Text)
                    {
                        nuevafila[3] = TBemail1.Text;
                        BTemail.Enabled = false;
                        TBemail2.Enabled = false;
                        TBemail1.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Ambas direcciones de correo electrónico deben coincidir.");
                        TBemail1.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("La dirección solo puede contener letras, números y puntos (aparte de la arroba).");
                    TBemail1.Focus();
                }
            }
            else
            {
                MessageBox.Show("La dirección debe contener una arroba.");
                TBemail1.Focus();
            }

            // si todos los botones de validación están deshabilitados
            if(BTnombre.Enabled == false && BTcontrasena.Enabled == false && BTedad.Enabled == false && BTemail.Enabled == false)
            {
                BTaceptar.Enabled = true;
            }
        }

        // Añade a la lista el nuevo registro con los datos proporcionados
        private void BTaceptar_Click(object sender, EventArgs e)
        {
            lvi = new ListViewItem(nuevafila);
            listView1.Items.Add(lvi);
        }

        // Devuelve el formulario a su estado inicial
        private void BTcancelar_Click(object sender, EventArgs e)
        {
            TBnombre.Text = "";
            TBcontrasena1.Text = "";
            TBcontrasena2.Text = "";
            TBedad.Text = "";
            TBemail1.Text = "";
            TBemail2.Text = "";
            
            TBnombre.Enabled = true;
            BTnombre.Enabled = true;
            BTcontrasena.Enabled = true;
            TBcontrasena1.Enabled = true;
            TBcontrasena2.Enabled = true;
            BTedad.Enabled = true;
            TBedad.Enabled = true;
            BTemail.Enabled = true;
            TBemail2.Enabled = true;
            TBemail1.Enabled = true;

            BTaceptar.Enabled = false;
        }

    }
}
