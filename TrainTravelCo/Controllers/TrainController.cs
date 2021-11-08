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
    [Route("train")]
    [ApiController]
    public class TrainController : ControllerBase
    {
        DataStore dataStore = DataStore.Instance;
        private TrainManager _trainManager;
        public TrainController()
        {
            _trainManager = new TrainManager();
        }
        [HttpPost]
        public Train CreateTrain(Train newTrain)
        {
            return _trainManager.Save(newTrain);
        }
        [HttpGet]
        public List<Train> ListTrains()
        {
            return _trainManager.List();           
        }
    }
}
