using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2_NSB.Ejercicio2
{
    public partial class VehiculosForm : Form
    {
        public VehiculosForm()
        {
            InitializeComponent();
        }

        private void carrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCarro rCarro = new rCarro();
            rCarro.Show();
        }

        private void lanchasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rMaritimo mar = new rMaritimo();
            mar.Show();
        }

        private void helicopterosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rAereo aire = new rAereo();
            aire.Show();
        }

        private void verTransportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cTransportesTerrestres terrestres = new cTransportesTerrestres();
            terrestres.Show();
        }
    }
}
