using System;

namespace Homework_04
{
    internal class Finance
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[,] incomeAndOutcome = new int[12, 2];
            int[] worstEarn = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            int[] earning = new int[12];
            int positiveEraning = 0;
            

            Console.WriteLine($"Month | {"Income", 7} | Outcome | Earning |");

            for (int i = 0; i < 12; i++)
            {
                Console.Write($"{i + 1, 5} | ");

                for (int j = 0; j < 2; j++)
                {
                    incomeAndOutcome[i, j] = r.Next(1_000_000);
                    Console.Write($"{incomeAndOutcome[i, j], 7} | ");
                }

                earning[i] = incomeAndOutcome[i, 0] - incomeAndOutcome[i, 1];

                if (earning[i] > 0)
                {
                    positiveEraning++;
                }

                Console.WriteLine($"{earning[i], 7} |");
                
            }

            Console.WriteLine("_____________________________________");

            temp();
                        

            Console.WriteLine($"Положительная прибыль: {positiveEraning} месяц(ев).");
            Console.WriteLine("\nДля пересчета напишите: Y");

            if (Console.ReadLine() == "Y" || Console.ReadLine() == "y")
            {
                Console.Clear();
                Main(args);
            }

                
            void temp()
            {
                
                int currentMin = 1_000_000;
                int currentMin1 = 1_000_000;
                int currentMin2 = 1_000_000;

                for (int i = 1; i < 12; i++)
                {
                    if (currentMin > earning[i])
                    {
                        currentMin = earning[i];
                        
                        worstEarn[0] = i + 1;
                        
                    }

                    if (currentMin1 > earning[i] && i != worstEarn[0] - 1)
                    {
                        currentMin1 = earning[i];

                        worstEarn[1] = i + 1;

                    }

                    if (currentMin2 > earning[i] && i != worstEarn[0] - 1 && i != worstEarn[1] - 1 )
                    {
                        currentMin2 = earning[i];

                        worstEarn[2] = i + 1;

                    }
                }

                Console.Write("Худшая прибыль в месяцах: ");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"{worstEarn[i]} ");
                }
                Console.WriteLine();
            }
            
            




        }
    }
}
