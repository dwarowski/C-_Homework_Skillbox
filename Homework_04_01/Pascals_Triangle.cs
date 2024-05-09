using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_04_01
{
    internal class Pascals_Triangle
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк треугольника паскаля: ");
            int N = int.Parse(Console.ReadLine());
            int windowWidth = Console.WindowWidth / 2;

            int[][] nums = new int[N + 1][];

            for (int i = 1; i < N + 1; i++)
            {
                
                Console.SetCursorPosition(windowWidth, i + 1);  // Установка курсора консоли по центру для вывода треугольника
                windowWidth -= 2;                               // Сдвиг следющих цифр, чтобы получилась пирамида

                nums[i] = new int[i + 1];                       // Создание нового ряда в зубчатом массиве 
                nums[i][0] = 1;                                 // Начальная еденица пирамиды
                Console.Write($" {nums[i][0], 2} ");            // Вывод начальной единцы 


                for (int j = 0;  j < i + 1; j++)
                {
                   
                    
                    Console.Write($" {nums[i][j], 2} ");
                    
                }

                nums[i][i + 1] = 1;                             // Конечная еденица пирамиды
                Console.Write($" {nums[i][i + 1],2} ");         // Вывод последней единцы 
                Console.WriteLine();

            }


            Console.ReadKey();

        }
    }
}
