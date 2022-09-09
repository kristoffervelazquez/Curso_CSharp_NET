using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp_1_clases_objetos
{

    public class CuentaBancaria
    {

        public int Saldo;
        public bool Estado = false;

        // Ejemplo de constructor
        //public CuentaBancaria(int saldo, bool estado)
        //{
        //    Saldo = saldo;
        //    Estado = estado;
        //}

        public void ActivarCuenta(int primerSaldo)
        {

            if (primerSaldo <= 0)
            {
                Console.WriteLine("La cuenta tiene que activarse con un saldo mayor a 0");
                return;
            }


            if (!Estado)
            {

                Saldo = primerSaldo;
                Estado = true;

            }
            else
            {
                Console.WriteLine("La cuenta ya está activa");
            }
        }


        public void Retirada(int cantidad)
        {
            if (!Estado)
            {
                Console.WriteLine("La cuenta no esta activa");
                return;
            }

            if (Saldo <= 0)
            {
                Console.WriteLine("No se puede retirar esa cantidad porque su saldo es inferior");
                return;
            }

            Saldo -= cantidad;

        }

        public void Deposito(int cantidad)
        {
            if (Estado)
            {
                Saldo += cantidad;
            }
        }

        public void MostrarSaldo()
        {
            Console.WriteLine(Saldo);
        }


        public void BloquearCuenta()
        {
            Estado = false;
        }
    }
}
