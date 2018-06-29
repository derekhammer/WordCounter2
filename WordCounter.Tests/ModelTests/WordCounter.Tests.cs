using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounter;
using System;

namespace WordChecker.TestTools
{
  [TestClass]
  public class WordCheckerTest
  {

    [TestMethod]
    public void SetWord_SetWord_String()
    {
      //Arrange
      string word = "pizza";
      Item newItem = new Item(word);

      //Act
      newItem.SetWord("pizza");
      string result = newItem.GetWord();

      //Assert
      Assert.AreEqual(word, result);
    }
  }
}
