using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Villa.Persistence.Migrations
{
    public partial class mig8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "42babb0b-f1a1-4a22-a039-cb0dba3af24d");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "657cc649-78c7-4382-b411-e9c1a3a58ca3");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "8a283667-4379-4805-8497-4d0f38f88b2c");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "c6e6cfa4-5260-435d-9cf7-eca80bbc929a");

            migrationBuilder.CreateTable(
                name: "VillaSahip",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VillaId = table.Column<int>(type: "integer", nullable: false),
                    Sahip = table.Column<string>(type: "text", nullable: true),
                    Telefon = table.Column<string>(type: "text", nullable: true),
                    Iban = table.Column<string>(type: "text", nullable: true),
                    Eposta = table.Column<string>(type: "text", nullable: true),
                    Not = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VillaSahip", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VillaSahip_Villa_VillaId",
                        column: x => x.VillaId,
                        principalTable: "Villa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "60c3937f-6b1f-4014-bc39-3ada63ecda3a", "d71ac726-2cdb-4081-a592-044beca6495f", "admin", "ADMIN" },
                    { "aace3f77-2789-40fe-9447-dc1402a4bee7", "53a4c60d-29f1-41cf-a58a-e23a468267aa", "sistemadmin", "SISTEMADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "450072c2-3ce6-4e0e-aec4-02ed15be2d79", 0, "Mehmet", "fb9b71cf-449a-4d51-be8e-531c04b195e0", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "5760bcec-2b1c-4ef8-b43c-ca8507a8be38", "YILMAZ", null, false, "sistemAdmin" },
                    { "ce687517-18f7-4df8-8beb-f278850969e4", 0, "Ali", "d96a5762-9e72-4a3e-ab16-b0d8cc470367", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "5eb3a523-43eb-4d93-86f4-2b404fa8d865", "DERİN", null, false, "iladmin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_VillaSahip_VillaId",
                table: "VillaSahip",
                column: "VillaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VillaSahip");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "60c3937f-6b1f-4014-bc39-3ada63ecda3a");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "aace3f77-2789-40fe-9447-dc1402a4bee7");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "450072c2-3ce6-4e0e-aec4-02ed15be2d79");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "ce687517-18f7-4df8-8beb-f278850969e4");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "42babb0b-f1a1-4a22-a039-cb0dba3af24d", "1835e265-820a-47cd-9818-edf279c8ee7e", "sistemadmin", "SISTEMADMIN" },
                    { "657cc649-78c7-4382-b411-e9c1a3a58ca3", "c73bc918-df1c-4dfa-9144-2da7f01006a1", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8a283667-4379-4805-8497-4d0f38f88b2c", 0, "Ali", "016dbaea-490f-430c-a8f3-be4455892301", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "77c1839c-e87a-4c3b-b6fa-ee9cb3b5ea4d", "DERİN", null, false, "iladmin" },
                    { "c6e6cfa4-5260-435d-9cf7-eca80bbc929a", 0, "Mehmet", "f1d79258-5c3a-46f0-8126-3fde643515ba", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "8245c08d-e471-4ba0-b108-a7feb4c7dad8", "YILMAZ", null, false, "sistemAdmin" }
                });
        }
    }
}
