using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class Item
    {
      private string _word;
      private static List<Item> _instances = new List<Item> {};

      public Item(string word)
      {
        _word = word;
      }
      public string GetWord()
      {
        return _word;
      }
      public void SetWord(string newWord)
      {
        _word = newWord;
      }

    }
}
