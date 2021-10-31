using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainTravelCo.Models;
using TrainTravelCo.Data;
using TrainTravelCo.Managers;

namespace TrainTravelCo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TrainController : ControllerBase
    {
        DataStore dataStore = DataStore.Instance;
        private TrainManager _trainManager;
        public TrainController()
        {
            _trainManager = new TrainManager();
        }
        [HttpGet]
        public List<Train> GetTrainList()
        {

            return dataStore.GetAllTrains();
            
        }
    }
}
