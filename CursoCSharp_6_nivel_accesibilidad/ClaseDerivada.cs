﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp_7_nivel_accesibilidad
{
    public class ClaseDerivada : ClaseBase
    {
        public ClaseDerivada()
        {

            //base.Edad = 15; // No se puede acceder porque es privada
            base.Apellidos = "Perez";
            base.Nombre = "Juan";
        }
    }
}
