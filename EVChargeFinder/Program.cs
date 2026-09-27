namespace EVChargeFinder
{
    using EVChargeFinder.Data;
    using EVChargeFinder.Data.Seeding;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;


    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration
                .GetConnectionString("DevConnectionString") ?? throw new InvalidOperationException("Connection string 'DevConnectionString' not found.");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {
                options
                    .UseSqlServer(connectionString)
                    .UseSeeding((context, _) =>
                    {
                        ApplicationDbContext dbContext =
                            (ApplicationDbContext)context;

                        OperatorSeeder.Seed(dbContext);
                        ChargeStationSeeder.Seed(dbContext);
                    });
            });

            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            builder.Services.AddControllersWithViews();
            builder.Services.AddRazorPages();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.MapRazorPages()
                .WithStaticAssets();

            app.Run();
        }
    }
}
