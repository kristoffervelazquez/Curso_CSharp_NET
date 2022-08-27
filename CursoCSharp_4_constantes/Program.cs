using System;

namespace CursoCSharp_4_constantes
{
    class Program
    {
        public const string NOMBRE = "Pedro";
        public const int NUMERO_PEDIDOS_MAXIMOS = 10;
        static void Main(string[] args)
        {
            // Esto no se hace
            // NUMERO_PEDIDOS_MAXIMOS = 12;
            for(int i = 0; i < NUMERO_PEDIDOS_MAXIMOS; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
