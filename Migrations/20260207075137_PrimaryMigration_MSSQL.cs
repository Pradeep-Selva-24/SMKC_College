using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace College.Migrations
{
    /// <inheritdoc />
    public partial class PrimaryMigration_MSSQL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "CLG");

            migrationBuilder.CreateTable(
                name: "AQARReport",
                schema: "CLG",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    S_AcademicYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_ReportTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    I_Order = table.Column<int>(type: "int", nullable: false),
                    S_CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D_CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    S_ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D_ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    B_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AQARReport", x => x.I_Id);
                });

            migrationBuilder.CreateTable(
                name: "CampusInfo",
                schema: "CLG",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    S_Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    I_Count = table.Column<int>(type: "int", nullable: false),
                    S_CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D_CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    S_ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D_ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    B_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampusInfo", x => x.I_Id);
                });

            migrationBuilder.CreateTable(
                name: "ClubsMaster",
                schema: "CLG",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    S_Clubs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    I_DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    S_CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D_CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    S_ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D_ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    B_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubsMaster", x => x.I_Id);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentsMaster",
                schema: "CLG",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    S_Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    I_Order = table.Column<int>(type: "int", nullable: false),
                    S_CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D_CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    S_ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D_ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    B_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentsMaster", x => x.I_Id);
                });

            migrationBuilder.CreateTable(
                name: "InstitutionPages",
                schema: "CLG",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    S_PageType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_Heading = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D_CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    S_ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D_ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    B_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstitutionPages", x => x.I_Id);
                });

            migrationBuilder.CreateTable(
                name: "IQACMembers",
                schema: "CLG",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    S_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    I_Order = table.Column<int>(type: "int", nullable: false),
                    S_CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D_CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    S_ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D_ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    B_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IQACMembers", x => x.I_Id);
                });

            migrationBuilder.CreateTable(
                name: "Login",
                schema: "CLG",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    S_UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D_LastLogin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    D_IsActive = table.Column<bool>(type: "bit", nullable: false),
                    D_CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    S_CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D_CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    S_ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D_ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    B_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.I_Id);
                });

            migrationBuilder.CreateTable(
                name: "Management",
                schema: "CLG",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    S_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    I_DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    S_CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D_CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    S_ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D_ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    B_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Management", x => x.I_Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuMaster",
                schema: "CLG",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    F_ParentMenuId = table.Column<int>(type: "int", nullable: true),
                    S_MenuName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_MenuUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    B_Display = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    I_Order = table.Column<int>(type: "int", nullable: false),
                    S_CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D_CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    S_ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D_ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    B_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuMaster", x => x.I_Id);
                    table.ForeignKey(
                        name: "FK_MenuMaster_MenuMaster_F_ParentMenuId",
                        column: x => x.F_ParentMenuId,
                        principalSchema: "CLG",
                        principalTable: "MenuMaster",
                        principalColumn: "I_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NACDetails",
                schema: "CLG",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    S_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    I_Order = table.Column<int>(type: "int", nullable: false),
                    S_CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D_CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    S_ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D_ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    B_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NACDetails", x => x.I_Id);
                });

            migrationBuilder.CreateTable(
                name: "NACDocument",
                schema: "CLG",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    S_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    I_Order = table.Column<int>(type: "int", nullable: false),
                    S_CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D_CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    S_ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D_ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    B_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NACDocument", x => x.I_Id);
                });

            migrationBuilder.CreateTable(
                name: "NIRFDetails",
                schema: "CLG",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    S_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    I_Order = table.Column<int>(type: "int", nullable: false),
                    S_CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D_CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    S_ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D_ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    B_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NIRFDetails", x => x.I_Id);
                });

            migrationBuilder.CreateTable(
                name: "NIRFDocument",
                schema: "CLG",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    S_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    I_Year = table.Column<int>(type: "int", nullable: false),
                    S_Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D_CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    S_ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D_ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    B_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NIRFDocument", x => x.I_Id);
                });

            migrationBuilder.CreateTable(
                name: "NIRFDocumentRanking",
                schema: "CLG",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    I_Year = table.Column<int>(type: "int", nullable: false),
                    S_Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_ParticipationStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_Score = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D_CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    S_ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D_ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    B_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NIRFDocumentRanking", x => x.I_Id);
                });

            migrationBuilder.CreateTable(
                name: "PageMedia",
                schema: "CLG",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    S_Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_Heading = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    S_ShortContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    I_DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    S_CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D_CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    S_ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D_ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    B_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageMedia", x => x.I_Id);
                });

            migrationBuilder.CreateTable(
                name: "PlacementContact",
                schema: "CLG",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    S_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    I_DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    S_CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D_CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    S_ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D_ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    B_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlacementContact", x => x.I_Id);
                });

            migrationBuilder.CreateTable(
                name: "ProgrammesOffered",
                schema: "CLG",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    S_Course = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_StudentCount = table.Column<int>(type: "int", nullable: false),
                    S_SyllabusPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    I_Order = table.Column<int>(type: "int", nullable: false),
                    S_CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D_CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    S_ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D_ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    B_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgrammesOffered", x => x.I_Id);
                });

            migrationBuilder.CreateTable(
                name: "SettingMaster",
                schema: "CLG",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    S_Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D_CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    S_ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D_ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    B_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SettingMaster", x => x.I_Id);
                });

            migrationBuilder.CreateTable(
                name: "ClubsDetails",
                schema: "CLG",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    F_ClubsMasterId = table.Column<int>(type: "int", nullable: false),
                    S_Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_Heading = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_ShortContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    I_DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    S_CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D_CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    S_ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D_ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    B_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubsDetails", x => x.I_Id);
                    table.ForeignKey(
                        name: "FK_ClubsDetails_ClubsMaster_F_ClubsMasterId",
                        column: x => x.F_ClubsMasterId,
                        principalSchema: "CLG",
                        principalTable: "ClubsMaster",
                        principalColumn: "I_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentsDetails",
                schema: "CLG",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    F_DepartmentsMasterId = table.Column<int>(type: "int", nullable: false),
                    S_Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_Heading = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_ShortContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    I_DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    S_CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D_CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    S_ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D_ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    B_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentsDetails", x => x.I_Id);
                    table.ForeignKey(
                        name: "FK_DepartmentsDetails_DepartmentsMaster_F_DepartmentsMasterId",
                        column: x => x.F_DepartmentsMasterId,
                        principalSchema: "CLG",
                        principalTable: "DepartmentsMaster",
                        principalColumn: "I_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentsMembers",
                schema: "CLG",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    F_DepartmentsMasterId = table.Column<int>(type: "int", nullable: false),
                    S_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    I_Order = table.Column<int>(type: "int", nullable: false),
                    S_CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D_CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    S_ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D_ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    B_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentsMembers", x => x.I_Id);
                    table.ForeignKey(
                        name: "FK_DepartmentsMembers_DepartmentsMaster_F_DepartmentsMasterId",
                        column: x => x.F_DepartmentsMasterId,
                        principalSchema: "CLG",
                        principalTable: "DepartmentsMaster",
                        principalColumn: "I_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ManagementContent",
                schema: "CLG",
                columns: table => new
                {
                    I_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    F_ManagementId = table.Column<int>(type: "int", nullable: false),
                    S_Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    S_CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    D_CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    S_ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    D_ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    B_Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagementContent", x => x.I_Id);
                    table.ForeignKey(
                        name: "FK_ManagementContent_Management_F_ManagementId",
                        column: x => x.F_ManagementId,
                        principalSchema: "CLG",
                        principalTable: "Management",
                        principalColumn: "I_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClubsDetails_F_ClubsMasterId",
                schema: "CLG",
                table: "ClubsDetails",
                column: "F_ClubsMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentsDetails_F_DepartmentsMasterId",
                schema: "CLG",
                table: "DepartmentsDetails",
                column: "F_DepartmentsMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentsMembers_F_DepartmentsMasterId",
                schema: "CLG",
                table: "DepartmentsMembers",
                column: "F_DepartmentsMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_ManagementContent_F_ManagementId",
                schema: "CLG",
                table: "ManagementContent",
                column: "F_ManagementId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuMaster_F_ParentMenuId",
                schema: "CLG",
                table: "MenuMaster",
                column: "F_ParentMenuId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AQARReport",
                schema: "CLG");

            migrationBuilder.DropTable(
                name: "CampusInfo",
                schema: "CLG");

            migrationBuilder.DropTable(
                name: "ClubsDetails",
                schema: "CLG");

            migrationBuilder.DropTable(
                name: "DepartmentsDetails",
                schema: "CLG");

            migrationBuilder.DropTable(
                name: "DepartmentsMembers",
                schema: "CLG");

            migrationBuilder.DropTable(
                name: "InstitutionPages",
                schema: "CLG");

            migrationBuilder.DropTable(
                name: "IQACMembers",
                schema: "CLG");

            migrationBuilder.DropTable(
                name: "Login",
                schema: "CLG");

            migrationBuilder.DropTable(
                name: "ManagementContent",
                schema: "CLG");

            migrationBuilder.DropTable(
                name: "MenuMaster",
                schema: "CLG");

            migrationBuilder.DropTable(
                name: "NACDetails",
                schema: "CLG");

            migrationBuilder.DropTable(
                name: "NACDocument",
                schema: "CLG");

            migrationBuilder.DropTable(
                name: "NIRFDetails",
                schema: "CLG");

            migrationBuilder.DropTable(
                name: "NIRFDocument",
                schema: "CLG");

            migrationBuilder.DropTable(
                name: "NIRFDocumentRanking",
                schema: "CLG");

            migrationBuilder.DropTable(
                name: "PageMedia",
                schema: "CLG");

            migrationBuilder.DropTable(
                name: "PlacementContact",
                schema: "CLG");

            migrationBuilder.DropTable(
                name: "ProgrammesOffered",
                schema: "CLG");

            migrationBuilder.DropTable(
                name: "SettingMaster",
                schema: "CLG");

            migrationBuilder.DropTable(
                name: "ClubsMaster",
                schema: "CLG");

            migrationBuilder.DropTable(
                name: "DepartmentsMaster",
                schema: "CLG");

            migrationBuilder.DropTable(
                name: "Management",
                schema: "CLG");
        }
    }
}
