using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework_Skillbox_Module2
{
    /// <summary>
    /// Класс пользователь с указанием имени пользователя, возраста, роста 
    /// и баллов по истории математики и русскому и средний бал
    /// </summary>
    class User
    {      

        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возраст пользователя
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Рост пользователя
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Баллы по истории пользователя
        /// </summary>
        public int History_score { get; set; }

        /// <summary>
        /// Баллы по матеше пользователя
        /// </summary>
        public int Math_score { get; set; }

        /// <summary>
        /// Баллы по русскому пользователя
        /// </summary>
        public int Russian_score { get; set; }


        /// <summary>
        /// Вывод обычный
        /// </summary>
        public void PrintCommon()
        {
            double Average_score = (History_score + Math_score + Russian_score) / 3; //Подсчет среднего балла

            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.WriteLine(Height);
            Console.WriteLine(History_score);
            Console.WriteLine(Math_score);
            Console.WriteLine(Russian_score);
            Console.WriteLine(Average_score);
            
            Console.WriteLine("");

            Console.ReadKey();

            Console.Clear();
        }


        /// <summary>
        /// Вывод форматированый 
        /// </summary>
        public void PrintFormatted()
        {
            double Average_score = (History_score + Math_score + Russian_score) / 3; //Подсчет среднего балла
            
            Console.WriteLine("Имя: {0} " +
                "\nВозраст: {1} " +
                "\nРост: {2} " +
                "\nИстория: {3} " +
                "\nМатематика: {4} " +
                "\nРусский: {5} " +
                "\nСредний: {6}",
                Name,
                Age,
                Height,
                History_score,
                Math_score,
                Russian_score,
                Average_score);

            Console.WriteLine("");
            
            Console.ReadKey();

            Console.Clear();
        }


        /// <summary>
        ///  Вывод интерполированый
        /// </summary>
        public void PrintInterpolated()
        {
            double Average_score = (History_score + Math_score + Russian_score) / 3; //Подсчет среднего балла

            Console.WriteLine($"{"Имя: " } {Name,10} ");
            Console.WriteLine($"{"Возраст: "} {Age,4} ");
            Console.WriteLine($"{"Рост: "} {Height,4} ");
            Console.WriteLine($"{"Баллы по истории: "} {History_score,4} ");
            Console.WriteLine($"{"Баллы по математике: "} {Math_score,4} ");
            Console.WriteLine($"{"Баллы по русскому: "} {Russian_score,4} ");
            Console.WriteLine($"{"Средний балл: "} {Average_score,4}");

            Console.WriteLine("");

            Console.ReadKey();

            Console.Clear();
        }

        /// <summary>
        /// Вывод по центру консоли
        /// </summary>
        public void PrintCentered()
        {
            double Average_score = (History_score + Math_score + Russian_score) / 3; //Подсчет среднего балла

            int consoleWidth = Console.WindowWidth / 2;           // Ширина окна консоли в момент печати
            int consoleHeight = Console.WindowHeight / 2;          // Длина окна консоли в момент печати
            
            
            
            Console.SetCursorPosition(consoleWidth, consoleHeight); // Установка курсора
            Console.WriteLine(Name);
            Console.SetCursorPosition(consoleWidth, consoleHeight + 1); // Установка курсора
            Console.WriteLine(Age);
            Console.SetCursorPosition(consoleWidth, consoleHeight + 2); // Установка курсора
            Console.WriteLine(Height);
            Console.SetCursorPosition(consoleWidth, consoleHeight + 3); // Установка курсора
            Console.WriteLine(History_score);
            Console.SetCursorPosition(consoleWidth, consoleHeight + 4); // Установка курсора
            Console.WriteLine(Math_score);
            Console.SetCursorPosition(consoleWidth, consoleHeight + 5); // Установка курсора
            Console.WriteLine(Russian_score);
            Console.SetCursorPosition(consoleWidth, consoleHeight + 6); // Установка курсора
            Console.WriteLine(Average_score);

            Console.WriteLine("");

            Console.ReadKey();

            Console.Clear();
        }

    }
}
