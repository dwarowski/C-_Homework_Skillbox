using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Homework_05
{
    internal class Matrix
    {
        Random r = new Random();
        /// <summary>
        /// Умножение числа на матрицу
        /// </summary>
        public void MatrixMltiplyByNum(int matrixRow, int matrixColumn, int matrixNumMultiplier)   
        {
            int[,] matrix = new int[matrixRow, matrixColumn];           // Создаем матрицу по заданым значениям
            
            Console.Clear();
            Console.SetCursorPosition(0, matrixRow / 2);                // Центровка числа в консоли
            Console.Write($"{matrixNumMultiplier} * ");                 // Вывод числа 
            

            for (int i = 0; i < matrixRow; i++)                         // Перебор циклом кадого элемента матрицы
            {
                Console.SetCursorPosition(matrixNumMultiplier.ToString().Length + 3, i);         // Отступ матрицы от числа, количество цифр в числе + 3 символа 
                Console.Write($"| ");

                for (int j = 0 ; j < matrixColumn; j++)
                {
                    matrix[i, j] = r.Next(0,100);                          // Заполняем рандомно матрицу
                    Console.Write($"{matrix[i, j], 2} ");                  // Выводим матрицу в консоль
                }

                Console.WriteLine($"|");
            }

            Console.SetCursorPosition((matrixNumMultiplier.ToString().Length + 3) + 1 + (2 * matrixColumn) + matrixColumn + 1 + 1, matrixRow / 2);       // Отступ равно в консоли, кол-во цифр числа + символы + разделитель + столбцы  + отступы столбцов + разделитель + отступ от матрицы
            Console.Write(" = ");                                           // То самое равно


            for (int i = 0; i < matrixRow; i++)                             // Перебор циклом кадого элемента матрицы
            {
                Console.SetCursorPosition((matrixNumMultiplier.ToString().Length + 3) + 1 + (2 * matrixColumn) + matrixColumn + 1 + 4, i);               // Отступ перемноженной матрицы в консоли
                Console.Write("| ");

                for (int j = 0; j < matrixColumn; j++)
                {
                    matrix[i, j] *= matrixNumMultiplier;                   // Перемножение матрицы
                    Console.Write($"{matrix[i, j], 6} ");                  // Вывод перемноженной матрицы
                }
                Console.WriteLine("|");
            }

            Console.ReadKey();
            Console.Clear();
        }

        /// <summary>
        /// Сложение матриц 
        /// </summary>
        public void MatrixAddMatrix(int matrixRow, int matrixColumn, int matrixRow1, int matrixColumn1)                     
        {
            int[,] matrix = new int[matrixRow, matrixColumn];            // Первая матрица пользователя 
            int[,] matrix1 = new int[matrixRow1, matrixColumn1];         // Вторая матрица пользователя 
            int[,] matrixAdd = new int[matrixRow, matrixColumn];         // Матрица после сложения

            Console.Clear();            

            for (int i = 0; i < matrixRow; i++)                         // Перебор циклом кадого элемента матрицы
            {
                Console.SetCursorPosition(0, i);                        // Отступ матрицы в консоли
                Console.Write("| ");

                for (int j = 0; j < matrixColumn; j++)
                {
                    matrix[i, j] = r.Next(0, 100);                       // Заполняем рандомно матрицу
                    Console.Write($"{matrix[i, j],2} ");                 // Выводим матрицу в консоль
                }
                Console.Write("|");
            }

            Console.SetCursorPosition((2 * matrixColumn) + matrixColumn + 3, matrixRow / 2);       // Отступ в консоли
            Console.Write(" + ");

            for (int i = 0; i < matrixRow1; i++)                         // Перебор циклом кадого элемента матрицы
            {
                Console.SetCursorPosition((matrixColumn * 2) + matrixColumn + 3 + 3, i);      // Отступ матрицы в консоли
                Console.Write("| ");

                for (int j = 0; j < matrixColumn1; j++)
                {
                    matrix1[i, j] = r.Next(0, 100);                       // Заполняем рандомно матрицу
                    Console.Write($"{matrix1[i, j],2} ");                  // Выводим матрицу в консоль
                }
                Console.Write("|");
            }

            Console.SetCursorPosition(((2 * matrixColumn) + matrixColumn) + ((2 * matrixColumn1) + matrixColumn1) + 9, matrixRow / 2);       // Отступ равно в консоли
            Console.Write(" = ");

            if (matrixColumn == matrixColumn1 && matrixRow == matrixRow1)
            {
                for (int i = 0; i < matrixRow; i++)                         // Перебор циклом кадого элемента матрицы
                {
                    Console.SetCursorPosition((2 * matrixColumn) + matrixColumn + (2 * matrixColumn1) + matrixColumn1 + 12, i);      // Отступ матрицы в консоли
                    Console.Write("| ");

                    for (int j = 0; j < matrixColumn; j++)
                    {
                        matrixAdd[i,j] = matrix[i, j] + matrix1[i, j];
                        Console.Write($"{matrixAdd[i, j],4} ");                  // Выводим матрицу в консоль
                    }
                    Console.Write("|");
                }
            }
            else
            {
                Console.WriteLine("Матрциы разных размеров нельзя складывать");
            }
            

            Console.ReadKey();
            Console.Clear();
        }       

        /// <summary>
        /// Вычитание матриц
        /// </summary>
        public void MatrixSubMatrix(int matrixRow, int matrixColumn, int matrixRow1, int matrixColumn1)
        {
            int[,] matrix = new int[matrixRow, matrixColumn];            // Первая матрица пользователя 
            int[,] matrix1 = new int[matrixRow1, matrixColumn1];         // Вторая матрица пользователя 
            int[,] matrixSub = new int[matrixRow, matrixColumn];         // Матрица после вычитания

            Console.Clear();

            for (int i = 0; i < matrixRow; i++)                         // Перебор циклом кадого элемента матрицы
            {
                Console.SetCursorPosition(0, i);                        // Отступ матрицы в консоли
                Console.Write("| ");

                for (int j = 0; j < matrixColumn; j++)
                {
                    matrix[i, j] = r.Next(0, 100);                       // Заполняем рандомно матрицу
                    Console.Write($"{matrix[i, j],2} ");                 // Выводим матрицу в консоль
                }
                Console.Write("|");
            }

            Console.SetCursorPosition((2 * matrixColumn) + matrixColumn + 3, matrixRow / 2);       // Отступ  в консоли
            Console.Write(" - ");

            for (int i = 0; i < matrixRow1; i++)                         // Перебор циклом кадого элемента матрицы
            {
                Console.SetCursorPosition((matrixColumn * 2) + matrixColumn + 3 + 3, i);      // Отступ матрицы в консоли
                Console.Write("| ");

                for (int j = 0; j < matrixColumn1; j++)
                {
                    matrix1[i, j] = r.Next(0, 100);                       // Заполняем рандомно матрицу
                    Console.Write($"{matrix1[i, j],2} ");                  // Выводим матрицу в консоль
                }
                Console.Write("|");
            }

            Console.SetCursorPosition(((2 * matrixColumn) + matrixColumn) + ((2 * matrixColumn1) + matrixColumn1) + 9, matrixRow / 2);       // Отступ равно в консоли
            Console.Write(" = ");

            if (matrixColumn == matrixColumn1 && matrixRow == matrixRow1)
            {
                for (int i = 0; i < matrixRow; i++)                         // Перебор циклом кадого элемента матрицы
                {
                    Console.SetCursorPosition((2 * matrixColumn) + matrixColumn + (2 * matrixColumn1) + matrixColumn1 + 12, i);      // Отступ матрицы в консоли
                    Console.Write("| ");

                    for (int j = 0; j < matrixColumn; j++)
                    {
                        matrixSub[i, j] = matrix[i, j] - matrix1[i, j];
                        Console.Write($"{matrixSub[i, j],3} ");                  // Выводим матрицу в консоль
                    }
                    Console.Write("|");
                }
            }
            else
            {
                Console.WriteLine("Матрциы разных размеров нельзя вычитать");
            }


            Console.ReadKey();
            Console.Clear();

        }

        /// <summary>
        /// Умножение матрицы на матрицу
        /// </summary>
        public void MatrixMultiplyMatrix(int matrixRow, int matrixColumn, int matrixRow1, int matrixColumn1)
        {
            int[,] matrix = new int[matrixRow, matrixColumn];            // Первая матрица пользователя 
            int[,] matrix1 = new int[matrixRow1, matrixColumn1];         // Вторая матрица пользователя 
            int[,] matrixMul = new int[matrixRow, matrixColumn1];
            
            Console.Clear();

            for (int i = 0; i < matrixRow; i++)                         // Перебор циклом кадого элемента матрицы
            {
                Console.SetCursorPosition(0, i);                        // Отступ матрицы в консоли
                Console.Write("| ");

                for (int j = 0; j < matrixColumn; j++)
                {
                    matrix[i, j] = r.Next(0, 100);                       // Заполняем рандомно матрицу
                    Console.Write($"{matrix[i, j],2} ");                 // Выводим матрицу в консоль
                }
                Console.Write("|");
            }

            Console.SetCursorPosition((2 * matrixColumn) + matrixColumn + 3, matrixRow / 2);       // Отступ  в консоли
            Console.Write(" * ");

            for (int i = 0; i < matrixRow1; i++)                         // Перебор циклом кадого элемента матрицы
            {
                Console.SetCursorPosition((matrixColumn * 2) + matrixColumn + 3 + 3, i);      // Отступ матрицы в консоли
                Console.Write("| ");

                for (int j = 0; j < matrixColumn1; j++)
                {
                    matrix1[i, j] = r.Next(0, 100);                       // Заполняем рандомно матрицу
                    Console.Write($"{matrix1[i, j],2} ");                  // Выводим матрицу в консоль
                }
                Console.Write("|");
            }

            Console.SetCursorPosition(((2 * matrixColumn) + matrixColumn) + ((2 * matrixColumn1) + matrixColumn1) + 9, matrixRow / 2);       // Отступ равно в консоли
            Console.Write(" = ");

            if (matrixColumn == matrixRow1)
            {
                for (int i = 0; i < matrixRow; i++)                         // Перебор циклом кадого элемента матрицы
                {
                    Console.SetCursorPosition((2 * matrixColumn) + matrixColumn + (2 * matrixColumn1) + matrixColumn1 + 12, i);      // Отступ матрицы в консоли
                    Console.Write("| ");

                    for (int j = 0; j < matrixColumn1; j++)
                    {
                        
                        for (int k = 0; k < matrixColumn; k++)
                        {
                            matrixMul[i, j] += matrix[i, k] * matrix1[k, j];     
                        }
                        Console.Write($"{matrixMul[i, j],3} ");                  // Выводим матрицу в консоль
                    }
                    Console.Write("|");
                }
            }
            else
            {
                Console.WriteLine("Матрицы неправильной размерности");
            }


            Console.ReadKey();
            Console.Clear();

        }
    }
}
