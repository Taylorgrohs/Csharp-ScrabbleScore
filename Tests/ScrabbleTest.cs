using Xunit;
using System.Collections.Generic;
using System;
namespace ScrabbleScore
{
  public class ScrabbleScore
  {
    [Fact]
    public void Score_A_Equals_1()
    {
      Scrabble newScrabble = new Scrabble();
      Assert.Equal(1, newScrabble.Score("a"));
    }
  }
}
