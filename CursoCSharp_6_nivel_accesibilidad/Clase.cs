using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp_7_nivel_accesibilidad
{
    public class ClaseBase
    {
        public string Telefono { get; set; } // Public: Se puede obtener acceso desde clase base y clases derivadas
        private int Edad { get; set; } // Private: Solamente se puede acceder desde el constructor o cualquier metodo de la misma clase.
        internal string Nombre { get; set; } // Internal: Solamente se puede acceder desde la misma solucion
        protected string Apellidos { get; set; } // Protected: solamente pueden acceder desde el código de la misma clase, o bien de una clase derivada de esa clase.
        protected internal string Nacionalidad { get; set; } // Protected internal: Solamente se puede acceder en el mismo ensamblado y de la misma clase o derivada.

        public ClaseBase()
        {
            Edad = 16;
            Apellidos = "Lopez";
        }

        public void Sumar(int a, int b)
        {

        }
    }
}
