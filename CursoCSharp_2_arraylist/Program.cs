using System;
using System.Collections;
using System.Collections.Generic;

namespace CursoCSharp_2_arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList
            List<Object> lista = new List<Object>();

            lista.Add(1);
            lista.Add("Batman");

            var elemento = lista[0];
            var elemento1 = lista[1];

            Console.WriteLine(elemento1);

            lista.Insert(1, "Superman");

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            lista.RemoveAt(1);

            Console.WriteLine(lista.Count);
            Console.WriteLine(lista.Contains("Batman"));

            Console.ReadLine();

        }
    }
}
