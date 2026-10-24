namespace EVChargeFinder.InputModels
{
    
    using System.ComponentModel.DataAnnotations;
    using static  Common.EntityValidation.ChargingSessions;

    public class ChargingSessionsCreateInputModel : IValidatableObject
    {
        [Required]
        [Display(Name = "Charging Station")]
        public int ChargingStationId { get; set; }

        [Range(ConnectorIdMinValue, ConnectorIdMaxValue, ErrorMessage = "Please select a valid connector.")]
        [Display(Name = "Connector")]
        public int ConnectorId { get; set; }

        [Display(Name = "Started At")]
        public DateTime StartedAt { get; set; }

        [Display(Name = "Ended At")]
        public DateTime EndedAt { get; set; }


        [Range(EnergyKWhMinValue, EnergyKWhMaxValue, ErrorMessage = "Please enter a valid energy consumption.")]
        [Display(Name = "Total Energy Used")]
        public decimal EnergyKWh { get; set; }

        [Range(AppliedPricePerKWhMinValue, AppliedPricePerKWhMaxValue,
            ErrorMessage = "Please enter a valid applied price per kWh.")]
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