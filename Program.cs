using FindingSquare.Model;
using FindingSquare.Repository;
using System;
using System.Collections.Generic;

namespace FindingSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller.FindingSquare squareBuss = new Controller.FindingSquare();
            List<Square> squares = squareBuss.Find();

            Console.WriteLine("Girilen listedeki kare sayısı {0}", squares.Count);
            foreach (var square in squares)
            {
                Console.WriteLine("     {0}. Kare İçin Koordinatlar :  ", square.Id);

                int pointCount = 0;
                foreach (var item in square.Axis)
                {
                    pointCount++;
                    Console.WriteLine(@"        Nokta {2} = {0},{1} ", item.X, item.Y, pointCount);
                }
                                        
            }
        }
    }
}
