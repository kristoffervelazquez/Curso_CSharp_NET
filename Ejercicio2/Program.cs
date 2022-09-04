using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir un programa que pida una palabra, y la escriba a su inversa, por ejemplo si se introduce Paris, devolverá "Sirap".


           Console.WriteLine("Inrtroduce una palabra: ");

            string palabra = Console.ReadLine();

            if(palabra != null)
            {
                char[] array = palabra.ToCharArray();
                Array.Reverse(array);
                palabra = new String(array);

                Console.WriteLine(palabra);
            }
            Console.ReadLine();
        }
    }
}
