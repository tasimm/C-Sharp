// Dating profile program that allows user to set their name, age, city, country, pronouns, and hobbies

using System;

namespace DatingProfile
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create an example profile named Sam
      Profile sam = new Profile("Sam Drakkila", 30, "New York", "USA", "he/him");

      // Using method SetHobbies to add hobbies to the profile
      sam.SetHobbies(new string[] {"listening to audiobooks and podcasts", "playing rec sports like bowling and kickball", "writing a speculative fiction novel", "reading advice columns"});

      Console.WriteLine(sam.ViewProfile());
    }
  }
}
