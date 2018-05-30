using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ej13supertest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        // introducir preguntas 3, 4 y 5
        string[] preguntas = new string[] { "¿Qué significa LAN?", "¿Qué significa WAN?", "¿Qué significa IP?", "¿Qué significa OSI?", "El protocolo Ethernet fue inventado por..."};
        int[] soluciones = new int[] { 1, 2, 3, 1, 2 }; // guardo las soluciones del test
        int[] respuestasusuario = new int[5]; // Inicializo la hoja de respuestas del usuario.
        int preguntaactual = 1;

        private void BTempezar_Click(object sender, EventArgs e)
        {
            LABq.Visible = true;
            RBa1.Visible = true;
            RBa2.Visible = true;
            RBa3.Visible = true;
            BTcontinuar.Visible = true;
            BTempezar.Visible = false;
            LABinicio.Visible = false;
        }
        
        private void RBa1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked) // si el RB actual es el q pinchó el usuario
            {
                // guardo su respuesta
                respuestasusuario[preguntaactual - 1] = 1;
            }

        }
        
        private void RBa2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                respuestasusuario[preguntaactual - 1] = 2;
            }
        }

        private void RBa3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                respuestasusuario[preguntaactual - 1] = 3;
            }
        }

        private void BTcontinuar_Click(object sender, EventArgs e)
        {
            preguntaactual = preguntaactual + 1; // voy aumentando el número de la pregunta según avanza por el test

            if(preguntaactual <= 5)
            {
                LABq.Text = "Pregunta " + preguntaactual + ": " + preguntas[preguntaactual - 1];
            }

            switch (preguntaactual)
            {
                case 1:
                    ; // se deja vacío (ya están introcidas como texto inicial)
                    break;
                case 2:
                    RBa1.Text = "Windows Area Network";
                    RBa2.Text = "Wide Area Network";
                    RBa3.Text = "World Area Network";
                    ;
                    break;
                case 3:
                    RBa1.Text = "Illinois Protocol";
                    RBa2.Text = "Internet Pool";
                    RBa3.Text = "Internet Protocol";
                    ; // introducir respuestas para las preguntas 3, 4 y 5
                    break;
                case 4:
                    RBa1.Text = "Open System Interconnection";
                    RBa2.Text = "Open Software Interconnection";
                    RBa3.Text = "Open System Internet";
                    ;
                    break;
                case 5:
                    RBa1.Text = "Robert Bobby";
                    RBa2.Text = "Robert Metcalfe";
                    RBa3.Text = "Bobby Bobby";

                    BTcontinuar.Text = "Finalizar"; // cambio el texto del botón
                    ;
                    break;
                case 6: // Aquí no hay pregunta: es el resultado del test.
                    RBa1.Visible = false;
                    RBa2.Visible = false;
                    RBa3.Visible = false;

                    int aciertos = 0;

                    for (int i = 0; i < 5; i++)
                    {
                        if(soluciones[i] == respuestasusuario[i])
                        {
                            aciertos = aciertos + 1;
                        }
                    }

                    LABq.Text = "Has acertado un total de " + aciertos + " respuestas.";

                    BTcontinuar.Visible = false; // Al dar el resultado, el botón desaparece.
                    ;
                    break;
            }
        }
    }
}
