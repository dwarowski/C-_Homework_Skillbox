using System;

namespace Homework_04
{
    internal class Finance
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[,] incomeAndOutcome = new int[12, 2];
            //int[] worstEarn = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            int[] worstEarn = new int[12];
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


                int[] currentMin = new int[12];
                currentMin[0] = 1_000_001;

                for (int i = 0; i < 12; i++)
                {    
                    for (int j = 0; j < 12; j++)
                    {
                        if (currentMin[i] > earning[j] && j != worstEarn[i] - 1)
                        {
                            
                            currentMin[i] = earning[j];
                            worstEarn[i] = j + 1;

                        }
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
