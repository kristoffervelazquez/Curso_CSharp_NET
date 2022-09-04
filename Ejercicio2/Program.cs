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

            if (palabra != null)
            {
                char[] array = palabra.ToCharArray();
                Array.Reverse(array);
                palabra = new String(array);

                Console.WriteLine(palabra);
            }
            Console.ReadLine();


            //Crear un programa que muestre las letras de la Z(mayúscula) a la A(mayúscula, descendiendo)

            int i;
            Console.Write("ABECEDARIO DESCENDENTE");
            Console.WriteLine();

            //Se recorren los numero de conversion de char segun su numero

            for (i = 90; i >= 65; i--)
            {
                Console.WriteLine("LETRA: " + Convert.ToString((char)i));
            }
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
    }
}
