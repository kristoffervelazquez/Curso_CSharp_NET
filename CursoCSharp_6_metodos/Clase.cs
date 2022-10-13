using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp_5_campos_propiedades
{
    public class Clase
    {
        //Campos o Propiedades
        public int Campo;
        private const int _NUMERO = 15;
        public string Nombre { get; set; }
        public readonly string Identificador = "XX";

        //Constructor
        public Clase()
        {

        }

        //Metodo
        public void SumarQuince(int edad)
        {
            //Operacion de nuestro metodo
            Console.WriteLine(edad + _NUMERO);
        }

        //Metodo
        public static int Sumar(int numero , int numero2)
        {
            //Operacion de nuestro metodo
            return numero + numero2;
        }
    }
}
