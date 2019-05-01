using System;
using System.Threading.Tasks;
using BullSheepFood.HttpClients;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace BullSheepFood.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly FoodClient _foodClient;

        public FoodController(FoodClient foodClient, IConfiguration configuration)
        {
            _foodClient = foodClient;
            _foodClient.ApplicationId = configuration["FoodDatabaseAPI:ApplicationId"];
            _foodClient.ApplicationKey = configuration["FoodDatabaseAPI:ApplicationKey"];
        }

        [HttpGet("{ingredientName}")]
        public async Task<ActionResult> Get(string ingredientName)
        {
            try
            {
                var result = await _foodClient.Get(ingredientName);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}