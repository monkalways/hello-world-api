using Microsoft.AspNetCore.Mvc;
using System;

namespace hello_world_api.Controllers
{
    [ApiController]
    public class Option1Controller : ControllerBase
    {
        [HttpGet("/random-number")]
        public int GenerateRandomNumber(int from, int to)
        {
            return (new Random()).Next(from, to + 1);
        }
    }
}
