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

    public string Index()
    {
      return "This is my default action...";
    }

    //
    // GET : /HelloWorld/Welcome

    public string Welcome(string name, int numTimes = 1)
    {
      // return "This is the Welcome action method...";
      return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
    }
  }
}