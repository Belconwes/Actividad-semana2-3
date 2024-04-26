using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Xml.Linq;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/ Reemplazar el método index:

        public IActionResult Index()
        {
            return View();
        }

        //
        // GET: /HelloWorld/Welcome/ Agregar este método:

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = " The best Movie" + " " +  name;
            ViewData["NumTimes"] = numTimes;


            return View();
            
        }
    }
}
