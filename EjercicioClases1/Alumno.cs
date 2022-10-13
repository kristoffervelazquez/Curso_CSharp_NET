using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClases1
{
    internal class Alumno : Persona
    {
        public int Id { get; set; }

        public Alumno(string nombre, int edad, int id) : base(nombre, edad)
        {
            Id = id;
        }
    }
}
