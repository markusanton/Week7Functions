using System;

namespace Week7Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year you were born: ");
            AgeCalculator();
        }
        public static void AgeCalculator()
        {
            int userBirth = Int32.Parse(Console.ReadLine());
            int userAge = 2020 - userBirth;
            Console.WriteLine($"You are {userAge} years old.");
        }
    }
}