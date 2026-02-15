

using College.Entities;
using Microsoft.EntityFrameworkCore;

namespace College.Services.Context
{
    public class CLGDbContext(DbContextOptions<CLGDbContext> options, IConfiguration config) : DbContext(options)
    {
        public DbSet<Login> Login { get; set; }
        public DbSet<SettingMaster> SettingMaster { get; set; }
        public DbSet<CampusInfo> CampusInfo { get; set; }
        public DbSet<InstitutionPages> InstitutionPages { get; set; }
        public DbSet<Management> Management { get; set; }
        public DbSet<ManagementContent> ManagementContent { get; set; }
        public DbSet<PageMedia> PageMedia { get; set; }
        public DbSet<ClubsMaster> ClubsMaster { get; set; }
        public DbSet<ClubsDetails> ClubsDetails { get; set; }
        public DbSet<IQACMembers> IQACMembers { get; set; }
        public DbSet<IQACDocument> IQACDocument { get; set; }
        public DbSet<AQARReport> AQARReport { get; set; }
        public DbSet<NACDetails> NACDetails { get; set; }
        public DbSet<NACDocument> NACDocument { get; set; }
        public DbSet<NIRFDetails> NIRFDetails { get; set; }
        public DbSet<PlacementContact> PlacementContact { get; set; }
        public DbSet<NIRFDocument> NIRFDocument { get; set; }
        public DbSet<NIRFDocumentRanking> NIRFDocumentRanking { get; set; }
        public DbSet<DepartmentsMaster> DepartmentsMaster { get; set; }
        public DbSet<DepartmentsMembers> DepartmentsMembers { get; set; }
        public DbSet<DepartmentsDetails> DepartmentsDetails { get; set; }
        public DbSet<MenuMaster> MenuMaster { get; set; }
        public DbSet<ProgrammesOffered> ProgrammesOffered { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CLGDbContext).Assembly);

            if (config["ConnectionStrings:DB_Provider"]?.ToString().ToUpperInvariant() == "MYSQL")
            {
                foreach (var entityType in modelBuilder.Model.GetEntityTypes())
                {
                    var tableName = entityType.GetTableName();
                    var schema = entityType.GetSchema();

                    if (!string.IsNullOrEmpty(schema))
                    {
                        entityType.SetTableName($"{schema}.{tableName}");
                        entityType.SetSchema(null);
                    }
                }
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var provider = config["ConnectionStrings:DB_Provider"]?.ToUpperInvariant() ?? throw new Exception("DB_Provider not set");

            if (provider == "MYSQL")
            {
                optionsBuilder.UseMySql(
                    config.GetConnectionString("MYSQL"),
                    ServerVersion.AutoDetect(config.GetConnectionString("MYSQL"))
                );
            }
            else if (provider == "MSSQL")
            {
                optionsBuilder.UseSqlServer(config.GetConnectionString("MSSQL"));
            }
            else if (provider == "POSTGRESQL")
            {
                optionsBuilder.UseNpgsql(config.GetConnectionString("POSTGRESQL"));
            }
        }


    }
}
