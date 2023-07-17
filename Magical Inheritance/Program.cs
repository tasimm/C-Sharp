/* 
WIZARD CHARACTER MAKER
Program allows you to create a wizard of rank Pupil, Mage or Archmage
Wizards have names and places of origin
Pupil wizards can create weak wind storms
Mages can create weak wind storms and weak rain storms
Archmages can create weak wind storms, strong rain storms, and strong lightning storms
*/

using System;

namespace MagicalInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create an array and index to store our wizard profiles
      Storm[] storms = new Storm[10];
      int stormsIndex = 0;

      // Pupil object
      Pupil p = new Pupil("Mezil-Kree", "Icecrown");
      storms[stormsIndex] = p.CastWindStorm();
      stormsIndex++; // increment index so as not to overwrite array

      // Mage object
      Mage m = new Mage("Gul'dan", "Draenor");
      storms[stormsIndex] = m.CastRainStorm();
      stormsIndex++;

      // Archmage object, able to cast all three storms
      Archmage a = new Archmage("Nielas Aran", "Stormwind");
      storms[stormsIndex] = a.CastWindStorm();
      stormsIndex++;
      storms[stormsIndex] = a.CastRainStorm();
      stormsIndex++;
      storms[stormsIndex] = a.CastLightningStorm();
      stormsIndex++;

      // Iterate through the array of wizard profiles and output them
      for (int i = 0; i < stormsIndex; i++)
      {
        Console.WriteLine(storms[i].Announce());
      }
    }
  }
}
