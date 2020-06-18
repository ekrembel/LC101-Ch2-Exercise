using System;

namespace chapter2_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Promts user for name
            Console.WriteLine("Hey there! What's your name?");
            string userName = Console.ReadLine();

            // Greets user and prompts for dimenssions of rectangle
            Console.WriteLine($"Hey {userName}! How you doing? What's the width of your rectangle?");
            string width = Console.ReadLine();

            // Converts string to int
            int x = int.Parse(width);
            Console.WriteLine("What about the length?");
            string length = Console.ReadLine();
            int y = int.Parse(length);

            // Calculates area then prints it
            int areaOfRectangle = x * y;
            Console.WriteLine($"The area of your rectangle is {areaOfRectangle}");

            Console.WriteLine("\nHow many miles did you travel today?");
            string distanceTraveled = Console.ReadLine();
            Console.WriteLine("How many gallons of gasoline did you use?");
            string gasUsed = Console.ReadLine();
            int gasMileage = int.Parse(distanceTraveled) / int.Parse(gasUsed);
            Console.WriteLine($"\nThe gas mileage of your car for this trip is {gasMileage} mpg.");

            string adventure = "Alice was beginning to get very tired of sitting by her sister on the bank," +
                " and of having nothing to do: once or twice she had peeped into the book her sister was reading," +
                " but it had no pictures or conversations in it, \'and what is the use of a book,\' thought Alice \'without pictures or conversation?\'";

            string adventureLower = adventure.ToLower();
            Console.WriteLine("Word to search: ");
            string userInput = Console.ReadLine();

            if (adventureLower.Contains(userInput.ToLower()))
            {
                Console.WriteLine($"Index of {userInput} is {adventureLower.IndexOf(userInput)}. The length of your word is {userInput.Length}. We'll now try to remove it.");
                Console.WriteLine($"{userInput} was found");
                string newAdventure = adventureLower.Remove(adventureLower.IndexOf(userInput), userInput.Length + 1);
                Console.WriteLine($"The new sentence is '{newAdventure}'");
            }
            else
            {
                Console.WriteLine($"{userInput} can't be found");
            }
        }
    }
}
