using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagrammer;
using System.Collections.Generic;

namespace Anagrammer.Tests
{
  [TestClass]
  public class AnagramTest
  {
    [TestMethod]
    public void IsAnagram_TargetWordDifferent_False()
    {
      Anagram testAnagram = new Anagram();
      List<string> words = new List<string> {"bagel"};
      List<bool> testList = new List<bool> {false};
      CollectionAssert.AreEqual(testList, testAnagram.CheckAnagram ("bread", words));
    }
    [TestMethod]
    public void IsAnagram_TargetWordAnagram_True()
    {
      Anagram testAnagram = new Anagram();
      List<string> words = new List<string> {"beard"};
      List<bool> testList = new List<bool> {true};
      CollectionAssert.AreEqual(testList, testAnagram.CheckAnagram ("bread", words));
    }
    [TestMethod]
    public void IsAnagram_TargetMultipleWords_FalseTrue()
    {
      Anagram testAnagram = new Anagram();
      List<string> words = new List<string> {"bagel", "beard"};
      List<bool> testList = new List<bool> {false, true};
      CollectionAssert.AreEqual(testList, testAnagram.CheckAnagram ("bread", words));
    }
  }
}
