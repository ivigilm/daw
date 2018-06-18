using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ej22editarlistview
{
    public partial class Form2 : Form
    {
        public string[] datos;

        public Form2()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Dado un NIF (8 cifras y una letra) comprueba si la letra se corresponde con el número.
        /// </summary>
        /// <param name="nif">NIF introducido por parámetro.</param>
        /// <returns>true si es un NIF correcto, false si no.</returns>
        private bool LetraNIFCorrecta(string nif)
        {
            // Cojo los 8 primeros caracteres del NIF (el número) y lo convierto a entero.
            int numero, resto;
            bool correcta;

            // Guardo en una caden las letras correspondientes a los restos 0-22 (en este orden)
            string letrasnif = "TRWAGMYFPDXBNJZSQVHLCKE";

            numero = Convert.ToInt32(nif.Substring(0, 8));

            resto = numero % 23;

            if(nif[8] == letrasnif[resto]) // Si la letra indicada es la que le corresponde a ese número
            {
                correcta = true;
            }
            else
            {
                correcta = false;
            }

            return correcta;
        }

        /// <summary>
        /// Comprueba si una cadena forma un NIF.
        /// </summary>
        /// <param name="nif">NIF para comprobar.</param>
        /// <returns>true si es correcto, false si no</returns>
        private bool NIFcorrecto(string nif)
        {
            int i;
            bool correcto = true;

            if(nif.Length == 9 && char.IsLetter(nif[8])) // Compruebo que tiene 9 caracteres y el último es una letra
            {
                for(i = 0; i < 8; i++) // Compruebo que los 8 primeros son números
                {
                    if (!char.IsNumber(nif[i]))
                    {
                        correcto = false;
                    }
                }

                if(correcto == true) // si hasta ahora todo va bien (8 números + 1 letra)
                {
                    if (!LetraNIFCorrecta(nif))
                    {
                        correcto = false;
                    }
                }
            }
            else
            {
                correcto = false;
            }

            return correcto;
        }

        /// <summary>
        /// Comprueba si un año dado es bisiesto e imprime la información por pantalla.
        /// </summary>
        static bool EsBisiestoONo(int year)
        {
            bool bisiesto;

            if (((year % 4 == 0) && (year % 100 == 0) && (year % 400 == 0)) || ((year % 4 == 0) && (year % 100 != 0)))
            {
                bisiesto = true;
            }
            else
            {
                bisiesto = false;
            }

            return bisiesto;
        }

        /// <summary>
        /// Comprueba si la fecha de alta es una fecha posible de alta en la empresa (1970-2018).
        /// </summary>
        /// <param name="fecha">Fecha de alta introducida en el formulario (formato: dd/mm/aa).</param>
        /// <returns>true si es válida, false si no</returns>
        private bool fechacorrecta(string fecha)
        {
            bool correcta = true;
            int dia, mes, anio;

            dia = Convert.ToInt32(fecha.Substring(0, 2));
            mes = Convert.ToInt32(fecha.Substring(3, 2));
            anio = Convert.ToInt32(fecha.Substring(6, 2));

            if(anio <= 18) // Convierto 70 a 1970 para operar con el año real.
            {
                anio = anio + 2000;
            }
            else
            {
                anio = anio + 1900;
            }

            if ( mes < 1 || mes > 12 || dia < 1)
            {
                correcta = false;
            }
            
            if( (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12) && dia > 31) // Meses de 31 días
            {
                correcta = false;
            }
            else
            {
                if(mes == 2) // Febrero
                {
                    if ((EsBisiestoONo(anio) && dia > 29) || (!EsBisiestoONo(anio) && dia > 28))
                    {
                        correcta = false;
                    }
                }
                else // Meses de 30 días
                {
                    if(dia > 30)
                    {
                        correcta = false;
                    }
                }
            }

            if(anio < 1970 || anio > 2018) // Entiendo que el rango de años en que se pudo dar de alta un empleado es 1970-2018.
            {
                correcta = false;
            }

            return correcta;
        }

        private void TBfechaalta_TextChanged(object sender, EventArgs e)
        {            // Falta permitir que solo se introduzcan números en el campo fecha
            if(TBfechaalta.Text.Length == 2 || TBfechaalta.Text.Length == 5) // Tras el día y el mes, pone automáticamente una barra
            {
                TBfechaalta.Text = TBfechaalta.Text + '/';
            }
        }

        private void BTaceptar_Click(object sender, EventArgs e)
        {
            // Comprueba si los datos introducidos son correctos

            if (NIFcorrecto(TBnif.Text) && TBnombre.Text != "" && TBapellidos.Text != "" && TBsalario.Text != "" && fechacorrecta(TBfechaalta.Text))
            {
                datos = new string[5] { TBnif.Text, TBnombre.Text, TBapellidos.Text, TBsalario.Text, TBfechaalta.Text};
            }
            else
            {
                if (!NIFcorrecto(TBnif.Text))
                {
                    MessageBox.Show("El NIF introducido es incorrecto.");
                }

                if (!fechacorrecta(TBfechaalta.Text))
                {
                    MessageBox.Show("La fecha introducida es incorrecta.");
                }
            }
        }

    }
}
