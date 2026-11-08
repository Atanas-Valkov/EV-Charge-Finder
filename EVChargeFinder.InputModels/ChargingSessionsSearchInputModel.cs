namespace EVChargeFinder.InputModels
{
    using System.ComponentModel.DataAnnotations;
    using static GCommon.EntityValidation.ChargingSessionsValidationConst;
    using static GCommon.ApplicationConstants;

    public class ChargingSessionsSearchInputModel : IValidatableObject
    {
        [StringLength(ChargingSessionsSearchTermMaxLength, ErrorMessage = "Search term cannot exceed 100 characters.")]
        public string? SearchTerm { get; set; }

        [DataType(DataType.Date)]
        public DateTime? From { get; set; }

        [DataType(DataType.Date)]
        public DateTime? To { get; set; }

        [Range(PageNumberMinValue, PageNumberMaxValue, ErrorMessage = "Invalid page number.")]
        public int PageNumber { get; set; } = 1;

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (From.HasValue && To.HasValue && From.Value.Date > To.Value.Date)
            {
                yield return new ValidationResult("End date must be the same as or later than the start date.",
                    new[] { nameof(To) });
            }
        }
    }
}