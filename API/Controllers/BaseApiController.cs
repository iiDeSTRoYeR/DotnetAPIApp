using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]    // Client specifies path as api/UsersController
    public class BaseApiController : ControllerBase
    {
        
    }
}