using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Villa.Persistence.Migrations
{
    public partial class mig27 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "a25f17c3-8794-4e2b-8783-a63768ba0a45");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "d18c94c4-ec20-439e-bb50-2982f3bc3941");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "e8ef40f6-fe30-44d6-bd0a-5d95868d2413");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "fffbb91a-0ebb-44b1-bfef-26fa7b7e7fd6");

            migrationBuilder.AddColumn<bool>(
                name: "OpenState",
                table: "Rezervasyon",
                type: "boolean",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Revoked",
                table: "RefreshToken",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Expires",
                table: "RefreshToken",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "RefreshToken",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "011e9eef-b643-4547-b005-8bde4b56c941", "5efaebaf-1dca-4585-9e4b-cb77bf9d729b", "admin", "ADMİN" },
                    { "27eac46d-c741-48f6-a04b-dffe801bd279", "c7b13862-de2c-40d5-8bf7-e2ff3fb3c36a", "sistemadmin", "SİSTEMADMİN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "bf07a656-4247-4fa3-92fa-ea3a7d4452d5", 0, "Ali", "7b7e8220-30ad-4160-9fb6-021dcf849c16", "iladmin@gmail.com", false, null, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "b9b59701-802f-41ea-b899-9d1a8a0133b4", "DERİN", null, false, "iladmin" },
                    { "c3aac016-1bcf-4a22-8f14-c2cc6f5aa9d8", 0, "Mehmet", "121bf7a8-3ea6-4312-a9d9-cbff6860307e", "sistemAdmin@gmail.com", false, null, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "db924945-fded-4971-8c0d-9036bfc2c12e", "YILMAZ", null, false, "sistemAdmin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "011e9eef-b643-4547-b005-8bde4b56c941");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "27eac46d-c741-48f6-a04b-dffe801bd279");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "bf07a656-4247-4fa3-92fa-ea3a7d4452d5");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "c3aac016-1bcf-4a22-8f14-c2cc6f5aa9d8");

            migrationBuilder.DropColumn(
                name: "OpenState",
                table: "Rezervasyon");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Revoked",
                table: "RefreshToken",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Expires",
                table: "RefreshToken",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "RefreshToken",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a25f17c3-8794-4e2b-8783-a63768ba0a45", "e3aba15b-208c-46c0-91a4-4399ec3030ee", "sistemadmin", "SISTEMADMIN" },
                    { "d18c94c4-ec20-439e-bb50-2982f3bc3941", "57ccf2cc-604c-44df-9a3e-8caaf22f94d6", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "e8ef40f6-fe30-44d6-bd0a-5d95868d2413", 0, "Mehmet", "8d312dd9-31a3-4d31-a8f8-744dadfb7b55", "sistemAdmin@gmail.com", false, null, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "f073638b-2ab9-498c-9a3c-54de6aaa929a", "YILMAZ", null, false, "sistemAdmin" },
                    { "fffbb91a-0ebb-44b1-bfef-26fa7b7e7fd6", 0, "Ali", "72208b86-b87b-47a1-9ded-4f31e24001d7", "iladmin@gmail.com", false, null, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "448ba948-63f9-4077-943f-65cca45353fc", "DERİN", null, false, "iladmin" }
                });
        }
    }
}
