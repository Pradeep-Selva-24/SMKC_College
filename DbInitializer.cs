using College.Constant;
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
        await SeedIfEmptyAsync(context.Login, LoginConstant.lstLogin, nameof(context.Login), context);
        await SeedIfEmptyAsync(context.PageMedia, PageMediaConstant.lstPageMedia, nameof(context.PageMedia), context);
        await SeedIfEmptyAsync(context.InstitutionPages, InstitutionPagesConstant.lstInstitutionPages, nameof(context.InstitutionPages), context);
        await SeedIfEmptyAsync(context.CampusInfo, CampusInfoConstant.lstCampusInfo, nameof(context.CampusInfo), context);
        await SeedIfEmptyAsync(context.AQARReport, AQARReportConstant.lstAQARReport, nameof(context.AQARReport), context);
        await SeedIfEmptyAsync(context.IQACMembers, IQACMembersConstant.lstIQACMembers, nameof(context.IQACMembers), context);
        await SeedIfEmptyAsync(context.NACDocument, NACDocumentConstant.lstNACDocument, nameof(context.NACDocument), context);
        await SeedIfEmptyAsync(context.NACDetails, NACDetailsConstant.lstNACDetails, nameof(context.NACDetails), context);
        await SeedIfEmptyAsync(context.NIRFDocument, NIRFDocumentConstant.lstNIRFDocument, nameof(context.NIRFDocument), context);
        await SeedIfEmptyAsync(context.NIRFDetails, NIRFDetailsConstant.lstNIRFDetails, nameof(context.NIRFDetails), context);
        await SeedIfEmptyAsync(context.NIRFDocumentRanking, NIRFDocumentRankingConstant.lstNIRFDocumentRanking, nameof(context.NIRFDocumentRanking), context);

    }

    private static async Task SeedIfEmptyAsync<TEntity>(DbSet<TEntity> dbSet, IEnumerable<TEntity> data, string name, CLGDbContext context) where TEntity : class
    {
        if (!await dbSet.AnyAsync())
        {
            Console.WriteLine($"Seeding {name}...");
            await dbSet.AddRangeAsync(data);
            await context.SaveChangesAsync();
        }
    }

}
