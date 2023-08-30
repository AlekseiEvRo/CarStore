using CarStore.AppContext;
using CarStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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
        CarContext db = new CarContext();

        // GET: api/Cars
        [HttpGet]
        public IEnumerable<Car> Get()
        {
            return db.Cars;
        }

        // GET api/Cars/5
        [HttpGet("{id}")]
        public Car Get(int id)
        {
            return db.Cars.Find(id);
        }

        // POST api/Cars
        [HttpPost]
        public void AddCar([FromBody] Car car)
        {
            db.Cars.Add(car);
            db.SaveChanges();
        }

        // PUT api/Cars
        [HttpPut("{id}")]
        public void EditCar(int id, [FromBody] Car car)
        {
            if (id == car.Id)
            {
                db.Entry(car).State = EntityState.Modified;

                db.SaveChanges();
            }
        }

        // DELETE api/Cars/5
        [HttpDelete("{id}")]
        public void DeleteCar(int id)
        {
            Car car = db.Cars.Find(id);
            if (car != null)
            {
                db.Cars.Remove(car);
                db.SaveChanges();
            }
        }
    }
}
