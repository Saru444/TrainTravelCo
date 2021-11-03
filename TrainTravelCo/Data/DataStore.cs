using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainTravelCo.Models;

namespace TrainTravelCo.Data
{
    public class DataStore
    {
        private List<Train> _trainList = new();
        private List<Trip> _tripList = new();
        private static DataStore _instance = null;
        DataStore dataStore = DataStore.Instance;
        public static DataStore Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DataStore();
                }
                return _instance;
            }
        }
        private DataStore()
        {
            _trainList.Add(new Train { RegNr = "Train-001", MaxCapacity = 20 });
            _trainList.Add(new Train { RegNr = "Train-002", MaxCapacity = 45 });
            _tripList.Add(new Trip { Start = "Hallsberg", Destination = "Stockholm", DepartureTime = "08:10", TrainId = 0 });
            _tripList.Add(new Trip { Start = "Göteborg", Destination = "örebro", DepartureTime = "13:30", TrainId = 1 });
            _tripList.Add(new Trip { Start = "Hallsberg", Destination = "Oslo", DepartureTime = "12:19", TrainId = 3 });


        }
        public void AddTrain(Train newTrain)
        {
            _trainList.Add(newTrain);
        }
        public List<Train> GetAllTrains()
        {
            return _trainList;
        }
        public void AddTrip(Trip trip)
        {
            _tripList.Add(trip);
        }
        public List<Trip> GetAllTrips()
        {
            return _tripList;
        }
    }
}
