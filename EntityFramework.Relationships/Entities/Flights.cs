using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Relationships.Entities
{
    public class Flights
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int AirplanesId { get; set; }
        public int ClientsId { get; set; }
        public string DateOfDeparture { get; set; }
        public string DateOfArrival { get; set; }
        public string PlaceDeparture { get; set; }
        public string PlaceArrivale { get; set; }

        //
        public Airplanes Airplanes { get; set; }
        public Clients Clients { get; set; }
    }
}
