using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_Number // Угадай число.
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int lower, higher;
            int triesCount = 5;
            int userInput;
            Random rand = new Random();

            number = rand.Next(0, 101);
            lower = rand.Next(number - 10, number);
            higher = rand.Next(number + 1, number + 10);

            Console.WriteLine($"Мы загадали число от 0 до 100, оно больше чем {lower}, " +
                $"но меньше, чем {higher}.");
            Console.WriteLine($"Что это за число? У вас {triesCount} попыток его отгадать.");

            while (triesCount-- > 0)
            {
                Console.Write("Ваш ответ:");
                userInput = Convert.ToInt32(Console.ReadLine());
                if(userInput == number)
                {
                    Console.WriteLine("Вы правы, это было число " + number + ". Поздравляем, вы выиграли в нашей игре!");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Не верно, попробуйте ещё раз!");
                }
            }

            if (triesCount < 0)
            {
                Console.WriteLine("Вы проиграли. Не расстраивайся, повезёт в следующий раз! Это было число " + number + ".");
                Console.ReadLine();
            }
        }
    }
}
