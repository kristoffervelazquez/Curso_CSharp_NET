using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioED_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa, que recorra con un bucle for del 1 al 1000, insertando en cada iteración el valor del numero en un ArrayList.
            //una vez acabe el proceso, recorreremos ese ArrayList mostrando en consola la suma de los números, ejemplo: 1, 3, 6, 10.

            List<int> lista = new List<int>();

            var suma = 0;

            for (int i = 1; i <= 1000; i++)
            {
                lista.Add(i);
            }

            foreach (var numero in lista)
            {
                suma = numero + suma;
                Console.WriteLine(suma);

            }
            Console.ReadLine();


        }
    }
}
