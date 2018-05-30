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

namespace ej18blocnotaspro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarContenido(); // Guardo

            TBcontenido.Clear(); // Vacío el contenido del fichero.
        }

        private void GuardarContenido()
        {
            StreamWriter sw;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();

            sfd.FileName = "nota"; // Pongo un nombre opcional que utilizará para el nuevo fichero si no lo modifica el usuario.

            sw = new StreamWriter(sfd.FileName);

            sw.Write(TBcontenido.Text);

            /*
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                sw.Write(TBcontenido.Text);
            }
            */

            sw.Close();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            string fichero = "";
            OpenFileDialog ofd = new OpenFileDialog(); // Abro la ventana de "Examinar"
            ofd.ShowDialog();

            StreamReader file = new StreamReader(ofd.FileName, Encoding.Default); // Inicio la lectura del fichero seleccionado

            while (!file.EndOfStream)
            {
                fichero = fichero + file.ReadLine() + "\r\n"; // Guardo la información del fichero en una cadena
            }

            // Antes de grabar el nuevo contenido, vacío y guardo el anterior
            TBcontenido.Clear();

            // => guardar

            // Muestro el contenido del fichero en el bloc
            TBcontenido.Text = fichero;

            file.Close();            
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarContenido();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            StreamWriter sw = null;

            sfd.Filter = "Text (*.txt)|*.txt|HTML(*.html)|*.html|All files(*.*)|*.*)";
            sfd.CheckFileExists = true;
            sfd.Title = "Guardar como";
            sfd.ShowDialog(this);

            try
            {
                sw = File.AppendText(sfd.FileName);
                sw.Write(TBcontenido.Text);
                sw.Flush();
            }
            catch (Exception)
            {

            }

            sw.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        
        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TBcontenido.Cut();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TBcontenido.Copy();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TBcontenido.Paste();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TBcontenido.SelectedText = "";
        }

        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TBcontenido.SelectAll();
        }

        private void horaYFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TBcontenido.AppendText(DateTime.Now.ToString());
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();

            if (fd.ShowDialog() == DialogResult.OK)
            {
                TBcontenido.Font = fd.Font;
            }
        }

        private void acercaDelBlocDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Hola, Luis! \r\n Este bloc de notas ha sido creado en junio de 2018. Próximas versiones próximamente.");
        }
    }
}
