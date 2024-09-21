using Microsoft.AspNetCore.Mvc;
using VehicleAPi.Interfaces;
using VehicleAPi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VehicleAPi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private IVehicle _vehicleServiceList;
        private IVehicleType _vehicleTypeServicesList;
        public VehicleController(IVehicle vehicleService, IVehicleType vehicleTypeServices)
        {
            _vehicleServiceList = vehicleService;
            _vehicleTypeServicesList = vehicleTypeServices;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<IEnumerable<Vehicle>> Get()
        {
            try { 
            var vehicles =  await _vehicleServiceList.GetVehicles();
            foreach (var item in vehicles)
            {
                    if(item.VehicleTypeId!=null){
                        item.VehicleType = await _vehicleTypeServicesList.GetVehicleType((int)item.VehicleTypeId);
                    }
            }
            return vehicles;
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                return (IEnumerable<Vehicle>)BadRequest(ex.Message);
            }

        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<Vehicle> Get(int id)
        {
            var vehicle = await _vehicleServiceList.GetVehicle(id);

            vehicle.VehicleType = await _vehicleTypeServicesList.GetVehicleType(id);
            return vehicle;
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task Post([FromBody] Vehicle vehicle)
        {
            await _vehicleServiceList.AddVehicle(vehicle);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] Vehicle value)
        {
            await _vehicleServiceList.UpdateVehicle(id, value);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _vehicleServiceList.DeleteVehicle(id);

        }
    }
}
