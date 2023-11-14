using Group7Final.Data;
using Group7Final.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Group7Final.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoiveAPIController : ControllerBase
    {
        
        FinalContext ctx;
        public MovieController(FinalContext context)
        {
            ctx = context;
        }
       
        [HttpGet]

        [HttpGet("id")]

        [HttpPost]

        [HttpPut]

        [HttpDelete]

    
}
}
