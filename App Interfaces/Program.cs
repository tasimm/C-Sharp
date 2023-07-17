// Program that simulates basic to do list and password managing applications

using System;

namespace SavingInterface
{
  class Program
  {
    static void Main(string[] args)
    {
      // Creating and adding items to our To do list
      TodoList tdl = new TodoList();
      tdl.Add("Grocery shopping");
      tdl.Add("Do dishes");
      tdl.Add("Take out trash");
      tdl.Add("Mop the floors");

      // Creating the password
      PasswordManager pm = new PasswordManager("iluvpie", true);   

      // Calling to do list and password to display on the screen
      tdl.Display();
      pm.Display();   

      // tdl.Reset(); and pm.Reset(); can be called to reset values
      
    }
  }
}
