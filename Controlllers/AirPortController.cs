using Microsoft.AspNetCore.Mvc;
using AirPortApi.Services;
using AirPortApi.Models;

namespace AirPortApi.Controllers
{

    [ApiController]
    [Route("api/airport")]
    public class AirPortController : ControllerBase
    {
        private readonly AirportServices _airportServices;

        public AirPortController(AirportServices airportServices)
        {
            _airportServices = airportServices;
        }

        [HttpGet]
        public IActionResult GetAirports()
        {
            return Ok(_airportServices.GetAirports());
        }

        [HttpGet]
        public IActionResult GetAirportById(int id)
        {
            return Ok(_airportServices.GetAirportById(id));
        }

        // [HttpPost]
        // public IActionResult Create([FromBody] AirportsModel airport)
        // {
        //     var createdAirport = _airportServices.CreateAirport(airport);
        //     return CreatedAtAction(nameof(GetById), new { id = createdAirport.Id }, createdAirport);
        // }
    }
}