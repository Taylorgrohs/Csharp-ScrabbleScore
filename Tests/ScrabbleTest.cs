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
      Assert.Equal("a is 1 points", newScrabble.Score("a"));
    }
    [Fact]
    public void Score_At_equals_2()
    {
      Scrabble newScrabble = new Scrabble();
      Assert.Equal("AT is 2 points", newScrabble.Score("AT"));
    }
    [Fact]
    public void Score_good_equals_6()
    {
      Scrabble newScrabble = new Scrabble();
      Assert.Equal("good is 6 points", newScrabble.Score("good"));
    }
    [Fact]
    public void Score_Computer_equals_14()
    {
      Scrabble newScrabble = new Scrabble();
      Assert.Equal("CoMputEr is 14 points", newScrabble.Score("CoMputEr"));
    }
    [Fact]
    public void Score_Yellow_equals_12()
    {
      Scrabble newScrabble= new Scrabble();
      Assert.Equal("YeLlOw is 12 points", newScrabble.Score("YeLlOw"));
    }
    [Fact]
    public void Score_HaCk_equals_13()
    {
      Scrabble newScrabble= new Scrabble();
      Assert.Equal("hAcK is 13 points", newScrabble.Score("hAcK"));
    }
    [Fact]
    public void Score_JINX_equals_18()
    {
      Scrabble newScrabble= new Scrabble();
      Assert.Equal("jinx is 18 points", newScrabble.Score("jinx"));
    }
    [Fact]
    public void Score_quiz_equals_22()
    {
      Scrabble newScrabble= new Scrabble();
      Assert.Equal("quiz is 22 points", newScrabble.Score("quiz"));
    }
  }
}
