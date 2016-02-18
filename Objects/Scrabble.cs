using System;
using System.Collections.Generic;

namespace ScrabbleScore
{
  public class Scrabble
  {
    public int Score(string word)
    {
      int score = 0;
      char[] onePoint = {'a', 'e', 'i', 'o', 'u', 'l', 'n', 'r', 's', 't'};
      char[] twoPoint = {'d', 'g'};
      char[] threePoint = {'b', 'c', 'm', 'p'};
      char[] fourPoint = {'f', 'h', 'v', 'w', 'y'};
      char[] fivePoint = {'k'};
      char[] eightPoint = {'j', 'x'};
      char[] tenPoint = {'q', 'z'};
      char[] wordArray = word.ToLower().ToCharArray();
      foreach(char i in wordArray)
      {
        foreach (char x in onePoint)
        {
          if(i == x)
          {
            score += 1;
          }
        }
      }
      return score;
    }
  }
}
