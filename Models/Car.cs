using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarStore.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
    }
}
