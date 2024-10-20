using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Select 1 for addition, 2 for subtraction, 3 for multiplication, 4 for division. Or select anything else to cancel.");
            double inputNum;
            double inputNum2;
            double inputNum3;

            inputNum = double.Parse(Console.ReadLine());
           

            if (inputNum == 1)
            {
                Console.WriteLine("Input two numbers to add.");
                inputNum2 = double.Parse(Console.ReadLine());
                inputNum3 = double.Parse(Console.ReadLine());
                addNums(inputNum2, inputNum3);
            }
            else if (inputNum == 2)
            {
                Console.WriteLine("Input two numbers to subtract.");
                inputNum2 = double.Parse(Console.ReadLine());
                inputNum3 = double.Parse(Console.ReadLine());
                subtractNums(inputNum2, inputNum3);
            }
            else if (inputNum == 3)
            {
                Console.WriteLine("Input two numbers to multiply.");
                inputNum2 = double.Parse(Console.ReadLine());
                inputNum3 = double.Parse(Console.ReadLine());
                multiplyNums(inputNum2, inputNum3);
            }
            else if (inputNum == 4)
            {
                Console.WriteLine("Input two numbers to divide.");
                inputNum2 = double.Parse(Console.ReadLine());
                inputNum3 = double.Parse(Console.ReadLine());
                divideNums(inputNum2, inputNum3);
            }
            else
            {
                
            }

        }

            static double addNums(double num1, double num2)
            {
            double sumNums;

            sumNums = num1 + num2;
            Console.WriteLine(sumNums);
            return sumNums;
             }
        static double subtractNums(double num1, double num2)
        {
            double diffNums;

            diffNums = num1 - num2;
            Console.WriteLine(diffNums);
            return diffNums;
        }
        static double multiplyNums(double num1, double num2)
        {
            double productNums;

            productNums = num1 * num2;
            Console.WriteLine(productNums);
            return productNums;

        }
        static double divideNums(double num1, double num2)
        {
            double quotientNums;

            quotientNums = num1 / num2;
            Console.WriteLine(quotientNums);
            return quotientNums;
        }
    }
}
