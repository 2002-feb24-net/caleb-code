using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcProjectStarter.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /<controller>/
        //IActionResult is what methods return a view
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome(string name = "Bob", int numTimes = 1)
        {
            //html encoder is added to help keep things safe
            //return HtmlEncoder.Default.Encode($"Hello {name}, ID is: {ID}");

            //when put in [] after ViewData, the item in quotes becomes a variable
            ViewData["Message"] = "Hello" + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
