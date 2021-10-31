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
            bool hasError = false;
            try
            {
                var transList = dataStore.GetAllTrains().Find(x => x.Id == trainId);
                var newTrip = new Trip()
                {
                    Start = start,
                    Destination = destination,
                    DepartureTime = departureTime,
                    trainId = trainId
                };
                dataStore.AddTrip(newTrip);
            }
            catch(Exception)
            {
                Console.WriteLine("Error!");
                hasError = true;
            }
            finally   //förstår hur may använder finally, men vet int om det passar här? eller ska man bara skriva try catch(Exception){throw;}
            {
                if(hasError)
                {
                    Console.WriteLine("Error!");
                }
                else
                {
                    Console.WriteLine("Done!");
                }
            }
           
        }
    }
}
