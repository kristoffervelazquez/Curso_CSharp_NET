using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioED_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pedir por pantalla 10 números, que iremos almacenando en un Listado(o 2 como prefiramos). 
            //al terminar de introducir los números, tendremos que recorrer el / los listados, diciéndonos cuanto suman los pares y cuando los impares.

            List<int> lista = new List<int>();
            int sumaImpares = 0;
            int sumaPares = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Inserte el numero #{i}: ");
                lista.Add(int.Parse(Console.ReadLine()));
            }

            foreach (int numero in lista)
            {
                if (numero % 2 == 0)
                {
                    sumaPares = numero + sumaPares;
                    Console.WriteLine($"El numero: {numero} es par");
                }
                else
                {
                    sumaImpares = numero + sumaImpares;
                    Console.WriteLine($"El numero: {numero} es impar");

                }
            }

            Console.WriteLine($"Los pares suman: {sumaPares}");
            Console.WriteLine($"Los impares suman: {sumaImpares}");

            Console.ReadLine();
        }
    }
}
