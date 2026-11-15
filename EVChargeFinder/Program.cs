namespace EVChargeFinder
{
    using Services.Core.Interfaces;
    using Services.Core;
    using Data;
    using Data.Seeding;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;

    public class Program
    {
        public static async Task Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            string connectionString = builder.Configuration.GetConnectionString("DevConnectionString") ??
                                   throw new InvalidOperationException("Connection string 'DevConnectionString' not found.");

            // Add DbContext with SQL Server and async seeding
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {
                options
                    .UseSqlServer(connectionString)
                    .UseSeeding((context, _) =>
                    {
                        ApplicationDbContext dbContext = (ApplicationDbContext)context;

                        OperatorSeeder.SeedAsync(dbContext).GetAwaiter().GetResult();
                        ChargingStationSeeder.SeedAsync(dbContext).GetAwaiter().GetResult();
                        ConnectorSeeder.SeedAsync(dbContext).GetAwaiter().GetResult();
                        ChargingSessionSeeder.SeedAsync(dbContext).GetAwaiter().GetResult();
                    })
                    .UseAsyncSeeding(async (context, _, cancellationToken) =>
                    {
                        ApplicationDbContext dbContext = (ApplicationDbContext)context;

                        await OperatorSeeder.SeedAsync(dbContext);
                        await ChargingStationSeeder.SeedAsync(dbContext);
                        await ConnectorSeeder.SeedAsync(dbContext);
                        await ChargingSessionSeeder.SeedAsync(dbContext);
                    });
            });

            builder.Services.AddDatabaseDeveloperPageExceptionFilter();
           
            // Register custom services in DI container
            builder.Services.AddScoped<IChargingStationService, ChargingStationService>();
            builder.Services.AddScoped<IChargingSessionService, ChargingSessionService>();

            // Register Identity in DI container
            builder.Services.AddDefaultIdentity<IdentityUser>(options =>
                {
                    ConfigureIdentity(options, builder.Configuration);
                })
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();


            builder.Services.AddControllersWithViews();
            builder.Services.AddRazorPages();

            WebApplication app = builder.Build();

            // Seed development Identity roles
            if (app.Environment.IsDevelopment())
            {
                using IServiceScope scope = app.Services.CreateScope();

                RoleManager<IdentityRole> roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                UserManager<IdentityUser> userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

                await IdentityRoleSeeder.SeedAsync(roleManager, userManager);
            }

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

            await app.RunAsync();
        }

        private static void ConfigureIdentity(IdentityOptions options, ConfigurationManager configuration)
        {
            bool signInRequireConfirmedEmail = configuration.GetValue<bool>("Identity:SignIn:RequireConfirmedAccount");

            // Dev settings 
            // Register Identity in DI container

            // SingIn settings
            options.SignIn.RequireConfirmedEmail = configuration.GetValue<bool>("Identity:SignIn:RequireConfirmedEmail");
            options.SignIn.RequireConfirmedAccount = configuration.GetValue<bool>("Identity:SignIn:RequireConfirmedAccount");
            options.SignIn.RequireConfirmedPhoneNumber = configuration.GetValue<bool>("Identity:SignIn:RequireConfirmedPhoneNumber");
            
            //User settings 
            options.User.RequireUniqueEmail = configuration.GetValue<bool>("Identity:User:RequireUniqueEmail");

            // Lockout settings
            options.Lockout.MaxFailedAccessAttempts = configuration.GetValue<int>("Identity:Lockout:MaxFailedAccessAttempts");
            options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(configuration.GetValue<int>("Identity:Lockout:DefaultLockoutTimeSpan"));

            // Password settings
            options.Password.RequireDigit = configuration.GetValue<bool>("Identity:Password:RequireDigit");
            options.Password.RequireLowercase = configuration.GetValue<bool>("Identity:Password:RequireLowercase");
            options.Password.RequireUppercase = configuration.GetValue<bool>("Identity:Password:RequireUppercase");
            options.Password.RequiredLength = configuration.GetValue<int>("Identity:Password:RequiredLength");
            options.Password.RequiredUniqueChars = configuration.GetValue<int>("Identity:Password:RequiredUniqueChars");
            options.Password.RequireNonAlphanumeric = configuration.GetValue<bool>("Identity:Password:RequireNonAlphanumeric");
     

        }
    }
}