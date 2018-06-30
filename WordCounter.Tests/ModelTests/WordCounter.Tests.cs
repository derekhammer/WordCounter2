using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounter;
using System;

namespace WordChecker.TestTools
{
  [TestClass]
  public class WordCounterTest
  {
    //Tests if I can input a word
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
    //Tests if I can input a paragraph.  Essentially the same as the test above
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
    //Tests if I can split my input paragraph into an array of words!
    [TestMethod]
    public void UserParagraph_SplitParagraph_True()
    {
      //Arrange
      string newParagraph = "oh boy, i sure love pizza";
      string[] array = {"oh", "boy,", "i", "sure", "love", "pizza"};
      words newWords = new words();
      //Act
      newWords.SetParagraph(newParagraph);
      newWords.GetParagraph();
      string[] result = newWords.Split();
      //Assert
      CollectionAssert.AreEqual(array, result);
      Console.WriteLine(result);
    }
    //Compares the input word against the input paragraph and spits out a value
    [TestMethod]
    public void UserParagraph_Compare_True()
    {
      //Arrange
      string newWord = "pizza";
      string newParagraph = "oh boy, i sure love pizza";
      words newWords = new words();
      //Act
      newWords.SetWord(newWord);
      newWords.SetParagraph(newParagraph);
      string testWord = newWords.GetWord();
      string[] testPara = newWords.Split();
      int result = newWords.Compare(testWord, testPara);
      //Assert
      Assert.AreEqual(result, 1);
    }


  }
}
