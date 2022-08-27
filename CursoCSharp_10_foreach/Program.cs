using System;
using System.Collections.Generic;
using static System.Console;

namespace CursoCSharp_10_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaDeNumeros = new List<int> { 0, 1, 2, 4, 5, 6, 7, 8, 9 };

            foreach (var numero in listaDeNumeros)
            {
                WriteLine(numero);
            }

            var listaDePersonas = new List<Persona>();

            var persona1 = new Persona()
            {
                Edad = 20,
                Apellido = "Velázquez",
                Nombre = "Kristoffer"

            };

            var persona2 = new Persona()
            {
                Edad = 19,
                Apellido = "Villa",
                Nombre = "Hanna"

            };

            listaDePersonas.Add(persona1);
            listaDePersonas.Add(persona2);

            foreach (var persona in listaDePersonas)
            {
                Console.WriteLine($"{persona.Nombre} {persona.Apellido}, tiene {persona.Edad} años");
            }

        }
    }


    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
    }

}
