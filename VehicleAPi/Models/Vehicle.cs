using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehicleAPi.Models
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }
        public int? VehicleTypeId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public string Displacement { get; set; }
        public string MaxSpeed { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
       
        

        [NotMapped]
        public VehicleType? VehicleType { get; set; }
        //public VehicleType? VehicleType { get; set; }
    }
}
