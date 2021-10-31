using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainTravelCo.Managers;
using TrainTravelCo.Models;
using TrainTravelCo.Data;

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
        [HttpPost]
        public string Create(int trainId, string start, string destination, string departureTime)
        {
            return _tripManager.AddTrip(trainId, start, destination, departureTime);
        }
        [HttpGet]
        public List<Trip> GetTripList()
        {

            return _tripManager.GetAllTrips();

        }

    }
    
}
