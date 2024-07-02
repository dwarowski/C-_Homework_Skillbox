using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Homework_04_02
{
    internal class Matrix
    {
        Random r = new Random();
        public void MltiplyByNum()   // Умножение числа на матрицу 
        {
            int matrixRow = 0;                                          // Число рядов матрицы
            int matrixColumn = 0;                                       // Число колонок матрицы

            Console.Write("Введите количество рядов матрицы: ");
            matrixRow = int.Parse(Console.ReadLine());                  // Считываем кол-во рядов
            Console.Write("Введите количество колонок матрицы: ");
            matrixColumn = int.Parse((Console.ReadLine()));             // Считываем кол-во колонок 
            Console.Write("Введите число на которое надо умножить: ");

            
            int matrixNumMultiplier = int.Parse(Console.ReadLine());    // Число на которое будет умножатся матрица
            int[,] matrix = new int[matrixRow, matrixColumn];           // Создаем матрицу по заданым значениям
            
            Console.Clear();
            Console.SetCursorPosition(0, matrixRow / 2);                // Центровка числа в консоли
            Console.Write($"{matrixNumMultiplier} * ");                 // Вывод числа 
            

            for (int i = 0; i < matrixRow; i++)                         // Перебор циклом кадого элемента матрицы
            {
                Console.SetCursorPosition(4, i);                        // Отступ матрицы в консоли
                Console.Write("| ");

                for (int j = 0 ; j < matrixColumn; j++)
                {
                    matrix[i, j] = r.Next(0,100);                       // Заполняем рандомно матрицу
                    Console.Write($"{matrix[i, j], 2} ");                  // Выводим матрицу в консоль
                }

                Console.WriteLine($"|");
            }

            Console.SetCursorPosition(7 + (2 * matrixColumn) + matrixColumn - 1, matrixRow / 2);       // Отступ равно в консоли
            Console.Write("=");                                                     // То самое равно


            for (int i = 0; i < matrixRow; i++)                                     // Перебор циклом кадого элемента матрицы
            {
                Console.SetCursorPosition(5 + (4 * matrixColumn), i);               // Отступ перемноженной матрицы в консоли
                Console.Write("| ");

                for (int j = 0; j < matrixColumn; j++)
                {
                    matrix[i, j] *= matrixNumMultiplier;                // Перемножение матрицы
                    Console.Write($"{matrix[i, j]} ");                  // Вывод перемноженной матрицы
                }
                Console.WriteLine("|");
            }

            Console.ReadKey();
            Console.Clear();
        }



        public void MatrixAddMatrix()
        {
            int matrixRow = 0;                                          // Число рядов первой матрицы
            int matrixColumn = 0;                                       // Число колонок первой матрицы
            int matrixRow1 = 0;                                         // Число рядов второй матрицы
            int matrixColumn1 = 0;                                      // Число колонок второй матрицы

            Console.Write("Введите количество рядов первой матрицы: ");
            matrixRow = int.Parse(Console.ReadLine());                  // Считываем кол-во рядов первой матрицы
            Console.Write("Введите количество колонок первой матрицы: ");
            matrixColumn = int.Parse((Console.ReadLine()));             // Считываем кол-во колонок первой матрицы


            Console.Write("Введите количество рядов второй матрицы: ");
            matrixRow1 = int.Parse(Console.ReadLine());                  // Считываем кол-во рядов второй матрицы
            Console.Write("Введите количество колонок второй матрицы: ");
            matrixColumn1 = int.Parse((Console.ReadLine()));             // Считываем кол-во колонок второй матрицы

            int[,] matrix = new int[matrixRow, matrixColumn];
            int[,] matrix1 = new int[matrixRow1, matrixColumn1];

            Console.Clear();            

            for (int i = 0; i < matrixRow; i++)                         // Перебор циклом кадого элемента матрицы
            {
                Console.SetCursorPosition(0, i);                        // Отступ матрицы в консоли
                Console.Write("| ");

                for (int j = 0; j < matrixColumn; j++)
                {
                    matrix[i, j] = r.Next(0, 100);                       // Заполняем рандомно матрицу
                    Console.Write($"{matrix[i, j], 2} ");                  // Выводим матрицу в консоль
                }
                Console.Write("|");
            }

            Console.SetCursorPosition(5 + (2 * matrixColumn) + matrixColumn - 1, matrixRow / 2);       // Отступ равно в консоли
            Console.Write("+");

            for (int i = 0; i < matrixRow1; i++)                         // Перебор циклом кадого элемента матрицы
            {
                Console.SetCursorPosition(7 + (matrixColumn * 2) + matrixColumn - 1, i);      // Отступ матрицы в консоли
                Console.Write("| ");

                for (int j = 0; j < matrixColumn1; j++)
                {
                    matrix1[i, j] = r.Next(0, 100);                       // Заполняем рандомно матрицу
                    Console.Write($"{matrix1[i, j], 2} ");                  // Выводим матрицу в консоль
                }
                Console.Write("|");
            }

            Console.SetCursorPosition(12 + (2 * matrixColumn) + matrixColumn - 1 + (2 * matrixColumn1) + matrixColumn1 - 1, matrixRow / 2);       // Отступ равно в консоли
            Console.Write("=");
            
            for (int i = 0; i < matrixRow1; i++)                         // Перебор циклом кадого элемента матрицы
            {
                Console.SetCursorPosition(14 + (2 * matrixColumn) + matrixColumn - 1 + (2 * matrixColumn1) + matrixColumn1 - 1, i);      // Отступ матрицы в консоли
                Console.Write("| ");

                for (int j = 0; j < matrixColumn1; j++)
                {
                                           
                    Console.Write($"{matrix1[i, j],2} ");                  // Выводим матрицу в консоль
                }
                Console.Write("|");
            }



            Console.ReadKey();
            Console.Clear();
        }
    }
}
