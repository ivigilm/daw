using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ej16peqbasedatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            

            // Lee los datos guardados en un fichero
            
            StreamReader sr = new StreamReader("gatitos.txt", Encoding.Default);

            // Creo los campos

            sr.ReadLine();

            /* ASÍ AGREGARÍA LA CABECERA DE LOS CAMPOS SI NO LOS HUBIERA AGREGADO YA EN EL DISEÑO
             * 
            string[] celdas = sr.ReadLine().Split(','); // Leo la primera línea del fichero y la guardo en un array (cada posición, un nombre de campo)

            for(i = 0; i < celdas.Length; i++)
            {
                listView1.Columns.Add(celdas[i]); // Creo las columnas/campos con el nombre indicado
            }
            */

            while (!sr.EndOfStream)
            {
                string[] datos = sr.ReadLine().Split(','); // Leo la siguiente línea y la guardo en un array (cada valor de celda en una posición)

                ListViewItem lvi = new ListViewItem(datos); // Agrego el conjunto de datos de la línea al nuevo ítem

                listView1.Items.Add(lvi); // Agrego el nuevo ítem a mi ListView
            }

            sr.Close();
        }

        int i, j;

        private void BTnuevo_Click(object sender, EventArgs e)
        {
            // Limpiamos los datos introducidos en el formulario

            for(i = 0; i < this.Controls.Count; i++)
            {
                if(this.Controls[i].GetType() == typeof(TextBox))
                {
                    this.Controls[i].Text = "";
                }
            }

            /* Esto sustituye a:
            TBcolorojos.Text = "";
            TBcolorpelo.Text = "";
            TBnombre.Text = "";
            TBpeso.Text = "";
            TBraza.Text = "";
            TBtamano.Text = "";
            */
        }

        private void BTguardar_Click(object sender, EventArgs e)
        {
            // Creo un array donde guardo los 6 datos de cada gato (en el orden en que aparecen en el ListView)

            string[] nuevafila = new string[6];

            nuevafila[0] = TBnombre.Text;
            nuevafila[1] = TBcolorpelo.Text;
            nuevafila[2] = TBraza.Text;
            nuevafila[3] = TBpeso.Text;
            nuevafila[4] = TBtamano.Text;
            nuevafila[5] = TBcolorojos.Text;

            // Creo un nuevo ítem de tipo "ListView" y guardo en él el array de datos

            ListViewItem nuevo = new ListViewItem(nuevafila);

            // Añado el elemento al control ListView deseado

            listView1.Items.Add(nuevo);
        }

        private void BTborrar_Click(object sender, EventArgs e)
        {
            // Para cada elemento ListViewItem en el conjunto de elementos seleccionados de mi listView1

            foreach (ListViewItem fila in listView1.SelectedItems)
            {
                fila.Remove(); // elimino ese elemento
            }            
        }

        private void BTmodificar_Click(object sender, EventArgs e)
        {
            // Copio el contenido de la fila a los cuadros de texto

            TBnombre.Text = listView1.SelectedItems[0].Text;
            TBcolorpelo.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TBraza.Text = listView1.SelectedItems[0].SubItems[2].Text;
            TBpeso.Text = listView1.SelectedItems[0].SubItems[3].Text;
            TBtamano.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TBcolorojos.Text = listView1.SelectedItems[0].SubItems[5].Text;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {           
            // Si hay alguna fila seleccionada, habilito los botones Borrar y Modificar.

            if(listView1.SelectedIndices.Count > 0)
            {
                BTborrar.Enabled = true;
                BTmodificar.Enabled = true;
            }
            else // Si no hay ninguna fila seleccionada, los deshabilito.
            {
                BTborrar.Enabled = false;
                BTmodificar.Enabled = false;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string linea = "";

            // Guardaremos la tabla de datos en un fichero de texto llamado "gatitos.txt".

            StreamWriter sw = new StreamWriter("gatitos.txt", false, Encoding.Default);

            // Escribo los títulos de los campos

            sw.Write(nombre.Text + ',' + colorpelo.Text + ',' + raza.Text + ',' + peso.Text + ',' + tamano.Text + ',' + colorojos.Text);
            sw.WriteLine();
            
            // Escribo los datos

            for(i = 0; i < listView1.Items.Count; i++)
            {
                for(j = 0; j < 5; j++)
                {
                    linea = linea + listView1.Items[i].SubItems[j].Text + ",";
                }

                linea = linea + listView1.Items[i].SubItems[5].Text;

                sw.WriteLine(linea);
                linea = "";
            }

            sw.Close();
        }

        // Este podría ser otro botón: inicializar la tabla (borrar todos los registros)
        // ListView1.Items.Clear
    }
}
