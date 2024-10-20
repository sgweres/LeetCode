using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What shape do you want to know the area for? Square, Rectangle, or Triangle?");
            string inputShape;

            inputShape = Console.ReadLine();

            ifOperation(inputShape);



        }
        static void areaSquare(double sideLength)
        {
            double areaReturn;
            areaReturn = sideLength * sideLength;
            Console.WriteLine("The area of the square is " + areaReturn);
        }
        static void areaRectangle(double width, double height)
        {
            double areaReturn;
            areaReturn = width * height;
            Console.WriteLine("The area of the rectangle is " + areaReturn);

        }
        static void areaTriangle(double baseLength, double height)
        {
            double areaReturn;
            double halfNum;
            halfNum = 0.5;
            areaReturn = (halfNum * baseLength * height);
            Console.WriteLine("The area of the triangle is " + areaReturn);
        }
        static void ifOperation(string inputShape)
        {
            if (inputShape == "Square" || inputShape == "square")
            {
                double squareSide;

                Console.WriteLine("Enter the length of a side of the square.");
                squareSide = double.Parse(Console.ReadLine());
                areaSquare(squareSide);
            }
            else if (inputShape == "Rectangle" || inputShape == "rectangle")
            {
                double rectangleWidth;
                double rectangleHeight;

                Console.WriteLine("What is the width of the rectangle?");
                rectangleWidth = double.Parse(Console.ReadLine());
                Console.WriteLine("What is the height of the rectangle?");
                rectangleHeight = double.Parse(Console.ReadLine());
                areaRectangle(rectangleWidth, rectangleHeight);

            }
            else if (inputShape == "Triangle" || inputShape == "triangle")
            {
                double triangleBase;
                double triangleHeight;

                Console.WriteLine("What is the base of the triangle?");
                triangleBase = double.Parse(Console.ReadLine());
                Console.WriteLine("What is the height of the triangle?");
                triangleHeight = double.Parse(Console.ReadLine());
                areaTriangle(triangleBase, triangleHeight);
            }
            else
            {
                Console.WriteLine("That is not a shape I know!");
            }
        }


    }
}
