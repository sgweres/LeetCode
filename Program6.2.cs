using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_2._2._1
{
    internal class Square : Shape
    {
        
        public override double CalculateArea(double input)
        {
            double side = input;
            double areaSquare = side * side;
            Console.WriteLine(areaSquare);
            return areaSquare;
        }
    }
}
