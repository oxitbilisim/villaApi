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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    NormalizedName = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
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
                name: "MenuPermission",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MenuId = table.Column<Guid>(type: "uuid", nullable: false),
                    PermissionId = table.Column<Guid>(type: "uuid", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuPermission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menu",
                        column: x => x.MenuId,
                        principalTable: "Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuPermission",
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

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "CreateDate", "Icon", "Label", "ParentMenuId", "RouteLink" },
                values: new object[,]
                {
                    { new Guid("703d0bbb-ecdf-4402-9bc1-cf60384fb8ef"), null, "fa fa-gavel", "Kullanıcı", null, "/kullanıcı" },
                    { new Guid("a553ddbd-219c-457b-a37a-41cf5ec8d7ab"), null, "fa fa-balance-scale", "Kullanıcı Grup", null, "/kullanicigrup" },
                    { new Guid("e1c1dc1c-e346-471e-8141-dc5f9c3c5328"), null, "pi pi-fw pi-globe", "Panel", null, "/" }
                });

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "Id", "CreateDate", "Name" },
                values: new object[,]
                {
                    { new Guid("2e1ada02-ce74-4d99-8fef-31a3798097d7"), null, "Permissions.Grup.All" },
                    { new Guid("2fbcb26e-7164-46c9-a9e5-6042893cce46"), null, "Permissions.Log.All" },
                    { new Guid("5042520a-919e-4c1a-8243-3f67690bb9ed"), null, "Permissions.Genel.All" },
                    { new Guid("78734159-b68c-4fd6-832a-ec18a6879137"), null, "Permissions.Ayarlar.All" },
                    { new Guid("84936a2d-f89d-4789-ab36-c80ca7a7a26e"), null, "Permissions.Ilce.All" },
                    { new Guid("b676d942-f3f7-450d-8e7d-a00b32747256"), null, "Permissions.KullaniciGrup.All" },
                    { new Guid("c957e04c-3d3f-4e4b-a7ae-2e3aeee34d29"), null, "Permissions.Credential.All" },
                    { new Guid("cffb1f69-709d-471c-9311-610a9c95e819"), null, "Permissions.Il.All" },
                    { new Guid("fce2c2b6-ffcd-4e72-ba3e-74997a21779b"), null, "Permissions.Kullanici.All" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0eec2cdd-0f20-4017-a657-5e007e0d813b", "3e4042a8-bd97-47fe-9cba-deb16d2c69d8", "ılceadmın", "ILCEADMIN" },
                    { "9eca2436-a0b8-49d9-bd5f-617bfd1efbce", "1e2206ed-baaa-4f4a-99d3-8f3d988f47a5", "karakol", "KARAKOL" },
                    { "d6ee5854-7b1a-4b6c-9012-2d6bb615e249", "ace32bf5-ed4c-446a-a80c-e128b357227e", "ıladmın", "ILADMIN" },
                    { "f363aabf-4825-4581-9215-add6ecfdd666", "114e328c-dc28-4e77-9df3-bd6fea157a59", "sıstemadmın", "SISTEMADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SicilNo", "Soyad", "TCKN", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6c937a62-8596-4c83-b0f4-c897ebaf8fd3", 0, "Mehmet", "2ee8b2f9-dae1-4448-9f33-854719af19b6", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "b7a2918d-5352-48e2-b886-8ad65494011e", null, "YILMAZ", null, null, false, "sistemAdmin" },
                    { "754484b4-b2d3-43c5-8ec3-d587a6935621", 0, "Ali", "37d3760c-12dd-4603-8192-8e8b055f9a19", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "f909284a-fd0b-4288-813a-5c9ca3448415", null, "DERİN", null, null, false, "iladmin" }
                });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "files_merkez");

            migrationBuilder.DropTable(
                name: "Ilce");

            migrationBuilder.DropTable(
                name: "MenuPermission");

            migrationBuilder.DropTable(
                name: "RefreshToken");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "RoleClaim");

            migrationBuilder.DropTable(
                name: "UserClaim");

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
                name: "User");
        }
    }
}
