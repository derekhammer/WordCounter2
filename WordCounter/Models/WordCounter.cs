using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class words
    {
      private string _userWord;
      private string _userParagraph;
      private int _score;
      //private static int _wordCount;

      //Sets the word
      public void SetWord (string UserWord)
      {
        _userWord = UserWord;
      }
      //Gets the word
      public string GetWord ()
      {
        return _userWord;
      }
      public int GetScore()
      {
        return _score;
      }
      //Sets the paragraph
      public void SetParagraph (string UserParagraph)
      {
        _userParagraph = UserParagraph;
      }
      //Gets the paragraph
      public string GetParagraph ()
      {
        return _userParagraph;
      }
      //splits the user paragraph into an array of words
      // public string[] Split ()
      // {
      //   return _userParagraph.Split(' ');
      // }
      //compares the array paragraph against the input word
      public int Compare ()
      {
        string[] splitInput = _userParagraph.Split(' ');
        int wordCount =  0;
            foreach(string word in splitInput)
            {
                if(word == _userWord)
                {
                    wordCount++;
                }
            }
            _score = wordCount;
            return _score;
      }
    }
  // public class Program
  // {
  //   public static void Main()
  //   {
  //     Console.WriteLine("Type in a word you want to check for.");
  //     string typedWord = Console.ReadLine();
  //     Console.WriteLine("Type in a paragraph that we can check for that word.");
  //     string typedParagraph = Console.ReadLine();
  //     words newWords = new words();
  //     newWords.SetWord(typedWord);
  //     newWords.SetParagraph(typedParagraph);
  //     string testWord = newWords.GetWord();
  //     string[] testPara = newWords.Split();
  //     int result = newWords.Compare(testWord, testPara);
  //     Console.WriteLine("Your word appears " + result + " time(s).");
  //   }
  // }
}
