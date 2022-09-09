using System;
using System.Collections.Generic;

namespace CursoCSharp_6_poliformismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gato gato = new();
            gato.HacerRuido();

            Perro perro = new();
            perro.HacerRuido();

            Lobo lobo = new();
            lobo.HacerRuido();

            Pez pez = new();
            pez.HacerRuido();

            Console.Read();

            List<Animal> animales = new();
            animales.Add(gato);
            animales.Add(perro);
            animales.Add(lobo);
            animales.Add(pez);

            foreach (var item in animales)
            {
                item.HacerRuido();
            }

            Console.Read();

        }
    }
}
