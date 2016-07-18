using Nancy;
using System.Collections.Generic;
using ClockAngleList.Objects;
namespace ClockAngleList
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>{
        return View["index.cshtml"];
      };
      Get["/result"] = _ => {
        Angle newAngle = new Angle(Request.Query["inputHour"], Request.Query["inputMinute"]);
        return View["result.cshtml", newAngle];
      };

    }
  }
}
