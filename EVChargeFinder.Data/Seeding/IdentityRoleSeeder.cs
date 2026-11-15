namespace EVChargeFinder.Data.Seeding
{
    using Microsoft.AspNetCore.Identity;

    public static class IdentityRoleSeeder
    {
        public static async Task SeedAsync(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            string[] roles = ["User", "Admin"];

            foreach (string role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    IdentityResult result = await roleManager.CreateAsync(new IdentityRole(role));

                    if (!result.Succeeded)
                    {
                        throw new InvalidOperationException($"Failed to create role '{role}': " + string.Join(", ", result.Errors.Select(e => e.Description)));
                    }
                }
            }

            (string Email, string Role)[] users =
            [
                ("user1@test.test", "User"),
                ("user2@test.test", "User"),
                ("admin@test.test", "Admin")
            ];

            foreach (var (email, role) in users)
            {
                IdentityUser? user = await userManager.FindByEmailAsync(email);

                if (user == null)
                {
                    throw new InvalidOperationException($"User '{email}' was not found.");
                }

                if (!await userManager.IsInRoleAsync(user, role))
                {
                    IdentityResult result = await userManager.AddToRoleAsync(user, role);

                    if (!result.Succeeded)
                    {
                        throw new InvalidOperationException( $"Failed to assign role '{role}' to '{email}': " +
                            string.Join(", ", result.Errors.Select(e => e.Description)));
                    }
                }
            }
        }
    }
}

