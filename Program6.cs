using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_2._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string shapeName;
            double sideSquare;
            double radiusCircle;

            Console.BackgroundColor = ConsoleColor.Green;

            Console.WriteLine("Do you have a circle or a square?");
            shapeName = Console.ReadLine();
            if (shapeName == "Square" || shapeName == "square")
            {
                Console.WriteLine("What is the length of a side of the square?");
                sideSquare = double.Parse(Console.ReadLine());
                Square square = new Square();
                Console.Write("The area of your " + shapeName + " is ");
                square.CalculateArea(sideSquare);
            }
            else if (shapeName == "Circle" || shapeName == "circle")
            {
                Console.WriteLine("What is the radius of the circle?");
                radiusCircle = double.Parse(Console.ReadLine());
                Circle circle = new Circle();
                Console.Write("The area of your " + shapeName + " is ");
                circle.CalculateArea(radiusCircle);
            }



            
            

        }
        
    }
    #region shape class

    abstract class Shape
    {
        
        public abstract double CalculateArea(double input);
        
    }
    #endregion
}
