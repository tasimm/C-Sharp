using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program simulates a game of Mad Libs by taking user input to string interpolate into a story
      Author: Taylor Simmons
      */


      // Let the user know that the program is starting:
      Console.WriteLine("Welcome to virtual Mad Libs! Please input words when prompted.\n");

      // Give the Mad Lib a title:
      string title = "A Crazy Day";

      Console.WriteLine(title);
      // Define user input and variables:
      Console.Write("Enter a name: ");
      string name = Console.ReadLine();

      // Ask the user for three adjectives
      Console.Write("Enter an adjective: ");
      string adjective1 = Console.ReadLine();

      Console.Write("Enter another adjective: ");
      string adjective2 = Console.ReadLine();

      Console.Write("Enter a third adjective: ");
      string adjective3 = Console.ReadLine();

      // Ask the user for a verb
      Console.Write("Enter a verb: ");
      string verb = Console.ReadLine();

      // Ask the user for two nouns
      Console.Write("Enter a noun: ");
      string noun1 = Console.ReadLine();

      Console.Write("Enter another noun: ");
      string noun2 = Console.ReadLine();

      // Ask the user for specific things
      Console.Write("Enter an animal: ");
      string animal = Console.ReadLine();

      Console.Write("Enter a food: ");
      string food = Console.ReadLine();

      Console.Write("Enter a fruit: ");
      string fruit = Console.ReadLine();

      Console.Write("Enter a superhero: ");
      string superhero = Console.ReadLine();

      Console.Write("Enter a country: ");
      string country = Console.ReadLine();

      Console.Write("Enter a dessert: ");
      string dessert = Console.ReadLine();

      Console.Write("Enter a year: ");
      string year = Console.ReadLine();

      // The template for the story:

      string story = $"This morning {name} woke up feeling {adjective1}. 'It is going to be a {adjective2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adjective3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


      // Print the story:
      Console.WriteLine(story);
    }
  }
}
