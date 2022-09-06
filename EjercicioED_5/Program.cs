using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioED_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Usando Arrays, crea un programa que nos pida cuantos elementos tendrá el array, 
            //dependiendo de ese numero de elementos, nos ira pidiendo valores, que introduciremos en el array. 
            //una vez introducidos, nos pedirá un nuevo valor a insertar y la posición donde queremos insertarla en el array.
            List<Object> lista = new List<Object>();


            Console.Write("Por favor introduce la cantidad de elementos que tendrá la lista: ");
            int longitud = int.Parse(Console.ReadLine());

            for(int i = 0; i < longitud; i++)
            {
                Console.Write("Inserte un valor: ");
                lista.Add(Console.ReadLine());
            }

            Console.Write("Que valor desea inserar ahora?: ");
            var valorNuevo = Console.ReadLine();
            Console.Write("En que posicion desea insertarlo?: ");
            int posicionNueva = int.Parse(Console.ReadLine());
            lista.Insert(posicionNueva-1, valorNuevo);

            foreach(Object obj in lista)
            {
                Console.WriteLine(obj.ToString());
            }

            Console.ReadLine();
            
        }
    }
}
