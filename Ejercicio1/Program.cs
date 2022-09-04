using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear un programa que pida al usuario su nombre, y le diga "Hola" si se llama "Alejandro", o bien le diga "No te conozco" si teclea otro nombre. 
            // Tener en cuenta, que el la validación no es case sensitive, es decir que si escriben "alejandro" ,"Alejandro", "aleJANdrO" serán valores validos.

            string nombre;

            Console.Write("Introduce tu nombre: ");
            nombre = Console.ReadLine();

            if (nombre.ToLower() == "alejandro")
            {
                Console.WriteLine($"Hola Alejandro");
            }else
            {
                Console.WriteLine("No te conozco");
            }

            
            Console.ReadLine();
        }
    }
}
