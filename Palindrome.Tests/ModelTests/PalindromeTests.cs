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

    [TestMethod]
    public void IsPalindrome_SameNumberWhenReversed_True()
    {
      Word testWord = new Word();
      Assert.AreEqual(true, Word.IsPalindrome("121"));
    }

    [TestMethod]
    public void IsPalindromeNoMethod_SameNumberWhenReversed_True()
    {
      Word testWord = new Word();
      Assert.AreEqual(true, Word.IsPalindromeNoMethod("racecar"));
    }
    [TestMethod]
    public void IsPalindromeNoMethod_SameNumberWhenReversed_False()
    {
      Word testWord = new Word();
      Assert.AreEqual(false, Word.IsPalindromeNoMethod("racecars"));
    }

    [TestMethod]
    public void IsPalindromeLooping_SameNumberWhenReversed_True()
    {
      Word testWord = new Word();
      Assert.AreEqual(true, Word.IsPalindromeLooping("racecar"));
    }
    [TestMethod]
    public void IsPalindromeLooping_SameNumberWhenReversed_False()
    {
      Word testWord = new Word();
      Assert.AreEqual(false, Word.IsPalindromeLooping("racecars"));
    }
    [TestMethod]
    public void IsPalindromeLooping_WithSpace_True()
    {
      Word testWord = new Word();
      Assert.AreEqual(true, Word.IsPalindromeLooping("rac e car"));
    }
  }
}