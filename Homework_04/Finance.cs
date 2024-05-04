using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_04
{
    internal class Finance
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[,] IncomeAndOutcome = new int[12, 2];
            int[] WorstEarning = new int[12];
            

            Console.WriteLine($"Month | {"Income", 7} | Outcome | Earning |");

            for (int i = 0; i < 12; i++)
            {
                Console.Write($"{i + 1, 5} | ");

                for (int j = 0; j < 2; j++)
                {
                    IncomeAndOutcome[i, j] = r.Next(1_000_000);
                    Console.Write($"{IncomeAndOutcome[i, j], 7} | ");
                }

                WorstEarning[i] = IncomeAndOutcome[i, 0] - IncomeAndOutcome[i, 1];
                Console.WriteLine($"{WorstEarning[i], 7} |");
                
            }

            Console.WriteLine("To restart app type Y. N to quit.");
            if (Console.ReadLine() == "Y" || Console.ReadLine() == "y")
            {
                Main(args);
            }
           

            

            void WorstEarn()
            {

                

                for (int k = 0; k < 12; k++)
                {
                    if (WorstEarning[k] <= )
                    
                }

            }
            




        }
    }
}
