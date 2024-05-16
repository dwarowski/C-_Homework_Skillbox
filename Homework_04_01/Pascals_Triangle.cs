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
            int N = int.Parse(Console.ReadLine());                              // Ожидание ввода 
            int windowWidth = Console.WindowWidth / 2;                          // Ширина окна консоли 

            int[][] nums = new int[N + 1][];                                    // Создание зубчатого массива

            if (N > 0)                                                          // Если ввод больше 0 выводи начало труегольника 
            {
                nums[0] = new int[1];                                           // Создание первого ряда массива
                nums[0][0] = 1;                                                 // Первая единица треугольника 

                Console.SetCursorPosition(windowWidth, 1);                      // Установка курсора консоли по центру для вывода треугольника
                Console.WriteLine($" {nums[0][0]} ");                           // Вывод первого ряда чисел 
                if (N > 1)                                                      // Если ввод больше 1 выводи N-ый труегольник
                {
                    for (int i = 1; i < N; i++)                                 // Цикл i-го ряда треугольника, со второго ряда
                    {
                        windowWidth -= 4;                                       // Сдвиг курсора влево на 4 символа
                        Console.SetCursorPosition(windowWidth, i + 1);          // Установка курсора консоли по центру для вывода треугольника

                        nums[i] = new int[i + 1];                               // Создание нового ряда в зубчатом массиве 
                        nums[i][0] = 1;                                         // Начальная еденица пирамиды
                        Console.Write($" {nums[i][0]} ");                       // Вывод начальной единцы 

                        for (int j = 1; j < i; j++)                             // Цикл заполнения внутренней части треугольника
                        {
                            nums[i][j] = nums[i - 1][j - 1] + nums[i - 1][j];   // Расчет внутренних чисел тругольника 
                            Console.Write($" {nums[i][j],6} ");                 // Вывод i-го ряда треугольника 
                        }

                        nums[i][i] = 1;                                         // Конечная еденица треугольника
                        Console.Write($" {nums[i][i],6}");                      // Вывод последней единцы                              //
                    }
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Число должно быть больше 0");
            }
        }
    }
}
