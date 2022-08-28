using System;

namespace CursoCSharp_3_funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string saludo = Saludo("Kristoffer", "Velazquez Martinez");
            Console.WriteLine(saludo);

        }

        // Se le pasan parametros y devuelve valor
        public static string Saludo(string nombre, string apellidos)
        {   
            Metodo(); // Se llama al metodo dentro de una funcion 
            return ($"Hola, mi nombre es: {nombre} {apellidos}");
        }

        // Metodo: Solo ejecutan codigo
        public static void Metodo()
        {
            Console.WriteLine("Valor");
        }

        // Devuelve valor pero no recibe valores
        public static int FuncionSinParametros()
        {
            return 6 + 9;
        }

        // Metodo que no devuelvevalor y recibe parametros
        public static void MetodoConParametros(string nombre, string apellido)
        {
            Console.WriteLine(nombre + " " + apellido);
        }


    }
}
