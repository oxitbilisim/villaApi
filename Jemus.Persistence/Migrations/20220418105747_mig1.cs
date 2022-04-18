using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Jemus.Persistence.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "files_merkez",
                columns: table => new
                {
                    clientid = table.Column<long>(type: "bigint", nullable: false),
                    filepath = table.Column<string>(type: "text", nullable: true),
                    name = table.Column<string>(type: "text", nullable: true),
                    plaka = table.Column<string>(type: "text", nullable: true),
                    clientname = table.Column<string>(type: "text", nullable: true),
                    yonbilgisi = table.Column<string>(type: "text", nullable: true),
                    ulke = table.Column<string>(type: "text", nullable: true),
                    tip = table.Column<string>(type: "text", nullable: true),
                    marka = table.Column<string>(type: "text", nullable: true),
                    renk = table.Column<string>(type: "text", nullable: true),
                    plakakoordinati = table.Column<string>(type: "text", nullable: true),
                    hiz = table.Column<string>(type: "text", nullable: true),
                    detectionnumber = table.Column<string>(type: "text", nullable: true),
                    confidence = table.Column<string>(type: "text", nullable: true),
                    enlem = table.Column<string>(type: "text", nullable: true),
                    boylam = table.Column<string>(type: "text", nullable: true),
                    plakaokumasayisi = table.Column<string>(type: "text", nullable: true),
                    dogrulukorani = table.Column<string>(type: "text", nullable: true),
                    datetime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    isprocessed = table.Column<bool>(type: "boolean", nullable: true),
                    gedoid = table.Column<long>(type: "bigint", nullable: false),
                    result = table.Column<string>(type: "text", nullable: true),
                    aciklama = table.Column<string>(type: "text", nullable: true),
                    tescilyil = table.Column<string>(type: "text", nullable: true),
                    tescilrenk = table.Column<string>(type: "text", nullable: true),
                    tescilmarka = table.Column<string>(type: "text", nullable: true),
                    tescilcinsi = table.Column<string>(type: "text", nullable: true),
                    tescilmodel = table.Column<string>(type: "text", nullable: true),
                    tesciltip = table.Column<string>(type: "text", nullable: true),
                    tescilsinif = table.Column<string>(type: "text", nullable: true),
                    tescilzamani = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    sakincadurumu = table.Column<string>(type: "text", nullable: true),
                    islemtipi = table.Column<string>(type: "text", nullable: true),
                    il = table.Column<string>(type: "text", nullable: true),
                    ptsyonu = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Ad = table.Column<string>(type: "text", nullable: true),
                    Tanim = table.Column<string>(type: "text", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IdentityRole",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    NormalizedName = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Il",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Ad = table.Column<string>(type: "text", nullable: true),
                    Kod = table.Column<string>(type: "text", nullable: true),
                    Sira = table.Column<int>(type: "integer", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Il", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Label = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    Icon = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    RouteLink = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    ParentMenuId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menu_Menu_ParentMenuId",
                        column: x => x.ParentMenuId,
                        principalTable: "Menu",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Permission",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: true),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    Ad = table.Column<string>(type: "text", nullable: true),
                    Soyad = table.Column<string>(type: "text", nullable: true),
                    SicilNo = table.Column<string>(type: "text", nullable: true),
                    TCKN = table.Column<string>(type: "text", nullable: true),
                    Eposta = table.Column<string>(type: "text", nullable: true),
                    TelefonGSM = table.Column<string>(type: "text", nullable: true),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "text", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogin",
                columns: table => new
                {
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogin", x => new { x.UserId, x.ProviderKey });
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "UserToken",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserToken", x => new { x.UserId, x.Value });
                });

            migrationBuilder.CreateTable(
                name: "Ilce",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Ad = table.Column<string>(type: "text", nullable: true),
                    IlId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilce", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ilce_Il_IlId",
                        column: x => x.IlId,
                        principalTable: "Il",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GroupClaims",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    GroupId = table.Column<Guid>(type: "uuid", nullable: false),
                    PermissionId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupClaims_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupClaims_Permission_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuPermission",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MenuId = table.Column<Guid>(type: "uuid", nullable: false),
                    PermissionId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuPermission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MenuPermission_Menu_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuPermission_Permission_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RefreshToken",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Token = table.Column<string>(type: "text", nullable: true),
                    Expires = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedByIp = table.Column<string>(type: "text", nullable: true),
                    Revoked = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    RevokedByIp = table.Column<string>(type: "text", nullable: true),
                    ReplacedByToken = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshToken_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserGrup",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    GroupId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId1 = table.Column<string>(type: "text", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGrup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserGrup_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserGrup_User_UserId1",
                        column: x => x.UserId1,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Group",
                columns: new[] { "Id", "Ad", "CreateDate", "Tanim" },
                values: new object[,]
                {
                    { new Guid("35e98f79-dedd-4e2d-af65-1c8a66c7d100"), "IlceAdmin", null, "IlceAdmin" },
                    { new Guid("5e047018-8ccb-4cba-bc96-9be05ed71b40"), "IlAdmin", null, "IlAdmin" },
                    { new Guid("71e3f96f-b9dc-4f7f-a07a-827906b3b8e7"), "SistemAdmin", null, "SistemAdmin" },
                    { new Guid("976538d3-482b-41b6-ad88-eef23593087c"), "Karakol", null, "Karakol" }
                });

            migrationBuilder.InsertData(
                table: "IdentityRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "31fc1aef-ea2b-4a92-98bd-b06c9a519edf", "c82f17ac-6aff-4267-95df-89384b769ba9", "IlceAdmin", "IlceAdmin" },
                    { "3744e480-c058-4f6a-92cc-fc2c489f8fd7", "43e26fea-c621-477c-a4db-42cdc1b4bb29", "SistemAdmin", "SistemAdmin" },
                    { "60951c67-f784-4f85-ad52-b26389adfd14", "8f0d62b4-8967-4af9-8f0e-b490853eab59", "IlAdmin", "IlAdmin" },
                    { "94076f29-f3c6-4a19-ac7c-234b214a2a7e", "2614fcd6-9322-41f0-b6d2-3a4c2ed5367a", "Karakol", "Karakol" }
                });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "CreateDate", "Icon", "Label", "ParentMenuId", "RouteLink" },
                values: new object[,]
                {
                    { new Guid("8c8642fe-d1d8-4c10-a72e-27bdfd499fe3"), null, "pi pi-fw pi-globe", "Panel", null, "/" },
                    { new Guid("e1a943d6-8be9-412c-85ae-fb711ab0d519"), null, "fa fa-balance-scale", "Kullanıcı Grup", null, "/kullanicigrup" },
                    { new Guid("fd96c197-76b7-42dc-a6b5-13228f60397f"), null, "fa fa-gavel", "Kullanıcı", null, "/kullanıcı" }
                });

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "Id", "CreateDate", "Name" },
                values: new object[,]
                {
                    { new Guid("098ab422-ba9e-4ae7-84f6-256e05616dbb"), null, "Permissions.Grup.All" },
                    { new Guid("16969182-0104-4dfc-9958-e53d77a92ac1"), null, "Permissions.Credential.All" },
                    { new Guid("1a8f5ba6-ff9f-4f82-b230-9b27300119b8"), null, "Permissions.Ilce.All" },
                    { new Guid("2b14272d-4e4a-4f9f-94f2-fdcf0b5359a6"), null, "Permissions.Kullanici.All" },
                    { new Guid("367a2dcc-389f-4a7b-9dca-05e5ddb05224"), null, "Permissions.Ayarlar.All" },
                    { new Guid("6d768d43-3054-4daf-b2c1-cd65b0409959"), null, "Permissions.Genel.All" },
                    { new Guid("6f4530de-c164-408c-93d6-0477fd4bf978"), null, "Permissions.Il.All" },
                    { new Guid("a72c9ab2-ee19-4452-b82e-4c94428f37f3"), null, "Permissions.Log.All" },
                    { new Guid("bd70510c-42fc-48b1-ae7b-e8606fef4d3c"), null, "Permissions.KullaniciGrup.All" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Eposta", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SicilNo", "Soyad", "TCKN", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1e7d01b0-86ca-4d2c-9631-0fa122f43099", 0, null, "ee3279a0-a8f2-433e-89b5-6f890173861a", "User", "sistemAdmin@gmail.com", false, null, "sistemAdmin", "sistemAdmin", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "02b7f890-d62d-4697-933b-eaa7d554853f", null, null, null, null, false, "sistemAdmin" },
                    { "709b9e47-5b51-447e-ac19-8aa4a9a6c2c6", 0, null, "52ed4329-c937-4930-9ed4-b19797eba665", "User", "iladmin@gmail.com", false, null, "iladmin", "User", false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "7e793617-282d-485c-8517-5ffb03320568", null, null, null, null, false, "iladmin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GroupClaims_GroupId",
                table: "GroupClaims",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupClaims_PermissionId",
                table: "GroupClaims",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Ilce_IlId",
                table: "Ilce",
                column: "IlId");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_ParentMenuId",
                table: "Menu",
                column: "ParentMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuPermission_MenuId",
                table: "MenuPermission",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuPermission_PermissionId",
                table: "MenuPermission",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshToken_UserId",
                table: "RefreshToken",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserGrup_GroupId",
                table: "UserGrup",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_UserGrup_UserId1",
                table: "UserGrup",
                column: "UserId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "files_merkez");

            migrationBuilder.DropTable(
                name: "GroupClaims");

            migrationBuilder.DropTable(
                name: "IdentityRole");

            migrationBuilder.DropTable(
                name: "Ilce");

            migrationBuilder.DropTable(
                name: "MenuPermission");

            migrationBuilder.DropTable(
                name: "RefreshToken");

            migrationBuilder.DropTable(
                name: "RoleClaim");

            migrationBuilder.DropTable(
                name: "UserClaim");

            migrationBuilder.DropTable(
                name: "UserGrup");

            migrationBuilder.DropTable(
                name: "UserLogin");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "UserToken");

            migrationBuilder.DropTable(
                name: "Il");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Permission");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
