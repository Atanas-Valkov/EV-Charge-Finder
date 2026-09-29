namespace EVChargeFinder.DbModels
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class ChargingSession
    {
        [Key]
        public int Id { get; set; }

        public DateTime StartedAt { get; set; } = DateTime.UtcNow;

        public DateTime? EndedAt { get; set; } = DateTime.UtcNow;

        [Precision(8, 4)]
        public decimal EnergyKWh { get; set; }

        [Precision(8, 4)]
        public decimal AppliedPricePerKWh { get; set; }

        [Precision(8, 4)]
        public decimal TotalCost { get; set; }

        [ForeignKey(nameof(Connector))]
        public int ConnectorId { get; set; }
        public virtual Connector Connector { get; set; } = null!;

    }
}