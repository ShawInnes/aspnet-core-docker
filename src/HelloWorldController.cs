using Microsoft.AspNetCore.Mvc;

namespace HelloUniverse
{
    [Route("api/[controller]")]
    public class HelloWorldController : Controller
    {
        // GET api/HelloWorld
        [HttpGet]
        public string Get()
        {
            return "Hello, world!";
        }

        [HttpGet]
        [Route("{name}")]
        public string GetAnother(string name)
        {
            Serilog.Log.Information("GetAnother {name}", name);

            return $"Hello, {name}!";
        }
    }
}
