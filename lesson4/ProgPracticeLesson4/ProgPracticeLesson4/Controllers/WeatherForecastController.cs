using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Text.Json;

namespace ProgPracticeLesson4.Controllers {
    [ApiController]
    [Route("test")]
    public class WeatherForecastController: ControllerBase 
    {
        [HttpPost]
        [HttpGet]
        [Produces("application/json")]
        [Route("index")]

        public async Task<IActionResult> Index(){

            string json = JsonSerializer.Serialize(new { result = "Hello world!" });
            return this.Content(json);
        }
        [HttpPost]
        [HttpGet]
        [Produces("application/json")]
        [Route("hello_world")]
        public async Task<IActionResult> Test() 
        {
            MyClassResponse res = new MyClassResponse();
            res.Success = "success";
            res.Result = "Heelo_world";
            res.Version = "1.0";
            string json = JsonSerializer.Serialize(res);
        return this.Content( json );
        }
    }
}
