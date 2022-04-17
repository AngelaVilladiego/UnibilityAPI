using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Model.Helpers;
using Microsoft.AspNetCore.Mvc;
using API.Model.Entities;
using MongoDB.Bson;
using MongoDB.Driver;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReportsController : ControllerBase
    {
        private MongoDBHelper _mongoDBHelper;

        public ReportsController(MongoDBHelper helper)
        {
            _mongoDBHelper = helper;
        }


        [HttpPost("addreport")]
        public async Task<IActionResult> Add(ReportEntity item)
        {
            MongoDBHelper.AddReport(item);
            return Ok();
        } 
    }
}