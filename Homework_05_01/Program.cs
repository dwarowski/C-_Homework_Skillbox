using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_05_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            Console.WriteLine(MinLenWord(inputString));

            Console.WriteLine(MaxLenWord(inputString));             
            
            Console.ReadKey();

            
            string MaxLenWord(string input)   // Поиск слова максимальной длины
            {
                string[] words = input.Split(' ');              // Делим входную строку в массив по пробелам
                int maxLengthWord = words.Max(w => w.Length);   // Ищем максимальную длину слова
                string maxWords = "";                           // Пустая выводная строка
                foreach (string word in words)                  // Ищем все подходящие в массиве и добавляем в выводной массив
                {
                    if (word.Length == maxLengthWord)
                    {
                       maxWords += $"{word} ";                  // Добавляем к выводной строке максимальное слово
                    }
                }
                return maxWords;
            }

            string MinLenWord(string input)   // Поиск слова минимальной длины
            {
                string[] words = input.Split(' ');               // Делим входную строку в массив по пробелам
                int minLengthWord = words.Min(w => w.Length );   // Ищем минимальную длину слова
                string minWords = "";                            // Пустая выводная строка

                foreach (string word in words)                   // Ищем все подходящие в массиве и добовляем в выводной массив
                {
                    if (word.Length == minLengthWord)
                    {
                        minWords += $"{word} ";                  // Добавляем к выводной строке минимальное слово
                    }
                }
                return minWords;
            }
        }

    }
       
}

