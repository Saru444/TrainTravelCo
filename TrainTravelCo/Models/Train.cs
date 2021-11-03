using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainTravelCo.Models
{
    public class Train
    {
        private static int _idCounter = 0;
        public string RegNr { get; init; }
        public int MaxCapacity { get; init; }
        public int Id { get; init; }
        public Train()
        {
            this.Id = _idCounter++; 
        }
    }

}
