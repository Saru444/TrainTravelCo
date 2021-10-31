using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainTravelCo.Models
{
    public class Train
    {
        private static int _idCounter = 0;
        public string RegNr { get; set; }
        public int MaxCapacity { get; set; }
        public int Id { get; private set; }
        public Train()
        {
            this.Id = _idCounter;
            _idCounter += 1;
        }
    }

}
