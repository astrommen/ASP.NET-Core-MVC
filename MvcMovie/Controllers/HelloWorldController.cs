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

    // model binding ex
    // public string Welcome(string name, int numTimes = 1)
    public string Welcome(string name, int ID=1)
    {
      // return "This is the Welcome action method...";

      // /Welcome?name=John&numTimes=52 -> Hello John, NumTimes is: 52
      // "?" is a separator with query string following
      // "&" separates field-value pairs
      // return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");

      // /Welcome/3?name=John -> Hello John, ID: 3
      // "?" is id param is optiona;
      return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
    }
  }
}