using System;
using System.Collections;

namespace CursoCSharp_3_pila
{
    class Program
    {
        static void Main(string[] args)
        {
            //LIFO last in first out   --> ultimo en entrar, primero en salir --> el primero que entra, es el ultimo en salir
            Stack pila = new Stack();

            pila.Push(10);
            pila.Push(20);
            pila.Push(30);
            pila.Push(40);

            //3 --> 10 --> 5 --> 1

            var numero = pila.Pop(); // Regresa el valor de arriba del stack y lo elimina de la pila.
            Console.WriteLine(numero);
            
            numero = pila.Peek(); // Regresa el valor de arriba del stack sin quitarlo de la pila.
            Console.WriteLine(numero);
            Console.WriteLine("----");
            Console.ReadLine();

            foreach (var item in pila)
            {
                Console.WriteLine(item);
                Console.ReadLine();
            }

            ////Contar elementos
            //int contador = pila.Count;

            ////Limpiar la pila
            //pila.Clear();

            //if (pila.Contains(10))
            //{
            //    Console.WriteLine("Contiene un 10");
            //}
        }
    }
}
