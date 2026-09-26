using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static EVChargeFinder.Common.EntityValidation.Vehicle;
namespace EVChargeFinder.DbModels
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(BrandMinLength)]
        [MaxLength(BrandMaxLength)]
        public string Brand { get; set; } = null!;

        [Required]
        [MinLength(ModelMinLength)]
        [MaxLength(ModelMaxLength)]
        public string Model { get; set; } = null!;

        [Range(YearMinValue,YearMaxValue)]
        public int Year { get; set; }

        [Precision(6, 2)]
        public decimal? BatteryCapacityKWh { get; set; }


    }
}