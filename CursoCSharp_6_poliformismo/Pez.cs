using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp_6_poliformismo
{
    public class Pez : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("El pez hace Glugluglu");
        }
    }
}
