using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework_Skillbox_Module3
{
    internal class Game
    {
        static void Main(string[] args)
        {

            Console.Write("Введите максимальное число игры: ");
            int maxGameNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите минимальное число игры: ");
            int minGameNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите максимальное число вычитания: ");
            int maxTurnMinus = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            int gameNumber = random.Next(minGameNumber, maxGameNumber + 1);


            Player player1 = new Player();
            

            player1.Naming();
           

            while (gameNumber > 0)
            {
                                  
                UserTry(player1.PlayerName, gameNumber);

                if (gameNumber <= 0)
                {
                    Console.WriteLine($"{player1.PlayerName} победил, еще разок?");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                }


                BotPlayer(gameNumber);
                if (gameNumber <= 0)
                {
                    Console.WriteLine($"Bot win, реванш?");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);
                }

            }


            void UserTry(string Name, int numberNow)
            {
                Console.WriteLine($"Число: {numberNow},");
                Console.Write($"Ход {Name}: ");
            
                int userInt = int.Parse(Console.ReadLine());

                if (userInt > 0 && userInt < maxTurnMinus + 1)
                {
                    gameNumber = numberNow - userInt;
                    
                }
            }        

            void BotPlayer(int numberNow)
            {
                Console.WriteLine($"Число: {numberNow},");
                int botInt = random.Next(1, maxTurnMinus + 1);
                Console.WriteLine($"Ход Бот: {botInt}");                
                gameNumber = numberNow -  botInt;

            }
        }
    }
}
