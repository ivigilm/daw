using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ej19reservabus
{
    public partial class Form1 : Form
    {
        List<Button> asientosbus = new List<Button>();

        public Form1()
        {
            InitializeComponent();

            int i, j, x, y;
            x = 20;
            y = 20;

            for(i = 1; i < 64; i = i + 4)
            {
                for(j = i; j < i + 4; j++)
                {
                    Button b = new Button(); // creo un botón
                    b.Text = j.ToString(); // Muestro el número del asiento en el botón.
                    b.Location = new Point(x, y); // Coloco el botón en su sitio.
                    b.Size = new Size(50, 50); // Le doy tamaño al botón.
                    b.BackColor = Color.LightGreen; // Lo pinto de verde.
                    b.Click += new EventHandler(B_Click); // Le adjudico al botón el evento que se lanza al pulsarlo.
                    this.Controls.Add(b); // Añado el botón a la propiedad Controls.
                    asientosbus.Add(b); // lo agrego a la lista de botones-asiento
                    x = x + 60;

                    if ((j - 2)%4 == 0) // Pasillo
                    {
                        x = x + 60;
                    }
                }

                x = 20;
                y = y + 60;
            }
        }
        
        private void B_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender; // sender me manda un objeto que es el botón: lo tranformo a botón
            
                // El usuario elige un asiento (o lo deselecciona)
                if (b.BackColor == Color.LightGreen) // Si el asiento estaba libre (verde), se pone en amarillo.
                {
                    b.BackColor = Color.Yellow; // El color del asiento cambia a amarillo.
                    BTguardar.Enabled = true; // Habilito el botón de guardar.
                }                
                else
                {
                    if (b.BackColor == Color.Yellow)  // Si estaba en amarillo, se pone en verde. 
                    {
                        b.BackColor = Color.LightGreen; // El asiento vuelve a estar libre (verde).
                        int amarillos = 0;

                        for (int i = 0; i < 63; i++)
                        {
                            if (asientosbus[i].BackColor == Color.Yellow)
                            {
                                amarillos = amarillos + 1;
                            }
                        }

                        if(amarillos == 0) // Si no hay ningún botón pulsado, se deshabilita "Guardar".
                        {
                            BTguardar.Enabled = false;
                        }
                    }
                    else // Si en rojo, no se puede seleccionar.
                    {
                        // No pongo nada aquí, porque cuando se ponga en rojo se deshabilitará a la vez.
                    }
                }
                
        }

        /* BORRAR ESTA FUNCIÓN */
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void BTguardar_Click(object sender, EventArgs e)
        {
            int i, amarillos;
            string asientosreservados = "";
            amarillos = 0;

            for(i = 0; i < 63; i++)
            {
                if(asientosbus[i].BackColor == Color.Yellow)
                {
                    amarillos = amarillos + 1;
                    asientosreservados = asientosreservados + asientosbus[i].Text + " "; // lo ideal sería formatear los asientos 
                    asientosbus[i].BackColor = Color.Red; // Coloreo de rojo el asiento reservado
                    asientosbus[i].Enabled = false;
                }
            }

            // Creo un array de cadenas donde guardaré los datos de cada campo de un elemento (fila).
            string[] datosreserva = new string[] { TBnombrereserva.Text, amarillos.ToString() + " (" + asientosreservados + ")" };

            // Creo una línea (li) para mi ListView y la relleno con los datos.
            ListViewItem li = new ListViewItem(datosreserva); // Guardo el nombre de la reserva en la primera columna

            listView1.Items.Add(li);
            
            amarillos = 0; // Reinicio el contador de amarillos
        }
    }
}
