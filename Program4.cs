using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the x axis coordinate and the y axis coordinate for Point 1.");
            Point point1 = new Point(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter the x axis coordinate and the y axis coordinate for Point 2.");
            Point point2 = new Point(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));

            string result = point1.IsXRight(point2);
           
        }
    }
    public struct Point
    {
        private int _xCoord;
        private int _yCoord;
        public Point(int x, int y)
        {
            this._xCoord = x;
            this._yCoord = y;
        }

        public string IsXRight(Point point)
        {
            if (this._xCoord > point._xCoord)
            {
                Console.WriteLine("Point 1 is to the right of point 2.");
                return null;

            }
            else if (this._xCoord < point._xCoord)
            {
                Console.WriteLine("Point 1 is to the left of point 2.");
                return null;
            }
            else
            {
                Console.WriteLine("The points share an x axis.");
                return null;
            }
        }
    }
}
