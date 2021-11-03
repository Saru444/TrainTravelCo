using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainTravelCo.Managers;
using TrainTravelCo.Models;
using
using TrainTravelCo.DTO;

namespace TrainTravelCo.Controllers
{
    [Route("booking")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private BookingManager _bookingManager;
        public BookingController()
        {
            _bookingManager = new BookingManager();
        }

        [HttpGet]
        public List<Trip> Search(string start)
        {
            return _bookingManager.Search(start);
        }
        [HttpPost]
        public void BookTrip (BookTripDTO bookTrip)
        {
            BookingManager manager = new BookingManager()
            {
                manager.BookTrip(bookTrip)
            };
        }

    }
}
