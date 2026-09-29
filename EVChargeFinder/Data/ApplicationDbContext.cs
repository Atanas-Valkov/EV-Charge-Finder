namespace EVChargeFinder.Data
{
    using EVChargeFinder.DbModels;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<ChargeStation> ChargeStations { get; set; } = null!;
        public DbSet<Connector> Connectors { get; set; } = null!;
        public DbSet<ChargingSession> ChargingSessions { get; set; } = null!;
        public DbSet<Operator> Operators { get; set; } = null!;

    }
}
