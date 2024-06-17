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
        public void MltiplyByNum(int matrixRow = 0, int matrixColumn = 0)
        {
            Console.Write("Введите количество рядов матрицы: ");
            matrixRow = int.Parse(Console.ReadLine());            // Считываем кол-во рядов
            Console.Write("Введите количество колонок матрицы: ");
            matrixColumn = int.Parse((Console.ReadLine()));       // Считываем кол-во колонок 
            Console.Write("Введите число на которое надо умножить: ");
            int matrixNumMultiplier = int.Parse(Console.ReadLine());    // Число на которое будет умножатся матрица
            
            int[,] matrix = new int[matrixRow, matrixColumn];     // Создаем матрицу по заданым значениям
            
            Console.Clear();
            Console.SetCursorPosition(matrixRow / 2, 0);
            Console.Write($"{matrixNumMultiplier} * ");


            for (int i = 0; i < matrixRow; i++)              // Перебор циклом кадого элемента матрицы
            {

                for (int j = 0 ; j < matrixColumn; j++)
                {
                    matrix[i, j] = r.Next(0,100);           // Заполняем рандомно матрицу
                    Console.Write($"{matrix[i, j]} "); 
                }
                Console.WriteLine();
            }
            
            ///matrix[i, j] *= matrixNumMultiplier;

            Console.ReadKey();

        }
    }
}
