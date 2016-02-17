using System.Collections.Generic;
using System;
namespace PalindromesNS.Objects
{
  public class Palindromes
  {
    public Palindromes()
    {
    }
    public static bool Do(string userInput)
    {
      bool output = false;
      char[] tester = userInput.ToCharArray();
      for(int i = 0; i< tester.Length-1; i++)
      {
        // racecar - length = 7
        if(tester[i] == tester[tester.Length-1-i])
        {
          // tester[0] == tester[7-1-0] r,r
          // tester[1] == tester[7-1-1] a,a
          // cat
          // tester[0] c == tester[3-1-0] t -false
          // tester[1] a == tester[3-1-1] a - true
          output = true;
        }
        else
        {
          output = false;
          break;
        }
      }
      return output;
      // Array.Reverse(tester);
      // string palidrome = string.Join("", tester);
      // return userInput == palidrome;
    }
  } // end class
} // end namespace
