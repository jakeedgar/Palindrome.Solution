using System;

namespace Palindrome
{
  public class Word
  {
    // public string InputWord;
    public static bool IsPalindrome(string word)
    {
      if (word.Length >=3)
      {
        // char[] checkArr = word.ToCharArray();
        char[] charArr = word.ToCharArray();
        Array.Reverse(charArr);
        string revString = new string(charArr);
        return word == revString;
      }
      else
      {
        return false;
      }
      
    }
  }
}