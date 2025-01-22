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
                    MembershipStatus = table.Column<int>(type: "int", nullable: false),
                    UserType = table.Column<int>(type: "int", nullable: false)
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
                    { 31, "Shanny Koss,Mckenzie Langosh,River Mante", "Horror", "DESKTOP-P8K1SK9", new DateTime(2025, 1, 21, 15, 33, 51, 717, DateTimeKind.Local).AddTicks(3932), "192.168.56.1", "Totam commodi libero laudantium unde omnis ad eligendi alias saepe.", "Sharon McKenzie", "Handcrafted Steel Keyboard", "French", "Incredible Steel KeyboardOriginal", null, 0, 35, "German", "Adams - Stanton", "http://aylin.info", null, null, null, new DateTime(2021, 1, 29, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 32, "Pearline Dooley,Lauryn Bechtelar,Zola O'Conner", "Comedy", "DESKTOP-P8K1SK9", new DateTime(2025, 1, 21, 15, 33, 51, 718, DateTimeKind.Local).AddTicks(5224), "192.168.56.1", "Enim et iusto ut illo alias labore aut amet corporis.", "Crawford Mertz", "Small Frozen Pizza", "French", "Tasty Frozen PantsOriginal", null, 0, 97, "French", "Abernathy and Sons", "https://eveline.biz", null, null, null, new DateTime(2009, 5, 11, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 33, "Lavon Hills,Shanny Jacobi,Rosamond Daniel", "Scifi", "DESKTOP-P8K1SK9", new DateTime(2025, 1, 21, 15, 33, 51, 718, DateTimeKind.Local).AddTicks(8946), "192.168.56.1", "Magnam incidunt non dicta dignissimos commodi fugiat aut eum aut.", "Allie Davis", "Ergonomic Frozen Car", "German", "Sleek Rubber CarOriginal", null, 0, 37, "Spanish", "Dicki, Sporer and Rosenbaum", "https://amalia.org", null, null, null, new DateTime(2004, 8, 29, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 34, "Hudson Grimes,Elza Brakus,Heloise Ruecker", "Drama", "DESKTOP-P8K1SK9", new DateTime(2025, 1, 21, 15, 33, 51, 719, DateTimeKind.Local).AddTicks(2607), "192.168.56.1", "Magnam aspernatur perferendis vitae totam ipsa sit odio omnis dicta.", "Junius White", "Handcrafted Fresh Chips", "German", "Sleek Plastic ShirtOriginal", null, 0, 70, "Spanish", "Baumbach - Sporer", "http://madie.net", null, null, null, new DateTime(2001, 12, 30, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 35, "Phyllis Lang,Zachary Kub,Brittany Mohr", "Drama", "DESKTOP-P8K1SK9", new DateTime(2025, 1, 21, 15, 33, 51, 719, DateTimeKind.Local).AddTicks(5650), "192.168.56.1", "Quam maiores quam voluptatem nulla praesentium possimus asperiores tenetur reiciendis.", "Austen Hilll", "Small Rubber Cheese", "English", "Awesome Metal SausagesOriginal", null, 0, 74, "French", "Tillman LLC", "https://alyson.net", null, null, null, new DateTime(2001, 12, 24, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 36, "Linda Bashirian,Jerrod O'Kon,Etha Ortiz", "Scifi", "DESKTOP-P8K1SK9", new DateTime(2025, 1, 21, 15, 33, 51, 719, DateTimeKind.Local).AddTicks(8660), "192.168.56.1", "Dignissimos aliquam sit et perferendis corporis enim earum ut aut.", "Shannon MacGyver", "Ergonomic Frozen Cheese", "Spanish", "Incredible Plastic KeyboardOriginal", null, 0, 16, "Spanish", "Wyman - Bode", "http://shanna.info", null, null, null, new DateTime(2011, 6, 5, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 37, "Merlin Stamm,Elian Marquardt,Noelia Senger", "Comedy", "DESKTOP-P8K1SK9", new DateTime(2025, 1, 21, 15, 33, 51, 720, DateTimeKind.Local).AddTicks(2549), "192.168.56.1", "Sunt aut nihil eius architecto dolore consequatur adipisci molestiae sit.", "Diamond Fritsch", "Small Granite Sausages", "German", "Intelligent Steel TowelsOriginal", null, 0, 6, "Spanish", "Bednar Inc", "https://wava.name", null, null, null, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 38, "Drew Smith,Bonnie Stanton,Brant Gutkowski", "Drama", "DESKTOP-P8K1SK9", new DateTime(2025, 1, 21, 15, 33, 51, 720, DateTimeKind.Local).AddTicks(5932), "192.168.56.1", "Perspiciatis placeat placeat nemo reprehenderit quia perspiciatis at esse tempora.", "Waldo Kling", "Awesome Rubber Bike", "English", "Sleek Metal ComputerOriginal", null, 0, 74, "Spanish", "Watsica - Breitenberg", "http://brando.biz", null, null, null, new DateTime(2012, 9, 5, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 39, "Cooper Weissnat,Corrine Hayes,Jonathan Lesch", "Action", "DESKTOP-P8K1SK9", new DateTime(2025, 1, 21, 15, 33, 51, 720, DateTimeKind.Local).AddTicks(9230), "192.168.56.1", "Et dolorem accusamus in sit enim quo minus voluptas distinctio.", "Otha Waters", "Generic Plastic Keyboard", "French", "Awesome Metal BaconOriginal", null, 0, 30, "English", "Crona, Larkin and Skiles", "http://ronny.name", null, null, null, new DateTime(2011, 2, 21, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 40, "Dannie Mitchell,Chasity Cole,Ray Kerluke", "Action", "DESKTOP-P8K1SK9", new DateTime(2025, 1, 21, 15, 33, 51, 721, DateTimeKind.Local).AddTicks(2567), "192.168.56.1", "Et accusantium ad et iure magni suscipit enim dicta necessitatibus.", "Gilda Miller", "Gorgeous Plastic Chair", "French", "Generic Plastic KeyboardOriginal", null, 0, 53, "Spanish", "O'Conner, Roberts and Mills", "http://oswaldo.com", null, null, null, new DateTime(1997, 8, 15, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 41, "Cordell Dibbert,Katlyn Bednar,Myles Bailey", "Comedy", "DESKTOP-P8K1SK9", new DateTime(2025, 1, 21, 15, 33, 51, 721, DateTimeKind.Local).AddTicks(5558), "192.168.56.1", "Quis perferendis voluptas labore voluptas molestiae omnis autem quaerat iusto.", "Jayda Schulist", "Licensed Metal Hat", "German", "Small Frozen BikeOriginal", null, 0, 99, "English", "Hamill and Sons", "https://cora.org", null, null, null, new DateTime(2012, 9, 26, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 42, "Eloise Stark,Mona Harvey,Carlie Baumbach", "Horror", "DESKTOP-P8K1SK9", new DateTime(2025, 1, 21, 15, 33, 51, 721, DateTimeKind.Local).AddTicks(8490), "192.168.56.1", "Necessitatibus nobis ipsam ratione unde iusto et officia at et.", "Lauretta Bayer", "Awesome Cotton Gloves", "French", "Awesome Steel GlovesOriginal", null, 0, 99, "French", "Quitzon, Corwin and Schumm", "https://rebekah.biz", null, null, null, new DateTime(2012, 9, 8, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 43, "Aimee Lowe,Fredy Dietrich,Amber Rosenbaum", "Drama", "DESKTOP-P8K1SK9", new DateTime(2025, 1, 21, 15, 33, 51, 722, DateTimeKind.Local).AddTicks(1481), "192.168.56.1", "Libero qui et corporis aspernatur qui et laboriosam dignissimos ratione.", "Irving Zulauf", "Incredible Granite Chips", "French", "Unbranded Cotton TunaOriginal", null, 0, 71, "Spanish", "Hammes - Rau", "http://alexander.com", null, null, null, new DateTime(2022, 6, 2, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 44, "Kiel Boyle,Amos Koss,Hilma Lubowitz", "Action", "DESKTOP-P8K1SK9", new DateTime(2025, 1, 21, 15, 33, 51, 722, DateTimeKind.Local).AddTicks(4416), "192.168.56.1", "Ea est est corporis necessitatibus officiis corrupti maxime assumenda neque.", "Jeanne Jast", "Licensed Wooden Gloves", "German", "Tasty Soft SaladOriginal", null, 0, 60, "English", "Kozey Inc", "http://garret.net", null, null, null, new DateTime(2012, 9, 29, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 45, "Jonas Krajcik,Torrey Moen,Tillman Bergstrom", "Horror", "DESKTOP-P8K1SK9", new DateTime(2025, 1, 21, 15, 33, 51, 722, DateTimeKind.Local).AddTicks(7406), "192.168.56.1", "İn odit maxime et consequuntur ea occaecati temporibus voluptatum aut.", "Meagan Mohr", "Generic Frozen Table", "French", "Generic Concrete ChickenOriginal", null, 0, 98, "Spanish", "Carroll - Wolff", "http://houston.biz", null, null, null, new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 46, "Romaine Ankunding,Moises Abernathy,Seamus Heller", "Scifi", "DESKTOP-P8K1SK9", new DateTime(2025, 1, 21, 15, 33, 51, 723, DateTimeKind.Local).AddTicks(329), "192.168.56.1", "Pariatur porro ratione quis ut vitae quisquam ut cupiditate quibusdam.", "Tierra Brekke", "Fantastic Soft Towels", "English", "Intelligent Frozen ComputerOriginal", null, 0, 41, "German", "Collier, Boehm and Anderson", "https://leland.info", null, null, null, new DateTime(2005, 8, 1, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 47, "Mireille Bernhard,Corbin Green,Steve Aufderhar", "Comedy", "DESKTOP-P8K1SK9", new DateTime(2025, 1, 21, 15, 33, 51, 723, DateTimeKind.Local).AddTicks(3268), "192.168.56.1", "Magni non quia quis vitae non ipsam inventore vitae in.", "Cedrick Ankunding", "Small Fresh Computer", "French", "Intelligent Soft ShirtOriginal", null, 0, 39, "German", "Ernser, Rodriguez and Bergstrom", "https://juliet.com", null, null, null, new DateTime(2019, 11, 8, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 48, "Carleton MacGyver,Anya Kautzer,Zakary Luettgen", "Action", "DESKTOP-P8K1SK9", new DateTime(2025, 1, 21, 15, 33, 51, 723, DateTimeKind.Local).AddTicks(6213), "192.168.56.1", "Non quam quia qui autem consectetur voluptate blanditiis deleniti possimus.", "Keagan Sipes", "Incredible Soft Computer", "English", "Sleek Frozen PizzaOriginal", null, 0, 37, "German", "Ebert - McLaughlin", "https://ısaias.info", null, null, null, new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 49, "Elvie Rosenbaum,Lavern Reynolds,Lucinda Bartoletti", "Comedy", "DESKTOP-P8K1SK9", new DateTime(2025, 1, 21, 15, 33, 51, 723, DateTimeKind.Local).AddTicks(9103), "192.168.56.1", "Dolores sed non illum id fugit facere autem aut et.", "Bennett Wilkinson", "Handcrafted Metal Keyboard", "Spanish", "Ergonomic Soft MouseOriginal", null, 0, 26, "Spanish", "Wiegand - Goodwin", "https://august.com", null, null, null, new DateTime(2004, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 50, "Lauryn Erdman,Freda Wiza,Augustus Hammes", "Scifi", "DESKTOP-P8K1SK9", new DateTime(2025, 1, 21, 15, 33, 51, 724, DateTimeKind.Local).AddTicks(2010), "192.168.56.1", "Repudiandae ut voluptatem quaerat nobis quasi qui saepe provident aut.", "Matteo Ruecker", "Handcrafted Wooden Cheese", "French", "Sleek Granite ChairOriginal", null, 0, 98, "French", "Spencer - Swaniawski", "http://americo.biz", null, null, null, new DateTime(2003, 1, 7, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 51, "Alex Von,Manuel Dietrich,Tatum Nolan", "Scifi", "DESKTOP-P8K1SK9", new DateTime(2025, 1, 21, 15, 33, 51, 724, DateTimeKind.Local).AddTicks(4892), "192.168.56.1", "Earum ea soluta est voluptatibus excepturi voluptate ut corrupti eum.", "Alexzander Bins", "Small Cotton Chair", "German", "Unbranded Cotton HatOriginal", null, 0, 38, "Spanish", "Labadie - Haley", "https://trace.name", null, null, null, new DateTime(2004, 8, 27, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 52, "Delbert King,Jason Grady,Gabe Bins", "Scifi", "DESKTOP-P8K1SK9", new DateTime(2025, 1, 21, 15, 33, 51, 724, DateTimeKind.Local).AddTicks(7793), "192.168.56.1", "Architecto voluptatum dicta perspiciatis repudiandae sint aut quo distinctio consequatur.", "Yessenia Bergnaum", "Practical Plastic Gloves", "French", "Rustic Steel ChipsOriginal", null, 0, 90, "French", "Cartwright, Johnston and Huel", "https://eleanore.net", null, null, null, new DateTime(2003, 2, 22, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 53, "Jaquelin Gorczany,Keenan Considine,Agnes Erdman", "Comedy", "DESKTOP-P8K1SK9", new DateTime(2025, 1, 21, 15, 33, 51, 725, DateTimeKind.Local).AddTicks(1777), "192.168.56.1", "Earum omnis voluptate et illo cum modi labore et ab.", "Giles Nader", "Tasty Wooden Shoes", "Spanish", "Incredible Wooden HatOriginal", null, 0, 91, "French", "Auer LLC", "https://larue.name", null, null, null, new DateTime(2022, 3, 28, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 54, "Mya Senger,Pascale Ratke,Kiel Sanford", "Scifi", "DESKTOP-P8K1SK9", new DateTime(2025, 1, 21, 15, 33, 51, 725, DateTimeKind.Local).AddTicks(5170), "192.168.56.1", "Veritatis sit deserunt eos voluptatibus consequatur corrupti rerum ab quisquam.", "Romaine Frami", "Tasty Steel Tuna", "German", "Incredible Soft BikeOriginal", null, 0, 79, "English", "Gutmann Inc", "http://enos.name", null, null, null, new DateTime(2024, 10, 18, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 55, "Nico Gulgowski,Cecil Dare,Otis Rutherford", "Horror", "DESKTOP-P8K1SK9", new DateTime(2025, 1, 21, 15, 33, 51, 725, DateTimeKind.Local).AddTicks(9616), "192.168.56.1", "Atque et ipsam sit fugit voluptatem ipsam qui qui eum.", "Henri Lynch", "Practical Fresh Keyboard", "French", "Sleek Cotton HatOriginal", null, 0, 23, "English", "Steuber, Hilpert and Kuhic", "http://baby.net", null, null, null, new DateTime(1997, 8, 14, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 56, "Cicero Anderson,Malika Monahan,August Mraz", "Horror", "DESKTOP-P8K1SK9", new DateTime(2025, 1, 21, 15, 33, 51, 726, DateTimeKind.Local).AddTicks(3249), "192.168.56.1", "Vel molestiae sapiente animi et incidunt nulla excepturi molestiae suscipit.", "Emmalee Konopelski", "Practical Cotton Keyboard", "English", "Tasty Plastic TableOriginal", null, 0, 40, "French", "Davis Group", "https://roger.biz", null, null, null, new DateTime(1997, 6, 25, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 57, "Elody Prohaska,Corene Beer,Baby Schmidt", "Horror", "DESKTOP-P8K1SK9", new DateTime(2025, 1, 21, 15, 33, 51, 726, DateTimeKind.Local).AddTicks(7103), "192.168.56.1", "Distinctio aspernatur commodi non cumque et ex similique dignissimos maiores.", "Martina Paucek", "Incredible Concrete Cheese", "French", "Incredible Metal KeyboardOriginal", null, 0, 49, "English", "Cummerata LLC", "http://reed.name", null, null, null, new DateTime(2014, 5, 21, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 58, "Bill Swaniawski,Mabelle Kassulke,Finn Boyer", "Action", "DESKTOP-P8K1SK9", new DateTime(2025, 1, 21, 15, 33, 51, 727, DateTimeKind.Local).AddTicks(538), "192.168.56.1", "Soluta quae doloribus dolorem libero asperiores mollitia et deserunt similique.", "Halie Labadie", "Ergonomic Metal Chicken", "French", "Rustic Concrete BikeOriginal", null, 0, 20, "French", "Schaefer Group", "http://cordell.info", null, null, null, new DateTime(1997, 9, 30, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 59, "Nyasia Medhurst,Raleigh Rice,Elinor Daniel", "Scifi", "DESKTOP-P8K1SK9", new DateTime(2025, 1, 21, 15, 33, 51, 727, DateTimeKind.Local).AddTicks(3876), "192.168.56.1", "Architecto at repudiandae quo eos fuga et harum consequatur similique.", "Michele Connelly", "Intelligent Rubber Fish", "English", "Handmade Metal BallOriginal", null, 0, 63, "French", "Sipes LLC", "https://marjorie.biz", null, null, null, new DateTime(2015, 7, 14, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 60, "Sid Pacocha,Darryl Harber,Mikel Fritsch", "Scifi", "DESKTOP-P8K1SK9", new DateTime(2025, 1, 21, 15, 33, 51, 727, DateTimeKind.Local).AddTicks(7603), "192.168.56.1", "Distinctio voluptatem et minus laboriosam eveniet sint consequatur et possimus.", "Evie Harris", "Licensed Steel Soap", "German", "Awesome Frozen GlovesOriginal", null, 0, 21, "English", "Shanahan LLC", "http://shanie.net", null, null, null, new DateTime(2013, 11, 9, 0, 0, 0, 0, DateTimeKind.Local) }
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
