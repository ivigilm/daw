using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ej3bingo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Introduzco los botones de mi boleto en la lista
            numerosboleto = new List<Button>() { BT01carton, button2, BT03carton, BT04carton, BT05carton, BT06carton, BT07carton, BT08carton, BT09carton, BT10carton, BT11carton, BT12carton, BT13carton, BT14carton, BT15carton};

            for (i = 1; i < 91; i++)
            {
                bombo.Add(i); // Relleno el bombo.
            }
        }

        int i, aleatorio, posicionaleatoria;
        List<Button> numerosboleto;
        List<int> bombo = new List<int> ();
        Random r = new Random();
        bool primeralinea;


        /* BOTÓN "EMPEZAR PARTIDA" */
        private void BTjugar_Click(object sender, EventArgs e)
        {
            List<int> numeros, noventa;
                        
            // El botón "Empezar partida" es sustituido por el botón "Sacar bola"

            BTjugar.Visible = false;
            BTbola.Visible = true;

            // Utilizo dos listas auxiliares para crear mi boleto

            numeros = new List<int>(); // lista de números q tendré en mi boleto
            noventa = new List<int>(); // lista de números del 1 al 90   
                       

            for (i = 1; i < 91; i++)
            {
                LVnumeros.Items.Add(i.ToString()); // Muestro los números del 1 al 90 en el ListView
                
                noventa.Add(i); // y los agrego a la lista "noventa"
            }            

            // Creo un boleto
            
            for (i = 0; i < 15; i++)
            {
                posicionaleatoria = r.Next(0, noventa.Count - 1); // saco una posición aleatoria de la lista "noventa"
                aleatorio = noventa[posicionaleatoria]; // obtengo el número guardado en esa posición
                numeros.Add(aleatorio); // lo agrego a mi boleto (a la lista q guarda mi boleto)
                noventa.Remove(aleatorio); // lo elimino de la lista de números q me pueden salir                                           
            }

            // Tengo 15 números en mi lista "numeros". Ahora los muestro en los botones.

            numeros.Sort(); // los ordeno
            
            for(i = 0; i < 15; i++)
            {
                numerosboleto[i].Text = numeros[i].ToString(); // escribo en el botón el nº elegido
            }               
            
        }

        /* BOTÓN "SACAR BOLA" */
        private void BTbola_Click(object sender, EventArgs e)
        {
            posicionaleatoria = r.Next(0, bombo.Count - 1);
            aleatorio = bombo[posicionaleatoria]; // Saco una bola del bombo
            bombo.Remove(aleatorio); // la elimino de la lista "bombo"

            LABnumextraido.Text = aleatorio.ToString(); // muestro el número

            /*
            LABnumextraido.Width = 70; // cambio el tamaño (o no)
            LABnumextraido.Height = 70;
            */

            if (bombo.Contains(aleatorio))
            {
                bombo.Remove(aleatorio);
            }

            // Muestro el contenido del bombo en el ListView

            LVnumeros.Clear();

            for(i = 0; i < bombo.Count - 1; i++)
            {
                LVnumeros.Items.Add(bombo[i].ToString());
            }                    
        }

        /// <summary>
        /// Indica si hay línea en el bingo.
        /// </summary>
        /// <returns>"true" si hay línea por primera vez, "false" si no.</returns>
        private bool HayLinea()
        {
            primeralinea = false;
            bool linea = false;

            if (((BT01carton.BackColor == Color.LightGreen && button2.BackColor == Color.LightGreen && BT03carton.BackColor == Color.LightGreen && BT04carton.BackColor == Color.LightGreen && BT05carton.BackColor == Color.LightGreen) || (BT06carton.BackColor == Color.LightGreen && BT07carton.BackColor == Color.LightGreen && BT08carton.BackColor == Color.LightGreen && BT09carton.BackColor == Color.LightGreen && BT10carton.BackColor == Color.LightGreen) || (BT11carton.BackColor == Color.LightGreen && BT12carton.BackColor == Color.LightGreen && BT13carton.BackColor == Color.LightGreen && BT14carton.BackColor == Color.LightGreen && BT15carton.BackColor == Color.LightGreen)) && primeralinea == false )
            {
                primeralinea = true;
                linea = true;
            }

            return linea;
        }

        /// <summary>
        /// Indica si hay bingo.
        /// </summary>
        /// <returns>true/false</returns>
        private bool HayBingo()
        {
            bool bingo;

            if (((BT01carton.BackColor == Color.LightGreen && button2.BackColor == Color.LightGreen && BT03carton.BackColor == Color.LightGreen && BT04carton.BackColor == Color.LightGreen && BT05carton.BackColor == Color.LightGreen) && (BT06carton.BackColor == Color.LightGreen && BT07carton.BackColor == Color.LightGreen && BT08carton.BackColor == Color.LightGreen && BT09carton.BackColor == Color.LightGreen && BT10carton.BackColor == Color.LightGreen) && (BT11carton.BackColor == Color.LightGreen && BT12carton.BackColor == Color.LightGreen && BT13carton.BackColor == Color.LightGreen && BT14carton.BackColor == Color.LightGreen && BT15carton.BackColor == Color.LightGreen)))
            {
                bingo = true;
            }
            else
            {
                bingo = false;
            }

            return bingo;
        }
        
        /// <summary>
        /// Cambia de color el botón (si es el indicado) y canta línea y bingo si ocurren.
        /// </summary>
        /// <param name="boton">Botón que pincha el usuario.</param>
        private void PinchaCarton(Button boton)
        {
            // Si el botón pinchado es el número que acaba de salir, se pone verde

            if (boton.Text == LABnumextraido.Text)
            {
                boton.BackColor = Color.LightGreen;
            }

            // Comprobar si hay línea o bingo

            if (HayLinea() && !primeralinea)
            {
                MessageBox.Show("¡LÍNEA!");
            }

            if (HayBingo())
            {
                MessageBox.Show("¡BINGO!");

                BTbola.Enabled = false; // Deshabilito el botón de sacar bola porque se acabó la partida.
            }       
            
            if(bombo.Count == 0) // si no pulsó los botones correctos
            {
                MessageBox.Show("¡Mendrugo!");
            }
        }

        private void BT01carton_Click(object sender, EventArgs e)
        {
            PinchaCarton(BT01carton);
        }

        /* Botón 2 del boleto: se le quedó este nombre por accidente (y no estoy segura de saber cambiarlo bien).
         * Por eso voy a tener que hacer cosas raras 15 veces.
         */
        private void button2_Click(object sender, EventArgs e)
        {
            PinchaCarton(button2);
        }

        private void BT03carton_Click(object sender, EventArgs e)
        {
            PinchaCarton(BT03carton);
        }

        private void BT04carton_Click(object sender, EventArgs e)
        {
            PinchaCarton(BT04carton);
        }

        private void BT05carton_Click(object sender, EventArgs e)
        {
            PinchaCarton(BT05carton);
        }

        private void BT06carton_Click(object sender, EventArgs e)
        {
            PinchaCarton(BT06carton);
        }

        private void BT07carton_Click(object sender, EventArgs e)
        {
            PinchaCarton(BT07carton);
        }

        private void BT08carton_Click(object sender, EventArgs e)
        {
            PinchaCarton(BT08carton);
        }

        private void BT09carton_Click(object sender, EventArgs e)
        {
            PinchaCarton(BT09carton);
        }

        private void BT10carton_Click(object sender, EventArgs e)
        {
            PinchaCarton(BT10carton);
        }

        private void BT11carton_Click(object sender, EventArgs e)
        {
            PinchaCarton(BT11carton);
        }

        private void BT12carton_Click(object sender, EventArgs e)
        {
            PinchaCarton(BT12carton);
        }

        private void BT13carton_Click(object sender, EventArgs e)
        {
            PinchaCarton(BT13carton);
        }

        private void BT14carton_Click(object sender, EventArgs e)
        {
            PinchaCarton(BT14carton);
        }

        private void BT15carton_Click(object sender, EventArgs e)
        {
            PinchaCarton(BT15carton);
        }

    }
}
