using System;
using System.Collections.Generic;

namespace Palindrome
{
  public class Word
  {
    // public string InputWord;
    public static bool IsPalindrome(string word)
    {
      if (word.Length >=3)
      {
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

    public static bool IsPalindromeNoMethod(string word)
    {
      char[] charArr = word.ToCharArray();
      List<char> reverseChar = new List<char>(0);
      for (int i = charArr.Length - 1; i >= 0; i--)
      {
        reverseChar.Add(charArr[i]);
      }
      string reverseWord = string.Join("", reverseChar); 

      return word == reverseWord;
    }

    public static bool IsPalindromeLooping(string word)
    {
      char[] charArr = word.ToCharArray();
      for (int i = 0; i < charArr.Length; i++) 
      {
        if (charArr[i] != charArr[(charArr.Length -1) - i])
        {
          return false;
        }
      }
      return true;
    }
  }
}