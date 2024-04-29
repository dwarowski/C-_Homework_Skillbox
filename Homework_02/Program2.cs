namespace Homework_Skillbox_Module2
{
    internal class Program2
    {
        static void Main(string[] args)
        {

            // Создание нового пользователя  и задаем параметры
            User user1 = new User
            {
                Name = "Artemas",
                Age = 18,
                Height = 169,
                History_score = 57,
                Math_score = 67,
                Russian_score = 44
            };

            user1.PrintCommon();
            user1.PrintInterpolated();
            user1.PrintFormatted();
            user1.PrintCentered();// Выводим 
            
        }
    }
}
