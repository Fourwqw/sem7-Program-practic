using Microsoft.AspNetCore.Http;
using System;
using System.Linq;
namespace ProgPractingLesson5.Requests 
{
    public class WebApplicationRequest 
    {
        public double sideOfBase { get; set; } = 0.0;
        public double heightOfPyramid { get; set; } = 0.0;
        public WebApplicationRequest(HttpRequest request) 
        {
            var form = request.Form.ToList();
            foreach( var param in form) 
            {
                switch( param.Key.ToLower() ) 
                {
                    case "a":
                        this.sideOfBase = Convert.ToDouble(param.Value.ToArray()[0].ToString());
                        break;
                    case "h":
                        this.heightOfPyramid = Convert.ToDouble(param.Value.ToArray()[0].ToString());
                        break;
                    default:
                        break;
        }
            }
        }
    }
}
