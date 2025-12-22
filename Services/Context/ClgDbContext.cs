

using College.Entities;
using Microsoft.EntityFrameworkCore;

namespace College.Services.Context
{
    public class ClgDbContext : DbContext
    {
        public ClgDbContext(DbContextOptions<ClgDbContext> options) : base(options) { }
        public DbSet<Login> Login { get; set; }
        public DbSet<CampusInfo> CampusInfo { get; set; }
        public DbSet<InstitutionPages> InstitutionPages { get; set; }
        public DbSet<Management> Management { get; set; }
        public DbSet<ManagementContent> ManagementContent { get; set; }
        public DbSet<PageMedia> PageMedia { get; set; }
        public DbSet<LatestNews> LatestNews { get; set; }
        public DbSet<ClubsMaster> ClubsMaster { get; set; }
        public DbSet<ClubsDetails> ClubsDetails { get; set; }
        public DbSet<IQACMembers> IQACMembers { get; set; }
        public DbSet<AQARReport> AQARReport { get; set; }
        public DbSet<NAACDetails> NAACDetails { get; set; }
        public DbSet<NAACDocument> NAACDocument { get; set; }
        public DbSet<NIRFDetails> NIRFDetails { get; set; }
        public DbSet<NIRFDocument> NIRFDocument { get; set; }
        public DbSet<NIRFDocumentRanking> NIRFDocumentRanking { get; set; }
        public DbSet<DepartmentsMaster> DepartmentsMaster { get; set; }
        public DbSet<DepartmentsMembers> DepartmentsMembers { get; set; }
        public DbSet<DepartmentsDetails> DepartmentsDetails { get; set; }
        public DbSet<MenuMaster> MenuMaster { get; set; }
    }
}
