using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_NSB.ClasesEj2
{
    class Maritimo : Vehiculo
    {
        private int numeroHelices;

        public int NumeroHelices
        {
            set
            {
                numeroHelices = value;
            }
            get
            {
                return numeroHelices;
            }
        }
    }
}
