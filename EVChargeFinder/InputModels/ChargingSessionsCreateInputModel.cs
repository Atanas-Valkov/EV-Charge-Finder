namespace EVChargeFinder.InputModels
{
    using Microsoft.AspNetCore.Mvc.ModelBinding;
    using System.ComponentModel.DataAnnotations;
    using static Common.EntityValidation.ChargingSessionsValidationConst;
    using static Common.EntityValidation.ChargingStationValidationConst; 
    using static Common.EntityValidation.ConnectorValidationConst;

    public class ChargingSessionsCreateInputModel : IValidatableObject
    {
        [Required]
        [Range(ChargingStationIdMinValue, ChargingStationIdMaxValue, ErrorMessage = "Please select a valid charging station.")]
        [Display(Name = "Charging Station")]
        public int ChargingStationId { get; set; }

        [Required(ErrorMessage = "Please select a connector.")]
        [Range(ConnectorIdMinValue, ConnectorIdMaxValue, ErrorMessage = "Please select a valid connector.")]
        [Display(Name = "Connector")]
        public int ConnectorId { get; set; }

        [BindRequired]
        [Display(Name = "Started At")]
        public DateTime StartedAt { get; set; }

        [BindRequired]
        [Display(Name = "Ended At")]
        public DateTime EndedAt { get; set; }


        [Range(EnergyKWhMinValue, EnergyKWhMaxValue, ErrorMessage = "Please enter a valid energy consumption.")]
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Energy must have at most 2 decimal places.")]
        [Display(Name = "Total Energy Used")]
        public decimal EnergyKWh { get; set; }

        [Range(AppliedPricePerKWhMinValue, AppliedPricePerKWhMaxValue, ErrorMessage = "Please enter a valid applied price per kWh.")]
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Applied price must have at most 2 decimal places.")]
        [Display(Name = "Applied Price per kWh")]
        public decimal AppliedPricePerKWh { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (EndedAt <= StartedAt)
            {
                yield return new ValidationResult(
                    "Ended At must be greater than Started At.",
                    new[] { nameof(EndedAt) });
            }
        }
    }
}