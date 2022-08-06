using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea2_NSB.Ejercicio1;

namespace Tarea2_NSB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NominaForm nomina = new NominaForm();
            nomina.Show();
        }
    }
}
