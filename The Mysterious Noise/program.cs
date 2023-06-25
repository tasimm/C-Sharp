// Choose your own adventure game

using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
      static void Main(string[] args)
    {
      /* THE MYSTERIOUS NOISE */

      // Start by asking for the user's name:
      Console.Write("What is your name?: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}! Welcome to our story.");

      // Begin story
     Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
     
     // First prompt
     Console.Write("Type YES or NO: ");
     string noiseChoice = Console.ReadLine();
     string noiseLoudChoice = noiseChoice.ToUpper();

    // If user's choice is NO
    if (noiseLoudChoice == "NO") {
      Console.WriteLine("Not much of an adventure if we don't leave our room!");
      Console.WriteLine("THE END.");
    }
    else if (noiseLoudChoice == "YES") {
      Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. You walk towards it. Do you open it or knock?");
    }

    // Second prompt
    Console.Write("Type OPEN or KNOCK: ");
    string doorChoice = Console.ReadLine();
    string doorLoudChoice = doorChoice.ToUpper();

    // If user's choice is KNOCK
    if (doorLoudChoice == "KNOCK") {
      Console.WriteLine("A voice behind the door speaks.It says, \"Answer this riddle: \"");
      Console.WriteLine("\"Poor people have it. Rich people need it. If you eat it you die. What is it?\"");

      // Prompt user to answer riddle
      Console.Write("Type your answer: ");
      string riddleAnswer = Console.ReadLine();
      string riddleLoudAnswer = riddleAnswer.ToUpper();

      // Loop for correct and incorrect answer
      if (riddleLoudAnswer == "NOTHING") {
        Console.WriteLine("The door opens and NOTHING is there.");
        Console.WriteLine("You turn off the light and run back to your room and lock the door.");
        Console.WriteLine("THE END.");
      }
      else {
        Console.WriteLine("You answered incorrectly. The door doesn't open.");
        Console.WriteLine("THE END.");
      }
    }
    // If user's choice is OPEN
    else if (doorLoudChoice == "OPEN") {
      Console.WriteLine("The door is locked! See if one of your three keys will open it");

      Console.Write("Enter a number (1-3): ");
      string keyChoice = Console.ReadLine();
      string keyUpperChoice = keyChoice.ToUpper();

      // Branches for 1, 2, or 3 key
      switch (keyUpperChoice) {

        case "1":
          Console.WriteLine("You choose the first key. Lucky choice!");
          Console.WriteLine("The door opens and NOTHING is there. Strange...");
          Console.WriteLine("THE END.");
          break;

       case "2":
        Console.WriteLine("You choose the second key. The door doesn't open.");
        Console.WriteLine("THE END.");
        break;

      case "3":
        Console.WriteLine("You choose the third key. The door doesn't open.");
        Console.WriteLine("THE END.");
        break;
      }
    }

    }
  }
}
