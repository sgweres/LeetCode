using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assign_2._2._1
{
    internal class Circle : Shape
    {
        

        public override double CalculateArea(double input)
        {
            double pie = 3.14;
        
            double AreaCircle;
            double radius = input;
            AreaCircle = (radius * radius) * pie;



            Console.WriteLine(AreaCircle);
            return AreaCircle;
        }
    }
}
