using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClases2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculo vehiculo = new Vehiculo(4, 2);

            Vehiculo vehiculo2 = new Vehiculo(0);

            Console.WriteLine(vehiculo.EsAcuatico(false));

        }
    }
}
