using System;
using System.Collections.Generic;
using SphinxRiddle.Models;


namespace SphinxRiddle {
  class Program
  {
    static void Main()
    {
      Random rnd =  new Random();
      int randNum = rnd.Next(0, 2);
      Console.WriteLine( Sphinx.GetRandomRiddle(randNum) );
      string response = Console.ReadLine();
      Console.WriteLine( Sphinx.CheckRiddleAnswer(randNum, response) );
    }
  }
}