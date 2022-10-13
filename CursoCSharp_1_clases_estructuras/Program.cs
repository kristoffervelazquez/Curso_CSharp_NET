using System;

namespace CursoCSharp_01_clases_estructuras
{
    class Program
    {
        static void Main(string[] args)
        {
            Point punto = new Point();
            punto.X = 10;
            punto.Y = 8;


            PointStruct puntoStruct = new PointStruct();
            puntoStruct.X = 20;
            puntoStruct.Y = 7;

            SumaCoordenadas(punto);
            // Este metodo no cambia los valores de la Estrucutra ya que el valor no se pasa por referencia.
            SumarCoordenadas(puntoStruct);

            Console.WriteLine($"Suma de coordenadas clase: X={punto.X} Y={punto.Y}"); // valor x= 20, Y = 18 // Este
            Console.WriteLine($"Suma de coordenadas struct: X={puntoStruct.X} Y={puntoStruct.Y}"); // valor X = 20, Y = 7
            Console.ReadKey();
        }

        public static void SumaCoordenadas(Point point)
        {
            point.X = point.X + 10;
            point.Y = point.Y + 10;
        }

        public static void SumarCoordenadas(PointStruct pointStruct)
        {
            pointStruct.X = pointStruct.X + 10;
            pointStruct.Y = pointStruct.Y + 10;
        }

    }
}
