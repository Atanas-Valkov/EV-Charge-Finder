namespace EVChargeFinder.DbModels
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using static EVChargeFinder.Common.EntityValidation.Operator;


    [Index(nameof(Name), IsUnique = true)]
    public class Operator
    {
        [Key]
        public int Id { get; set; }

        
        [MinLength(NameMinLength)]
        [MaxLength(NameMaxLength)]
        public required string Name { get; set; } = null!;

        [MinLength(WebsiteMinLength)]
        [MaxLength(WebsiteMaxLength)]
        public string? Website { get; set; }

        public ICollection<ChargingStation> ChargingStations { get; set; } 
            = new HashSet<ChargingStation>();
    }
}