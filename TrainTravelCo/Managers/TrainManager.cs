using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainTravelCo.Data;
using TrainTravelCo.Models;
using TrainTravelCo.Controllers;

namespace TrainTravelCo.Managers
{
    public class TrainManager
    {
        DataStore dataStore = DataStore.Instance;
        public List<Train> GetTrain()
        {
            
            return dataStore.GetAllTrains();

        }

    }

}

