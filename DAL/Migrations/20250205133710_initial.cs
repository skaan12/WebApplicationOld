using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Biography = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.ID);
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
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentCategoryID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Couriers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Couriers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Directors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Biography = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Memberships",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    PackageName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MontlyFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FilmLimit = table.Column<int>(type: "int", nullable: false),
                    FilmPerExchange = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Memberships", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SpecialCategories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialCategories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.ID);
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
                name: "Deliveries",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CourierID = table.Column<int>(type: "int", nullable: false),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeliveryStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deliveries", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Deliveries_Couriers_CourierID",
                        column: x => x.CourierID,
                        principalTable: "Couriers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditCardNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditCardExpDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CVC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MembershipID = table.Column<int>(type: "int", nullable: true),
                    MembershipDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MembershipStatus = table.Column<int>(type: "int", nullable: true),
                    UserType = table.Column<int>(type: "int", nullable: true),
                    DataStatus = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MembershipType = table.Column<int>(type: "int", nullable: true),
                    PaymentMethod = table.Column<int>(type: "int", nullable: true),
                    PaymentStatus = table.Column<int>(type: "int", nullable: true),
                    DeliveryStatus = table.Column<int>(type: "int", nullable: true),
                    NotificationType = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Memberships_MembershipID",
                        column: x => x.MembershipID,
                        principalTable: "Memberships",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    FilmName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginalName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Director = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Actors = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subtitles = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrailerURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Supplier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockInQuantity = table.Column<int>(type: "int", nullable: true),
                    SpecialCategoryID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Films_SpecialCategories_SpecialCategoryID",
                        column: x => x.SpecialCategoryID,
                        principalTable: "SpecialCategories",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    SupplierID = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Method = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Payments_Suppliers_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Suppliers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryPlans",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DeliveryID = table.Column<int>(type: "int", nullable: false),
                    PlannedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActualDeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeliveryStatus = table.Column<int>(type: "int", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryPlans", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DeliveryPlans_Deliveries_DeliveryID",
                        column: x => x.DeliveryID,
                        principalTable: "Deliveries",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                name: "Notifications",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: true),
                    NotificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NotificationType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Notifications_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Deliveries_DeliveryID",
                        column: x => x.DeliveryID,
                        principalTable: "Deliveries",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Awards",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    FilmID = table.Column<int>(type: "int", nullable: false),
                    AwardName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WinnerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AwardDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Awards", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Awards_Films_FilmID",
                        column: x => x.FilmID,
                        principalTable: "Films",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryFilms",
                columns: table => new
                {
                    FilmID = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    FirstID = table.Column<int>(type: "int", nullable: false),
                    SecondID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryFilms", x => new { x.CategoryID, x.FilmID });
                    table.ForeignKey(
                        name: "FK_CategoryFilms_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryFilms_Films_FilmID",
                        column: x => x.FilmID,
                        principalTable: "Films",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    FilmID = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Films_FilmID",
                        column: x => x.FilmID,
                        principalTable: "Films",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmArtists",
                columns: table => new
                {
                    FilmID = table.Column<int>(type: "int", nullable: false),
                    ArtistID = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstID = table.Column<int>(type: "int", nullable: false),
                    SecondID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmArtists", x => new { x.FilmID, x.ArtistID });
                    table.ForeignKey(
                        name: "FK_FilmArtists_Artists_ArtistID",
                        column: x => x.ArtistID,
                        principalTable: "Artists",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmArtists_Films_FilmID",
                        column: x => x.FilmID,
                        principalTable: "Films",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmDirectors",
                columns: table => new
                {
                    FilmID = table.Column<int>(type: "int", nullable: false),
                    DirectorID = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstID = table.Column<int>(type: "int", nullable: false),
                    SecondID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmDirectors", x => new { x.DirectorID, x.FilmID });
                    table.ForeignKey(
                        name: "FK_FilmDirectors_Directors_DirectorID",
                        column: x => x.DirectorID,
                        principalTable: "Directors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmDirectors_Films_FilmID",
                        column: x => x.FilmID,
                        principalTable: "Films",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    FilmID = table.Column<int>(type: "int", nullable: false),
                    StockCount = table.Column<int>(type: "int", nullable: true),
                    DamagedCount = table.Column<int>(type: "int", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SupplierID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Inventories_Films_FilmID",
                        column: x => x.FilmID,
                        principalTable: "Films",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inventories_Suppliers_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Suppliers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    FilmID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Score = table.Column<double>(type: "float", nullable: false),
                    Review = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Ratings_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ratings_Films_FilmID",
                        column: x => x.FilmID,
                        principalTable: "Films",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupplierFilms",
                columns: table => new
                {
                    SupplierID = table.Column<int>(type: "int", nullable: false),
                    FilmID = table.Column<int>(type: "int", nullable: false),
                    SuppliedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    FirstID = table.Column<int>(type: "int", nullable: false),
                    SecondID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierFilms", x => new { x.SupplierID, x.FilmID });
                    table.ForeignKey(
                        name: "FK_SupplierFilms_Films_FilmID",
                        column: x => x.FilmID,
                        principalTable: "Films",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFilms_Suppliers_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Suppliers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserFilmLists",
                columns: table => new
                {
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FilmID = table.Column<int>(type: "int", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFilmLists", x => new { x.UserID, x.FilmID });
                    table.ForeignKey(
                        name: "FK_UserFilmLists_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFilmLists_Films_FilmID",
                        column: x => x.FilmID,
                        principalTable: "Films",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserFilmRentals",
                columns: table => new
                {
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FilmID = table.Column<int>(type: "int", nullable: false),
                    RentalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RentalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsReturned = table.Column<bool>(type: "bit", nullable: false),
                    FirstID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFilmRentals", x => new { x.UserID, x.FilmID });
                    table.ForeignKey(
                        name: "FK_UserFilmRentals_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFilmRentals_Films_FilmID",
                        column: x => x.FilmID,
                        principalTable: "Films",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserWatchLists",
                columns: table => new
                {
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FilmID = table.Column<int>(type: "int", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserWatchLists", x => new { x.UserID, x.FilmID });
                    table.ForeignKey(
                        name: "FK_UserWatchLists_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserWatchLists_Films_FilmID",
                        column: x => x.FilmID,
                        principalTable: "Films",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    FilmID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Films_FilmID",
                        column: x => x.FilmID,
                        principalTable: "Films",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FaultyFilms",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    FilmID = table.Column<int>(type: "int", nullable: false),
                    TestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FilmStatus = table.Column<int>(type: "int", nullable: true),
                    InventoryID = table.Column<int>(type: "int", nullable: false),
                    FirstID = table.Column<int>(type: "int", nullable: false),
                    SecondID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaultyFilms", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FaultyFilms_Films_FilmID",
                        column: x => x.FilmID,
                        principalTable: "Films",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_FaultyFilms_Inventories_InventoryID",
                        column: x => x.InventoryID,
                        principalTable: "Inventories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "ID", "Actors", "Category", "ComputerName", "CreatedDate", "CreatedIpAdress", "Description", "Director", "FilmName", "Language", "OriginalName", "SpecialCategoryID", "Status", "StockInQuantity", "Subtitles", "Supplier", "TrailerURL", "UpdatedComputerName", "UpdatedIpAdress", "UpdatedTime", "Year" },
                values: new object[,]
                {
                    { 31, "Carroll Schaden,Bette Leuschke,Julie Willms", "Scifi", "DESKTOP-P8K1SK9", new DateTime(2025, 2, 5, 16, 37, 9, 990, DateTimeKind.Local).AddTicks(7984), "192.168.56.1", "Culpa recusandae nihil beatae et ut dicta vitae consequatur harum.", "Emily Breitenberg", "Handcrafted Fresh Soap", "Spanish", "Tasty Frozen TunaOriginal", null, 0, 85, "Spanish", "Von, Casper and Welch", "http://casper.info", null, null, null, new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 32, "Freddy Wuckert,Nia Ortiz,Dejuan Flatley", "Comedy", "DESKTOP-P8K1SK9", new DateTime(2025, 2, 5, 16, 37, 9, 991, DateTimeKind.Local).AddTicks(7207), "192.168.56.1", "İn itaque voluptas aliquam itaque non sint corporis excepturi dicta.", "Kelli Schumm", "Unbranded Metal Chips", "English", "Unbranded Steel SaladOriginal", null, 0, 93, "English", "Wintheiser LLC", "http://novella.net", null, null, null, new DateTime(2000, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 33, "Sydney Kutch,Fernando Ortiz,Kelley Hudson", "Comedy", "DESKTOP-P8K1SK9", new DateTime(2025, 2, 5, 16, 37, 9, 992, DateTimeKind.Local).AddTicks(1419), "192.168.56.1", "Saepe eum et id porro voluptates voluptas sed libero culpa.", "Roy Bahringer", "Licensed Rubber Ball", "English", "Unbranded Cotton FishOriginal", null, 0, 91, "Spanish", "Hickle - Cartwright", "https://bill.org", null, null, null, new DateTime(2002, 11, 24, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 34, "Rebecca Cremin,Ora Kunze,Rafael Heathcote", "Scifi", "DESKTOP-P8K1SK9", new DateTime(2025, 2, 5, 16, 37, 9, 992, DateTimeKind.Local).AddTicks(4890), "192.168.56.1", "Consequuntur ut suscipit voluptas dolore occaecati sunt maxime illo iste.", "Demond Lubowitz", "Licensed Granite Soap", "Spanish", "Rustic Soft ShirtOriginal", null, 0, 52, "English", "Walter - Stanton", "https://lavonne.info", null, null, null, new DateTime(2018, 2, 25, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 35, "Zella Mosciski,Aaliyah Hegmann,Wanda Auer", "Action", "DESKTOP-P8K1SK9", new DateTime(2025, 2, 5, 16, 37, 9, 992, DateTimeKind.Local).AddTicks(8198), "192.168.56.1", "Accusantium libero porro sit deserunt tempora qui sunt sit exercitationem.", "King Kilback", "Fantastic Fresh Bacon", "English", "Small Rubber CarOriginal", null, 0, 5, "English", "Lebsack - Carter", "https://earl.com", null, null, null, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 36, "Lenny Hayes,Cecelia Deckow,Odell McClure", "Horror", "DESKTOP-P8K1SK9", new DateTime(2025, 2, 5, 16, 37, 9, 993, DateTimeKind.Local).AddTicks(1401), "192.168.56.1", "Error ut iste rerum aperiam odio sapiente quis ab aut.", "Verna Price", "Ergonomic Metal Fish", "English", "Handmade Granite FishOriginal", null, 0, 10, "English", "Dooley - Stiedemann", "http://malcolm.org", null, null, null, new DateTime(2006, 12, 20, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 37, "Kirstin Flatley,Edgar Anderson,Hilton Adams", "Action", "DESKTOP-P8K1SK9", new DateTime(2025, 2, 5, 16, 37, 9, 993, DateTimeKind.Local).AddTicks(4611), "192.168.56.1", "Eum necessitatibus et perspiciatis corrupti labore qui magnam et labore.", "Noemy Greenfelder", "Handmade Plastic Tuna", "French", "Practical Steel ChipsOriginal", null, 0, 22, "French", "Harber - Beatty", "https://garland.com", null, null, null, new DateTime(2008, 1, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 38, "Hermann Jaskolski,Xzavier Johns,Dante Kemmer", "Drama", "DESKTOP-P8K1SK9", new DateTime(2025, 2, 5, 16, 37, 9, 993, DateTimeKind.Local).AddTicks(7929), "192.168.56.1", "Eveniet accusantium explicabo non et sunt a rerum sit est.", "Morgan Gottlieb", "Licensed Steel Fish", "French", "Refined Soft CheeseOriginal", null, 0, 95, "English", "Krajcik LLC", "https://vena.net", null, null, null, new DateTime(2005, 7, 7, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 39, "Alyson Lynch,Silas Larson,Domenico Grady", "Comedy", "DESKTOP-P8K1SK9", new DateTime(2025, 2, 5, 16, 37, 9, 994, DateTimeKind.Local).AddTicks(1111), "192.168.56.1", "Porro et corrupti iusto deleniti vel quia consequatur a nostrum.", "Annie Hartmann", "Tasty Soft Shirt", "Spanish", "Unbranded Frozen CarOriginal", null, 0, 2, "English", "Rice, Turcotte and Howell", "https://newton.org", null, null, null, new DateTime(2012, 1, 13, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 40, "Raymundo Hilpert,Earnestine Kris,Kassandra Hintz", "Scifi", "DESKTOP-P8K1SK9", new DateTime(2025, 2, 5, 16, 37, 9, 994, DateTimeKind.Local).AddTicks(4338), "192.168.56.1", "Voluptatem officiis maxime quibusdam dicta esse quo sit rerum quia.", "Zane Smitham", "Generic Plastic Shirt", "English", "Handcrafted Fresh CheeseOriginal", null, 0, 73, "English", "Donnelly, Dibbert and Rogahn", "http://conrad.org", null, null, null, new DateTime(1998, 7, 3, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 41, "Davon Prohaska,Clotilde Feil,Zackary Simonis", "Comedy", "DESKTOP-P8K1SK9", new DateTime(2025, 2, 5, 16, 37, 9, 994, DateTimeKind.Local).AddTicks(7487), "192.168.56.1", "Laborum accusantium voluptatem quibusdam eum vero dolores tenetur fugit et.", "Leonie Rolfson", "Small Soft Bike", "French", "Unbranded Frozen ComputerOriginal", null, 0, 13, "Spanish", "Monahan - Gleichner", "http://caesar.name", null, null, null, new DateTime(2002, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 42, "Lura Mante,Audreanne Kihn,Howard Haag", "Drama", "DESKTOP-P8K1SK9", new DateTime(2025, 2, 5, 16, 37, 9, 995, DateTimeKind.Local).AddTicks(557), "192.168.56.1", "Enim quam minus voluptatum minus omnis dolore rem aut necessitatibus.", "Anahi Nitzsche", "Small Granite Tuna", "English", "Refined Fresh ChipsOriginal", null, 0, 58, "French", "Kautzer and Sons", "https://bailey.org", null, null, null, new DateTime(2014, 7, 25, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 43, "Van Zulauf,Nola Goyette,Elinore Hettinger", "Scifi", "DESKTOP-P8K1SK9", new DateTime(2025, 2, 5, 16, 37, 9, 995, DateTimeKind.Local).AddTicks(3711), "192.168.56.1", "İtaque occaecati error ullam sint alias eos quis velit autem.", "Fritz Ortiz", "Unbranded Plastic Keyboard", "German", "Licensed Fresh BallOriginal", null, 0, 23, "Spanish", "Feil - Jerde", "https://jane.net", null, null, null, new DateTime(2004, 12, 15, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 44, "Dejuan Johns,Samantha Haag,Vaughn Conn", "Scifi", "DESKTOP-P8K1SK9", new DateTime(2025, 2, 5, 16, 37, 9, 995, DateTimeKind.Local).AddTicks(6814), "192.168.56.1", "Eum in cumque consequatur inventore earum quia illo exercitationem quo.", "Brennan Langworth", "Intelligent Frozen Keyboard", "French", "Refined Plastic TunaOriginal", null, 0, 13, "French", "Deckow - Douglas", "https://pinkie.com", null, null, null, new DateTime(1998, 4, 6, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 45, "Daphnee Pollich,Ara Schinner,Wilfredo Connelly", "Horror", "DESKTOP-P8K1SK9", new DateTime(2025, 2, 5, 16, 37, 9, 995, DateTimeKind.Local).AddTicks(9917), "192.168.56.1", "Odio ut excepturi saepe expedita non porro dicta dolorem voluptates.", "Kayley Weissnat", "Unbranded Plastic Mouse", "French", "Unbranded Cotton ChipsOriginal", null, 0, 14, "Spanish", "Wilkinson Group", "http://juliana.info", null, null, null, new DateTime(2014, 4, 20, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 46, "Salvador Lockman,Shemar Renner,Jess Christiansen", "Horror", "DESKTOP-P8K1SK9", new DateTime(2025, 2, 5, 16, 37, 9, 996, DateTimeKind.Local).AddTicks(3030), "192.168.56.1", "Est soluta numquam rerum aperiam maiores voluptatum ducimus ipsum possimus.", "Cassidy Effertz", "Ergonomic Fresh Towels", "French", "Gorgeous Plastic ComputerOriginal", null, 0, 19, "German", "Crist, Rodriguez and Simonis", "https://marcia.net", null, null, null, new DateTime(2008, 7, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 47, "Deshaun Pagac,Jairo Crona,Velma Cronin", "Scifi", "DESKTOP-P8K1SK9", new DateTime(2025, 2, 5, 16, 37, 9, 996, DateTimeKind.Local).AddTicks(6598), "192.168.56.1", "Recusandae aliquid ea minima deleniti aut numquam in aut modi.", "Rhiannon Rogahn", "Handcrafted Concrete Chips", "Spanish", "Licensed Soft PantsOriginal", null, 0, 89, "French", "Torp Group", "https://ara.com", null, null, null, new DateTime(2004, 11, 10, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 48, "Destiney Barrows,Kathlyn Hudson,Margarette Kunde", "Scifi", "DESKTOP-P8K1SK9", new DateTime(2025, 2, 5, 16, 37, 9, 996, DateTimeKind.Local).AddTicks(9722), "192.168.56.1", "Provident eveniet amet doloribus id quam esse ratione excepturi quidem.", "Dewitt Schmidt", "Rustic Cotton Cheese", "Spanish", "Handmade Frozen CarOriginal", null, 0, 32, "French", "Brown - Anderson", "http://johanna.biz", null, null, null, new DateTime(2001, 8, 31, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 49, "Alisa Grimes,Christ Miller,Kendrick Kuhlman", "Action", "DESKTOP-P8K1SK9", new DateTime(2025, 2, 5, 16, 37, 9, 997, DateTimeKind.Local).AddTicks(3371), "192.168.56.1", "Qui est sunt qui consequatur laboriosam blanditiis commodi dicta pariatur.", "Fanny Osinski", "Intelligent Granite Mouse", "French", "Ergonomic Granite BallOriginal", null, 0, 97, "French", "Ratke - Pacocha", "http://krystina.biz", null, null, null, new DateTime(2005, 8, 12, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 50, "Thea Gerhold,Francisco Corkery,Kariane Howe", "Action", "DESKTOP-P8K1SK9", new DateTime(2025, 2, 5, 16, 37, 9, 997, DateTimeKind.Local).AddTicks(8764), "192.168.56.1", "Quisquam quia sint repudiandae quod repudiandae accusantium minus et occaecati.", "Jana Shanahan", "Handmade Plastic Towels", "French", "Small Fresh CheeseOriginal", null, 0, 39, "English", "Harber - Nader", "https://paolo.info", null, null, null, new DateTime(2017, 4, 17, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 51, "Maye Wilderman,Reese Schamberger,Leatha Barton", "Horror", "DESKTOP-P8K1SK9", new DateTime(2025, 2, 5, 16, 37, 9, 998, DateTimeKind.Local).AddTicks(2473), "192.168.56.1", "Ut dolorem culpa blanditiis facilis et culpa non quo enim.", "Josianne Barrows", "Intelligent Steel Towels", "German", "Licensed Metal TowelsOriginal", null, 0, 17, "Spanish", "Schiller Group", "https://sigmund.net", null, null, null, new DateTime(2010, 12, 2, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 52, "Stanford Simonis,Ella Harris,Orval Gorczany", "Scifi", "DESKTOP-P8K1SK9", new DateTime(2025, 2, 5, 16, 37, 9, 998, DateTimeKind.Local).AddTicks(6949), "192.168.56.1", "Sunt id at molestias dolor culpa error voluptatem nulla iste.", "Carey Reynolds", "Generic Frozen Mouse", "German", "Handmade Metal TableOriginal", null, 0, 31, "French", "Anderson Inc", "https://eudora.info", null, null, null, new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 53, "Jan Lehner,Ressie Walsh,Bette Mueller", "Comedy", "DESKTOP-P8K1SK9", new DateTime(2025, 2, 5, 16, 37, 9, 999, DateTimeKind.Local).AddTicks(1089), "192.168.56.1", "Quia ipsa assumenda iste debitis itaque sit enim necessitatibus repellat.", "Ressie Wehner", "Ergonomic Soft Shirt", "French", "Awesome Frozen ChipsOriginal", null, 0, 14, "French", "Lubowitz - Hickle", "https://christ.info", null, null, null, new DateTime(1996, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 54, "Palma Langworth,Karolann Reinger,Ambrose Bins", "Scifi", "DESKTOP-P8K1SK9", new DateTime(2025, 2, 5, 16, 37, 9, 999, DateTimeKind.Local).AddTicks(6712), "192.168.56.1", "Soluta debitis eveniet quisquam expedita ipsam voluptates consectetur qui unde.", "Lempi Emmerich", "Intelligent Concrete Bike", "Spanish", "Rustic Wooden ShirtOriginal", null, 0, 20, "French", "Homenick Group", "https://cynthia.com", null, null, null, new DateTime(2001, 5, 5, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 55, "Desiree Kuhn,Shemar Schowalter,Elaina Weber", "Action", "DESKTOP-P8K1SK9", new DateTime(2025, 2, 5, 16, 37, 10, 0, DateTimeKind.Local).AddTicks(2487), "192.168.56.1", "Nemo hic vel consequatur est voluptate laudantium necessitatibus non aperiam.", "Nyah Lowe", "Generic Plastic Bacon", "German", "Handcrafted Plastic ComputerOriginal", null, 0, 38, "French", "Toy and Sons", "http://alvena.info", null, null, null, new DateTime(2017, 1, 26, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 56, "Russel Auer,Jennifer O'Reilly,Alexandrea Kihn", "Action", "DESKTOP-P8K1SK9", new DateTime(2025, 2, 5, 16, 37, 10, 0, DateTimeKind.Local).AddTicks(7567), "192.168.56.1", "Et aperiam quia omnis eos velit eveniet quis asperiores similique.", "Bryce Zulauf", "Handcrafted Soft Pants", "French", "Generic Soft SausagesOriginal", null, 0, 94, "German", "Hahn - Lowe", "http://easter.biz", null, null, null, new DateTime(2004, 8, 5, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 57, "Fabian Hartmann,Fritz Wyman,Fiona Fadel", "Drama", "DESKTOP-P8K1SK9", new DateTime(2025, 2, 5, 16, 37, 10, 1, DateTimeKind.Local).AddTicks(2287), "192.168.56.1", "Voluptatem eligendi architecto consequatur ut quam odio quia reprehenderit amet.", "Nils Zieme", "Generic Soft Chicken", "Spanish", "Intelligent Concrete SausagesOriginal", null, 0, 20, "French", "Collier - Kirlin", "https://rosendo.info", null, null, null, new DateTime(2017, 1, 6, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 58, "Jakayla Batz,Emmanuel Ernser,Cristobal Rippin", "Comedy", "DESKTOP-P8K1SK9", new DateTime(2025, 2, 5, 16, 37, 10, 1, DateTimeKind.Local).AddTicks(6685), "192.168.56.1", "Quis ad non perferendis sint qui dolores minus qui amet.", "Alf Schulist", "Sleek Plastic Car", "Spanish", "Handcrafted Wooden ChairOriginal", null, 0, 89, "Spanish", "Lind, Wunsch and King", "https://norberto.info", null, null, null, new DateTime(2010, 4, 17, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 59, "Tom Klocko,Guadalupe McGlynn,Dereck Hirthe", "Horror", "DESKTOP-P8K1SK9", new DateTime(2025, 2, 5, 16, 37, 10, 2, DateTimeKind.Local).AddTicks(741), "192.168.56.1", "Qui corrupti aliquid voluptas temporibus qui tempore molestiae rerum aliquam.", "Hermina Bartell", "Sleek Cotton Chicken", "Spanish", "Licensed Granite TunaOriginal", null, 0, 37, "Spanish", "Daugherty, Marks and Weissnat", "https://johathan.name", null, null, null, new DateTime(2024, 2, 4, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 60, "Harry Vandervort,Destin Cremin,Jonas Schowalter", "Comedy", "DESKTOP-P8K1SK9", new DateTime(2025, 2, 5, 16, 37, 10, 2, DateTimeKind.Local).AddTicks(6121), "192.168.56.1", "Sit amet rerum nemo incidunt rerum et sit nisi excepturi.", "Brigitte Labadie", "Incredible Frozen Ball", "French", "Small Plastic ComputerOriginal", null, 0, 33, "English", "Parker, Lebsack and Hessel", "http://ava.net", null, null, null, new DateTime(2002, 8, 1, 0, 0, 0, 0, DateTimeKind.Local) }
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
                name: "IX_AspNetUsers_MembershipID",
                table: "AspNetUsers",
                column: "MembershipID");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Awards_FilmID",
                table: "Awards",
                column: "FilmID");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryFilms_FilmID",
                table: "CategoryFilms",
                column: "FilmID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_FilmID",
                table: "Comments",
                column: "FilmID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserID",
                table: "Comments",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_CourierID",
                table: "Deliveries",
                column: "CourierID");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryPlans_DeliveryID",
                table: "DeliveryPlans",
                column: "DeliveryID");

            migrationBuilder.CreateIndex(
                name: "IX_FaultyFilms_FilmID",
                table: "FaultyFilms",
                column: "FilmID");

            migrationBuilder.CreateIndex(
                name: "IX_FaultyFilms_InventoryID",
                table: "FaultyFilms",
                column: "InventoryID");

            migrationBuilder.CreateIndex(
                name: "IX_FilmArtists_ArtistID",
                table: "FilmArtists",
                column: "ArtistID");

            migrationBuilder.CreateIndex(
                name: "IX_FilmDirectors_FilmID",
                table: "FilmDirectors",
                column: "FilmID");

            migrationBuilder.CreateIndex(
                name: "IX_Films_SpecialCategoryID",
                table: "Films",
                column: "SpecialCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_FilmID",
                table: "Inventories",
                column: "FilmID");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_SupplierID",
                table: "Inventories",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserID",
                table: "Notifications",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_FilmID",
                table: "OrderDetails",
                column: "FilmID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderID",
                table: "OrderDetails",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DeliveryID",
                table: "Orders",
                column: "DeliveryID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserID",
                table: "Orders",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_SupplierID",
                table: "Payments",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_FilmID",
                table: "Ratings",
                column: "FilmID");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_UserID",
                table: "Ratings",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFilms_FilmID",
                table: "SupplierFilms",
                column: "FilmID");

            migrationBuilder.CreateIndex(
                name: "IX_UserFilmLists_FilmID",
                table: "UserFilmLists",
                column: "FilmID");

            migrationBuilder.CreateIndex(
                name: "IX_UserFilmLists_UserID_FilmID",
                table: "UserFilmLists",
                columns: new[] { "UserID", "FilmID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserFilmRentals_FilmID",
                table: "UserFilmRentals",
                column: "FilmID");

            migrationBuilder.CreateIndex(
                name: "IX_UserWatchLists_FilmID",
                table: "UserWatchLists",
                column: "FilmID");
        }

        /// <inheritdoc />
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
                name: "Awards");

            migrationBuilder.DropTable(
                name: "CategoryFilms");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "DeliveryPlans");

            migrationBuilder.DropTable(
                name: "FaultyFilms");

            migrationBuilder.DropTable(
                name: "FilmArtists");

            migrationBuilder.DropTable(
                name: "FilmDirectors");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "SupplierFilms");

            migrationBuilder.DropTable(
                name: "UserFilmLists");

            migrationBuilder.DropTable(
                name: "UserFilmRentals");

            migrationBuilder.DropTable(
                name: "UserWatchLists");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Directors");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Deliveries");

            migrationBuilder.DropTable(
                name: "SpecialCategories");

            migrationBuilder.DropTable(
                name: "Memberships");

            migrationBuilder.DropTable(
                name: "Couriers");
        }
    }
}
