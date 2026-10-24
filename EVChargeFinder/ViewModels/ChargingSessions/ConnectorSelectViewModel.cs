namespace EVChargeFinder.ViewModels.ChargingSessions
{
    public class ConnectorSelectViewModel
    {
        public int Id { get; set; }

        public string Text { get; set; } = null!;

        public decimal PowerKw { get; set; }

        public decimal PricePerKWh { get; set; }
    }
}