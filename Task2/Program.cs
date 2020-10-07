using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = { "1, 2, 3, 4, 5, 6, 7, 8, 9, 10" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, numbers.Length);
            Console.WriteLine($" This is your random number: {numbers[randomIndex]} ");




        }
    }
}
