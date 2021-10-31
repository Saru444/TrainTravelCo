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
        public int TripId { get; private set; }
        public List<Booking> booking;
        private static int _idCounter = 0;
        public Trip()
        {
            this.TripId = _idCounter++;
            booking = new List<Booking>();
        }


    }
}
