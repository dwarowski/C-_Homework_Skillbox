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
            int functionNum = 1;

            Console.WriteLine("Возможные действия:");
            Console.WriteLine("1. Умножить матрицу на число");
            Console.WriteLine("2.");
            Console.WriteLine("3.");
            Console.WriteLine("4.");
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
               
            Matrix matrix = new Matrix();       // Создание новой матрицы

            if (functionNum == 1)
            {
                matrix.MltiplyByNum();          // Умножение числа на матрицу
                Main(args);                     // Перезапуск
            }
            if (functionNum == 2)
            {
                Main(args);
            }
            if (functionNum == 3)
            {
                Main(args);
            }
            if (functionNum == 4)
            {
                Main(args);
            }
        }
    }
}
