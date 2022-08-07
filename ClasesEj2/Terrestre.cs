using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_NSB.ClasesEj2
{
    class Terrestre : Vehiculo
    {
        
        private int numeroPuertas;

        

        public int NumeroPuertas
        {
            set
            {
                numeroPuertas = value;
            }
            get
            {
                return numeroPuertas;
            }
        }
    }
}
