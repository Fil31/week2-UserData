using System;

namespace UserPIN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Для входа в Swedbank требуется ввести ваш PIN");
            string pin = Console.ReadLine();
            if(pin == "1234")
                Console.WriteLine("Добро пожаловать в Swedbank!");
            else
            {
                Console.WriteLine("Введеным Вами PIN неверный");
            }
            if (pin == "1234")
            {
                Console.WriteLine("Напомните, как Вас зовут?");
                string name = Console.ReadLine();
                Console.WriteLine($"Рады вновь видеть Вас в банке, который забыл как вас зовут, {name}!");
            }

            //Приложение просит юзера ввести пинкод, если введеный PIN "1234", то приложение приветсвует юзера
            //*и спрашивает его имя, а затем приветствует по имени его.
            //В ином случае, консоль выдаст сообщение об ошибке Invalid PIN. 
            
        }
    }
}
