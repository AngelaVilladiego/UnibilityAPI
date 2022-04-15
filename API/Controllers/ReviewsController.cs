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
    public class ReviewsController : ControllerBase
    {
        private MongoDBHelper _mongoDBHelper;

        public ReviewsController(MongoDBHelper helper)
        {
            _mongoDBHelper = helper;
        }


        [HttpPost("addreview")]
        public async Task<IActionResult> Add(ReviewEntity item)
        {
            MongoDBHelper.AddReview(item);
            return Ok();
        } 
    }
}