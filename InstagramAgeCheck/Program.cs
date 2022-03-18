using System;

namespace InstagramAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //Приложение спрашивают у юзера возраст, если возраст менее 13 лет, то приложение сообщает 
            //Что он слишком молод, если более 13 лет, приветствует
            Console.WriteLine("Hello, please enter your age!");
            int userAge = Convert.ToInt32(Console.ReadLine());
            if (userAge < 13)
            {
                Console.WriteLine("You are too young for Instagram.");
            } else if (userAge > 13)
            {
                Console.WriteLine("Welcome to Instagram!");
            }
            else
            {
                Console.WriteLine("Congratulations! You may use Instagram now.");
            }
            Console.WriteLine("Have a nice day!");
        }
    }
}
