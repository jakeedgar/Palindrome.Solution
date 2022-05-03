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
        string noSpaceWord = word.Replace(" ", "");
        char[] charArr = noSpaceWord.ToCharArray();
        Array.Reverse(charArr);
        string revString = new string(charArr);
        return noSpaceWord == revString;
      }
      else
      {
        return false;
      }
    }

    public static bool IsPalindromeNoMethod(string word)
    {
      string noSpaceWord = word.Replace(" ", "");
      char[] charArr = noSpaceWord.ToCharArray();
      List<char> reverseChar = new List<char>(0);
      for (int i = charArr.Length - 1; i >= 0; i--)
      {
        reverseChar.Add(charArr[i]);
      }
      string reverseWord = string.Join("", reverseChar); 

      return noSpaceWord == reverseWord;
    }

    public static bool IsPalindromeLooping(string word)
    {
      string noSpaceWord = word.Replace(" ", "");
      char[] charArr = noSpaceWord.ToCharArray();
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