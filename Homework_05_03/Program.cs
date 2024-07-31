using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_05_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите арфиметическую прогресию, у которой вы хотите узнать шаг: "); // Выводим строку
            string inputArifmeticalProgress = Console.ReadLine();                                // Считываем 
            Console.WriteLine(ArifmeticalProgress(inputArifmeticalProgress));                    // Выводим результат работы метода  

            Console.ReadKey();
            Console.Clear();
             
            Console.Write("Введите геометрическую прогресию, у которой вы хотите узнать шаг: "); // Выводим строку
            string inputGeometricalProgress = Console.ReadLine();                                // Считываем 
            Console.WriteLine(GeometricalProgress(inputGeometricalProgress));                    // Выводим результат работы метода
            
            Console.ReadKey();                                                                   // Ждем ввода


            string ArifmeticalProgress(string methodInputString)
            {
                string[] splittedInputString = methodInputString.Split(' ');        // Разделяем ввод по пробелам на массив строк
                int[] inputInt = Array.ConvertAll(splittedInputString, int.Parse);  // Конвертируем все строки в числа

                int arifmeticStep = inputInt[1] - inputInt[0];                      // Определяем шаг прогрессии

                for (int i = 0; i < inputInt.Length - 1; i++)                       // Перебор всех чисел 
                {
                    if (inputInt[i + 1] - inputInt[i] != arifmeticStep)             // Если шаг отличается то ->
                    {
                        return "Это не арифметическаяя прогрессия";                 // -> Возврат отрицательный
                    }                 
                }
                return $"Это арифметическая прогрессия, шаг: {arifmeticStep}";      // Возврат положительный
            }


            string GeometricalProgress(string methodInputString)
            {
                string[] splittedInputString = methodInputString.Split(' ');        // Разделяем ввод по пробелам на массив строк
                int[] inputInt = Array.ConvertAll(splittedInputString, int.Parse);  // Конвертируем все строки в числа

                int geometricStep = inputInt[1] / inputInt[0];                      // Определяем шаг прогрессии

                for (int i = 0; i < inputInt.Length - 1; i++)                       // Перебор всех чисел 
                {
                    if (inputInt[i + 1] / inputInt[i] != geometricStep || inputInt[0] == 0 || geometricStep == 0) // Если шаг отличается то ->
                    {
                        return "Это не геометрическая прогрессия";                 // -> Возврат отрицательный
                    }
                }
                return $"Это геометрическая прогрессия, шаг: {geometricStep}";     // Возврат положительный
            }

        }
    }
}
