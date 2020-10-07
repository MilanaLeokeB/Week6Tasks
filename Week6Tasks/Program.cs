using System;

namespace Week6Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] superHeroes = { "Batman", "Santa", "Spongebob", "Thor", "Harry Potter" };
            string[] superVillains = { "Godzilla", "Voldemort", "Grinch", "Darth Vader", "T-1000" };
            string[] weapon = { "banana", "fork", "keyboard", "purse", "jar of mud" };

            Random rnd = new Random();
            int randomIndex = rnd.Next(0, superHeroes.Length);
            int randomIndexx = rnd.Next(0, superVillains.Length);
            int randomIndexxx = rnd.Next(0, weapon.Length);
            Console.WriteLine($"Today {superHeroes[randomIndex]} will fight {superVillains[randomIndexx]} with a {weapon[randomIndexxx]}");

        }
    }
}
