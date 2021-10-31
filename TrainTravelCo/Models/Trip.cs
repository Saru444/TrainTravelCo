using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainTravelCo.Models
{
    public class Trip
    {
        public string Start { get; set; }
        public string Destination { get; set; }
        
        public string DepartureTime { get; set; }
        public int trainId { get; set; }
        public List<Booking> booking = new();



    }
}
