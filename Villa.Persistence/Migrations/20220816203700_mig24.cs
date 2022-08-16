using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Villa.Persistence.Migrations
{
    public partial class mig24 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "9b2565d0-76ce-49d4-9caf-d5b11671c173");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "c58851c4-7a07-4118-8f82-1ab4b79dfbea");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3535189e-835b-48be-8113-6ef2d540af02");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "aca5a425-e19d-41ef-9d18-bb016e120f0b");

            migrationBuilder.CreateTable(
                name: "EkstraHizmet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ad = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EkstraHizmet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RezervasyonEkstraHizmet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RezervasyonId = table.Column<int>(type: "integer", nullable: false),
                    EkstraHizmetId = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RezervasyonEkstraHizmet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RezervasyonEkstraHizmet_EkstraHizmet_EkstraHizmetId",
                        column: x => x.EkstraHizmetId,
                        principalTable: "EkstraHizmet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RezervasyonEkstraHizmet_Rezervasyon_RezervasyonId",
                        column: x => x.RezervasyonId,
                        principalTable: "Rezervasyon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b2ce721e-ff02-4dfc-b50a-152006961318", "b3da7ede-81f3-4a4e-b69b-60a20a2d9248", "admin", "ADMİN" },
                    { "c1bdcd98-5487-41a8-b13a-0ab74d53f57b", "8343a4e7-83d4-4443-96e2-15241a3c68a3", "sistemadmin", "SİSTEMADMİN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "60125a63-89bd-4e0b-891c-bd46b0987b05", 0, "Mehmet", "53305e8d-13a8-42f4-9f2d-fd11b64a0312", "sistemAdmin@gmail.com", false, null, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "93447023-6721-4857-b07b-543b5b45d769", "YILMAZ", null, false, "sistemAdmin" },
                    { "6c560ede-63cb-4b1f-babf-43210e6358b2", 0, "Ali", "4544e97e-68fe-42ff-9c0d-e8d1f1f49432", "iladmin@gmail.com", false, null, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "b4077b02-face-4d9a-8663-2e071a91466d", "DERİN", null, false, "iladmin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RezervasyonEkstraHizmet_EkstraHizmetId",
                table: "RezervasyonEkstraHizmet",
                column: "EkstraHizmetId");

            migrationBuilder.CreateIndex(
                name: "IX_RezervasyonEkstraHizmet_RezervasyonId",
                table: "RezervasyonEkstraHizmet",
                column: "RezervasyonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RezervasyonEkstraHizmet");

            migrationBuilder.DropTable(
                name: "EkstraHizmet");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "b2ce721e-ff02-4dfc-b50a-152006961318");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "c1bdcd98-5487-41a8-b13a-0ab74d53f57b");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "60125a63-89bd-4e0b-891c-bd46b0987b05");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "6c560ede-63cb-4b1f-babf-43210e6358b2");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9b2565d0-76ce-49d4-9caf-d5b11671c173", "826efc5c-b721-46d0-91c8-1217c6a1df02", "admin", "ADMİN" },
                    { "c58851c4-7a07-4118-8f82-1ab4b79dfbea", "77af566f-5524-4b01-b3e4-c29f647a1b69", "sistemadmin", "SİSTEMADMİN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3535189e-835b-48be-8113-6ef2d540af02", 0, "Ali", "5542355a-d697-4ab9-aa2c-5d514b72ea6e", "iladmin@gmail.com", false, null, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "1b16d680-fef6-4af1-ac4e-5a209100907b", "DERİN", null, false, "iladmin" },
                    { "aca5a425-e19d-41ef-9d18-bb016e120f0b", 0, "Mehmet", "0389b5ef-a3b9-4164-9784-54535d041754", "sistemAdmin@gmail.com", false, null, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "039fc212-72c3-4b59-b2ec-a989ab80f77b", "YILMAZ", null, false, "sistemAdmin" }
                });
        }
    }
}
