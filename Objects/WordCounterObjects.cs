using System;
using System.Collections.Generic;


namespace WordCounter.Objects
{
  public class UserWords
  {
    private string _inputWord;
    private string _inputSentence;

    public UserWords(string inputWord, string inputSentence)
    {
      _inputWord = inputWord;
      _inputSentence = inputSentence;
    }
    public string GetInputWord()
    {
      return _inputWord;
    }
    public void SetInputWord(string inputWord)
    {
      _inputWord = inputWord;
    }
    public string GetInputSentence()
    {
      return _inputSentence;
    }
    public void SetInputSentence(string inputSentence)
    {
      _inputSentence = inputSentence;
    }
    public int CountRepeats()
    {
      int count = 0;
      string sentenceComparing = this._inputSentence;
      string[] sentenceArray = sentenceComparing.Split(' ');
      for(int i = 0; i<sentenceArray.Length; i++)
      {
        if(sentenceArray[i]==this._inputWord)
        {
          count = count +1;
        }
      }
      return count;
    }

  }
}
