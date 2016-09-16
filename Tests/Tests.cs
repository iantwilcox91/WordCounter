using Xunit;
using WordCounter.Objects;
using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class Tests
  {
    [Fact]
    public void Test1_oneLetterAsBoth_1()
    {
      string newWordInput = "a";
      string newSentenceInput = "a";
      UserWords newUserWords = new UserWords(newWordInput, newSentenceInput);
      Assert.Equal(1 , newUserWords.CountRepeats() );
    }


  }
}
