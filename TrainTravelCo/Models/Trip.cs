using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainTravelCo.Models
{
    public class Trip
    {
        public string Start { get; init; }
        public string Destination { get; init; }

        public string DepartureTime { get; init; }
        public int TrainId { get; init; }
        public int Id { get; init; }
        public Train train { get; init; }
        public List<Booking> bookings { get; init; }
        private static int _idCounter = 0;
        public Trip()
        {
            this.Id = _idCounter++;
            bookings = new List<Booking>();
        }


    }
}
