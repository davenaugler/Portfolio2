using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio1
{
    public class HomeController : Controller
    {
        // Requests
        // localhost:5000/
        // [Route("")]
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }
      

        [HttpGet("projects")]
        public ViewResult Projects()
        {
            // localhost:5000/projects
            return View();
        }

        [HttpGet("contact")]
        public ViewResult Contact()
        {
            return View();
        }

        [HttpGet("hello")]
        public RedirectToActionResult Hello()
        {
            // localhot:500
            System.Console.WriteLine("Redirecting...");
            // Dictionary<string,string> params = new Dictionary<string,string>();

            return RedirectToAction("Hello there", new{username="Dave", location="Boise"});
        }

        // [HttpGet("helloview")]
        // public IActionResult Index()
        // {
        //     ViewBag.Example = "Hello Universe!";
        //     return View();
        // }




    }
}