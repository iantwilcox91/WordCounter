using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Nancy;
using WordCounter.Objects;

namespace WordCounter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        return View["index.cshtml"];
      };

      Post["/result"] = _ =>
      {
        UserWords newUserWords = new UserWords(Request.Form["InputWordForm"], Request.Form["InputSentenceForm"] );
        newUserWords.SetUserScore();
        return View["result.cshtml" , newUserWords];
      };

    }
  }
}
