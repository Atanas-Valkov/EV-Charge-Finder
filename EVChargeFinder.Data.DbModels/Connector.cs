namespace EVChargeFinder.Data.DbModels
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;
    using Enums;
    using static GCommon.EntityValidation.ConnectorValidationConst;

    [Index(nameof(ChargingStationId), nameof(ConnectorNumber), IsUnique = true)]
    public class Connector
    {
        [Key]
        public int Id { get; set; }

        public int ConnectorNumber { get; set; }

        public ConnectorType ConnectorType { get; set; }

        [Precision(6, 2)]
        public decimal PowerKw { get; set; }

        [Precision(8, 4)]
        public decimal PricePerKWh { get; set; }

        public ConnectorStatus ConnectorStatus { get; set; }

        [MaxLength(ExternalIdMaxLength)]
        public string? ExternalId { get; set; }

        [ForeignKey(nameof(ChargingStation))]
        public int ChargingStationId { get; set; }

        public virtual ChargingStation ChargingStation { get; set; } = null!;
    }
}