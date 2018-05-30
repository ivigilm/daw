using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ej4adivino
{
    public partial class Form1 : Form
    {
        // Atributos de la clase Form1
        
        private double intento = 50; // el último número que he probado
        private double min = 0; // rango donde está el número q hay q adivinar
        private double max = 100;

        public Form1()
        {
            InitializeComponent();            
        }

        private void BTmayor_Click(object sender, EventArgs e)
        {
            // El usuario me dice que el número es mayor del que le he dicho:
            min = intento + 1;

            // El próximo intento será el número que esté en medio del rango de números posibles:
            intento = Math.Round((max + min )/ 2);

            // Le comunico mi nuevo intento:
            LBinstrucciones.Text = "¿Es tu número el " + intento.ToString() + "?";
        }

        private void BTmenor_Click(object sender, EventArgs e)
        {
            // El usuario me dice que el número es menor del que le he dicho:
            max = intento - 1;

            // Próximo intento
            intento = Math.Round((max + min) / 2);

            // Le comunico mi nuevo intento:
            LBinstrucciones.Text = "¿Es tu número el " + intento.ToString() + "?";
        }

        private void BTacertado_Click(object sender, EventArgs e)
        {
            // El usuario me dice que acerté su número.

            LBinstrucciones.Text = "¡Ja-ja!";
            
        }
    }
}
