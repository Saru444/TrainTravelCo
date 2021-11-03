using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainTravelCo.Data;
using TrainTravelCo.Models;

namespace TrainTravelCo.Managers
{
    public class TripManager
    {
        DataStore dataStore = DataStore.Instance;
        public void CreateTrip(string start,string destination,string departureTime,int trainId)
        {
            try
            {
                //Train train =;
                var transList = dataStore.GetAllTrains().Find(x => x.Id == trainId);
                var newTrip = new Trip()
                {
                    Start = start,
                    Destination = destination,
                    DepartureTime = departureTime,                     
                    TrainId = trainId
                };
                dataStore.AddTrip(newTrip);
            }
            catch(Exception)
            {
                throw;
            }
        
           
        }
    }
}
