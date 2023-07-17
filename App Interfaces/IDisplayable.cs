// Interface IDisplayable used in Display() method

using System;

namespace SavingInterface
{
  interface IDisplayable
  {

    public void Display();

    string HeaderSymbol { get; }
    
  }
}
