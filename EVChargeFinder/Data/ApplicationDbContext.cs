
using EVChargeFinder.DbModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EVChargeFinder.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public virtual DbSet<ChargeStation> ChargeStations { get; set; } = null!;
        public virtual DbSet<Connector> Connectors { get; set; } = null!;
        public virtual DbSet<ChargingSession> ChargingSessions { get; set; } = null!;
        public virtual DbSet<Operator> Operators { get; set; } = null!;
        public virtual DbSet<Vehicle> Vehicles { get; set; } = null!;
    }
}
