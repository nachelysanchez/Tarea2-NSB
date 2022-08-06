using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_NSB.ClasesEj2
{
    class Aereo : Vehiculo
    {
        private int numeroAlas;
        protected int  NumeroAlas
        {
            set
            {
                numeroAlas = value;
            }
            get
            {
                return numeroAlas;
            }
        }
    }
}
