using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioED_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa nos pida introducir 10 números enteros. 
            //esos valores los introduciremos en un Listado y  mostraremos el numero mayor y menor, consultando los valores en el Listado.

            List<int> list = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Inserte el numero #{i}: ");
                list.Add(int.Parse(Console.ReadLine()));
            }

            list.Sort((a, b) => a - b);

            Console.WriteLine("El numero menor: " + list[0]);
            Console.WriteLine("El numero mayor: " + list[9]);
            Console.ReadLine();

        }
    }
}
