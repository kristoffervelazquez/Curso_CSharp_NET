using System;

namespace CursoCSharp_5_campos_propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            //Clase clase = new Clase();
            //clase.Campo = 12;
            //clase.Apellidos = "Lopez Serrano";
            //clase.Edad = 12; //! No se puede modificar ya que es una propiedad set privada.

            //Console.WriteLine(clase.Edad);
            //Console.ReadLine();

            Clase clase2 = new();
            clase2.Estado = 5; // Hace una asignacion de valor 5 a la propiedad Estado.
            var estado = clase2.Estado; // Hace un get de Estado y lo almacena en la variable

            clase2.Metodo(19);
            Console.WriteLine(clase2.Edad);

            Console.WriteLine(estado);



            Console.ReadLine();

        }
    }
}
