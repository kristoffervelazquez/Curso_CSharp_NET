using System;

namespace CursoCSharp_3_nomenclatura
{
    class Program
    {

        private readonly string _estaEsMiCadena;


       

        static void Main(string[] args)
        {
            //CamelCase: Se usa en variables locales y miembros privados 
            var estoEsUnaVariable = "Camel";

            //Pascal. Se usa en metodos, tipos o clases.
            var EstoEsUnaVariable = "Pascal";
            
        }

        public int SumaDosNumeros(int numUno, int numDos)
        {
            return numUno + numDos;
        }


    }
}
