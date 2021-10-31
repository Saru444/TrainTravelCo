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
            //_tripList.Add(new Train { RegNr = "Train-001", MaxCapacity = 25 });




        }
        public void AddTrain(Train train)
        {
            _trainList.Add(train);
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
