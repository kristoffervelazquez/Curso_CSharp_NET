using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClases2
{
    internal class Vehiculo
    {
        private int Ruedas { get; set; }
        private int Puertas { get; set; }

        public Vehiculo(int ruedas, int puertas)
        {
            Ruedas = ruedas;
            Puertas = puertas;
        }

        public Vehiculo(int ruedas)
        {
            Ruedas = ruedas;
        }


        public virtual bool EsAereo(bool aereo)
        {
            return aereo;
        }

        public virtual bool EsAcuatico(bool acuatico)
        {
            return acuatico;
        }
        public virtual bool EsDeTierra(bool tierra)
        {
            return tierra;
        }
    }
}
