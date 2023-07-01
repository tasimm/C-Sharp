/* 
Program that simulates a game called "Exquisite Corpse".
There are three different creature types: ghost, bug, and monster.
They each contain a head, a body, and feet. These body parts are separated into individual methods containing ASCII art depicting the body part.
The program contains a random generation method that assigns each body part type a number and randomly generates a creature.
 */
using System;

namespace ExquisiteCorpse
{
  class Program
  {
    static void Main(string[] args)
    {
      // Call the random generator method.
      RandomMode();
    }

      // Method that contains the random generator process.
      static void RandomMode() {
        Random randomNumber = new Random();

        // Assign head, body and feet a random number between 1 and 3.
        int head = randomNumber.Next(1, 4);
        int body = randomNumber.Next(1, 4);
        int feet = randomNumber.Next(1, 4);

        // Call the method to generate the creature.
        SwitchCase(head, body, feet);
      }

      // Method that contains switch statements that will output ASCII art based on which random number is generated for each body part.
      static void SwitchCase(int head, int body, int feet) {
        switch (head) {
          case 1:
            GhostHead();
            break;

          case 2:
            BugHead();
            break;

          case 3:
            MonsterHead();
            break;
        }

        switch (body) {
          case 1:
            GhostBody();
            break;

          case 2:
            BugBody();
            break;

          case 3:
            MonsterBody();
            break;
        }

        switch (feet) {
          case 1:
            GhostFeet();
            break;

          case 2:
            BugFeet();
            break;

          case 3:
            MonsterFeet();
            break;
        }
      }

    static void GhostHead()
    {
      Console.WriteLine("     ..-..");
      Console.WriteLine("    ( o o )");
      Console.WriteLine("    |  O  |");
    }

    static void GhostBody()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
    }

    static void GhostFeet()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    '~~~~~'");
    }

    static void BugHead()
    {
      Console.WriteLine("     /   \\");
      Console.WriteLine("     \\. ./");
      Console.WriteLine("    (o + o)");
    }

    static void BugBody()
    {
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
    }

    static void BugFeet()
    {
      Console.WriteLine("     v   v");
      Console.WriteLine("     *****");
    }

    static void MonsterHead()
    {
      Console.WriteLine("     _____");
      Console.WriteLine(" .-,;='';_),-.");
      Console.WriteLine("  \\_\\(),()/_/");
      Console.WriteLine("　  (,___,)");
    }

    static void MonsterBody()
    {
      Console.WriteLine("   ,-/`~`\\-,___");
      Console.WriteLine("  / /).:.('--._)");
      Console.WriteLine(" {_[ (_,_)");
    }

    static void MonsterFeet()
    {
      Console.WriteLine("    |  Y  |");
      Console.WriteLine("   /   |   \\");
      Console.WriteLine("   \"\"\"\" \"\"\"\"");
    }
  }
}
