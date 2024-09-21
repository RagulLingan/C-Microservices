using VehicleAPi.Models;

namespace VehicleAPi.Interfaces
{
    public interface IVehicleType
    {
        Task<List<VehicleType>> GetVehicleTypes();
        Task<VehicleType> GetVehicleType(int id);
        Task AddVehicleType(VehicleType vehicleType);
        Task UpdateVehicleType(int id, VehicleType vehicle);
        Task DeleteVehicleType(int id);
        //Task<VehicleType> GetVehicleType(int vehicleTypeId);
    }
}
