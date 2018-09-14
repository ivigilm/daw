using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ej8cursor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // LBo.Location = new Point(120, 112); // le doy coordenadas iniciales
            LBo.BackColor = Color.ForestGreen; // le doy color a la etiqueta para verla bien
        }

        // Para cada botón (Norte - Sur - Este ...)
        private void BTno_Click(object sender, EventArgs e)
        { 
            // Al pinchar el botón, muevo la etiqueta 1 punto hacia ese botón
            LBo.Location = new Point(LBo.Location.X - 1, LBo.Location.Y - 1);
        }

        private void BTn_Click(object sender, EventArgs e)
        {
            LBo.Location = new Point(LBo.Location.X, LBo.Location.Y - 1);
        }

        private void BTne_Click(object sender, EventArgs e)
        {
            LBo.Location = new Point(LBo.Location.X + 1, LBo.Location.Y - 1);
        }

        private void BTo_Click(object sender, EventArgs e)
        {
            LBo.Location = new Point(LBo.Location.X - 1, LBo.Location.Y);
        }

        private void BTcentro_Click(object sender, EventArgs e)
        {
            // Muevo la etiqueta sobre el eje X

            if (LBo.Location.X > 120) // está a la derecha
            {
                LBo.Location = new Point(LBo.Location.X - 1, LBo.Location.Y);
            }
            else
            {
                if(LBo.Location.X < 120) // está a la izquierda
                {
                    LBo.Location = new Point(LBo.Location.X + 1, LBo.Location.Y);
                }                
            }

            // Muevo la etiqueta sobre el eje Y

            if(LBo.Location.Y > 112)
            {
                LBo.Location = new Point(LBo.Location.X, LBo.Location.Y - 1);
            }
            else
            {
                if(LBo.Location.Y < 112)
                {
                    LBo.Location = new Point(LBo.Location.X, LBo.Location.Y + 1);
                }
            }

            // Si // x == 120 && y  == 112 se queda quieta

        }

        private void BTe_Click(object sender, EventArgs e)
        {
            LBo.Location = LBo.Location = new Point(LBo.Location.X + 1, LBo.Location.Y);
        }

        private void BTso_Click(object sender, EventArgs e)
        {
            LBo.Location = LBo.Location = new Point(LBo.Location.X - 1, LBo.Location.Y + 1);
        }

        private void BTs_Click(object sender, EventArgs e)
        {
            LBo.Location = new Point(LBo.Location.X, LBo.Location.Y + 1);
        }

        private void BTse_Click(object sender, EventArgs e)
        {
            LBo.Location = new Point(LBo.Location.X + 1, LBo.Location.Y + 1);
        }
    }
}
