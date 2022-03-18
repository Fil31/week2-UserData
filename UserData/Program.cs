using System;

namespace UserData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Спрашивает у юзера его имя и пароль
            // Если имя совпадает с зарегистрированным юзером admin, то консоль приветствует юзера Welcome, user
            // В ином случае ошибка Sorry, but username not registered.
            Console.WriteLine("Hey! Please enter your username");
            string username = Console.ReadLine();
            if(username == "admin")
            {
                Console.WriteLine($"Welcome, {username}!");
            }
            else 
            {
                Console.WriteLine($"Sorry, but username {username} not registered.");
            }
            if (username == "admin")
            {
                Console.WriteLine("Have a good day!");
            }
            else 
            {
                Console.WriteLine("You can register at https://www.cisco.com/");
            }
           // Я знаю что это можно было уместить в гораздо меньше строк, но для практики я считаю можно сделать так.
        }
    }
}
