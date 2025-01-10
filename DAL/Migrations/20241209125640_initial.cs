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
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreditCardNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreditCardExpDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CVC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MembershipID = table.Column<int>(type: "int", nullable: false),
                    MembershipDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MembershipStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Memberships_MembershipID",
                        column: x => x.MembershipID,
                        principalTable: "Memberships",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                    { 31, "Tom Gerhold,Carlos Daugherty,Edmund Morissette", "Comedy", "DESKTOP-P8K1SK9", new DateTime(2024, 12, 9, 15, 56, 40, 510, DateTimeKind.Local).AddTicks(271), "192.168.56.1", "Autem velit eveniet veniam modi voluptate enim eius assumenda fugit.", "Adonis Farrell", "Small Wooden Bacon", "Spanish", "Practical Plastic GlovesOriginal", null, 0, 54, "Spanish", "Ward - Welch", "https://odie.com", null, null, null, new DateTime(2019, 11, 5, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 32, "Annette D'Amore,Rosalinda Goyette,Vivienne Bradtke", "Scifi", "DESKTOP-P8K1SK9", new DateTime(2024, 12, 9, 15, 56, 40, 510, DateTimeKind.Local).AddTicks(9234), "192.168.56.1", "Mollitia voluptatem pariatur nostrum et minus voluptatibus reprehenderit beatae accusamus.", "Bret Gibson", "Awesome Fresh Gloves", "English", "Handmade Steel MouseOriginal", null, 0, 98, "French", "Tromp, Nicolas and Langworth", "https://xavier.org", null, null, null, new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 33, "Erin Ortiz,Mervin Aufderhar,Dina West", "Horror", "DESKTOP-P8K1SK9", new DateTime(2024, 12, 9, 15, 56, 40, 511, DateTimeKind.Local).AddTicks(2757), "192.168.56.1", "Velit nihil inventore exercitationem praesentium distinctio molestias expedita asperiores adipisci.", "Kelton Effertz", "Licensed Cotton Sausages", "English", "Generic Fresh ChairOriginal", null, 0, 86, "Spanish", "Paucek, Lowe and Schuppe", "http://jocelyn.org", null, null, null, new DateTime(1996, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 34, "Aurore Adams,Frederique Corwin,Camille Pollich", "Comedy", "DESKTOP-P8K1SK9", new DateTime(2024, 12, 9, 15, 56, 40, 511, DateTimeKind.Local).AddTicks(5906), "192.168.56.1", "Dolores quia sint eligendi iste omnis quaerat architecto eos voluptatum.", "Andrew Lakin", "Ergonomic Fresh Fish", "German", "Incredible Plastic BallOriginal", null, 0, 90, "English", "Stiedemann, Berge and Mueller", "http://kenton.net", null, null, null, new DateTime(2018, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 35, "Cora Hane,Noelia Mayert,Heidi Medhurst", "Comedy", "DESKTOP-P8K1SK9", new DateTime(2024, 12, 9, 15, 56, 40, 511, DateTimeKind.Local).AddTicks(9246), "192.168.56.1", "Distinctio unde labore est aut sed adipisci deserunt voluptatibus quis.", "Seth Wintheiser", "Unbranded Metal Towels", "Spanish", "Licensed Concrete PantsOriginal", null, 0, 53, "English", "White Group", "http://kendra.biz", null, null, null, new DateTime(2018, 4, 24, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 36, "Kathleen Parker,Erik Quitzon,Beatrice Borer", "Scifi", "DESKTOP-P8K1SK9", new DateTime(2024, 12, 9, 15, 56, 40, 512, DateTimeKind.Local).AddTicks(2218), "192.168.56.1", "Est consequatur dolor placeat quia est deleniti rerum adipisci et.", "Albertha Murazik", "Licensed Cotton Car", "English", "Licensed Steel KeyboardOriginal", null, 0, 47, "Spanish", "Hoppe, Rodriguez and Spinka", "http://tanya.net", null, null, null, new DateTime(2009, 6, 10, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 37, "Tiana Thiel,Waylon Braun,Maud Rice", "Comedy", "DESKTOP-P8K1SK9", new DateTime(2024, 12, 9, 15, 56, 40, 512, DateTimeKind.Local).AddTicks(5175), "192.168.56.1", "Dignissimos id at similique recusandae aspernatur cupiditate error et omnis.", "Kay Nitzsche", "Intelligent Fresh Sausages", "French", "Awesome Frozen BaconOriginal", null, 0, 47, "English", "Gislason LLC", "http://teresa.name", null, null, null, new DateTime(2016, 9, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 38, "Camden Jerde,Lelah Feil,Brycen Fadel", "Drama", "DESKTOP-P8K1SK9", new DateTime(2024, 12, 9, 15, 56, 40, 512, DateTimeKind.Local).AddTicks(8099), "192.168.56.1", "Tenetur sequi quam sit laboriosam magnam omnis fugit qui doloremque.", "Dwight Konopelski", "Intelligent Plastic Towels", "French", "Generic Wooden PantsOriginal", null, 0, 34, "English", "Von, Parker and Bartell", "http://yasmin.com", null, null, null, new DateTime(2018, 6, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 39, "Anjali Ernser,Assunta Upton,Krista Gulgowski", "Action", "DESKTOP-P8K1SK9", new DateTime(2024, 12, 9, 15, 56, 40, 513, DateTimeKind.Local).AddTicks(1023), "192.168.56.1", "Quia non sed eaque ut aliquam officiis eum accusamus et.", "Letitia Hirthe", "Handmade Wooden Shoes", "Spanish", "Rustic Wooden CheeseOriginal", null, 0, 77, "Spanish", "Hammes, Metz and Nolan", "https://gussie.biz", null, null, null, new DateTime(2020, 7, 18, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 40, "Lamont Shanahan,Sandy Schaden,Freeman Cremin", "Horror", "DESKTOP-P8K1SK9", new DateTime(2024, 12, 9, 15, 56, 40, 513, DateTimeKind.Local).AddTicks(3941), "192.168.56.1", "Est rem nesciunt eius id est exercitationem provident aut officiis.", "Friedrich Sawayn", "Licensed Fresh Car", "English", "Fantastic Cotton GlovesOriginal", null, 0, 90, "English", "Kshlerin, Adams and Mraz", "https://tracey.org", null, null, null, new DateTime(2013, 11, 4, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 41, "Wayne Mitchell,Kyla Adams,Stephany Bogan", "Drama", "DESKTOP-P8K1SK9", new DateTime(2024, 12, 9, 15, 56, 40, 513, DateTimeKind.Local).AddTicks(7218), "192.168.56.1", "Maiores vitae consectetur neque ut architecto eum temporibus expedita eius.", "Meta Jast", "Tasty Frozen Bike", "French", "Sleek Steel KeyboardOriginal", null, 0, 93, "English", "Lebsack, Dickinson and Okuneva", "https://rosalinda.com", null, null, null, new DateTime(2004, 11, 10, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 42, "Shannon Yost,Sofia Harris,Pearlie Cruickshank", "Action", "DESKTOP-P8K1SK9", new DateTime(2024, 12, 9, 15, 56, 40, 514, DateTimeKind.Local).AddTicks(1147), "192.168.56.1", "Animi natus quia excepturi cumque aut voluptas omnis culpa aut.", "Jedediah Gottlieb", "Rustic Plastic Chips", "German", "Tasty Cotton FishOriginal", null, 0, 33, "English", "Wiza, Muller and Jacobi", "http://tommie.info", null, null, null, new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 43, "Owen Koepp,Citlalli Volkman,Alek Ullrich", "Drama", "DESKTOP-P8K1SK9", new DateTime(2024, 12, 9, 15, 56, 40, 514, DateTimeKind.Local).AddTicks(4683), "192.168.56.1", "Est hic et eum quod nam pariatur aliquid error voluptate.", "Troy MacGyver", "Incredible Rubber Salad", "Spanish", "Practical Plastic HatOriginal", null, 0, 21, "German", "Ortiz - Schiller", "http://oceane.biz", null, null, null, new DateTime(2012, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 44, "Eliza Dickens,Sally Abshire,Adelia Stark", "Action", "DESKTOP-P8K1SK9", new DateTime(2024, 12, 9, 15, 56, 40, 514, DateTimeKind.Local).AddTicks(8916), "192.168.56.1", "Dolor aut ut exercitationem consectetur unde dolor quis est ea.", "Carmine Reilly", "Generic Soft Keyboard", "English", "Ergonomic Fresh ShoesOriginal", null, 0, 30, "English", "Oberbrunner - Zieme", "http://amira.com", null, null, null, new DateTime(2012, 8, 5, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 45, "Amir Hackett,Della Breitenberg,Maurice Quigley", "Drama", "DESKTOP-P8K1SK9", new DateTime(2024, 12, 9, 15, 56, 40, 515, DateTimeKind.Local).AddTicks(2211), "192.168.56.1", "Consequuntur beatae consectetur reiciendis optio pariatur voluptate quis nostrum corrupti.", "Vella Sawayn", "Gorgeous Cotton Pants", "French", "Unbranded Metal ChickenOriginal", null, 0, 15, "French", "Erdman, Medhurst and Stehr", "http://maci.biz", null, null, null, new DateTime(1995, 4, 17, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 46, "Lura Stanton,Favian Jenkins,Sophia Mayer", "Scifi", "DESKTOP-P8K1SK9", new DateTime(2024, 12, 9, 15, 56, 40, 515, DateTimeKind.Local).AddTicks(5934), "192.168.56.1", "Ut deleniti qui recusandae recusandae illum est provident placeat ad.", "Ressie Murazik", "Practical Rubber Computer", "English", "Refined Rubber CheeseOriginal", null, 0, 12, "German", "Powlowski - Blick", "http://jody.com", null, null, null, new DateTime(2018, 2, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 47, "Giovanny Graham,Gardner Kautzer,Maude Breitenberg", "Comedy", "DESKTOP-P8K1SK9", new DateTime(2024, 12, 9, 15, 56, 40, 515, DateTimeKind.Local).AddTicks(9338), "192.168.56.1", "Neque tempora ab assumenda voluptatibus et occaecati voluptatum sit saepe.", "Alejandra Beahan", "Rustic Cotton Chair", "Spanish", "Licensed Concrete FishOriginal", null, 0, 29, "English", "Dietrich - Murazik", "https://jacey.org", null, null, null, new DateTime(1997, 12, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 48, "Dashawn Stamm,Mellie Lueilwitz,Nestor Wuckert", "Scifi", "DESKTOP-P8K1SK9", new DateTime(2024, 12, 9, 15, 56, 40, 516, DateTimeKind.Local).AddTicks(2813), "192.168.56.1", "Eius quia et laudantium repudiandae ea dolor consectetur accusamus enim.", "Joan Williamson", "Fantastic Granite Cheese", "English", "Sleek Concrete ShoesOriginal", null, 0, 89, "English", "Rohan, Roberts and Crooks", "https://jules.net", null, null, null, new DateTime(2007, 4, 30, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 49, "Jaylen Dibbert,Thora Leuschke,Sibyl Sauer", "Action", "DESKTOP-P8K1SK9", new DateTime(2024, 12, 9, 15, 56, 40, 516, DateTimeKind.Local).AddTicks(6365), "192.168.56.1", "Omnis maiores quia nihil quidem dolores rerum harum est delectus.", "Lenore Rau", "Ergonomic Metal Shoes", "Spanish", "Licensed Soft BaconOriginal", null, 0, 39, "English", "Kunde, Weber and Nitzsche", "https://bria.net", null, null, null, new DateTime(2001, 5, 21, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 50, "Justyn Cummings,Cielo Metz,Agnes Hamill", "Scifi", "DESKTOP-P8K1SK9", new DateTime(2024, 12, 9, 15, 56, 40, 517, DateTimeKind.Local).AddTicks(715), "192.168.56.1", "Voluptatem unde quae nobis porro quis ad aut quasi maxime.", "Sonny Daugherty", "Practical Plastic Soap", "English", "Awesome Rubber TableOriginal", null, 0, 42, "Spanish", "Hansen, Mayer and Krajcik", "https://macey.net", null, null, null, new DateTime(2021, 2, 17, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 51, "Gennaro Hansen,Alanis Reichert,Kristoffer Mitchell", "Comedy", "DESKTOP-P8K1SK9", new DateTime(2024, 12, 9, 15, 56, 40, 517, DateTimeKind.Local).AddTicks(3728), "192.168.56.1", "Magni omnis temporibus eaque ea fugiat soluta nobis fugit quis.", "Willa Schiller", "Handmade Cotton Shoes", "French", "Generic Rubber TowelsOriginal", null, 0, 18, "Spanish", "Padberg - Graham", "http://herminio.net", null, null, null, new DateTime(2019, 4, 24, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 52, "Maye Stracke,Alda Veum,Cade Howe", "Comedy", "DESKTOP-P8K1SK9", new DateTime(2024, 12, 9, 15, 56, 40, 517, DateTimeKind.Local).AddTicks(6639), "192.168.56.1", "Maiores id et occaecati quia qui praesentium et natus molestiae.", "Geovanny Boyle", "Unbranded Soft Tuna", "Spanish", "Small Cotton KeyboardOriginal", null, 0, 65, "English", "Mayert - Adams", "http://zackary.biz", null, null, null, new DateTime(1996, 12, 27, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 53, "Asha Maggio,Alva Emard,Zoie Marvin", "Drama", "DESKTOP-P8K1SK9", new DateTime(2024, 12, 9, 15, 56, 40, 518, DateTimeKind.Local).AddTicks(1167), "192.168.56.1", "Qui ipsam earum labore quos voluptas consequatur eum repellat recusandae.", "Astrid Gutkowski", "Fantastic Soft Pants", "English", "Generic Soft ShirtOriginal", null, 0, 6, "German", "VonRueden - Boyer", "https://ıva.biz", null, null, null, new DateTime(2007, 9, 24, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 54, "Mattie Daugherty,Sandra Sporer,Danielle Schmitt", "Comedy", "DESKTOP-P8K1SK9", new DateTime(2024, 12, 9, 15, 56, 40, 518, DateTimeKind.Local).AddTicks(5262), "192.168.56.1", "Et incidunt et mollitia magni voluptas ullam nihil ducimus omnis.", "Anita Labadie", "Ergonomic Fresh Bike", "English", "Refined Granite ChickenOriginal", null, 0, 94, "German", "Nolan - Parisian", "https://ısidro.net", null, null, null, new DateTime(2007, 4, 16, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 55, "Noah Legros,Dave Goodwin,Fidel Langosh", "Action", "DESKTOP-P8K1SK9", new DateTime(2024, 12, 9, 15, 56, 40, 519, DateTimeKind.Local).AddTicks(3619), "192.168.56.1", "Expedita iure molestias est nulla eveniet aut non quidem rerum.", "Ernestine Bashirian", "Generic Soft Bike", "German", "Tasty Cotton ChairOriginal", null, 0, 47, "French", "Oberbrunner - Walter", "http://josiane.info", null, null, null, new DateTime(2006, 8, 9, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 56, "Aryanna Zieme,Keenan Sipes,Marty Ernser", "Scifi", "DESKTOP-P8K1SK9", new DateTime(2024, 12, 9, 15, 56, 40, 520, DateTimeKind.Local).AddTicks(4243), "192.168.56.1", "Esse consequatur nesciunt hic pariatur velit quia ut voluptatibus id.", "Dora Dare", "Sleek Soft Table", "Spanish", "Awesome Frozen MouseOriginal", null, 0, 89, "English", "Gibson Group", "http://zander.biz", null, null, null, new DateTime(2009, 11, 10, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 57, "Carolanne Jakubowski,Matilde Smitham,Brennon Franecki", "Comedy", "DESKTOP-P8K1SK9", new DateTime(2024, 12, 9, 15, 56, 40, 520, DateTimeKind.Local).AddTicks(8105), "192.168.56.1", "Amet nihil provident nihil autem omnis non blanditiis voluptatem tempore.", "Kyleigh Barrows", "Practical Plastic Bike", "Spanish", "Unbranded Wooden PantsOriginal", null, 0, 30, "German", "White and Sons", "https://mohammed.com", null, null, null, new DateTime(2014, 10, 5, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 58, "Daisy Hickle,Terrence Pouros,Mable Vandervort", "Drama", "DESKTOP-P8K1SK9", new DateTime(2024, 12, 9, 15, 56, 40, 521, DateTimeKind.Local).AddTicks(1157), "192.168.56.1", "Rerum ea rerum aut qui eos tempora tempore eveniet natus.", "Isabella Gislason", "Generic Frozen Tuna", "French", "Awesome Metal ChipsOriginal", null, 0, 59, "English", "McClure - Lueilwitz", "http://aliyah.net", null, null, null, new DateTime(2017, 9, 7, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 59, "Jacey Macejkovic,Stanton Collier,Ayden Gerhold", "Scifi", "DESKTOP-P8K1SK9", new DateTime(2024, 12, 9, 15, 56, 40, 521, DateTimeKind.Local).AddTicks(4037), "192.168.56.1", "Repellat blanditiis explicabo cumque laboriosam fuga animi quia nostrum quo.", "Jordon Wintheiser", "Fantastic Rubber Cheese", "Spanish", "Handmade Metal ChickenOriginal", null, 0, 84, "Spanish", "Macejkovic, Goyette and Gibson", "http://marcellus.net", null, null, null, new DateTime(2018, 7, 4, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 60, "Kiana Goodwin,Kallie Green,Vella Grady", "Drama", "DESKTOP-P8K1SK9", new DateTime(2024, 12, 9, 15, 56, 40, 521, DateTimeKind.Local).AddTicks(7629), "192.168.56.1", "Sit voluptates officiis aut est nesciunt et dolore tenetur odio.", "Ronny Koss", "Intelligent Wooden Fish", "French", "Handcrafted Soft SaladOriginal", null, 0, 31, "Spanish", "Swaniawski Group", "http://chase.org", null, null, null, new DateTime(2004, 10, 14, 0, 0, 0, 0, DateTimeKind.Local) }
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
