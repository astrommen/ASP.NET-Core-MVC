using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// "/[Controller]/[ActionName]/[Parameters]"
// routing format is set in Configure method in Startup.cs file

namespace MvcMovie.Controllers
{
  public class HelloWorldController : Controller
  {
    //
    // GET: /HelloWorld/

    public IActionResult Index()
    {
      // method uses view template to render
      // when view file name is specified, default view is returned
      // default view has same name as action method Index() -> Index.cshtml
      return View();
    }

    //
    // GET : /HelloWorld/Welcome
    public IActionResult Welcome(string name, int numTimes = 1)
    {
      // /Welcome/3?name=John -> Hello John, ID: 3
      // "?" is id param is optional;
      ViewData["Message"] = "Hello" + name;
      ViewData["NumTimes"] = numTimes;

      return View();
    }
  }
}