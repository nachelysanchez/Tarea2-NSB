using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea2_NSB.Clases;

namespace Tarea2_NSB.Ejercicio1
{
    public partial class NominaForm : Form
    {
        public NominaForm()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            claNomina nomina = new claNomina(double.Parse(SueldoTextBox.Text));
            irsTextBox.Text = nomina.ValorISR.ToString("N2");
            afpTextBox.Text = nomina.ValorAFP.ToString("N2");
            arsTextBox.Text = nomina.ValorARS.ToString("N2");
            descuentosTextBox.Text = nomina.TotalDescuentos.ToString("N2");
            SueldoNetoTextBox.Text = nomina.SueldoNeto.ToString("N2");
        }
    }
}
