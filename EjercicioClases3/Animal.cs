using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClases3
{
    internal class Animal
    {
        public string Tipo { get; set; }
        public string ColorPelo { get; set; }

        public int NumeroDePatas { get; set; }

        public Animal(string tipo, string colorPelo, int numeroDePatas)
        {
            Tipo = tipo;
            ColorPelo = colorPelo;
            NumeroDePatas = numeroDePatas;
        }


    }
}
