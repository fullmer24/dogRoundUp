using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dogRoundUp.Models;
using dogRoundUp.Services;
using Microsoft.AspNetCore.Mvc;

namespace dogRoundUp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DogsController : ControllerBase
    {
        private readonly DogsService _dogsService;
        public DogsController(DogsService dogsService)
        {
            _dogsService = dogsService;
        }

        [HttpGet]
        public ActionResult<List<Dog>> GetDogs()
        {
            try
            {
                List<Dog> dogs = _dogsService.GetDogs();
                return Ok(dogs);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

    }
}