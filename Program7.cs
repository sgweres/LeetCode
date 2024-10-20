using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_2._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string basicInfo;
            Console.WriteLine("Input your name, age, and address here.");
            basicInfo = Console.ReadLine();
            try
            {
                StreamWriter writerOne = new StreamWriter("BasicInfo.txt");
                writerOne.Write(basicInfo);
                writerOne.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("You messed up.");
                Console.WriteLine(e);
            }

            try
            {
                StreamReader readerOne = new StreamReader("basicInfo.txt");
                string fileContent = readerOne.ReadToEnd();
                readerOne.Close();
                Console.WriteLine(fileContent);
            }
            catch (Exception e)
            {
                Console.WriteLine("File Not Found.");
                Console.WriteLine(e.Message); 
            }
        }
    }
}
