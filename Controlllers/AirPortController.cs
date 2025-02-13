using Microsoft.AspNetCore.Mvc;
using AirPortApi.Services;
using AirPortApi.Models;

namespace AirPortApi.Controllers
{
    [ApiController]
    [Route("api/airports")] // Se recomienda usar nombres en plural para APIs REST
    public class AirPortController : ControllerBase
    {
        private readonly AirportServices _airportServices;

        public AirPortController(AirportServices airportServices)
        {
            _airportServices = airportServices;
        }

        // Obtener todos los aeropuertos
        [HttpGet]
        public IActionResult GetAirports()
        {
            var airports = _airportServices.GetAirports();
            return Ok(airports);
        }

        // Obtener un aeropuerto por ID
        [HttpGet("{id}")] // Se agrega el parámetro a la ruta
        public IActionResult GetAirportById(int id)
        {
            var airport = _airportServices.GetAirportById(id);
            if (airport == null)
            {
                return NotFound();
            }
            return Ok(airport);
        }

        // Crear un aeropuerto
        [HttpPost]
        public IActionResult Create([FromBody] AirportsModel airport)
        {
            if (airport == null)
            {
                return BadRequest("El cuerpo de la solicitud es inválido.");
            }

            var createdAirport = _airportServices.CreateAirport(airport);
            return CreatedAtAction(nameof(GetAirportById), new { id = createdAirport.Id }, createdAirport);
        }

        // Actualizar un aeropuerto
        [HttpPut]
        public IActionResult Update([FromBody] AirportsModel airport)
        {
            if (airport == null || airport.Id == 0)
            {
                return BadRequest("El cuerpo de la solicitud es inválido o falta el ID del aeropuerto.");
            }

            var wasUpdated = _airportServices.UpdateAirport(airport);
            if (!wasUpdated)
            {
                return NotFound();
            }
            return Ok(new { message = "Aeropuerto actualizado correctamente" });
        }

        // Eliminar un aeropuerto por ID
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _airportServices.DeleteAirport(id); // Se usa _airportServices en lugar de _repository
            if (!result)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
