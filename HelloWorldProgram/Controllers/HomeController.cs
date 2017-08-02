using System.Web.Mvc;
using HelloWorldProgram.Infrastructure;
using HelloWorldProgram.Models;

namespace HelloWorldProgram.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PrintHelloWorld()
        {
            HelloWorldRepository hw = new HelloWorldRepository();

            var hwModel = new HelloWorldModel()
            {
                HelloWorld = hw.CreateHelloWorld()
            };

            return PartialView("PrintHelloWorld", hwModel);
        }
    }
}