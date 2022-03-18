using System;

namespace DrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please enter your year of birth");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());
            int result = 2022 - yearOfBirth;
                if (result < 18)
            {
                Console.WriteLine("You are too young for driving license.");
            }
            else if (result > 18)
            {
                Console.WriteLine("Drive carefully");
            }
                else
                    {
                Console.WriteLine("Congratulations, you may apply for your driving license now");
            }
            


            //Приложение просит юзера ввести его год рождения, 
            //Приложение вычисляет возраст юзера (2022 - текущий год юзера)
            //Если юзер младше 18 лет, то в консоли будет "Too young for driving license"
            //Если старше 18 лет, то в консоли будет "Drive carefully"
            //Если ему 18, то в консоли "Congratulations, you may apply for your driving license now!"
        }
    }
}
