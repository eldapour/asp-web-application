using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeServiceController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            UserRepository user = new UserRepository();
            var data = user.AllUsers();
            return Ok(data);
        }
    }
}
