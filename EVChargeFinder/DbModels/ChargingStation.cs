namespace EVChargeFinder.DbModels
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;
    using static EVChargeFinder.Common.EntityValidation.ChargingStation;
    using Enums;


    [Index(nameof(OperatorId), nameof(Name), nameof(Latitude), nameof(Longitude), IsUnique = true)]
    public class ChargingStation
    {
        [Key]
        public int Id { get; set; }

        
        [MinLength(NameMinLength)]
        [MaxLength(NameMaxLength)]
        public required string Name { get; set; } = null!;

       
        [MinLength(AddressMinLength)]
        [MaxLength(AddressMaxLength)]
        public required string Address { get; set; } = null!;

        [MinLength(CityMinLength)]
        [MaxLength(CityMaxLength)]
        public string? City { get; set; }

        [Range(typeof(decimal), LatitudeMinValue, LatitudeMaxValue)]
        [Precision(9, 6)]
        public decimal Latitude { get; set; }

        [Range(typeof(decimal), LongitudeMinValue, LongitudeMaxValue)]
        [Precision(9, 6)]
        public decimal Longitude { get; set; }

        public ChargingStationStatus ChargingStationStatus { get; set; }

        [MinLength(DataSourceMinLength)]
        [MaxLength(DataSourceMaxLength)]
        public required string DataSource { get; set; } = null!;

        [MinLength(ExternalIdMinLength)]
        [MaxLength(ExternalIdMaxLength)]
        public string? ExternalId { get; set; }

        public DateTime LastUpdatedAt { get; set; } = DateTime.UtcNow;

        [ForeignKey(nameof(Operator))]
        public int OperatorId { get; set; }

        public virtual Operator Operator { get; set; } = null!;

        public virtual ICollection<Connector> Connectors { get; set; }
            = new HashSet<Connector>();
    }
}