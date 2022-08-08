using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Villa.Persistence.Migrations
{
    public partial class mig16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "9be2279c-7207-4439-b915-4cc01991bac9");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "cc7be22a-9a00-4d6d-92cc-17b6e10a87e4");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "b44afff5-5611-4b99-9e8c-26cffdeb3ae7");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "ee91871f-aa42-41a5-9a80-d3838c00383c");

            migrationBuilder.CreateTable(
                name: "ExchangeRates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    from = table.Column<string>(type: "text", nullable: true),
                    to = table.Column<string>(type: "text", nullable: true),
                    rate = table.Column<double>(type: "double precision", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExchangeRates", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1afb403c-dc3e-4dec-ad8d-80d13f575a4a", "9ef04c66-b3ce-46b7-86fb-945f2c47b143", "admin", "ADMIN" },
                    { "1e67d35f-8e3d-4d6e-acd9-aa6c6a560114", "ae2ef62b-cbf1-4e85-8480-6a84f445a221", "sistemadmin", "SISTEMADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "c80a4bf6-635f-4391-94cb-7c83e79a5476", 0, "Ali", "01c6de86-b498-4119-a673-5bacda72a69b", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "5fdee7fd-d4f6-4546-a40d-f9616c7f8e61", "DERİN", null, false, "iladmin" },
                    { "e0487165-b6c1-4be1-8d9f-2ab0485f9172", 0, "Mehmet", "f8c0213d-ecf0-44c4-a50b-6d90c858d3e0", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "0d8624b5-6294-4a7f-a1d7-9ca448cfc09a", "YILMAZ", null, false, "sistemAdmin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExchangeRates");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "1afb403c-dc3e-4dec-ad8d-80d13f575a4a");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "1e67d35f-8e3d-4d6e-acd9-aa6c6a560114");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "c80a4bf6-635f-4391-94cb-7c83e79a5476");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "e0487165-b6c1-4be1-8d9f-2ab0485f9172");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9be2279c-7207-4439-b915-4cc01991bac9", "08ed7d4a-6436-4f5d-87ae-5eb1c84a3757", "admin", "ADMIN" },
                    { "cc7be22a-9a00-4d6d-92cc-17b6e10a87e4", "deefe107-0ed6-4445-b2db-c504ebfba4f5", "sistemadmin", "SISTEMADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b44afff5-5611-4b99-9e8c-26cffdeb3ae7", 0, "Mehmet", "d34d0331-abfe-4dfa-a992-64014a7e19ae", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "4212387f-9503-4088-9621-4d7e01a15b85", "YILMAZ", null, false, "sistemAdmin" },
                    { "ee91871f-aa42-41a5-9a80-d3838c00383c", 0, "Ali", "a803467b-b6f9-4613-befb-0cadc32ab035", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "2ac29520-de6e-4823-be30-5be339b4c779", "DERİN", null, false, "iladmin" }
                });
        }
    }
}
