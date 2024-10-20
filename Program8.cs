using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assign2._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal billTotal;
            decimal tipPercent;
            decimal tipTotal;
            decimal totalCharge;

            Console.WriteLine("Hope you enjoyed your meal. Let's see how much you should tip.\n");
            Console.WriteLine("Enter your bill total.");
            Console.Write("$");
            billTotal = decimal.Parse(Console.ReadLine());

            Console.WriteLine("What percentage do you want to tip?\n");
            tipPercent = decimal.Parse(Console.ReadLine());

            tipTotal = (tipPercent / 100) *billTotal;
            totalCharge = tipTotal + billTotal;
            

            Console.WriteLine("Your tip should be\n");
            Console.WriteLine($"{tipTotal:C2}");
            Console.WriteLine($"Your total bill is {totalCharge:C2}");

        }
    }
}
