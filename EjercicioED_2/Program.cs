using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioED_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pedir por pantalla 5 nombres, e insertarlo en una Lista(List) 
            //una vez insertados, se pedirá que introduzcamos un nombre, el programa tendrá que decirnos, si ese nombre esta contenido en la lista.

            List<string> list = new List<string>();

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Por favor introduzca el nombre #{i}: ");
                list.Add(Console.ReadLine());
            }

            Console.WriteLine("Busca el nombre: ");
            string nombre = Console.ReadLine();

            if (list.Contains(nombre))
            {
                Console.WriteLine("El nombre esta en la lista");
            }
            else
            {
                Console.WriteLine("El nombre especificado no existe");
            }

            Console.ReadLine();
        }
    }
}
