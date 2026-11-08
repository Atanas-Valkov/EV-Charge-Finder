namespace EVChargeFinder.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using EVChargeFinder.Data.DbModels;

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