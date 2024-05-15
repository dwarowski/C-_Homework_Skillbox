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

            Random random = new Random();  // Создание рандома
            int gameNumber = random.Next(minGameNumber, maxGameNumber + 1);  // Установка финального значения игры


            Player player1 = new Player(); // Создание игрока 1
            

            player1.Naming();   
           

            while (gameNumber > 0)          // Индикатор конца игры
            {
                                  
                UserTry(player1.PlayerName, gameNumber);    // Ход игрока

                if (gameNumber <= 0)                // Проверка хода на победу
                {
                    Console.WriteLine($"{player1.PlayerName} победил, еще разок?");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);         // Перезапуск программыы 
                }


                BotPlayer(gameNumber);      // Ход Бота
                if (gameNumber <= 0)        // Проверка хода на победу
                {
                    Console.WriteLine($"Bot win, реванш?");
                    Console.ReadKey();
                    Console.Clear();
                    Main(args);         // Перезапуск программыы 
                }

            }

           
            void UserTry(string Name, int numberNow)       // Ход игрока
            {
                Console.WriteLine($"Число: {numberNow},");  // Вывод какое число сейчас
                Console.Write($"Ход {Name}: ");             // Вывод как походит игрок
            
                int userInt = int.Parse(Console.ReadLine());      // Ожидаем ввод игрока 

                if (userInt > 0 && userInt < maxTurnMinus + 1)  // Условие сделать ход
                {
                    gameNumber = numberNow - userInt;            // Применение хода 

                }
            }        

            void BotPlayer(int numberNow)   // Ход бота
            {
                Console.WriteLine($"Число: {numberNow},");          // Вывод какое число сейчас
                int botInt = random.Next(1, maxTurnMinus + 1);      // Расчет хода 
                Console.WriteLine($"Ход Бот: {botInt}");            // Вывод каким числом походил       
                gameNumber = numberNow -  botInt;                   // Применение хода 

            }
        }
    }
}
