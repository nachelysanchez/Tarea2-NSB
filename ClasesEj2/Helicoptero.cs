using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_NSB.ClasesEj2
{
    class Helicoptero : Aereo
    {
        private double velocidad;
        protected double Velocidad
        {
            set
            {
                velocidad = value;
            }
            get
            {
                return velocidad;
            }
        }

        public Helicoptero(string marca, int anio, string placa, string combustible, int numeroAlas, double velocidad, bool ocupado)
        {
            Marca = marca;
            Anio = anio;
            Placa = placa;
            Combustible = combustible;
            NumeroAlas = numeroAlas;
            Velocidad = velocidad;
            Ocupado = ocupado;
        }
    }
}
