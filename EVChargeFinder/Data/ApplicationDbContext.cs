namespace EVChargeFinder.Data
{
    using DbModels;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public virtual DbSet<ChargingStation> ChargingStations { get; set; } = null!;
        public virtual DbSet<Connector> Connectors { get; set; } = null!;
        public virtual DbSet<ChargingSession> ChargingSessions { get; set; } = null!;
        public virtual DbSet<Operator> Operators { get; set; } = null!;

    }
}
