using System;
using System.Threading;

public class Program
{
  static void Main(string[] args)
  {
    Random rnd = new Random();
    int random = rnd.Next(0, 75);
    
    Console.WriteLine("Type text to be coolified below:\n(By the way, this can be used for any c# console application, pretty simple too)");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    
    string text = Console.ReadLine();   
    string[] cooltextArray = text.Split(' ');
    
    
    foreach (var x in cooltextArray) {
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.Write(x + " ");
      Thread.Sleep(random);
    }
  }
}
