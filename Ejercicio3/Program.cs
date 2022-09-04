using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crea un programa que pida una frase de al menos 20 caracteres y al menos 4 palabras por consola
            // y se muestre la siguiente información de esa cadena (usa funciones para cada caso) ,
            //se deberá validar que la cadena tiene al menos 20 caracteres y la frase consta al menos de 4 palabras
            string frase;

            Console.WriteLine("Por favor introduce una frase de al mentos 20 caractares y al menos 4 palabras");
            frase = Console.ReadLine();

            if (!ValidarCaractares(frase))
            {
                Console.WriteLine("No contiene 20 caractares");
                return;
            }

            if (!ValidarPalabras(frase))
            {
                Console.WriteLine("No contiene 4 palabras");
                return;
            }

            Console.WriteLine("Longitud de la cadena: " + frase.Length);
            Console.WriteLine(frase.ToUpper());
            Console.WriteLine(frase.ToLower());
            Console.WriteLine(CambiarLetraAtoX(frase));
            Console.WriteLine(RemoverPrimeras3Letras(frase));
            Console.WriteLine(Posicion5A10(frase));
            Console.WriteLine(TercerPalabra(frase));

            Console.ReadLine();


        }


        public static bool ValidarCaractares(string frase)
        {
            return (frase.Length >= 20);
        }


        public static bool ValidarPalabras(string frase)
        {
            var palabras = frase.Split(' ');

            return (palabras.Length >= 4);
        }


        public static string CambiarLetraAtoX(string frase)
        {
            return frase.Replace("A", "X").Replace("a", "x");
        }

        public static string RemoverPrimeras3Letras(string frase)
        {
            return frase.Substring(3);
        }

        public static string Posicion5A10(string frase)
        {
            return frase.Substring(5,5);
        }

        public static string TercerPalabra(string frase)
        {
            return frase.Split(' ')[2];
        }
    }
}
