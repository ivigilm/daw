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
        }

        private void BTno_Click(object sender, EventArgs e)
        {
            LBo.Location = new Point(12, 30);
        }

        private void BTn_Click(object sender, EventArgs e)
        {
            LBo.Location = new Point(93, 30);
        }

        private void BTne_Click(object sender, EventArgs e)
        {
            LBo.Location = new Point(174, 30);
        }

        private void BTo_Click(object sender, EventArgs e)
        {
            LBo.Location = new Point(12, 96);
        }

        private void BTcentro_Click(object sender, EventArgs e)
        {
            LBo.Location = new Point(93, 96);
        }

        private void BTe_Click(object sender, EventArgs e)
        {
            LBo.Location = new Point(174, 96);
        }

        private void BTso_Click(object sender, EventArgs e)
        {
            LBo.Location = new Point(12, 163);
        }

        private void BTs_Click(object sender, EventArgs e)
        {
            LBo.Location = new Point(93, 163);
        }

        private void BTse_Click(object sender, EventArgs e)
        {
            LBo.Location = new Point(174, 163);
        }
    }
}
