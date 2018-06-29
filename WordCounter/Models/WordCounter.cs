using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class words
    {
      private string _userWord;
      private string _userParagraph;
      //private static int _wordCount;

      //Sets the word to be checked
      public void SetWord (string UserWord)
      {
        _userWord = UserWord;
      }
      //Gets the word to ge checked
      public string GetWord ()
      {
        return _userWord;
      }

      public void SetParagraph (string UserParagraph)
      {
        _userParagraph = UserParagraph;
      }
      //Gets the word to ge checked
      public string GetParagraph ()
      {
        return _userParagraph;
      }
      public string[] Split ()
      {
        return _userParagraph.Split(' ');
      }
    }

}
