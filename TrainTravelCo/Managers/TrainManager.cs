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
        public Train Save(Train newTrain)
        {
            dataStore.SaveTrain(newTrain);
            return newTrain;
        }           
        public List<Train> List()
        {           
            return dataStore.ListTrains();
        }
    }

}

