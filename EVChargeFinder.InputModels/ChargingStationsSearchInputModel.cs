using Microsoft.Win32.SafeHandles;

namespace EVChargeFinder.InputModels
{
    using static GCommon.EntityValidation.OperatorValidationConst;
    using static GCommon.EntityValidation.ChargingStationValidationConst;
    using static GCommon.ApplicationConstants;

    using Data.DbModels.Enums;
    using System.ComponentModel.DataAnnotations;

    public class ChargingStationsSearchInputModel
    {
        [StringLength(ChargingStationsSearchMaxLength, ErrorMessage = "Search term cannot exceed 100 characters.")]
        public string? SearchTerm { get; set; }

        [RegularExpression(@"^(AC|DC|AC/DC)$", ErrorMessage = "Please select a valid charging type.")]
        public string? ChargingType { get; set; }

        [EnumDataType(typeof(ChargingStationStatus), ErrorMessage = "Please select a valid station status.")]
        public ChargingStationStatus? Status { get; set; }

        [Range(OperatorIdMinValue, OperatorIdMaxValue, ErrorMessage = "Please select a valid operator.")]
        public int? OperatorId { get; set; }

        [EnumDataType(typeof(ConnectorType), ErrorMessage = "Please select a valid connector type.")]
        public ConnectorType? ConnectorType { get; set; }

        [Range(PageNumberMinValue, PageNumberMaxValue, ErrorMessage = "Invalid page number.")]
        public int PageNumber { get; set; } = 1;
    }
}