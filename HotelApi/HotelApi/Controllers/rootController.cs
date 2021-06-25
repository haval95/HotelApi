using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApi.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class rootController: ControllerBase
    {
        [HttpGet(Name = nameof(Get))]
       public IActionResult Get()
        {
            var respone = new
            {

                href = Url.Link(nameof(Get), null)
            };
            return (Ok(respone));
        }
    }
}
