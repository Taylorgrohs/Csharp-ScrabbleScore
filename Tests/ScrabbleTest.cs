using Xunit;
using System.Collections.Generic;
using System;
namespace ScrabbleScore
{
  public class ScrabbleScoreTest
  {
    [Fact]
    public void Score_A_Equals_1()
    {
      Scrabble newScrabble = new Scrabble();
      Assert.Equal(1, newScrabble.Score("a"));
    }
    [Fact]
    public void Score_At_equals_2()
    {
      Scrabble newScrabble = new Scrabble();
      Assert.Equal(2, newScrabble.Score("AT"));
    }
  }
}
