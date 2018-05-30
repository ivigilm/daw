using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ej11generadordados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();

        private void BTtirar_Click(object sender, EventArgs e)
        {
            // Limpio el listbox
            LBtiradas.Items.Clear();

            // Agrega los resultados de las tiradas al listbox (primero debo realizar las tiradas)
            int i, resultado, suma;
            suma = 0;

            for(i = 0; i < NUDdados.Value; i++) // tiro cada dado
            {
                resultado = r.Next(1, Convert.ToInt32(NUDcaras.Value) + 1); // realizo una tirada
                LBtiradas.Items.Add(resultado); // agrego el resultado a la lista
                suma = suma + resultado; // sumamos los resultados de las tiradas
            }

            TBsuma.Text = suma.ToString();
        }
    }
}
