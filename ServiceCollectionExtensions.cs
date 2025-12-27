using College.Services.Context;
using Microsoft.EntityFrameworkCore;
namespace College;
public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddConfiguredDatabase(this IServiceCollection services, IConfiguration config)
    {
        var provider = config["ConnectionStrings:DB_Provider"] ?? throw new Exception("DB_Provider must be configured");

        provider = provider.ToUpperInvariant();

        services.AddDbContext<CLGDbContext>(options =>
        {
            switch (provider)
            {
                case "MYSQL":
                    options.UseMySql(
                        config.GetConnectionString("MYSQL"),
                        ServerVersion.AutoDetect(config.GetConnectionString("MYSQL")),
                        my => my.MigrationsAssembly("College"));
                    break;

                case "MSSQL":
                    options.UseSqlServer(
                        config.GetConnectionString("MSSQL"),
                        sql => sql.MigrationsAssembly("College")
                                  .MigrationsHistoryTable("__EFMigrationsHistory", "dbo"));
                    break;

                case "POSTGRESQL":
                    options.UseNpgsql(
                        config.GetConnectionString("POSTGRESQL"),
                        pg => pg.MigrationsAssembly("College")
                                 .MigrationsHistoryTable("__EFMigrationsHistory", "public")).EnableSensitiveDataLogging();
                    break;

                default:
                    throw new Exception($"Unsupported DB Provider: {provider}");
            }
        });

        return services;
    }

}
