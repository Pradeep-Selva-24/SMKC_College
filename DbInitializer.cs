using College.Constant;
using College.DTO;
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
        await InsertIfNotExistsAsync<Login, string>
            (context.Login, LoginConstant.lstLogin, x => x.UserId!, nameof(context.Login), context);

        await InsertIfNotExistsAsync<SettingMaster, string>
            (context.SettingMaster, SettingMasterConstant.lstSettingMaster, x => x.Key!, nameof(context.SettingMaster), context);

        await InsertIfNotExistsAsync<PageMedia, string>
            (context.PageMedia, PageMediaConstant.lstPageMedia, x => $"{x.Category}|{x.ImagePath}", nameof(context.PageMedia), context);

        await InsertIfNotExistsAsync<InstitutionPages, string>
            (context.InstitutionPages, InstitutionPagesConstant.lstInstitutionPages, x => $"{x.PageType}|{x.Content}", nameof(context.InstitutionPages), context);

        await InsertIfNotExistsAsync<CampusInfo, string>
            (context.CampusInfo, CampusInfoConstant.lstCampusInfo, x => x.Category!, nameof(context.CampusInfo), context);

        await InsertIfNotExistsAsync<AQARReport, string>
            (context.AQARReport, AQARReportConstant.lstAQARReport, x => $"{x.ReportTitle}|{x.ReportTitle}", nameof(context.AQARReport), context);

        await InsertIfNotExistsAsync<IQACMembers, string>
            (context.IQACMembers, IQACMembersConstant.lstIQACMembers, x => $"{x.Name}|{x.Designation}", nameof(context.IQACMembers), context);

        await InsertIfNotExistsAsync<NACDocument, string>
            (context.NACDocument, NACDocumentConstant.lstNACDocument, x => $"{x.Name}|{x.Path}", nameof(context.NACDocument), context);

        await InsertIfNotExistsAsync<NACDetails, string>
            (context.NACDetails, NACDetailsConstant.lstNACDetails, x => $"{x.Name}|{x.Description}", nameof(context.NACDetails), context);

        await InsertIfNotExistsAsync<NIRFDocument, string>
            (context.NIRFDocument, NIRFDocumentConstant.lstNIRFDocument, x => $"{x.Name}|{x.Path}", nameof(context.NIRFDocument), context);

        await InsertIfNotExistsAsync<NIRFDetails, string>
            (context.NIRFDetails, NIRFDetailsConstant.lstNIRFDetails, x => $"{x.Name}|{x.Description}", nameof(context.NIRFDetails), context);

        await InsertIfNotExistsAsync<PlacementContact, string>
            (context.PlacementContact, PlacementContactConstant.lstPlacementContact, x => $"{x.Name}|{x.Phone}", nameof(context.PlacementContact), context);

        await InsertIfNotExistsAsync<NIRFDocumentRanking, string>
            (context.NIRFDocumentRanking, NIRFDocumentRankingConstant.lstNIRFDocumentRanking, x => $"{x.Category}|{x.ParticipationStatus}", nameof(context.NIRFDocumentRanking), context);

        await InsertIfNotExistsAsync<ProgrammesOffered, string>
            (context.ProgrammesOffered, ProgrammesOfferedConstant.lstProgrammesOffered, x => x.Course!, nameof(context.ProgrammesOffered), context);

        await InsertMasterSubIfNotExistsAsync<Management, ManagementContent, ManagementDTO, string, string>
            (context.Management, context.ManagementContent, ManagementConstant.lstManagementDTO, dto => dto.Management, dto => dto.lstManagementContent, m => m.Name!, s => $"{s.ManagementId}|{s.Content}", (sub, masterId) => sub.ManagementId = (int)masterId, master => master.Id, nameof(context.Management), context);

        await InsertMasterSubIfNotExistsAsync<ClubsMaster, ClubsDetails, ClubsDTO, string, string>
            (context.ClubsMaster, context.ClubsDetails, ClubsConstant.lstClubsDTO, dto => dto.ClubsMaster, dto => dto.lstClubsDetails, m => m.Clubs!, s => $"{s.Category}|{s.ImagePath}", (sub, masterId) => sub.ClubsMasterId = (int)masterId, master => master.Id, nameof(context.ClubsMaster), context);

        await InsertMasterSubIfNotExistsAsync<DepartmentsMaster, DepartmentsMembers, DepartmentsDTO, string, string>
            (context.DepartmentsMaster, context.DepartmentsMembers, DepartmentsConstant.lstDepartmentsDTO, dto => dto.DepartmentsMaster, dto => dto.lstDepartmentsMembers, m => m.Department!, s => $"{s.DepartmentsMasterId}|{s.Name}|{s.Designation}", (sub, masterId) => sub.DepartmentsMasterId = (int)masterId, master => master.Id, nameof(context.DepartmentsMembers), context);

        await InsertMasterSubIfNotExistsAsync<DepartmentsMaster, DepartmentsDetails, DepartmentsDTO, string, string>
            (context.DepartmentsMaster, context.DepartmentsDetails, DepartmentsConstant.lstDepartmentsDTO, dto => dto.DepartmentsMaster, dto => dto.lstDepartmentsDetails, m => m.Department!, s => $"{s.DepartmentsMasterId}|{s.Category}|{s.Heading}", (sub, masterId) => sub.DepartmentsMasterId = (int)masterId, master => master.Id, nameof(context.DepartmentsDetails), context);

        await SeedMenuTreeAsync(context.MenuMaster, MenuConstant.lstMenuDTO, null, context);

    }

    private static async Task InsertIfNotExistsAsync<TEntity, TKey>(
        DbSet<TEntity> dbSet,
        IEnumerable<TEntity> sourceData,
        Func<TEntity, TKey> keySelector,
        string name, CLGDbContext context
    )
    where TEntity : class
    {
        Console.WriteLine($"Checking and inserting {name}...");

        var existingData = await dbSet.ToListAsync();
        var existingKeys = existingData.Select(keySelector).ToHashSet();

        var newRecords = sourceData.Where(item => !existingKeys.Contains(keySelector(item))).ToList();

        if (newRecords.Count != 0)
        {
            await dbSet.AddRangeAsync(newRecords);
            await context.SaveChangesAsync();
            Console.WriteLine($"Inserted {newRecords.Count} new records into {name}");
        }
        else
        {
            Console.WriteLine($"No new records found for {name}");
        }
    }

    private static async Task InsertMasterSubIfNotExistsAsync<TMaster, TSub, TDto, TMasterKey, TSubKey>(
        DbSet<TMaster> masterSet,
        DbSet<TSub> subSet,
        IEnumerable<TDto> sourceData,

        Func<TDto, TMaster> masterSelector,
        Func<TDto, IEnumerable<TSub>> subSelector,

        Func<TMaster, TMasterKey> masterKeySelector,
        Func<TSub, TSubKey> subKeySelector,

        Action<TSub, object> setForeignKey,
        Func<TMaster, object> getPrimaryKey,

        string name,
        CLGDbContext context
    )
    where TMaster : class
    where TSub : class
    {
        Console.WriteLine($"Seeding {name} (Master + Sub, safe insert)...");

        // Cache existing data
        var existingMasters = await masterSet.ToListAsync();
        var existingSubs = await subSet.ToListAsync();

        foreach (var dto in sourceData)
        {
            var master = masterSelector(dto);
            var masterKey = masterKeySelector(master);

            // Find or insert master
            var existingMaster = existingMasters
                .FirstOrDefault(m => EqualityComparer<TMasterKey>.Default.Equals(
                    masterKeySelector(m), masterKey));

            if (existingMaster == null)
            {
                await masterSet.AddAsync(master);
                await context.SaveChangesAsync();

                existingMasters.Add(master);
                existingMaster = master;
            }

            var masterId = getPrimaryKey(existingMaster);

            // Handle sub records
            foreach (var sub in subSelector(dto))
            {
                setForeignKey(sub, masterId);

                var subKey = subKeySelector(sub);

                var exists = existingSubs.Any(s =>
                    EqualityComparer<TSubKey>.Default.Equals(subKeySelector(s), subKey));

                if (!exists)
                {
                    await subSet.AddAsync(sub);
                    existingSubs.Add(sub);
                }
            }

            await context.SaveChangesAsync();
        }
    }

    private static async Task SeedMenuTreeAsync(DbSet<MenuMaster> menuSet, IEnumerable<MenuDTO> menus, int? parentId, CLGDbContext context)
    {
        var existingMenus = await menuSet.ToListAsync();

        foreach (var dto in menus)
        {
            var menu = dto.Menu;
            menu.ParentMenuId = parentId;

            var existing = existingMenus.FirstOrDefault(m =>
                m.MenuName == menu.MenuName &&
                m.ParentMenuId == parentId
            );

            if (existing == null)
            {
                await menuSet.AddAsync(menu);
                await context.SaveChangesAsync();

                existingMenus.Add(menu);
                existing = menu;
            }

            if (dto.Children.Any())
            {
                await SeedMenuTreeAsync(
                    menuSet,
                    dto.Children,
                    existing.Id,
                    context
                );
            }
        }
    }

}
