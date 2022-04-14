using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Model.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LocationController : ControllerBase
    {
        private MongoDBHelper _mongoDBHelper;

        public LocationController(MongoDBHelper helper)
        {
            _mongoDBHelper = helper;
        }

        [HttpGet("getLocationData")]
        public async Task<IActionResult> Get()
        {
            await MongoDBHelper.GetLocationInformation();
            return Ok("Working");
        }
    }
}