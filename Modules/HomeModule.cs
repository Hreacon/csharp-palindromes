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
        return View["header.cshtml"];
      };
    }
  }
}
