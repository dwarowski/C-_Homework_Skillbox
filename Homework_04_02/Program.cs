using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_04_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Возможные действия:");
            Console.WriteLine("1. Умножить матрицу на число");
            Console.WriteLine("2.");
            Console.WriteLine("3.");
            Console.WriteLine("4.");
            Console.WriteLine("Для выбора, напишиите цифру нужного действия: ");
            int functionNum = int.Parse(Console.ReadLine());    // Читаем действие

            Matrix matrix = new Matrix();       // Создание новой матрицы

            if (functionNum == 1)
            {
                matrix.MltiplyByNum();
            }
            if (functionNum == 2)
            {

            }
            if (functionNum == 3)
            {

            }
            if (functionNum == 4)
            {

            }
        }
    }
}
