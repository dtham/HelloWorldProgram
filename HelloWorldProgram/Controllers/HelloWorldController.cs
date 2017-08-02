using System.Web.Http;

namespace HelloWorldProgram.Controllers
{
    public class HelloWorldController : ApiController
    {
        public string Get()
        {
            return "Hello World";
        }
    }
}
