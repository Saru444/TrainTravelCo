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
        public List<Trip> ListTrips()
        {
            return dataStore.ListTrips();
        }
        DataStore dataStore = DataStore.Instance;
        public Trip CreateTrip(string start, string destination, string departureTime, int trainId)
        {
            Train train = GetTrain(trainId);
            var newTrip = new Trip()
            {
                Start = start,
                Destination = destination,
                DepartureTime = departureTime,
                TrainId = trainId
            };
            dataStore.SaveTrip(newTrip);
            return newTrip;          
        }
        private Train GetTrain(int trainId)
        {
            Train train = null;
            var transList = dataStore.ListTrains().Find(x => x.Id == trainId);
            if (train == null)
            {
                throw new Exception($"Train not found for Id {trainId}");
            }
            return train;
        }
    }    
}
