using Nancy;
using PalindromesNS.Objects;
using System.Collections.Generic;
namespace PalindromesNS
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["play.cshtml"];
      };
      Post["/result"] = _ => {
        string palindrome = Request.Form["palindrome"];
        string output = palindrome + " is not a palindrome";
        if(Palindromes.Do(palindrome)) output = palindrome + " is a palindrome";
        return View["result.cshtml", output ];
      };
    }
  }
}
