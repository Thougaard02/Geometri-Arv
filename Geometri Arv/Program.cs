using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Sqaure
            Square square = new Square(2);

            //Printing square
            Console.WriteLine("Perimeter of sqaure");
            Console.WriteLine(square.CalculatePerimeter());
            Console.WriteLine("\nArea of sqaure");
            Console.WriteLine(square.CalculateArea());
            #endregion

            #region Paralleogram
            Parallelogram parallelogram = new Parallelogram(3, 5, 20);

            //Printing paralleogram
            Console.WriteLine("\nArea of parallelogram");
            Console.WriteLine(parallelogram.CalculateArea());
            #endregion

            #region Trapez
            Trapez trapez = new Trapez(10, 9, 8, 9);

            //Printing trapez
            Console.WriteLine("\nArea of trapez");
            Console.WriteLine(trapez.CalculateArea());
            #endregion

            #region Right angel triangle
            RightAngelTriangle rightAngelTrianglePerimeter = new RightAngelTriangle(3, 4, 5);
            RightAngelTriangle rightAngelTriangleArea = new RightAngelTriangle(3, 4);

            //Printing right angel triangle
            Console.WriteLine("\nPerimeter of right angel triangle");
            Console.WriteLine(rightAngelTrianglePerimeter.CalculatePerimeter());
            Console.WriteLine("\nArea of right angel triangle");
            Console.WriteLine(rightAngelTriangleArea.CalculateArea());
            #endregion
        }
    }
}
