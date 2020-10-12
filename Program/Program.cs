using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your year of birth:");
            string userInput = Console.ReadLine();
            int userAge = CalculateAge(userInput);

            Console.WriteLine($"You are {userAge} years old.");
            ValidateAge(userAge);
        }
        public static int CalculateAge(string userInput)
        {
            int userAge = 2020 - Int32.Parse(userInput);
            return userAge;
        }
        public static void ValidateAge(int age)
        {
            if (age < 18)
            {
                Console.WriteLine("You aren't old enough to operate a powered wagon.");
            }
            else
            {
                Console.WriteLine("get older lol.");
            }
        }
        
    }
}
