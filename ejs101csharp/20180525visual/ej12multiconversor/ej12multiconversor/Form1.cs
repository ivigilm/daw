using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ej12multiconversor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool modificando = false;
        string udinicial = "tsp";
        string udfinal = "ml";
        double medidainicial, medidafinal;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked) // si este es el botón q está seleccionado
            {
                udinicial = "tsp";
                udfinal = "ml";

                Conversion();
            }
        }

        private void RBTbstoml_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                udinicial = "Tbsp";
                udfinal = "ml";

                Conversion();
            }
        }

        private void RBfloztoml_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                udinicial = "fl oz";
                udfinal = "ml";

                Conversion();
            }
        }

        private void RBmltotsp_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                udinicial = "ml";
                udfinal = "tsp";

                Conversion();
            }
        }

        private void RBmltoTbsp_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                udinicial = "ml";
                udfinal = "Tbsp";

                Conversion();
            }
        }

        private void RBmltofloz_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                udinicial = "ml";
                udfinal = "fl oz";

                Conversion();
            }
        }

        private void Conversion() // string udinicial, string udfinal
        {
            if(TBvoriginal.Text != "")
            {
                medidainicial = Convert.ToDouble(TBvoriginal.Text);
            }
            else
            {
                throw new Exception("Debe introducir una cantidad.");
            }
            

            if (Double.TryParse(TBvoriginal.Text, out medidafinal))
            {
                // convierto la medida

                switch (udinicial)
                {
                    case "tsp":
                        medidafinal = medidainicial * 5;
                        break;
                    case "Tbsp":
                        medidafinal = medidainicial * 15;
                        break;
                    case "fl oz":
                        medidafinal = medidainicial * 30;
                        break;
                    case "ml":
                        switch (udfinal)
                        {
                            case "tsp":
                                medidafinal = medidainicial / 5;
                                break;
                            case "Tbsp":
                                medidafinal = medidainicial / 15;
                                break;
                            case "fl oz":
                                medidafinal = medidainicial / 30;
                                break;
                            default:
                                throw new Exception("Unidad final no contemplada");
                        }
                        break;
                    default:
                        throw new Exception("Unidad inicial no contemplada");
                }

                TBresultado.Text = medidafinal.ToString(); // la muestro
            }
            else
            {
                MessageBox.Show("Debe introducir una medida válida.");
            }
        }

        private void TBvoriginal_TextChanged(object sender, EventArgs e)
        {
            Conversion();
        }

        /* Hay que borrar esta función porque el campo TBresultado estará deshabilitado. */
        private void TBresultado_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
