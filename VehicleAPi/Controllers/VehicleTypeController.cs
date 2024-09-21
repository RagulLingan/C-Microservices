using Microsoft.AspNetCore.Mvc;
using VehicleAPi.Interfaces;
using VehicleAPi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VehicleAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleTypeController : ControllerBase
    {
        private IVehicleType _vehicleTypeServicesList;
        public VehicleTypeController(IVehicleType vehicleTypeServices) {
            _vehicleTypeServicesList = vehicleTypeServices;
        }
        // GET: api/<VehicleTypeController>
        [HttpGet]
        public async Task<IEnumerable<VehicleType>>Get()
        {
            var vehiclesTypes = await _vehicleTypeServicesList.GetVehicleTypes();
            return vehiclesTypes;
        }

        // GET api/<VehicleTypeController>/5
        [HttpGet("{id}")]
        public async Task<VehicleType> Get(int id)
        {
            var vehicleType = await _vehicleTypeServicesList.GetVehicleType(id);
            return vehicleType;
        }

        // POST api/<VehicleTypeController>
        [HttpPost]
        public async Task Post([FromBody] VehicleType value)
        {
            await _vehicleTypeServicesList.AddVehicleType(value);
        }

        // PUT api/<VehicleTypeController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] VehicleType value)
        {
            await _vehicleTypeServicesList.UpdateVehicleType(id, value);
        }

        // DELETE api/<VehicleTypeController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _vehicleTypeServicesList.DeleteVehicleType(id);
        }
    }
}
