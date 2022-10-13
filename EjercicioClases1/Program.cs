using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClases1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();



            for (int i = 1; i <= 3; i++)
            {
                string nombre;
                int edad;
                int ocupacion;
                string materia;
                int numero;

                do
                {
                    Console.Write($"Escribe el nombre de la persona #{i}: ");
                    nombre = Console.ReadLine();
                    Console.Write($"Escribe la edad de la persona #{i}: ");
                    edad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Profesor: 1, Alumno: 2");
                    ocupacion = int.Parse(Console.ReadLine());


                } while (nombre == "" || edad <= 0);

                if (ocupacion == 1)
                {
                    Console.Write("Materia que imparte: ");
                    materia = Console.ReadLine();
                    Profesor profesor = new Profesor(nombre, edad, materia);
                    personas.Add(profesor);

                }
                else
                {
                    Console.WriteLine("Numero de alumno: ");
                    numero = int.Parse(Console.ReadLine());
                    Alumno alumno = new Alumno(nombre, edad, numero);
                    personas.Add(alumno);
                }

               

                Console.WriteLine("-----------------------------------------------");
                


            }


            foreach (Persona p in personas)
            {
                if (p.EsMayorDeEdad())
                {
                    Console.WriteLine($"Nombre: {p.Nombre}, {p.Edad} ");
                }
            }


            Console.ReadLine();
        }


    }
}
