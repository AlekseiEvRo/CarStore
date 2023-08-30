using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        // GET: api/Cars
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Car1", "Car2" };
        }

        // GET api/Cars/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"Car id = {id}";
        }

        // POST api/Cars
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/Cars
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/Cars/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            
        }
    }
}
