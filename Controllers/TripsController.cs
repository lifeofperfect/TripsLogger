using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trips.Data.Models;
using Trips.Data.Services;

namespace Trips.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripsController : Controller
    {
        private readonly ITripService _serv;

        public TripsController(ITripService serv)
        {
            _serv = serv;
        }

        [HttpPost("AddTrip")]
        public IActionResult AddTrip([FromBody] Trip trip)
        {
            if(trip != null)
            {
                _serv.AddTrip(trip);
            }

            return Ok();
        }

        [HttpGet("[action]")]
        public IActionResult GetTrips()
        {
            var allTrips = _serv.GetAllTrips();
            return Ok(allTrips);
        }
        [HttpPut("[action]/{id}")]
        public IActionResult UpdateTrip(int id, [FromBody] Trip trip)
        {
            _serv.UpdateTrip(id, trip);
            return Ok(trip);
        }
        [HttpDelete("[action]/{id}")]
        public IActionResult DeleteTrip(int id)
        {
            _serv.DeleteTrip(id);
            return Ok();
        }

        [HttpGet("[action]/{id}")]
        public IActionResult SingleTrip(int id)
        {
            var trip = _serv.GetTripById(id);
            return Ok(trip);
        }
    }
}
