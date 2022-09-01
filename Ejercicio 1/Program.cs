using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PesosToDolar());
            Console.ReadKey();
        }

        public static double PesosToDolar()
        {
            Console.WriteLine("Cual es el precio del dolar hoy?");
            double precioDolar = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad en pesos que desea convertir: ");
            int pesos = int.Parse(Console.ReadLine());


            return pesos / precioDolar;
        }




        
    }
}
