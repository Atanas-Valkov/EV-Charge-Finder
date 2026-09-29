using EVChargeFinder.Common;

namespace EVChargeFinder.DbModels
{
    using Enums;
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static EntityValidation.Connector;

    [Index(nameof(ChargeStationId), nameof(ConnectorNumber), IsUnique = true)]
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

        [ForeignKey(nameof(ChargeStation))]
        public int ChargeStationId { get; set; }
        public virtual ChargeStation ChargeStation { get; set; } = null!;

    }
}