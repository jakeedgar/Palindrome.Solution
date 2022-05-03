using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace Palindrome.Tests 
{
  [TestClass]
  public class WordTests
  {
    [TestMethod]  
    public void IsPalindrome_LengthIsAtLeastThree_True()
    {
      Word testWord = new Word();
      Assert.AreEqual(true, Word.IsPalindrome("asa"));
    }

    [TestMethod]
    public void IsPalindrome_LengthIsAtLeastThree_False()
    {
      Word testWord = new Word();
      Assert.AreEqual(false, Word.IsPalindrome("to"));
    }

    [TestMethod]
    public void IsPalindrome_SameWhenReversed_True()
    {
      Word testWord = new Word();
      Assert.AreEqual(true, Word.IsPalindrome("racecar"));
    }
    
    [TestMethod]
    public void IsPalindrome_SameWhenReversed_False()
    {
      Word testWord = new Word();
      Assert.AreEqual(false, Word.IsPalindrome("capricorn"));
    }
  }
}