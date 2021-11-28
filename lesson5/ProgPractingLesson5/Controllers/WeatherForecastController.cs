using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Text.Json;
using ProgPractingLesson5.Requests;
using System;

namespace ProgPracticeLesson4.Controllers {
    [ApiController]
    [Route("test")]
    public class WeatherForecastController: ControllerBase {
        [HttpPost]
        [HttpGet]
        [Produces("application/json")]
        [Route("index")]

        public async Task<IActionResult> Index() 
        {
            string json = JsonSerializer.Serialize(new { result = "Hello world!" });
            return this.Content(json);
        }
  
        [HttpPost]
        [HttpGet]
        [Produces("application/json")]
        [Route("regular_pyramid_volume")]
        public async Task<IActionResult> VolumeOfPyramid() 
        {   
            WebApplicationRequest request = new WebApplicationRequest(this.Request);
            double pyramidSquare = (double)(1.0 / 3.0) * ( Math.Pow(request.sideOfBase, 2) * request.heightOfPyramid);

            MyClassResponse res = new MyClassResponse();
            res.Success = "success";
            res.Version = "1.0";
            res.Result = Math.Round(pyramidSquare, 3);
          
            return this.Content(JsonSerializer.Serialize(res));
        }
    }
}
