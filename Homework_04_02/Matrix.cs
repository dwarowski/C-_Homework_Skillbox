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
                    Console.Write($"{matrix[i, j]} ");                  // Выводим матрицу в консоль
                }

                Console.WriteLine($"|");
            }

            Console.SetCursorPosition(7 + (3 * matrixColumn), matrixRow / 2);       // Отступ равно в консоли
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

        }
    }
}
