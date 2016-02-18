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
    [Fact]
    public void Score_good_equals_6()
    {
      Scrabble newScrabble = new Scrabble();
      Assert.Equal(6, newScrabble.Score("good"));
    }
    [Fact]
    public void Score_Computer_equals_14()
    {
      Scrabble newScrabble = new Scrabble();
      Assert.Equal(14, newScrabble.Score("CoMputEr"));
    }
    [Fact]
    public void Score_Yellow_equals_12()
    {
      Scrabble newScrabble= new Scrabble();
      Assert.Equal(12, newScrabble.Score("YeLlOw"));
    }
  }
}
