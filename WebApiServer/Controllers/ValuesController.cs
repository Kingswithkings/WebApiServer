using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public string[] Get() 
        {
            return new string[] { "Mangoe", "Bannana", "Pear", "Apple" };
        }
    }
}
