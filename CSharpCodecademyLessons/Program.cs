using System;

namespace CSharpCodecademyLessons
{
    class Program
    {
        static void Main(string[] args)
        {
            madLibs();
        }
        static void MoneyMaker()
        {
            
            Console.WriteLine("Welcome to Money Maker! Enter an amount to convert to coins:");
            double amount = Convert.ToDouble(Console.ReadLine());
            double goldCoinsValue = 10;
            double silverCoinsValue = 5;
            double goldCoins = Math.Floor(amount / goldCoinsValue);
            double remainderAfterGold = amount % goldCoinsValue;
            double silverCoins = Math.Floor(remainderAfterGold / silverCoinsValue);
            double remainder = amount % silverCoinsValue;
            Console.WriteLine($"{amount} cents is equal to ...");
            Console.WriteLine($"Gold Coins: {goldCoins}");
            Console.WriteLine($"silver Coins: {silverCoins}");
            Console.WriteLine($"Bronze Coins: {remainder}");
        }
        static void madLibs()
        {
            /*
This program mad libs
Author: moe
*/


            // Let the user know that the program is starting:
            Console.WriteLine("Yo the program is starting...");

            // Give the Mad Lib a title:
            string title = "The Average Human Work";

            Console.WriteLine(title);
            // Define user input and variables:
            Console.Write("Enter your name foo: ");
            string name = Console.ReadLine();

            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            Console.Write("Enter a first adjective: ");
            string adj1 = Console.ReadLine();

            Console.Write("Another adj: ");
            string adj3 = Console.ReadLine();


            Console.Write("Enter a verb: ");
            string verb = Console.ReadLine();

            Console.Write("Enter a noun: ");
            string noun1 = Console.ReadLine();

            Console.Write("Enter a another noun: ");
            string noun2 = Console.ReadLine();

            Console.WriteLine("Enter an animal: ");
            string animal = Console.ReadLine();

            Console.WriteLine("Enter a food name: ");
            string food = Console.ReadLine();

            Console.WriteLine("Enter a fruit: ");
            string fruit = Console.ReadLine();

            Console.WriteLine("Enter a superhero: ");
            string superhero = Console.ReadLine();


            Console.WriteLine("Enter a country: ");
            string country = Console.ReadLine();

            Console.WriteLine("Enter a dessert: ");
            string dessert = Console.ReadLine();

            Console.WriteLine("Enter a year: ");
            string year = Console.ReadLine();


            // The template for the story:

            string story = $"This morning {name} woke up feeling {word}. 'It is going to be a {adj1} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {superhero} texted {name}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


            // Print the story:
            Console.Write(story);
        }
    }
}
