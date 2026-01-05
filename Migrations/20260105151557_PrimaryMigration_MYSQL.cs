using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace College.Migrations
{
    /// <inheritdoc />
    public partial class PrimaryMigration_MYSQL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CLG.AQARReport",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    S_AcademicYear = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    S_ReportTitle = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    S_FilePath = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    I_Order = table.Column<int>(type: "int", nullable: false),
                    S_CreatedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    D_CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    S_ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    D_ModifiedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    B_Status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLG.AQARReport", x => x.I_Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CLG.CampusInfo",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    S_Category = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    I_Count = table.Column<int>(type: "int", nullable: false),
                    S_CreatedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    D_CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    S_ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    D_ModifiedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    B_Status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLG.CampusInfo", x => x.I_Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CLG.ClubsMaster",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    S_Clubs = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    I_DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    S_CreatedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    D_CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    S_ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    D_ModifiedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    B_Status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLG.ClubsMaster", x => x.I_Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CLG.DepartmentsMaster",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    S_Department = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    S_Category = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    S_ImagePath = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    S_Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    S_SyllabusPath = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    I_Order = table.Column<int>(type: "int", nullable: false),
                    S_CreatedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    D_CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    S_ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    D_ModifiedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    B_Status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLG.DepartmentsMaster", x => x.I_Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CLG.InstitutionPages",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    S_PageType = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    S_Heading = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    S_Content = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    S_CreatedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    D_CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    S_ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    D_ModifiedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    B_Status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLG.InstitutionPages", x => x.I_Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CLG.IQACMembers",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    S_Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    S_Designation = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    S_Role = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    I_Order = table.Column<int>(type: "int", nullable: false),
                    S_CreatedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    D_CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    S_ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    D_ModifiedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    B_Status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLG.IQACMembers", x => x.I_Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CLG.Login",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    S_UserId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    S_Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    D_LastLogin = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    S_CreatedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    D_CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    S_ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    D_ModifiedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    B_Status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLG.Login", x => x.I_Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CLG.Management",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    S_Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    S_Designation = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    I_DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    S_CreatedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    D_CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    S_ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    D_ModifiedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    B_Status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLG.Management", x => x.I_Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CLG.MenuMaster",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    F_ParentMenuId = table.Column<int>(type: "int", nullable: true),
                    S_MenuName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    S_MenuUrl = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    B_Display = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    I_Order = table.Column<int>(type: "int", nullable: false),
                    S_CreatedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    D_CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    S_ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    D_ModifiedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    B_Status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLG.MenuMaster", x => x.I_Id);
                    table.ForeignKey(
                        name: "FK_CLG.MenuMaster_CLG.MenuMaster_F_ParentMenuId",
                        column: x => x.F_ParentMenuId,
                        principalTable: "CLG.MenuMaster",
                        principalColumn: "I_Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CLG.NACDetails",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    S_Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    S_description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    I_Order = table.Column<int>(type: "int", nullable: false),
                    S_CreatedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    D_CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    S_ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    D_ModifiedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    B_Status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLG.NACDetails", x => x.I_Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CLG.NACDocument",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    S_Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    S_Path = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    I_Order = table.Column<int>(type: "int", nullable: false),
                    S_CreatedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    D_CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    S_ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    D_ModifiedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    B_Status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLG.NACDocument", x => x.I_Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CLG.NIRFDetails",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    S_Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    S_description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    I_Order = table.Column<int>(type: "int", nullable: false),
                    S_CreatedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    D_CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    S_ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    D_ModifiedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    B_Status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLG.NIRFDetails", x => x.I_Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CLG.NIRFDocument",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    S_Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    S_Path = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    I_Order = table.Column<int>(type: "int", nullable: false),
                    S_CreatedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    D_CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    S_ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    D_ModifiedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    B_Status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLG.NIRFDocument", x => x.I_Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CLG.NIRFDocumentRanking",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    I_Year = table.Column<int>(type: "int", nullable: false),
                    S_Category = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    S_ParticipationStatus = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    S_Score = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    S_CreatedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    D_CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    S_ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    D_ModifiedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    B_Status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLG.NIRFDocumentRanking", x => x.I_Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CLG.PageMedia",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    S_Category = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    S_ImagePath = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    S_Heading = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    S_ShortContent = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    D_Date = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    I_DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    S_CreatedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    D_CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    S_ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    D_ModifiedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    B_Status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLG.PageMedia", x => x.I_Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CLG.ClubsDetails",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    F_ClubsMasterId = table.Column<int>(type: "int", nullable: false),
                    S_Category = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    S_ImagePath = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    S_Heading = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    S_ShortContent = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    I_DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    S_CreatedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    D_CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    S_ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    D_ModifiedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    B_Status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLG.ClubsDetails", x => x.I_Id);
                    table.ForeignKey(
                        name: "FK_CLG.ClubsDetails_CLG.ClubsMaster_F_ClubsMasterId",
                        column: x => x.F_ClubsMasterId,
                        principalTable: "CLG.ClubsMaster",
                        principalColumn: "I_Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CLG.DepartmentsDetails",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    F_DepartmentsMasterId = table.Column<int>(type: "int", nullable: false),
                    S_Category = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    S_ImagePath = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    S_Heading = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    S_ShortContent = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    I_DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    S_CreatedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    D_CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    S_ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    D_ModifiedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    B_Status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLG.DepartmentsDetails", x => x.I_Id);
                    table.ForeignKey(
                        name: "FK_CLG.DepartmentsDetails_CLG.DepartmentsMaster_F_DepartmentsMa~",
                        column: x => x.F_DepartmentsMasterId,
                        principalTable: "CLG.DepartmentsMaster",
                        principalColumn: "I_Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CLG.DepartmentsMembers",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    F_DepartmentsMasterId = table.Column<int>(type: "int", nullable: false),
                    S_Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    S_Designation = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    S_ImagePath = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    I_Order = table.Column<int>(type: "int", nullable: false),
                    S_CreatedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    D_CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    S_ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    D_ModifiedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    B_Status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLG.DepartmentsMembers", x => x.I_Id);
                    table.ForeignKey(
                        name: "FK_CLG.DepartmentsMembers_CLG.DepartmentsMaster_F_DepartmentsMa~",
                        column: x => x.F_DepartmentsMasterId,
                        principalTable: "CLG.DepartmentsMaster",
                        principalColumn: "I_Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CLG.ManagementContent",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    F_ManagementId = table.Column<int>(type: "int", nullable: false),
                    S_Content = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    S_CreatedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    D_CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    S_ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    D_ModifiedDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    B_Status = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLG.ManagementContent", x => x.I_Id);
                    table.ForeignKey(
                        name: "FK_CLG.ManagementContent_CLG.Management_F_ManagementId",
                        column: x => x.F_ManagementId,
                        principalTable: "CLG.Management",
                        principalColumn: "I_Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_CLG.ClubsDetails_F_ClubsMasterId",
                table: "CLG.ClubsDetails",
                column: "F_ClubsMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_CLG.DepartmentsDetails_F_DepartmentsMasterId",
                table: "CLG.DepartmentsDetails",
                column: "F_DepartmentsMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_CLG.DepartmentsMembers_F_DepartmentsMasterId",
                table: "CLG.DepartmentsMembers",
                column: "F_DepartmentsMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_CLG.ManagementContent_F_ManagementId",
                table: "CLG.ManagementContent",
                column: "F_ManagementId");

            migrationBuilder.CreateIndex(
                name: "IX_CLG.MenuMaster_F_ParentMenuId",
                table: "CLG.MenuMaster",
                column: "F_ParentMenuId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CLG.AQARReport");

            migrationBuilder.DropTable(
                name: "CLG.CampusInfo");

            migrationBuilder.DropTable(
                name: "CLG.ClubsDetails");

            migrationBuilder.DropTable(
                name: "CLG.DepartmentsDetails");

            migrationBuilder.DropTable(
                name: "CLG.DepartmentsMembers");

            migrationBuilder.DropTable(
                name: "CLG.InstitutionPages");

            migrationBuilder.DropTable(
                name: "CLG.IQACMembers");

            migrationBuilder.DropTable(
                name: "CLG.Login");

            migrationBuilder.DropTable(
                name: "CLG.ManagementContent");

            migrationBuilder.DropTable(
                name: "CLG.MenuMaster");

            migrationBuilder.DropTable(
                name: "CLG.NACDetails");

            migrationBuilder.DropTable(
                name: "CLG.NACDocument");

            migrationBuilder.DropTable(
                name: "CLG.NIRFDetails");

            migrationBuilder.DropTable(
                name: "CLG.NIRFDocument");

            migrationBuilder.DropTable(
                name: "CLG.NIRFDocumentRanking");

            migrationBuilder.DropTable(
                name: "CLG.PageMedia");

            migrationBuilder.DropTable(
                name: "CLG.ClubsMaster");

            migrationBuilder.DropTable(
                name: "CLG.DepartmentsMaster");

            migrationBuilder.DropTable(
                name: "CLG.Management");
        }
    }
}
