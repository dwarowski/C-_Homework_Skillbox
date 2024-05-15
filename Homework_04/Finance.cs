using System;

namespace Homework_04
{
    internal class Finance
    {
        static void Main(string[] args) 
        {
            Random r = new Random();                        // Создание рандома
            int[,] incomeAndOutcome = new int[12, 2];       // Двумерный массив с приходом и расходом на 12 месяцев
            int[] worstEarn = new int[12];                  // Массив дял хранения 
            int[] earning = new int[12];                    // Массив для хранения дохода 
            int positiveEraning = 0;                        // Переменная для месяцев с положительным доходом
            

            Console.WriteLine($"Month | {"Income", 7} | Outcome | Earning |");      // Оглавление таблицы

            for (int i = 0; i < 12; i++)                        // Пербор по месяцам
            {
                Console.Write($"{i + 1, 5} | ");                // Вывод месяца по порядку

                for (int j = 0; j < 2; j++)                     // Перебор прихода и расхода 
                {
                    incomeAndOutcome[i, j] = r.Next(1_000_000);         // Добавляем рандомное значение в массив 
                    Console.Write($"{incomeAndOutcome[i, j], 7} | ");   // Вывод прихода и расхода в таблицу 
                }

                earning[i] = incomeAndOutcome[i, 0] - incomeAndOutcome[i, 1]; // Расчет дохода

                if (earning[i] > 0)                     // Условие положителного дохода
                {
                    positiveEraning++;                  // Подсчет месяцев с положительной прибылью
                }

                Console.WriteLine($"{earning[i], 7} |");       // Вывод дохода в таблицу
                
            }

            Console.WriteLine("_____________________________________");     // Конец  таблицы

            temp();
                        

            Console.WriteLine($"Положительная прибыль: {positiveEraning} месяц(ев).");  
            Console.WriteLine("\nДля пересчета напишите: Y");

            if (Console.ReadLine() == "Y" || Console.ReadLine() == "y") // Перезапуск
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
