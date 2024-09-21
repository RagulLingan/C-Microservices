using VehicleAPi.Models;

namespace VehicleAPi.Interfaces
{
    public interface IVehicle
    {
        Task<List<Vehicle>> GetVehicles();
        Task<Vehicle> GetVehicle(int id);
        Task AddVehicle(Vehicle vehicle);
        Task UpdateVehicle(int id, Vehicle vehicle);
        Task DeleteVehicle(int id);
    }
}
