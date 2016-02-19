using Nancy;
using NumToWordNS.Objects;
using System.Collections.Generic;
namespace NumToWordNS
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml", ""];
      };
      Post["/"] = _ => {
        return View["index.cshtml", new NumToWord(long.Parse(Request.Form["num"])).ChangeToWord()];
      };
    }
  }
}
