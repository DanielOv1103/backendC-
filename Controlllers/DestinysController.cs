using Microsoft.AspNetCore.Mvc;
using DestinysApi.Services;
using DestinysApi.Models;

namespace DestinysApi.Controllers
{
    [ApiController]
    [Route("api/destinies")] // Se recomienda usar nombres en plural para APIs REST
    public class DestinyController : ControllerBase
    {
        private readonly DestinyServices _destinyServices;

        public DestinyController(DestinyServices destinyServices)
        {
            _destinyServices = destinyServices;
        }

        // Obtener todos los destinos
        [HttpGet]
        public IActionResult GetDestinies()
        {
            var destinies = _destinyServices.GetDestinies();
            return Ok(destinies);
        }

        // Obtener un destino por ID
        [HttpGet("{id}")] // Se agrega el parámetro a la ruta
        public IActionResult GetDestinyById(int id)
        {
            var destiny = _destinyServices.GetDestinyById(id);
            if (destiny == null)
            {
                return NotFound();
            }
            return Ok(destiny);
        }

        // Crear un destino
        [HttpPost]
        public IActionResult Create([FromBody] DestinysModels destiny)
        {
            if (destiny == null)
            {
                return BadRequest("El cuerpo de la solicitud es inválido.");
            }

            var createdDestiny = _destinyServices.CreateDestiny(destiny);
            return CreatedAtAction(nameof(GetDestinyById), new { id = createdDestiny.Id }, createdDestiny);
        }

        // Actualizar un destino
        [HttpPut]
        public IActionResult Update([FromBody] DestinysModels destiny)
        {
            if (destiny == null || destiny.Id == 0)
            {
                return BadRequest("El cuerpo de la solicitud es inválido o falta el ID del destino.");
            }

            var wasUpdated = _destinyServices.UpdateDestiny(destiny);
            if (!wasUpdated)
            {
                return NotFound();
            }
            return Ok(new { message = "Destino actualizado correctamente" });
        }

        // Eliminar un destino por ID
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _destinyServices.DeleteDestiny(id);
            if (!result)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
