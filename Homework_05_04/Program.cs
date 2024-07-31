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
            Console.Write("Введите два параметра через пробел: ");
            string inputParams = Console.ReadLine();
            string[] inputParamsSplit = inputParams.Split(' ');
            int[] intParams = Array.ConvertAll(inputParamsSplit, int.Parse);


            Console.WriteLine(Acckermans(intParams[0], intParams[1]));

            Console.ReadKey();

            int Acckermans(int n, int m)
            {
                if (n < 0 || m < 0)
                {
                    return 0;
                }

                if (n == 0)
                {
                    return m++;
                }

                if (n >= 0 && m == 0)
                {
                    return Acckermans(n - 1, 1);
                }

               
                return Acckermans(n - 1, Acckermans(n, m - 1));
            }
        }
    }
}
