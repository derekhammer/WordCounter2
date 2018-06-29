using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class words
    {
      private string _userWord;

      //Sets the word to be checked
      public void SetWord (string UserWord)
      {
        _userWord = UserWord;
      }
      //Gets the word to be checked
      public string GetWord ()
      {
        return _userWord;
      }
    }
}
