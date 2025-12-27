using College.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace College.Services.Context;

internal class LoginConfig : IEntityTypeConfiguration<Login>
{
    public void Configure(EntityTypeBuilder<Login> builder)
    {
        builder.ToTable("Login", "CLG");
        builder.HasKey(e => e.Id);
    }
}

internal class PageMediaConfig : IEntityTypeConfiguration<PageMedia>
{
    public void Configure(EntityTypeBuilder<PageMedia> builder)
    {
        builder.ToTable("PageMedia", "CLG");
        builder.HasKey(e => e.Id);
    }
}

internal class InstitutionPagesConfig : IEntityTypeConfiguration<InstitutionPages>
{
    public void Configure(EntityTypeBuilder<InstitutionPages> builder)
    {
        builder.ToTable("InstitutionPages", "CLG");
        builder.HasKey(e => e.Id);
    }
}

internal class CampusInfoConfig : IEntityTypeConfiguration<CampusInfo>
{
    public void Configure(EntityTypeBuilder<CampusInfo> builder)
    {
        builder.ToTable("CampusInfo", "CLG");
        builder.HasKey(e => e.Id);
    }
}

internal class LatestNewsConfig : IEntityTypeConfiguration<LatestNews>
{
    public void Configure(EntityTypeBuilder<LatestNews> builder)
    {
        builder.ToTable("LatestNews", "CLG");
        builder.HasKey(e => e.Id);
    }
}

internal class AQARReportConfig : IEntityTypeConfiguration<AQARReport>
{
    public void Configure(EntityTypeBuilder<AQARReport> builder)
    {
        builder.ToTable("AQARReport", "CLG");
        builder.HasKey(e => e.Id);
    }
}

internal class IQACMembersConfig : IEntityTypeConfiguration<IQACMembers>
{
    public void Configure(EntityTypeBuilder<IQACMembers> builder)
    {
        builder.ToTable("IQACMembers", "CLG");
        builder.HasKey(e => e.Id);
    }
}

internal class NAACDocumentConfig : IEntityTypeConfiguration<NAACDocument>
{
    public void Configure(EntityTypeBuilder<NAACDocument> builder)
    {
        builder.ToTable("NAACDocument", "CLG");
        builder.HasKey(e => e.Id);
    }
}

internal class NAACDetailsConfig : IEntityTypeConfiguration<NAACDetails>
{
    public void Configure(EntityTypeBuilder<NAACDetails> builder)
    {
        builder.ToTable("NAACDetails", "CLG");
        builder.HasKey(e => e.Id);
    }
}

internal class NIRFDocumentConfig : IEntityTypeConfiguration<NIRFDocument>
{
    public void Configure(EntityTypeBuilder<NIRFDocument> builder)
    {
        builder.ToTable("NIRFDocument", "CLG");
        builder.HasKey(e => e.Id);
    }
}

internal class NIRFDetailsConfig : IEntityTypeConfiguration<NIRFDetails>
{
    public void Configure(EntityTypeBuilder<NIRFDetails> builder)
    {
        builder.ToTable("NIRFDetails", "CLG");
        builder.HasKey(e => e.Id);
    }
}

internal class NIRFDocumentRankingConfig : IEntityTypeConfiguration<NIRFDocumentRanking>
{
    public void Configure(EntityTypeBuilder<NIRFDocumentRanking> builder)
    {
        builder.ToTable("NIRFDocumentRanking", "CLG");
        builder.HasKey(e => e.Id);
    }
}

internal class ManagementConfig : IEntityTypeConfiguration<Management>
{
    public void Configure(EntityTypeBuilder<Management> builder)
    {
        builder.ToTable("Management", "CLG");
        builder.HasKey(e => e.Id);
    }
}

internal class ManagementContentConfig : IEntityTypeConfiguration<ManagementContent>
{
    public void Configure(EntityTypeBuilder<ManagementContent> builder)
    {
        builder.ToTable("ManagementContent", "CLG");
        builder.HasKey(e => e.Id);
        builder.HasOne<Management>().WithMany().HasForeignKey(e => e.ManagementId).HasPrincipalKey(p => p.Id);
    }
}

internal class ClubsMasterConfig : IEntityTypeConfiguration<ClubsMaster>
{
    public void Configure(EntityTypeBuilder<ClubsMaster> builder)
    {
        builder.ToTable("ClubsMaster", "CLG");
        builder.HasKey(e => e.Id);
    }
}

internal class ClubsDetailsConfig : IEntityTypeConfiguration<ClubsDetails>
{
    public void Configure(EntityTypeBuilder<ClubsDetails> builder)
    {
        builder.ToTable("ClubsDetails", "CLG");
        builder.HasKey(e => e.Id);
        builder.HasOne<ClubsMaster>().WithMany().HasForeignKey(e => e.ClubsMasterId).HasPrincipalKey(p => p.Id);
    }
}

internal class DepartmentsMasterConfig : IEntityTypeConfiguration<DepartmentsMaster>
{
    public void Configure(EntityTypeBuilder<DepartmentsMaster> builder)
    {
        builder.ToTable("DepartmentsMaster", "CLG");
        builder.HasKey(e => e.Id);
    }
}

internal class DepartmentsMembersConfig : IEntityTypeConfiguration<DepartmentsMembers>
{
    public void Configure(EntityTypeBuilder<DepartmentsMembers> builder)
    {
        builder.ToTable("DepartmentsMembers", "CLG");
        builder.HasKey(e => e.Id);
        builder.HasOne<DepartmentsMaster>().WithMany().HasForeignKey(e => e.DepartmentsMasterId).HasPrincipalKey(p => p.Id);
    }
}

internal class DepartmentsDetailsConfig : IEntityTypeConfiguration<DepartmentsDetails>
{
    public void Configure(EntityTypeBuilder<DepartmentsDetails> builder)
    {
        builder.ToTable("DepartmentsDetails", "CLG");
        builder.HasKey(e => e.Id);
        builder.HasOne<DepartmentsMaster>().WithMany().HasForeignKey(e => e.DepartmentsMasterId).HasPrincipalKey(p => p.Id);
    }
}

internal class MenuMasterConfig : IEntityTypeConfiguration<MenuMaster>
{
    public void Configure(EntityTypeBuilder<MenuMaster> builder)
    {
        builder.ToTable("MenuMaster", "CLG");
        builder.HasKey(e => e.Id);
        builder.HasOne<MenuMaster>().WithMany().HasForeignKey(e => e.ParentMenuId).HasPrincipalKey(p => p.Id).OnDelete(DeleteBehavior.Restrict); ;
    }
}