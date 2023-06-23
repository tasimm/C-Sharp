// Program that converts a total coin amount into bronze, silver and gold coins
// Bronze = 1, Silver = 5, Gold = 10

using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      
      // Take input as a string
      Console.WriteLine("Enter an amount to convert to coins: ");
      string totalAsString = Console.ReadLine();

      // Convert it to a double
      double totalAsDouble = Convert.ToDouble(totalAsString);

      // Output the original amount for the user
      Console.WriteLine($"{totalAsString} cents is equal to...");

      // Value of the gold and silver coin 
      int gold = 10;
      int silver = 5;

      // Calculating the amount of gold coins that will fit evenly into the original amount
      // and find the remainder
      double goldCoins = Math.Floor(totalAsDouble / gold);
      double remainder = totalAsDouble % gold;

      // Calculating the amount of silver coins that will fit evenly into the original amount
      // and taking the original remainder to determine how many silver coins we need
      // on top of the existing gold coins
      double silverCoins = Math.Floor(remainder / silver);
      remainder = remainder % silver;

      Console.WriteLine($"Gold Coins: {goldCoins}");
      Console.WriteLine($"Silver Coins: {silverCoins}");
      Console.WriteLine($"Bronze Coins: {remainder}");    // Remainder doubles as bronze coin
    }
  }
}
