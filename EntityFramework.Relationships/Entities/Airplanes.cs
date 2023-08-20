using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Relationships.Entities
{
    public class Airplanes
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Kind { get; set; }
        public int Capacity { get; set; }
        public string Country { get; set; }
        //
        public ICollection<Flights> Flights { get; set; }
    }
}
