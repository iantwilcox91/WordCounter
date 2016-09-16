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

    [Fact]
    public void Test2_oneLetterButDifferent_0()
    {
      string newWordInput = "a";
      string newSentenceInput = "b";
      UserWords newUserWords = new UserWords(newWordInput, newSentenceInput);
      Assert.Equal(0 , newUserWords.CountRepeats() );
    }

    [Fact]
    public void Test3_oneLetterWithDoubbleString_2()
    {
      string newWordInput = "a";
      string newSentenceInput = "a a";
      UserWords newUserWords = new UserWords(newWordInput, newSentenceInput);
      Assert.Equal(2 , newUserWords.CountRepeats() );
    }

    [Fact]
    public void Test4_oneLetterWithDifferentDoubbleString_1()
    {
      string newWordInput = "a";
      string newSentenceInput = "a b";
      UserWords newUserWords = new UserWords(newWordInput, newSentenceInput);
      Assert.Equal(1 , newUserWords.CountRepeats() );
    }

    [Fact]
    public void Test5_SameWord_1()
    {
      string newWordInput = "apple";
      string newSentenceInput = "apple";
      UserWords newUserWords = new UserWords(newWordInput, newSentenceInput);
      Assert.Equal(1 , newUserWords.CountRepeats() );
    }

    [Fact]
    public void Test6_differentWords_0()
    {
      string newWordInput = "apple";
      string newSentenceInput = "banana";
      UserWords newUserWords = new UserWords(newWordInput, newSentenceInput);
      Assert.Equal(0 , newUserWords.CountRepeats() );
    }





  }
}
