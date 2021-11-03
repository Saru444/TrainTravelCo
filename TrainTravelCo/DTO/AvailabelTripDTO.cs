using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainTravelCo.Models;
using TrainTravelCo.Controllers;

namespace TrainTravelCo.DTO
{
    public class AvailabelTripDTO
    {
        public string Start { get; init; }
        public string Destination { get; init; }

        public string DepartureTime { get; init; }
        public int TrainId { get; init; }
        public int TripId { get; init; }
        public Train train { get; init; }
    }
}
