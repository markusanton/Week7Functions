using System;

namespace Gender
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your gender: ");
            string userGender = Console.ReadLine().ToLower();
            if (userGender == "m")
            {
                Console.WriteLine("Hello, sir!");
            }  
            else if (userGender == "f")
            {
                Console.WriteLine("Hello, madam");
            }
            else
            {
                Console.WriteLine("Please enter your gender, either M for male or F for female. No 'non-binary' bullshit.");
            }
        }
    }
}
