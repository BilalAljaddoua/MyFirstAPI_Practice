using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/MyFirstAPI")]
    [ApiController]
    public class MyFirstAPIController : ControllerBase
    {

        [HttpGet("MyName",Name ="koko")]
        public string GetMyName()
        {
            return "My Name is bilal al jadoua";
        }
        [HttpGet("YourName",Name ="YourName")]
        public string GetYourName()
        {
            return "Your Name is Ali al jadoua";
        }
        [HttpGet("Sum /{Num1}/{Num2}")]
        public int Sum2Numbers(int Num1,int Num2)
        {
            return Num2 + Num1;    
        }
    }
}
