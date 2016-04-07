using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodNow.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Suburb { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string Type_Restaurant { get; set; }
        public string Cousin { get; set; }
        public string Delivery { get; set; }
    }
}
