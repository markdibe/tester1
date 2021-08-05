using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace tester1.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountTypes",
                columns: table => new
                {
                    AccountTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dscription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountTypes", x => x.AccountTypeId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "CategoriesByUsers",
                columns: table => new
                {
                    CategoryByUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryByUserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriesByUsers", x => x.CategoryByUserId);
                });

            migrationBuilder.CreateTable(
                name: "Exercices",
                columns: table => new
                {
                    ExerciseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExerciseTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExerciseDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Time = table.Column<TimeSpan>(type: "time", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercices", x => x.ExerciseId);
                });

            migrationBuilder.CreateTable(
                name: "ExercisesCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExercisesCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Injuries",
                columns: table => new
                {
                    InjuriesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InjuryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InjuryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InjuryTreatment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Injuries", x => x.InjuriesId);
                });

            migrationBuilder.CreateTable(
                name: "ListOfMedications",
                columns: table => new
                {
                    MedicationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicationName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListOfMedications", x => x.MedicationId);
                });

            migrationBuilder.CreateTable(
                name: "PathologiesbyTherapists",
                columns: table => new
                {
                    PathologyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PathologyCase = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PathologiesbyTherapists", x => x.PathologyId);
                });

            migrationBuilder.CreateTable(
                name: "PatientGoals",
                columns: table => new
                {
                    PatientGoalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientGoalName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientGoals", x => x.PatientGoalId);
                });

            migrationBuilder.CreateTable(
                name: "Scales",
                columns: table => new
                {
                    ScaleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScaleRate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scales", x => x.ScaleId);
                });

            migrationBuilder.CreateTable(
                name: "SleepingPositions",
                columns: table => new
                {
                    SleepingPositionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SleepingPositionName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SleepingPositions", x => x.SleepingPositionId);
                });

            migrationBuilder.CreateTable(
                name: "SleepingQantities",
                columns: table => new
                {
                    SleepingQuantityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SleepingQuantityName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SleepingQantities", x => x.SleepingQuantityId);
                });

            migrationBuilder.CreateTable(
                name: "SleepingQualities",
                columns: table => new
                {
                    SleepingQualityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SleepingQualityName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SleepingQualities", x => x.SleepingQualityId);
                });

            migrationBuilder.CreateTable(
                name: "Surgeries",
                columns: table => new
                {
                    SurgeryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SurgeryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurgeryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SurgeryTreatment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surgeries", x => x.SurgeryId);
                });

            migrationBuilder.CreateTable(
                name: "TipsCategories",
                columns: table => new
                {
                    TipCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipsCategories", x => x.TipCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "TypesOfPains",
                columns: table => new
                {
                    TypeOfPainId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOfPainName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypesOfPains", x => x.TypeOfPainId);
                });

            migrationBuilder.CreateTable(
                name: "TypesOfResponders",
                columns: table => new
                {
                    TypeOfResponderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOfResponderName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypesOfResponders", x => x.TypeOfResponderId);
                });

            migrationBuilder.CreateTable(
                name: "WaterIntakes",
                columns: table => new
                {
                    WaterIntakeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WaterIntakeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaterIntakes", x => x.WaterIntakeId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActivated = table.Column<bool>(type: "bit", nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Bmi = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DominantHand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountTypeId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_AccountTypes_AccountTypeId",
                        column: x => x.AccountTypeId,
                        principalTable: "AccountTypes",
                        principalColumn: "AccountTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    SubCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.SubCategoryId);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tips",
                columns: table => new
                {
                    TipId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipsImagesId = table.Column<int>(type: "int", nullable: true),
                    TipVideoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipCategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tips", x => x.TipId);
                    table.ForeignKey(
                        name: "FK_Tips_TipsCategories_TipCategoryId",
                        column: x => x.TipCategoryId,
                        principalTable: "TipsCategories",
                        principalColumn: "TipCategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Meetings",
                columns: table => new
                {
                    MeetingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeetingTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeetingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TherapistId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConfirmationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsConfirmed = table.Column<bool>(type: "bit", nullable: true),
                    MeetingDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ApplicationUserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meetings", x => x.MeetingId);
                    table.ForeignKey(
                        name: "FK_Meetings_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Meetings_AspNetUsers_ApplicationUserId1",
                        column: x => x.ApplicationUserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PatientsMoodScales",
                columns: table => new
                {
                    PatientMoodScaleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MoodScaleId = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientsMoodScales", x => x.PatientMoodScaleId);
                    table.ForeignKey(
                        name: "FK_PatientsMoodScales_AspNetUsers_PatientId",
                        column: x => x.PatientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientsMoodScales_Scales_MoodScaleId",
                        column: x => x.MoodScaleId,
                        principalTable: "Scales",
                        principalColumn: "ScaleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PatientsPainScales",
                columns: table => new
                {
                    PatientPainScaleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PainScaleId = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientsPainScales", x => x.PatientPainScaleId);
                    table.ForeignKey(
                        name: "FK_PatientsPainScales_AspNetUsers_PatientId",
                        column: x => x.PatientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientsPainScales_Scales_PainScaleId",
                        column: x => x.PainScaleId,
                        principalTable: "Scales",
                        principalColumn: "ScaleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WaterIntakeRecords",
                columns: table => new
                {
                    WaterIntakeRecordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WaterIntakeId = table.Column<int>(type: "int", nullable: true),
                    PatientId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    NullEvery24Hour = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaterIntakeRecords", x => x.WaterIntakeRecordId);
                    table.ForeignKey(
                        name: "FK_WaterIntakeRecords_AspNetUsers_PatientId",
                        column: x => x.PatientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WaterIntakeRecords_WaterIntakes_WaterIntakeId",
                        column: x => x.WaterIntakeId,
                        principalTable: "WaterIntakes",
                        principalColumn: "WaterIntakeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PatientPrograms",
                columns: table => new
                {
                    PatientProgramId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TherapistId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgramStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProgramEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NumberOfSessions = table.Column<int>(type: "int", nullable: true),
                    InjuryTypeId = table.Column<int>(type: "int", nullable: true),
                    IsSeen = table.Column<bool>(type: "bit", nullable: true),
                    EffortNeeded = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ApplicationUserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientPrograms", x => x.PatientProgramId);
                    table.ForeignKey(
                        name: "FK_PatientPrograms_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientPrograms_AspNetUsers_ApplicationUserId1",
                        column: x => x.ApplicationUserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientPrograms_SubCategories_InjuryTypeId",
                        column: x => x.InjuryTypeId,
                        principalTable: "SubCategories",
                        principalColumn: "SubCategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TipsImages",
                columns: table => new
                {
                    TipImageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipsImages", x => x.TipImageId);
                    table.ForeignKey(
                        name: "FK_TipsImages_Tips_TipId",
                        column: x => x.TipId,
                        principalTable: "Tips",
                        principalColumn: "TipId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Assesments",
                columns: table => new
                {
                    AssesmentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TherapistId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryByUserId = table.Column<int>(type: "int", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    SubCategoryId = table.Column<int>(type: "int", nullable: true),
                    CheifComplaint = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WhenTheProbStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PathologyId = table.Column<int>(type: "int", nullable: true),
                    InjuriesId = table.Column<int>(type: "int", nullable: true),
                    Diseases = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurgeriesId = table.Column<int>(type: "int", nullable: true),
                    CtScan = table.Column<bool>(type: "bit", nullable: true),
                    CtScanUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Xray = table.Column<bool>(type: "bit", nullable: true),
                    XrayUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mri = table.Column<bool>(type: "bit", nullable: true),
                    Mriurl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Report = table.Column<bool>(type: "bit", nullable: true),
                    ReportUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreviousTreatment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medication = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FunctionalImpact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActivityLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Smokes = table.Column<bool>(type: "bit", nullable: true),
                    CigarettesPerDay = table.Column<int>(type: "int", nullable: true),
                    ScaleOfDiscomfortId = table.Column<int>(type: "int", nullable: true),
                    TypeOfResponderId = table.Column<int>(type: "int", nullable: true),
                    SleepingQuantityId = table.Column<int>(type: "int", nullable: true),
                    SleepingQualityId = table.Column<int>(type: "int", nullable: true),
                    SleepingPositionId = table.Column<int>(type: "int", nullable: true),
                    WaterIntakeRecordId = table.Column<int>(type: "int", nullable: true),
                    PsychologicalProblems = table.Column<bool>(type: "bit", nullable: true),
                    PsychologicalProblemsDescrption = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ListOfMedicationsId = table.Column<int>(type: "int", nullable: true),
                    TestedCovidPositive = table.Column<bool>(type: "bit", nullable: true),
                    ExperiencedAnyLoss = table.Column<bool>(type: "bit", nullable: true),
                    SymptomsOfCovid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuinematicUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PatientGoalId = table.Column<int>(type: "int", nullable: true),
                    PatientGoalInput = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeOfPainId = table.Column<int>(type: "int", nullable: true),
                    MaxPainScaleId = table.Column<int>(type: "int", nullable: true),
                    Conclusion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ApplicationUserId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PathologiesByTherapistPathologyId = table.Column<int>(type: "int", nullable: true),
                    ScaleId = table.Column<int>(type: "int", nullable: true),
                    ScaleId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assesments", x => x.AssesmentId);
                    table.ForeignKey(
                        name: "FK_Assesments_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assesments_AspNetUsers_ApplicationUserId1",
                        column: x => x.ApplicationUserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assesments_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assesments_CategoriesByUsers_CategoryByUserId",
                        column: x => x.CategoryByUserId,
                        principalTable: "CategoriesByUsers",
                        principalColumn: "CategoryByUserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assesments_Injuries_InjuriesId",
                        column: x => x.InjuriesId,
                        principalTable: "Injuries",
                        principalColumn: "InjuriesId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assesments_ListOfMedications_ListOfMedicationsId",
                        column: x => x.ListOfMedicationsId,
                        principalTable: "ListOfMedications",
                        principalColumn: "MedicationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assesments_PathologiesbyTherapists_PathologiesByTherapistPathologyId",
                        column: x => x.PathologiesByTherapistPathologyId,
                        principalTable: "PathologiesbyTherapists",
                        principalColumn: "PathologyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assesments_PatientGoals_PatientGoalId",
                        column: x => x.PatientGoalId,
                        principalTable: "PatientGoals",
                        principalColumn: "PatientGoalId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assesments_Scales_ScaleId",
                        column: x => x.ScaleId,
                        principalTable: "Scales",
                        principalColumn: "ScaleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assesments_Scales_ScaleId1",
                        column: x => x.ScaleId1,
                        principalTable: "Scales",
                        principalColumn: "ScaleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assesments_SleepingPositions_SleepingPositionId",
                        column: x => x.SleepingPositionId,
                        principalTable: "SleepingPositions",
                        principalColumn: "SleepingPositionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assesments_SleepingQantities_SleepingQuantityId",
                        column: x => x.SleepingQuantityId,
                        principalTable: "SleepingQantities",
                        principalColumn: "SleepingQuantityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assesments_SleepingQualities_SleepingQualityId",
                        column: x => x.SleepingQualityId,
                        principalTable: "SleepingQualities",
                        principalColumn: "SleepingQualityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assesments_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "SubCategoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assesments_Surgeries_SurgeriesId",
                        column: x => x.SurgeriesId,
                        principalTable: "Surgeries",
                        principalColumn: "SurgeryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assesments_TypesOfPains_TypeOfPainId",
                        column: x => x.TypeOfPainId,
                        principalTable: "TypesOfPains",
                        principalColumn: "TypeOfPainId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assesments_TypesOfResponders_TypeOfResponderId",
                        column: x => x.TypeOfResponderId,
                        principalTable: "TypesOfResponders",
                        principalColumn: "TypeOfResponderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assesments_WaterIntakeRecords_WaterIntakeRecordId",
                        column: x => x.WaterIntakeRecordId,
                        principalTable: "WaterIntakeRecords",
                        principalColumn: "WaterIntakeRecordId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PatientProgramsExercises",
                columns: table => new
                {
                    PatientProgramsExercisesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientProgramId = table.Column<int>(type: "int", nullable: true),
                    ExerciseId = table.Column<int>(type: "int", nullable: true),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: true),
                    Repetition = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientProgramsExercises", x => x.PatientProgramsExercisesId);
                    table.ForeignKey(
                        name: "FK_PatientProgramsExercises_Exercices_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercices",
                        principalColumn: "ExerciseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientProgramsExercises_PatientPrograms_PatientProgramId",
                        column: x => x.PatientProgramId,
                        principalTable: "PatientPrograms",
                        principalColumn: "PatientProgramId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AccountTypeId",
                table: "AspNetUsers",
                column: "AccountTypeId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Assesments_ApplicationUserId",
                table: "Assesments",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Assesments_ApplicationUserId1",
                table: "Assesments",
                column: "ApplicationUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Assesments_CategoryByUserId",
                table: "Assesments",
                column: "CategoryByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Assesments_CategoryId",
                table: "Assesments",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Assesments_InjuriesId",
                table: "Assesments",
                column: "InjuriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Assesments_ListOfMedicationsId",
                table: "Assesments",
                column: "ListOfMedicationsId");

            migrationBuilder.CreateIndex(
                name: "IX_Assesments_PathologiesByTherapistPathologyId",
                table: "Assesments",
                column: "PathologiesByTherapistPathologyId");

            migrationBuilder.CreateIndex(
                name: "IX_Assesments_PatientGoalId",
                table: "Assesments",
                column: "PatientGoalId");

            migrationBuilder.CreateIndex(
                name: "IX_Assesments_ScaleId",
                table: "Assesments",
                column: "ScaleId");

            migrationBuilder.CreateIndex(
                name: "IX_Assesments_ScaleId1",
                table: "Assesments",
                column: "ScaleId1");

            migrationBuilder.CreateIndex(
                name: "IX_Assesments_SleepingPositionId",
                table: "Assesments",
                column: "SleepingPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Assesments_SleepingQualityId",
                table: "Assesments",
                column: "SleepingQualityId");

            migrationBuilder.CreateIndex(
                name: "IX_Assesments_SleepingQuantityId",
                table: "Assesments",
                column: "SleepingQuantityId");

            migrationBuilder.CreateIndex(
                name: "IX_Assesments_SubCategoryId",
                table: "Assesments",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Assesments_SurgeriesId",
                table: "Assesments",
                column: "SurgeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Assesments_TypeOfPainId",
                table: "Assesments",
                column: "TypeOfPainId");

            migrationBuilder.CreateIndex(
                name: "IX_Assesments_TypeOfResponderId",
                table: "Assesments",
                column: "TypeOfResponderId");

            migrationBuilder.CreateIndex(
                name: "IX_Assesments_WaterIntakeRecordId",
                table: "Assesments",
                column: "WaterIntakeRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_ApplicationUserId",
                table: "Meetings",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_ApplicationUserId1",
                table: "Meetings",
                column: "ApplicationUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_PatientPrograms_ApplicationUserId",
                table: "PatientPrograms",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientPrograms_ApplicationUserId1",
                table: "PatientPrograms",
                column: "ApplicationUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_PatientPrograms_InjuryTypeId",
                table: "PatientPrograms",
                column: "InjuryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientProgramsExercises_ExerciseId",
                table: "PatientProgramsExercises",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientProgramsExercises_PatientProgramId",
                table: "PatientProgramsExercises",
                column: "PatientProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientsMoodScales_MoodScaleId",
                table: "PatientsMoodScales",
                column: "MoodScaleId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientsMoodScales_PatientId",
                table: "PatientsMoodScales",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientsPainScales_PainScaleId",
                table: "PatientsPainScales",
                column: "PainScaleId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientsPainScales_PatientId",
                table: "PatientsPainScales",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryId",
                table: "SubCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Tips_TipCategoryId",
                table: "Tips",
                column: "TipCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TipsImages_TipId",
                table: "TipsImages",
                column: "TipId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterIntakeRecords_PatientId",
                table: "WaterIntakeRecords",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterIntakeRecords_WaterIntakeId",
                table: "WaterIntakeRecords",
                column: "WaterIntakeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Assesments");

            migrationBuilder.DropTable(
                name: "ExercisesCategories");

            migrationBuilder.DropTable(
                name: "Meetings");

            migrationBuilder.DropTable(
                name: "PatientProgramsExercises");

            migrationBuilder.DropTable(
                name: "PatientsMoodScales");

            migrationBuilder.DropTable(
                name: "PatientsPainScales");

            migrationBuilder.DropTable(
                name: "TipsImages");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "CategoriesByUsers");

            migrationBuilder.DropTable(
                name: "Injuries");

            migrationBuilder.DropTable(
                name: "ListOfMedications");

            migrationBuilder.DropTable(
                name: "PathologiesbyTherapists");

            migrationBuilder.DropTable(
                name: "PatientGoals");

            migrationBuilder.DropTable(
                name: "SleepingPositions");

            migrationBuilder.DropTable(
                name: "SleepingQantities");

            migrationBuilder.DropTable(
                name: "SleepingQualities");

            migrationBuilder.DropTable(
                name: "Surgeries");

            migrationBuilder.DropTable(
                name: "TypesOfPains");

            migrationBuilder.DropTable(
                name: "TypesOfResponders");

            migrationBuilder.DropTable(
                name: "WaterIntakeRecords");

            migrationBuilder.DropTable(
                name: "Exercices");

            migrationBuilder.DropTable(
                name: "PatientPrograms");

            migrationBuilder.DropTable(
                name: "Scales");

            migrationBuilder.DropTable(
                name: "Tips");

            migrationBuilder.DropTable(
                name: "WaterIntakes");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "TipsCategories");

            migrationBuilder.DropTable(
                name: "AccountTypes");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
