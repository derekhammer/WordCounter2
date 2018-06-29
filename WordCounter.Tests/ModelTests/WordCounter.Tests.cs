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

    [TestMethod]
    public void UserParagraph_GetParagraph_True()
    {
      //Arrange
      string newParagraph = "oh boy, i sure love pizza";
      words newWords = new words();
      //Act
      newWords.SetParagraph(newParagraph);
      string result = newWords.GetParagraph();
      //Assert
      Assert.AreEqual(result, newParagraph);
      Console.WriteLine(result);
    }
    [TestMethod]
    public void UserParagraph_SplitParagraph_True()
    {
      string newParagraph = "oh boy, i sure love pizza";
      string[] array = {"oh", "boy,", "i", "sure", "love", "pizza"};
      words newWords = new words();

      newWords.SetParagraph(newParagraph);
      newWords.GetParagraph();
      string[] result = newWords.Split();

      CollectionAssert.AreEqual(array, result);
      Console.WriteLine(result);
    }



  }
}
