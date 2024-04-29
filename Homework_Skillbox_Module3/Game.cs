using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Skillbox_Module3
{
    internal class Game
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int gameNumber = random.Next(12, 121);

            Player player1 = new Player();
            Player player2 = new Player();

            player1.Naming();
            player2.Naming();


            while (gameNumber > 0)
            {
                UserTry(player1.PlayerName, gameNumber);
                if (gameNumber <= 0)
                {
                    
                }
                else
                {
                    UserTry(player2.PlayerName, gameNumber);
                }
            }


            void UserTry(string Name, int numberNow)
            {
                Console.WriteLine($"Число: {numberNow},");
                Console.Write($"Ход {Name}: ");
            
                int userInt = int.Parse(Console.ReadLine());

                if (userInt > 0 && userInt < 5)
                {
                    gameNumber = numberNow - userInt;
                }

            }        
        }
    }
}
