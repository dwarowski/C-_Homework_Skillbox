using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Homework_05_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите два параметра через пробел: ");           // Вывод строки для пользователя 
            string inputParams = Console.ReadLine();                         // Считывание строки
            string[] inputParamsSplit = inputParams.Split(' ');              // Разделение строки на строки по пробелам
            int[] intParams = Array.ConvertAll(inputParamsSplit, int.Parse); // Перевод в числа из строк


            Console.WriteLine(Acckermans(intParams[0], intParams[1]));       // Вызов функции с задаными параметрами 

            Console.ReadKey();                                               // Ожидание ввода

            int Acckermans(int n, int m)
            {

                if (n == 0)
                {
                    return m+=1;
                }

                else if (n > 0 && m == 0)
                {
                    return Acckermans(n - 1, 1);
                }
                else
                {
                    return Acckermans(n - 1, Acckermans(n, m - 1));
                }
               
                
            }
        }
    }
}
