using Microsoft.AspNetCore.Mvc;
using AirlineApi.Services;
using AirlineApi.Models;

namespace AirlineApi.Controllers{
    [ApiController]
    [Route("api/airlines")]
    public class AirlinesController : ControllerBase{
        private readonly AirlinesServices _airlinesServices;

        public AirlinesController(AirlinesServices airlinesServices){
            _airlinesServices = airlinesServices;
        }

        // Obtener todos los aviones
        [HttpGet]
        public IActionResult GetAirlines(){
            var airlines = _airlinesServices.GetAirlines();
            return Ok(airlines);
        }

        // Obtener un avión por ID
        [HttpGet("{id}")]
        public IActionResult GetAirlineById(int id){
            var airline = _airlinesServices.GetAirlineById(id);
            if (airline == null){
                return NotFound();
            }
            return Ok(airline);
        }

        // Crear un avión
        [HttpPost]
        public IActionResult Create([FromBody] AirlinesModel airline){
            var createdAirline = _airlinesServices.CreateAirline(airline);
            return CreatedAtAction(nameof(GetAirlineById), new { id = createdAirline.Id }, createdAirline);
        }

        // Actualizar un avión
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] AirlinesModel airline){
            var updatedAirline = _airlinesServices.UpdateAirline(airline);
            if (updatedAirline == false){
                return NotFound();
            }
            return Ok(updatedAirline);
        }

        // Eliminar un avión por ID
        [HttpDelete("{id}")]
        public IActionResult Delete(int id){
            var result = _airlinesServices.DeleteAirline(id);
            if (!result){
                return NotFound();
            }
            return NoContent();
        }
    }
}