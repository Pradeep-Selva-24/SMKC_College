using College.Entities;
using College.Services.Context;
using Microsoft.EntityFrameworkCore;

namespace College;

public static class DbInitializer
{
    public static async Task InitializeAsync(IServiceProvider services)
    {
        using var scope = services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<CLGDbContext>();

        var provider = context.Database.ProviderName;

        Console.WriteLine($"Running EF Migration for provider: {provider}");

        // Apply migrations only if needed
        var pending = await context.Database.GetPendingMigrationsAsync();

        if (pending.Any())
        {
            Console.WriteLine("Applying migrations...");
            await context.Database.MigrateAsync();
            Console.WriteLine("Migration completed.");
        }
        else
        {
            Console.WriteLine("Database already up to date.");
        }

        // ---- DEFAULT DATA SEEDING ----
        await SeedDefaultDataAsync(context);
    }

    private static async Task SeedDefaultDataAsync(CLGDbContext context)
    {
        if (!context.Login.Any())
        {
            Console.WriteLine("Seeding default Login...");

            context.Login.Add(new Login
            {
                UserId = "Admin",
                Password = "Admin@SMKC@2025",
                LastLogin = DateTime.Now,
                CreatedBy = "System",
                CreatedDate = DateTime.Now,
                Status = true
            });

            await context.SaveChangesAsync();

            Console.WriteLine("Default data seeded.");
        }
        else
        {
            Console.WriteLine("Default data already exists.");
        }
    }
}
