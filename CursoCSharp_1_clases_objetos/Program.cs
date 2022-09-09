using System;

namespace CursoCSharp_1_clases_objetos
{
    class Program
    {
        static void Main(string[] args)
        {

            CuentaBancaria cuenta1 = new(); // Se crea una instancia 1 de CuentaBancaria
            CuentaBancaria cuenta2 = new(); // Se crea una instancia 2 de CuenaBancaria


            Console.WriteLine(cuenta1.Estado); // Se imprime el estado de la cuenta (FALSE antes de activarse)
            cuenta1.ActivarCuenta(1200); // Se activa la cuenta bancaria con un saldo de 1200
            Console.WriteLine(cuenta1.Estado); // Se imprime el estado de la cuenta ya activada (TRUE)

            cuenta1.MostrarSaldo(); // Se imprime el saldo actual de la cuenta
            cuenta1.Retirada(200); // Se retiran 200 creditos
            cuenta1.MostrarSaldo(); // Se imprime el saldo actualizado (1200 - 200 = 1000)

            cuenta2.ActivarCuenta(3000); // Se activa la cuenta 2 con un saldo de 3000

            cuenta1.BloquearCuenta();
            Console.WriteLine(cuenta1.Estado);


            cuenta2.Retirada(cuenta1.Saldo); // Se retira la cantidad del saldo actual de la instancia 1
            cuenta2.MostrarSaldo(); // Se imprime el saldo actualizado (3000 - 1000 = 2000) 



        }
    }
}
