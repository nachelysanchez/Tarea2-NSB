using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_NSB.ClasesEj2
{
    class Vehiculo
    {
        private string marca;
        private int anio;
        private string placa;
        private string combustible;
        private bool ocupado;

        protected string Marca
        {
            set
            {
                marca = value;
            }
            get
            {
                return marca;
            }
        }
        protected int Anio
        {
            set
            {
                anio = value;
            }
            get
            {
                return anio;
            }
        }
        protected string Placa
        {
            set
            {
                placa = value;
            }
            get
            {
                return placa;
            }
        }
        protected string Combustible
        {
            set
            {
                combustible = value;
            }
            get
            {
                return combustible;
            }
        }

        protected bool Ocupado
        {
            set
            {
                ocupado = value;
            }
            get
            {
                return ocupado;
            }
        }
    }
}
