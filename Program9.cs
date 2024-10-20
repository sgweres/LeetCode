using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign3._1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int xCoord;
            int yCoord;

            Console.Write("Input the value for the x coordinate: ");
            xCoord = int.Parse(Console.ReadLine());
            Console.Write("Input the value for the y coordinate: ");
            yCoord = int.Parse(Console.ReadLine());

            InWhichQuadrant(xCoord,yCoord);

        }
        static void InWhichQuadrant(int x, int y)
        {

            if (x >= 0 && y >= 0)
            { Console.WriteLine("The coordinate point " + x + "," + y + " lies in the first quadrant."); }
            else if (x >= 0 && y < 0)
            { Console.WriteLine("The coordinate point" + x + "," + y + " lies in the second quadrant."); }
            else if (x < 0 && y < 0)
            { Console.WriteLine("The coordinate point" + x + "," + y + " lies in the third quadrant."); }
            else
            { Console.WriteLine("The coordinate point" + x + "," + y + " lies in the fourth quadrant."); }
        }   
    }
}
