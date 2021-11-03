using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainTravelCo.Managers;
using TrainTravelCo.Models;
using TrainTravelCo.Data;
using TrainTravelCo.DTO;

namespace TrainTravelCo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]   
    public class TripController : ControllerBase
    {
        private TripManager _tripManager;
        DataStore dataStore = DataStore.Instance;
        public TripController()
        {
            _tripManager = new TripManager();
        }
        [HttpPost("create")]
        public Trip Create(TripDTo tripDto)
        {
            string start = tripDto.Start;
            string destination = tripDto.Destination;
            string departureTime = tripDto.DepartureTime;
            int trainId = tripDto.TrainId;
            Trip trip= _tripManager.AddTrip(trainId, start, destination, departureTime);
            return trip;
        }
        [HttpGet("list")]
        public List<AvailabelTripDTO> GetTripList()
        {
            List<Trip> trips= _tripManager.GetAllTrips();
            List<AvailabelTripDTO> result = new();
            foreach (var item in trips)
            {

            }
        }

    }
    
}
