using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_05_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свою строку: ");     // Вывод сообщения о вводе
            string input = Console.ReadLine();          // Считывание введеной строки 

            Console.WriteLine(StringSeparator(input));  // Вывод работы метода
            Console.ReadKey();                          // Ожидание для просмотра


            string StringSeparator(string inputString)
            {
                string outputString = "";                            // Пустая строка для вывода
                
                for (int i = 0; i < inputString.Length - 1; i++)     // Цикл перебора всех букв 
                {
                    if (inputString.ToUpperInvariant()[i] != inputString.ToUpperInvariant()[i + 1]) // Если следущая буква другая -> 
                    {
                        outputString += inputString[i];              // -> Добавляй текущую букву в выводную строку 
                    }
                }

                outputString += inputString[inputString.Length - 1]; // Добавляем последнюю букву в строке 

                return outputString;                                 // Возвращаем выводную строку
            }
        }
    }
}
