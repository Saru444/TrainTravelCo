using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainTravelCo.Managers;
using TrainTravelCo.Models;

namespace TrainTravelCo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private BookingManager _bookingManager;
        public BookingController()
        {
            _bookingManager = new BookingManager();
        }

        [HttpGet("search")]
        public List<Trip> Search(string start)
        {
            return _bookingManager.Search(start);
        }
    }
}
