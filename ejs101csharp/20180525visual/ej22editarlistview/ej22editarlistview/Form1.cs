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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Abre un nuevo formulario para la introducción de los datos de un nuevo registro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTnuevo_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            DialogResult dr = f.ShowDialog();

            // En este punto se va al Form2 y vuelve

            if(dr == DialogResult.OK)
            {
                ListViewItem lvi = new ListViewItem(f.datos);

                listView1.Items.Add(lvi);
            }
        }
    }
}
