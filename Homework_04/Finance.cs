using System;
using System.Linq;

namespace Homework_04
{
    internal class Finance
    {
        static void Main(string[] args) 
        {
            Random r = new Random();                        // Создание рандома
            int[,] monthIncomeAndOutcome = new int[12, 3];  // Двумерный массив с приходом и расходом на 12 месяцев
            int positiveEraning = 0;                        // Переменная для месяцев с положительным доходом
            int[] earning = new int[12];                    // Массив дял хранения 
            int[] earningSorted = new int[12];              // Массив для хранения дохода 
           
            

            Console.WriteLine($"Month | {"Income", 7} | Outcome | Earning |");             // Оглавление таблицы

            for (int i = 0; i < 12; i++)            // Пербор по месяцам
            {
                monthIncomeAndOutcome[i, 0] = i + 1; 
                Console.Write($"{monthIncomeAndOutcome[i, 0], 5} | ");       // Вывод месяца по порядку

                for (int j = 1; j < 3; j++)         // Перебор прихода и расхода 
                {
                    monthIncomeAndOutcome[i, j] = r.Next(1_000_000);         // Добавляем рандомное значение в массив 
                    Console.Write($"{monthIncomeAndOutcome[i, j], 7} | ");   // Вывод прихода и расхода в таблицу 
                }

                earning[i] = monthIncomeAndOutcome[i, 1] - monthIncomeAndOutcome[i, 2];         // Расчет дохода
                earningSorted[i] = monthIncomeAndOutcome[i, 1] - monthIncomeAndOutcome[i, 2];   // Расчет дохода для сортикровки

                if (earning[i] > 0)                 // Условие положителного дохода
                {
                    positiveEraning++;              // Подсчет месяцев с положительной прибылью
                }

                Console.WriteLine($"{earning[i], 7} |");                     // Вывод дохода в таблицу
                
            }

            Console.WriteLine("_____________________________________");      // Конец  таблицы

            Array.Sort(earningSorted);  // Сорировка дохода 
            int[] earningSorted1 = earningSorted.Distinct().ToArray();  // Удаление повторов 

            Console.Write("Худшая прибыль в месяцах: ");    
            for (int i = 0; i < 3; i++)     // Поиск трех минимумов    
            {   
                for (int j = 0; j < 12; j++)    // Проврека всех 12 значений 
                {
                    if (earning[j] == earningSorted1[i])    // Условие равенства
                    {
                        Console.Write($"{j + 1} "); 
                    }
                }

            }
            Console.WriteLine();

            Console.WriteLine($"Положительная прибыль: {positiveEraning} месяц(ев).");  
            Console.WriteLine("\nДля пересчета напишите: Y");

            if (Console.ReadLine() == "Y" || Console.ReadLine() == "y")      // Перезапуск
            {
                Console.Clear();
                Main(args);
            }

                
            

                
            
            
            




        }
    }
}
