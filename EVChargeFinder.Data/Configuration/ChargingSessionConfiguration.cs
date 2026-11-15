namespace EVChargeFinder.Data.Configuration
{
    using Microsoft.AspNetCore.Identity;
    using DbModels;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    public class ChargingSessionConfiguration : IEntityTypeConfiguration<ChargingSession>
    {
        public void Configure(EntityTypeBuilder<ChargingSession> builder)
        {
            builder
                .HasOne<IdentityUser>()
                .WithMany()
                .HasForeignKey(s => s.UserId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}