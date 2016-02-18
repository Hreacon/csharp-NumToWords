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
        return View["header.cshtml"];
      };
    }
  }
}
