using CursoCSharp_7_nivel_accesibilidad;
using System;

namespace CursoCSharp_6_nivel_accesibilidad
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseDerivada clasederiv = new();
            clasederiv.Nacionalidad = "Mexicana"; 
            clasederiv.Nombre = "Kristoffer";
            clasederiv.Telefono = "123123123123123";
            clasederiv.Sumar(69, 69);
        }
    }
}
