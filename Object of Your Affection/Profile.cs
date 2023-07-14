using System;

namespace DatingProfile
{ 
  class Profile
  {
    // Fields users can fill their information in
    private string name;
    private int age;
    private string city;
    private string country;
    private string pronouns;
    private string[] hobbies;

    // Constructor that will set city, country and pronouns to n/a if user does not enter info
    public Profile(string name, int age, string city = "n/a", string country = "n/a", string pronouns = "n/a")
    {
      this.name = name;
      this.age = age;
      this.city = city;
      this.country = country;
      this.pronouns = pronouns;
      // we set the hobbies string to 0 in case user does not enter any hobbies
      this.hobbies = new string[0]; 
    }

    // Method to print out the user's profile
    public string ViewProfile()
    {
      string bio = $"Name: {name}\nAge: {age}\nCity: {city}\nCountry: {country}\nPronouns: {pronouns}";
      // Loop will only run if any hobbies have been added by the user
      if (this.hobbies.Length > 0) 
      {
        bio += "\nHobbies:\n";
        // Adds each hobby to the bio string
        foreach (string hobby in hobbies)
        {
          bio += $"- {hobby}\n";
        }
      }
      return bio;
    }

    // Allows user to set their hobbies
    public void SetHobbies(string[] hobbies)
    {
      this.hobbies = hobbies;
    }
  }
}
