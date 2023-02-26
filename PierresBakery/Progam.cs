using System;
using PierresBakery.Models;

namespace UserInterface
{
  class Program
  {
    public static void Main()
    {
     Console.BackgroundColor = ConsoleColor.Red;
     Console.ForegroundColor = ConsoleColor.Green;
     Console.WriteLine("~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~"); 
     Console.WriteLine("Welcome to Pierre's Bakery");
     Console.WriteLine("We specialize in bread and pastries");
     Console.WriteLine("------------------------------------------");
     Console.WriteLine("Bread is $5 per loaf. Buy 2! Get 1 Free!"); 
     Console.WriteLine("Pastries are $2 each. Buy 3! Get 1 Free!");
     Console.WriteLine("-------------------------------------------");
     Console.WriteLine("How many loaves can we get you?");
     string stringBreadNumber = Console.ReadLine();
     Bread newBread = new Bread(stringBreadNumber);

     Console.WriteLine("How many pastires would you like?");
     string stringPastryNumber = Console.ReadLine();
     Pastry newPastry = new Pastry(stringPastryNumber);
     
     Console.WriteLine("-------------------------------------------");
     Console.WriteLine("Your total is $" + (newBread.BreadPrice()+newPastry.PastryPrice()));
     Console.WriteLine("-------------------------------------------");
     Console.WriteLine("Thank you for your business!");
     Console.WriteLine("Goodbye and come again!");
     Console.WriteLine("============================================");
    }
  }
}
    