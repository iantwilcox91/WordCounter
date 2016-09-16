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
    public void SetInputWord(string inputSentence)
    {
      _inputSentence = inputSentence;
    }

}
}
