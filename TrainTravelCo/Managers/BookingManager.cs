using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainTravelCo.Models;
using TrainTravelCo.Data;
using TrainTravelCo.Controllers;


namespace TrainTravelCo.Managers
{
    public class BookingManager
    {
        DataStore dataStore = DataStore.Instance;
        public List<Trip> Search(string start)
        {
            var trainsList = dataStore.GetAllTrips().Find(x => x.Start == start);
            List<Trip> searchList = new();
            searchList.Add(trainsList);
            return searchList;
        }
        public void BookTrip(int tripId, Customer customer)
        {
            var trip = dataStore.GetAllTrips().Find(x => x.TripId == tripId);
            Booking booking = new Booking()
            {
                Customer = customer,
                Trip = trip
            };
            dataStore.AddTrip(trip);

        }
    }
}
