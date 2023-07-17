// Holds the information for creating the Password Manager application

using System;

namespace SavingInterface
{
  class PasswordManager : IDisplayable, IResetable
  {
    private string Password
    { get; set; }

    public bool Hidden
    { get; private set; }

    // Creates header space
    public string HeaderSymbol => "-----------";

    public PasswordManager(string password, bool hidden)
    {
        Password = password;
        Hidden = hidden;
    }

    public void Display()
    {

      Console.WriteLine("Password");
      Console.WriteLine(HeaderSymbol);
      
      if (Hidden == false)
      {
        Console.WriteLine(Password);
      }
      else
      {
        Console.WriteLine("*******");
      }
    }

    public void Reset()
    {
      Password = "";
      Hidden = false;
    }

  }
}
