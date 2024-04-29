using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Skillbox_Module3
{
    class Player
    {
        public string PlayerName;
        public int numberStart = 0;

        public void Naming()
        {
            Console.Write("Введите свое имя:");
            PlayerName = Console.ReadLine();
        }
    }
}
