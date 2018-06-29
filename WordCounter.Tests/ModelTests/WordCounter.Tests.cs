using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounter;
using System;

namespace WordChecker.TestTools
{
  [TestClass]
  public class WordCounterTest
  {
    [TestMethod]
    public void UserWord_GetWord_True()
    {
      //Arrange
      string newWord = "pizza";
      words newWords = new words();
      //Act
      newWords.SetWord(newWord);
      string result = newWords.GetWord();
      //Assert
      Assert.AreEqual(result, newWord);
    }
  }
}
