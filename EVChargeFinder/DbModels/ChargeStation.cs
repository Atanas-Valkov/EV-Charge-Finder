namespace EVChargeFinder.DbModels
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;
    using static EVChargeFinder.Common.EntityValidation.ChargeStation;
    using Enums;


    [Index(nameof(OperatorId), nameof(Name), nameof(Latitude), nameof(Longitude), IsUnique = true)]
    public class ChargeStation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(NameMinLength)]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MinLength(AddressMinLength)]
        [MaxLength(AddressMaxLength)]
        public string Address { get; set; } = null!;

        [MinLength(CityMinLength)]
        [MaxLength(CityMaxLength)]
        public string? City { get; set; }

        [Range(typeof(decimal), LatitudeMinValue, LatitudeMaxValue)]
        [Precision(9, 6)]
        public decimal Latitude { get; set; }

        [Range(typeof(decimal), LongitudeMinValue, LongitudeMaxValue)]
        [Precision(9, 6)]
        public decimal Longitude { get; set; }

        public ChargeStationStatus ChargeStationStatus { get; set; }

        [Required]
        [MinLength(DataSourceMinLength)]
        [MaxLength(DataSourceMaxLength)]
        public string DataSource { get; set; } = null!;

        [MinLength(ExternalIdMinLength)]
        [MaxLength(ExternalIdMaxLength)]
        public string? ExternalId { get; set; }

        public DateTime LastUpdatedAt { get; set; } = DateTime.UtcNow;

        [ForeignKey(nameof(Operator))]
        public int OperatorId { get; set; }

        public virtual Operator Operator { get; set; } = null!;
    }
}