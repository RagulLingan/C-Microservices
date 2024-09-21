using Microsoft.EntityFrameworkCore;
using VehicleAPi.Models;

namespace VehicleAPi.Data
{
    public class ApiDbContext :DbContext
    {
        public DbSet<VehicleType> VehicleTypes { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\ProjectModels;Database=VehicleApiDb;Trusted_Connection=True");
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-B48SUSN0;Database=VehicleDB;Trusted_Connection=True");

        }
    }
}
