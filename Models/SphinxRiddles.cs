using System;


namespace SphinxRiddle.Models{
  public class Sphinx
  {
    private static string[] myRiddles = { "What has to be broken before you can use it?", "I’m the rare case when today comes before yesterday. What am I?", "What goes all the way around the world but stays in a corner?" }; 

    private static string[] myAnswers = { "Egg", "Dictionary", "Stamp" };

    public static string GetRandomRiddle(int randNum){
      return myRiddles[randNum];
    }

    public static string CheckRiddleAnswer(int randNum, string response)
    {
      if (response == myAnswers[randNum]) {
        return "YOU WIN!";
      } else {
        return "You've been eaten by the Sphinx!";
      }
    }
  }
}



