// Holds the information for creating the To Do List application

using System;

namespace SavingInterface
{
  class TodoList : IDisplayable, IResetable 
  {
    // Creates header space
    public string HeaderSymbol => "-----------";

    public string[] Todos
    { get; private set; }

    private int nextOpenIndex;

    public TodoList()
    {
      Todos = new string[5];
      nextOpenIndex = 0;
    }

    public void Add(string todo)
    {
      if (nextOpenIndex < 5) // will not add more than 5 items
      {
      Todos[nextOpenIndex] = todo;
      nextOpenIndex++;
      }
    }

    public void Display()
    {
      Console.WriteLine("Todos");
      Console.WriteLine(HeaderSymbol);
      
      foreach (string Todo in Todos)
      {
        Console.WriteLine(Todo);
      }
    }

    public void Reset()
    {
      Todos = new string[5];
      nextOpenIndex = 0;
    }
  }
}
