using EVChargeFinder.DbModels.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EVChargeFinder.DbModels
{
    public class Connector
    {
        [Key]
        public int Id { get; set; }

        public ConnectorType ConnectorType { get; set; }

        [Precision(6, 2)]
        public decimal PowerKw { get; set; }

        public ConnectorStatus ConnectorStatus { get; set; }

        [ForeignKey(nameof(ChargeStation))]
        public int ChargeStationId { get; set; }
        public virtual ChargeStation ChargeStation { get; set; } = null!;

    }
}