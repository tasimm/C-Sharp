/*
Welcome to SPACE: Space Program for Aeronautical Collection and Exploration. You are in charge of the Rover Control Center. All rovers on Moon and Mars are under your direction!

Displays utilization of references, inheritance, interfaces, and arrays
*/

using System;

namespace RoverControlCenter
{
  class Program
  {
    static void Main(string[] args)
    {
      // Two MoonRover objects, one MarsRover object, and one Satellite object
      MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
      MoonRover apollo = new MoonRover("Apollo 15", 1971);
      MarsRover sojourner = new MarsRover("Sojourner", 1997);
      Satellite sputnik = new Satellite("Sputnik", 1957); 

      /* Array of interface IDirectables - we use this type because MarsRover and Moonrover
      inherit inherit from Rover and Rover and Satellite inherit from IDirectable
      */
      IDirectable[] directables = {lunokhod, apollo, sojourner, sputnik};

      DirectAll(directables);
      
    }

    // Methods are overwritten depending on type of object called
    public static void DirectAll(IDirectable[] directables)
      {
        foreach (IDirectable d in directables)
        {
          Console.WriteLine(d.GetInfo());
          Console.WriteLine(d.Explore());
          Console.WriteLine(d.Collect());
        }
      }
  }
}
