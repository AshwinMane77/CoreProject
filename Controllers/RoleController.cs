using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProject1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoleController : ControllerBase
    {
        [HttpPost]
        [Route("RoleChange")]
        public  IActionResult SaveRoles()
        {

            return Ok();
        }

        [HttpGet]
        [Route("")]
        public string get()
        {
            return null;
        }
        [HttpGet]
        [Route("GetAllRoleUser")]
        public bool alluser()
        {
            bool value = false;

            value = 1 > 0 ? true : false;

            return value;
        }
    }
}
