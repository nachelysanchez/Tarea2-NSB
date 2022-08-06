using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_NSB.ClasesEj2
{
    class Lancha : Maritimo
    {
        private int tamanio;

        private static List<Lancha> lanchas = new List<Lancha>();

        protected List<Lancha> Lanchas
        {
            get
            {
                return lanchas;
            }
            set
            {
                lanchas = value;
            }
        }

        protected int Tamanio
        {
            set
            {
                tamanio = value;
            }
            get
            {
                return tamanio;
            }
        }

        public Lancha(string marca, int anio, string placa, string combustible, int numeroHelices, int tamano, bool ocupado)
        {
            Marca = marca;
            Anio = anio;
            Placa = placa;
            Combustible = combustible;
            NumeroHelices = numeroHelices;
            Tamanio = tamano;
            Ocupado = ocupado;
        }
    }
}