using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[3];
            fillArray(intArray);
            Console.WriteLine("The values stored in the array are: ");
            displayArray(intArray);
            Console.WriteLine("The values stored in the array in reverse are: ");
            orderArray(intArray);
            displayArray(intArray);


            
        }
        static void fillArray(int[] intArray)
        {
            intArray[0] = 2;
            intArray[1] = 5;
            intArray[2] = 7;
        }
        static void orderArray(int[] intArray)
        {
            Array.Reverse(intArray);
        }
        static void displayArray(int[] intArray)
        {
            foreach (int item in intArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
