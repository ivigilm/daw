using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ej20pruebafiltros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i;

        // Borrar el evento
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private bool EsCampoDeLetras(string contenido)
        {
            bool sontodoletras = true;

            for(i = 0; i < contenido.Length; i++)
            {
                if (!char.IsLetter(contenido[i])) // si el caracter no es una letra
                {
                    sontodoletras = false;
                }
            }            

            return sontodoletras;
        }

        private bool EsCampoDeNumeros(string contenido)
        {
            bool sontodonumeros = true;

            for(i = 0; i < contenido.Length; i++)
            {
                if (!char.IsNumber(contenido[i]))
                {
                    sontodonumeros = false;
                }
            }

            return sontodonumeros;
        }
                
        private void TBnumerico_Leave(object sender, EventArgs e)
        {
            if (!EsCampoDeNumeros(textBox1.Text))
            {
                MessageBox.Show("¡El campo Numérico sólo puede contener números!");
            }
        }

        private void TBenteros_Leave(object sender, EventArgs e)
        {
            string quitandoelprimercaracter = TBenteros.Text.Substring(1); // todo el texto menos el primer caracter            

            // Si hay algún caracter distinto a un número (o un '-' en el caso de la primera posición), da error:

            if (!EsCampoDeNumeros(quitandoelprimercaracter) || (TBenteros.Text[0] != '-' && !char.IsNumber(TBenteros.Text[0])) )
            {
                MessageBox.Show("¡El campo de Números Enteros sólo puede contener números enteros!");
            }
        }

        private void TBreales_Leave(object sender, EventArgs e)
        {
            int puntodecimal = 0;
            bool campocorrecto = true;

            if(TBreales.Text[0] != '-' && !char.IsNumber(TBreales.Text[0])) // Comprobación del primer carácter
            {
                campocorrecto = false;
            }

            for(i = 1; i < TBreales.Text.Length; i++) // Comprobación del resto de caracteres
            {
                // Si no es un número y no es coma ni punto decimal O si es coma o punto pero es el segundo o más
                if ( (!char.IsNumber(TBreales.Text[i]) && TBreales.Text[i] != ',' && TBreales.Text[i] != '.') || ( (TBreales.Text[i] == ',' || TBreales.Text[i] == '.') && puntodecimal > 0 ) )
                {
                    campocorrecto = false;
                }
                else
                {
                    if(TBreales.Text[i] == '.' || TBreales.Text[i] == ',')
                    {
                        puntodecimal = puntodecimal + 1;
                    }
                }
            }

            if(campocorrecto == false)
            {
                MessageBox.Show("El campo Números Reales sólo puede contener números reales.");
            }
        }

        // Campo Letras
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (!EsCampoDeLetras(textBox1.Text)) // si no son todo letras
            {
                MessageBox.Show("¡El campo Letras sólo puede contener letras!");
            }
        }

        private void LABalfanumerico_Leave(object sender, EventArgs e)
        {
            for(i = 0; i < TBalfanumerico.Text.Length; i++)
            {
                if(!char.IsLetter(TBalfanumerico.Text[i]) && !char.IsNumber(TBalfanumerico.Text[i]))
                {
                    MessageBox.Show("El campo alfanumérico sólo acepta números y letras.");
                }
            }
        }

        private void TBNIF_Leave(object sender, EventArgs e)
        {
            bool nifcorrecto = true;

            if(TBNIF.Text.Length == 9)
            {
                for (i = 0; i < 8; i++)
                {
                    if (!char.IsNumber(TBNIF.Text[i])) // Si alguno de los 8 primeros caracteres del NIF no es un número
                    {
                        nifcorrecto = false;
                    }
                }

                if (!char.IsLetter(TBNIF.Text[8]))
                {
                    nifcorrecto = false;
                }

                if (nifcorrecto == false)
                {
                    MessageBox.Show("El NIF debe tener el siguiente formato: ocho números + una letra.");
                }
            }
            else // No se han introducido 9 caracteres
            {
                MessageBox.Show("El NIF debe tener el siguiente formato: ocho números + una letra.");
            }            
        }

        private void TBemail_Leave(object sender, EventArgs e)
        {
            // Compruebo que contiene una arroba y, detrás, un punto

            int posicionarroba;
            string segundaparteemail;

            if (!TBemail.Text.Contains('@')) // si no hay arroba
            {
                MessageBox.Show("Un e-mail válido debe contener una arroba.");
            }
            else // si hay arroba
            {
                posicionarroba = TBemail.Text.IndexOf('@'); // miro en qué posición está

                segundaparteemail = TBemail.Text.Substring(posicionarroba + 1); // me quedo con la cadena posterior a la arroba

                if (!segundaparteemail.Contains('.')) // si no hay punto detrás de la arroba
                {
                    MessageBox.Show("Un e-mail válido debe contener un punto.");
                }
            }            
        }

        //
    }
}
