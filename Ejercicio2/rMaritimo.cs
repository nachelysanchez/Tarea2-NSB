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
    public partial class rMaritimo : VehiculoGeneralFrm
    {
        public rMaritimo()
        {
            InitializeComponent();
        }

        private void rMaritimo_Load(object sender, EventArgs e)
        {

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            


        }

        private bool Validar()
        {
            bool paso = true;
            if(marcaTextBox.Text == string.Empty || marcaTextBox.Text == "")
            {
                MessageBox.Show("Debe de ingresar una marca");
                paso = false;
                marcaTextBox.Focus();
            }
            else if(anioTextBox.Text == string.Empty || marcaTextBox.Text == "")
            {
                MessageBox.Show("Debe de ingresar un año de creación");
                paso = false;
                anioTextBox.Focus();
            }
            else if (placaTextBox.Text == string.Empty || placaTextBox.Text == "")
            {
                MessageBox.Show("Debe de ingresar una placa");
                paso = false;
                placaTextBox.Focus();
            }
            else if(combustibleTextBox.Text == string.Empty || combustibleTextBox.Text == "")
            {
                MessageBox.Show("Debe de ingresar un tipo de combustible");
                paso = false;
                combustibleTextBox.Focus();
            }
            else if (numAlastxt.Text == string.Empty || numAlastxt.Text == "")
            {
                MessageBox.Show("Debe de ingresar un numero de helices");
                paso = false;
                numAlastxt.Focus();
            }
            else if (Tamanotxt.Text == string.Empty || Tamanotxt.Text == "")
            {
                MessageBox.Show("Debe de ingresar el tamaño");
                paso = false;
                Tamanotxt.Focus();
            }
            return paso;
        }
    }
}
