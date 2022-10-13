using CursoCSharp_5_campos_propiedades;
using CursoCSharp_7_nivel_accesibilidad;
using System;

namespace CursoCSharp_6_metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Clase clase = new Clase();
            clase.SumarQuince(30);
            
            var suma = Clase.Sumar(1, 6);

            Console.WriteLine(suma);
            Console.ReadLine();
        }
    }
}
