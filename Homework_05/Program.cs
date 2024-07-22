using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int functionNum = 1;

            Console.WriteLine("Возможные действия:");
            Console.WriteLine("1. Умножить матрицу на число");
            Console.WriteLine("2. Сложить матрицу с матрицей");
            Console.WriteLine("3. Вычесть матрицу из матрицы");
            Console.WriteLine("4. Умножить матрицу с матрицей");
            Console.Write("Для выбора, напишиите цифру нужного действия: ");

            functionNum = int.Parse(Console.ReadLine());                // Читаем действие
            if (functionNum >= 1 && functionNum <= 4) 
            {
                Console.Clear();
            }
            else                    // Перезапускаем если неправильно введена цифра 
            {
                Console.Write("Несуществующее действие");
                Console.ReadKey();
                Console.Clear();
                Main(args);
            }
               
            Matrix matrix = new Matrix();     // Создание новой матрицы*

            if (functionNum == 1)
            {
                Console.Write("Введите количество рядов матрицы: ");
                int matrixRow = int.Parse(Console.ReadLine());                  // Считываем кол-во рядов
                Console.Write("Введите количество колонок матрицы, но не больше 18: ");
                int matrixColumn = int.Parse((Console.ReadLine()));             // Считываем кол-во колонок 
                Console.Write("Введите число на которое надо умножить, но не больше 10 000: ");
                int matrixNumMultiplier = int.Parse(Console.ReadLine());    // Число на которое будет умножатся матрица

                matrix.MatrixMltiplyByNum(matrixRow, matrixColumn, matrixNumMultiplier);          
                Main(args);                     // Перезапуск
            } // Умножение матрицы на число

            if (functionNum == 2)
            {
                Console.Write("Введите количество рядов первой матрицы: ");
                int matrixRow = int.Parse(Console.ReadLine());                  // Считываем кол-во рядов первой матрицы
                Console.Write("Введите количество колонок первой матрицы: ");
                int matrixColumn = int.Parse((Console.ReadLine()));             // Считываем кол-во колонок первой матрицы


                Console.Write("Введите количество рядов второй матрицы: ");
                int matrixRow1 = int.Parse(Console.ReadLine());                  // Считываем кол-во рядов второй матрицы
                Console.Write("Введите количество колонок второй матрицы: ");
                int matrixColumn1 = int.Parse((Console.ReadLine()));             // Считываем кол-во колонок второй матрицы

                matrix.MatrixAddMatrix(matrixRow, matrixColumn, matrixRow1, matrixColumn1);     
                Main(args);                     // Перезапуск              
            } // Сложение двух матриц

            if (functionNum == 3)
            {
                Console.Write("Введите количество рядов первой матрицы: ");
                int matrixRow = int.Parse(Console.ReadLine());                  // Считываем кол-во рядов первой матрицы
                Console.Write("Введите количество колонок первой матрицы: ");
                int matrixColumn = int.Parse((Console.ReadLine()));             // Считываем кол-во колонок первой матрицы

                Console.Write("Введите количество рядов второй матрицы: ");
                int matrixRow1 = int.Parse(Console.ReadLine());                  // Считываем кол-во рядов второй матрицы
                Console.Write("Введите количество колонок второй матрицы: ");
                int matrixColumn1 = int.Parse((Console.ReadLine()));             // Считываем кол-во колонок второй матрицы

                matrix.MatrixSubMatrix(matrixRow, matrixColumn, matrixRow1, matrixColumn1);
                Main(args);
            } // Вычитание двух матриц
            
            if (functionNum == 4)
            {
                Console.Write("Введите количество рядов первой матрицы: ");
                int matrixRow = int.Parse(Console.ReadLine());                  // Считываем кол-во рядов первой матрицы
                Console.Write("Введите количество колонок первой матрицы: ");
                int matrixColumn = int.Parse((Console.ReadLine()));             // Считываем кол-во колонок первой матрицы

                Console.Write("Введите количество рядов второй матрицы: ");
                int matrixRow1 = int.Parse(Console.ReadLine());                  // Считываем кол-во рядов второй матрицы
                Console.Write("Введите количество колонок второй матрицы: ");
                int matrixColumn1 = int.Parse((Console.ReadLine()));             // Считываем кол-во колонок второй матрицы

                matrix.MatrixMultiplyMatrix(matrixRow, matrixColumn, matrixRow1, matrixColumn1);
                Main(args);
            } // Умножжение матрицы на матрицу
        }
    }
}
