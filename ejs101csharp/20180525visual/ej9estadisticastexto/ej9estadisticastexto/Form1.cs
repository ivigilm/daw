using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ej9estadisticastexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Comprueba si un caracter es una vocal o no.
        /// </summary>
        /// <param name="caracter">Caracter que se quiere comprobar.</param>
        /// <returns>"true" si es una vocal, "false" si no.</returns>
        public bool EsVocal(char caracter)
        {
            bool vocal;
            string vocales = "aeiouáéíóúAEIOUÁÉÍÓÚ";

            if (vocales.Contains(caracter))
            {
                vocal = true;
            }
            else
            {
                vocal = false;
            }

            return vocal;
        }

        /// <summary>
        /// Comprueba si un caracter es una consonante o no.
        /// </summary>
        /// <param name="caracter">Caracter que se quiere comprobar.</param>
        /// <returns>"true" si es una consonante, "false" si no.</returns>
        public bool EsConsonante(char caracter)
        {
            bool consonante;

            if (char.IsLetter(caracter))
            {
                if (EsVocal(caracter))
                {
                    consonante = false;
                }
                else
                {
                    consonante = true;
                }
            }
            else
            {
                consonante = false;
            }

            return consonante;
        }

        private void TBcontenido_TextChanged(object sender, EventArgs e)
        {
            int numletras, numpalabras, numespacios, numvocales, numconsonantes;
            string[] palabras = TBcontenido.Text.Split(' ');                       

            numletras = TBcontenido.Text.Count(char.IsLetter);
            numpalabras = palabras.Count(); // cuenta una nueva palabra en cuanto se escribe un espacio
            numespacios = numpalabras - 1;
            numvocales = TBcontenido.Text.Count(EsVocal);
            numconsonantes = TBcontenido.Text.Count(EsConsonante);

            LBletras.Text = "Número de letras: " + numletras.ToString();
            LBpalabras.Text = "Número de palabras: " + numpalabras.ToString();
            LBespacios.Text = "Número de espacios: " + numespacios.ToString();
            LBvocales.Text = "Número de vocales: " + numvocales.ToString();
            LBconsonantes.Text = "N´´umero de consonantes: " + numconsonantes.ToString();
        }
    }
}
