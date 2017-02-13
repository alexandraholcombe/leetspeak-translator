using Nancy;
using Leetspeak.Objects;
using System.Collections.Generic;

namespace Leetspeak
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      
    }
  }
}
