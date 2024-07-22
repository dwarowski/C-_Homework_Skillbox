using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_05_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            Console.WriteLine(MinLenWord(inputString));

            Console.ReadKey();

           string MinLenWord(string input)
           {
                string[] words = input.Split(' ');
                return words.;
           }

        }
       
    }
}
