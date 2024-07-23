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
            foreach( string word in MinLenWord(inputString))
            {
                if (word != null)
                {
                    Console.WriteLine(word);
                }
                
            }
            foreach (string word in MaxLenWord(inputString))
            {
                if (word != null)
                {
                    Console.WriteLine(word);
                }
            }
            
            Console.ReadKey();


            
            string[] MaxLenWord(string input)   // Поиск слова максимальной длины
            {
                string[] words = input.Split(' ');          // Делим входную строку в массив по пробелам
                int maxLengthWord = words.Max(w => w.Length);   // Ищем максимальную длину слова
                string[] maxWords = new string[words.Length];
                
                foreach (string word in words)          // Ищем все подходящие в массиве и добовляем в выводной массив
                {
                    if (word.Length == maxLengthWord)
                    {
                        maxWords.SetValue(word,1);
                    }
                }
                return maxWords;
            }

            string[] MinLenWord(string input)   // Поиск слова минимальной длины
            {
                string[] words = input.Split(' ');          // Делим входную строку в массив по пробелам
                int minLengthWord = words.Min(w => w.Length );   // Ищем минимальную длину слова
                string[] minWords = new string[words.Length];

                foreach (string word in words)          // Ищем все подходящие в массиве и добовляем в выводной массив
                {
                    if (word.Length == minLengthWord)
                    {
                        minWords.Append(word);
                    }
                }
                return minWords;
            }
        }

    }
       
}

