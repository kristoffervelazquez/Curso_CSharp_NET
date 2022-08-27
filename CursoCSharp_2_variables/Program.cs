using System;

namespace CursoCSharp_2_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //string mensaje = null;

            int edad = default(int); // 0
            int? altura = null;
            bool verdadero = default(bool); // false

            if (altura == null)
            {
                // hacer algo
            }


            DateTime? fecha = new DateTime();
            fecha = null;

            int? dia = fecha?.Day;



            Console.WriteLine(fecha);
            Console.WriteLine(dia);

            Console.ReadLine();

            var variable = edad + "1";
            variable = edad;



        }
    }
}
