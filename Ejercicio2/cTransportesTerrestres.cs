using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea2_NSB.ClasesEj2;

namespace Tarea2_NSB.Ejercicio2
{
    public partial class cTransportesTerrestres : Form
    {
        public cTransportesTerrestres()
        {
            InitializeComponent();
        }

        private void cTransportesTerrestres_Load(object sender, EventArgs e)
        {

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Carro carros = new Carro();
            foreach (var item in carros.Carros)
            {
                terrestresGrid.Rows.Add(item.Marca, item.Anio.ToString(), item.Placa, item.Combustible, item.NumeroRuedas.ToString(), item.NumeroPuertas.ToString(), item.Ocupado.ToString());
            }
        }
    }
}
