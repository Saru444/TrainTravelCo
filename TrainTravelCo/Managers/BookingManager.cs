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
            var trainsList = dataStore.ListTrips().Find(x => x.Start == start);
            List<Trip> result = new();
            result.Add(trainsList);
            return result;
        }
        public void BookTrip(int tripId,string customerName,string customerPhone)
        {
            Customer customer = new Customer()
            {
                Name = customerName,
                Phone = customerPhone
            };
            Trip trip = GetTrip(tripId);
            Booking booking = new Booking()
            {
                Customer = customer,
                Trip = trip
            };
            trip.bookings.Add(booking);
        }
        private Trip GetTrip(int tripId)
        {
            var trip = dataStore.ListTrips().Find(x => x.Id == tripId);
            return trip;
            throw new Exception($"No trip found for Id {tripId}");
        }
    }
}
