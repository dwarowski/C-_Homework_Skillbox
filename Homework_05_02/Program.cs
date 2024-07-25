using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_05_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(InputString(input));
            Console.ReadKey();


            string InputString(string inputString)
            {
                string outputString = "";
                char prevLetter = ' ';

                foreach (char letter in inputString)
                {
                    if (prevLetter != letter)
                    {
                        outputString += letter;
                    }
                    prevLetter = letter;
                }
                return outputString;
            }
        }
    }
}
