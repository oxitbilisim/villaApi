using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Villa.Persistence.Migrations
{
    public partial class mig14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "1629ef14-0590-41a6-b871-033ad6548737");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "68dd5f2d-df84-4324-9408-bbe0509ccdec");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "1c6cc87c-e86c-47f9-affa-4897507b8518");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "877022e9-564a-4879-9713-56579e2711e4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TahsilatTarihi",
                table: "RezervasyonMaliBilgi",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FaturaTarihi",
                table: "RezervasyonMaliBilgi",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EvSahibineOdemeTarihi",
                table: "RezervasyonMaliBilgi",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8ab7156d-b5ff-4f39-afda-78ff11f891ec", "b1d4d890-492e-4025-aaf5-1dcb5d4125c9", "sistemadmin", "SISTEMADMIN" },
                    { "9371ad8b-bda3-4d6f-93ff-353af9b37d56", "46f336dd-1c0d-4483-aa1a-efee284b63d2", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1bb9e613-5f09-4a80-8215-a9577046797e", 0, "Mehmet", "4e83b540-3e2d-4af1-984e-42c9b35f6ebd", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "1f44ca7a-3c8f-4e5e-bbac-5f53dda6bc19", "YILMAZ", null, false, "sistemAdmin" },
                    { "c2de7ff2-224f-4e84-87f2-e54a4f2800ca", 0, "Ali", "b85d073d-603f-4e02-81e3-f5e67bdaeb75", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "ebb3ee11-1b58-4400-a2dd-7c9aed9e4360", "DERİN", null, false, "iladmin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "8ab7156d-b5ff-4f39-afda-78ff11f891ec");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "9371ad8b-bda3-4d6f-93ff-353af9b37d56");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "1bb9e613-5f09-4a80-8215-a9577046797e");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "c2de7ff2-224f-4e84-87f2-e54a4f2800ca");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "TahsilatTarihi",
                table: "RezervasyonMaliBilgi",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "FaturaTarihi",
                table: "RezervasyonMaliBilgi",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "EvSahibineOdemeTarihi",
                table: "RezervasyonMaliBilgi",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1629ef14-0590-41a6-b871-033ad6548737", "5b8cfda7-f506-4006-a136-1279501fd79b", "sistemadmin", "SISTEMADMIN" },
                    { "68dd5f2d-df84-4324-9408-bbe0509ccdec", "4d47b67e-283b-4aa5-bac6-4328e5f0d5ae", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1c6cc87c-e86c-47f9-affa-4897507b8518", 0, "Ali", "4efcbc4c-b8cd-453f-827b-89e0ae423c43", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "c7d75231-b5a5-4325-8276-31c607e67910", "DERİN", null, false, "iladmin" },
                    { "877022e9-564a-4879-9713-56579e2711e4", 0, "Mehmet", "4301f535-7fd8-46d3-b3a4-ffa6b651d234", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "97432688-48fd-435e-9fb1-c3e0ef3586b1", "YILMAZ", null, false, "sistemAdmin" }
                });
        }
    }
}
