using Nancy;
using System;
using ScrabbleScore;

namespace TheRocksScrabbleScore
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        return View["index.cshtml"];
      };
      Post["/"] = _ =>
      {
        Scrabble newScrabble = new Scrabble();
        int score = newScrabble.Score(Request.Form["input"]);
        return View["index.cshtml", score];
      };
    }
  }
}
