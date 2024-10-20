using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Assign_2._1._3
{
    internal class MathProblems
    {
        static void Main(string[] args)
        {
            AddNums(5, 50);
            AddNums(5, 4, 90);
            MultiplyNums(6, 4);
            MultiplyNums(10, 10, 10);
        }



        public static int AddNums(int numOne, int numTwo)
        {
            int sumNums = numOne + numTwo;
            Console.WriteLine(sumNums);
            return sumNums;
        }
        public static int AddNums(int numOne, int numTwo, int numThree)
        {
            int sumNums = numOne + numTwo + numThree;
            Console.WriteLine(sumNums);
            return sumNums;
        }
        public static int MultiplyNums(int numOne, int numTwo)
        {
            int prodNums = numOne * numTwo;
            Console.WriteLine(prodNums);
            return prodNums;
        }
        public static int MultiplyNums(int numOne, int numTwo, int numThree)
        {
            int prodNums = numOne * numTwo * numThree;
            Console.WriteLine(prodNums);
            return prodNums;
        }
    }
}
