using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Villa.Persistence.Migrations
{
    public partial class mig10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "08c032a5-376f-47ad-8d4c-101e4c297764");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "fd95272d-1cf6-47a4-bb00-0bb36ca4c63b");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "0c0becec-cd35-482b-8a33-f886dbb1c794");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "f4e697fc-04d7-4268-a791-c9c57facf5ee");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "Collections");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8cec3865-612e-4bd0-8a7d-ba82943677ae", "91776757-7f55-402e-92b4-9549ef1e8dca", "sistemadmin", "SISTEMADMIN" },
                    { "c72926d9-5189-4d37-8939-6e34f2f7e238", "f9efe60f-7403-45f0-b852-9685d8db3dbd", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "047f4dda-0ef8-46b9-afc1-6dac1e2eadd0", 0, "Ali", "e19fdaeb-0478-4fbf-97ec-0a3519b81701", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "76f25946-6f7c-426f-8d55-0e2afd4c7307", "DERİN", null, false, "iladmin" },
                    { "3559d638-e708-49ac-9b41-e3ec1676cff4", 0, "Mehmet", "5e3fd2ad-6822-444b-bd52-91a5aa6fd3d9", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "bb54321f-af3d-417c-b6b8-24d865428c62", "YILMAZ", null, false, "sistemAdmin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "8cec3865-612e-4bd0-8a7d-ba82943677ae");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "c72926d9-5189-4d37-8939-6e34f2f7e238");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "047f4dda-0ef8-46b9-afc1-6dac1e2eadd0");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3559d638-e708-49ac-9b41-e3ec1676cff4");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "Collections",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "08c032a5-376f-47ad-8d4c-101e4c297764", "e5edd05d-6711-4470-ae08-ef817d5cdc7e", "admin", "ADMIN" },
                    { "fd95272d-1cf6-47a4-bb00-0bb36ca4c63b", "9bbf76be-f0a1-4531-b653-c5f289fd3ae8", "sistemadmin", "SISTEMADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0c0becec-cd35-482b-8a33-f886dbb1c794", 0, "Mehmet", "bbf93a86-d991-457c-90cb-8a892fd3354e", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "1aead207-3f1b-47bd-a50d-d7ff4b7130eb", "YILMAZ", null, false, "sistemAdmin" },
                    { "f4e697fc-04d7-4268-a791-c9c57facf5ee", 0, "Ali", "60c9474f-62ac-40d7-8d02-cdcf8ea26e04", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "02cbd20e-a3dc-4668-b824-4386921e89b0", "DERİN", null, false, "iladmin" }
                });
        }
    }
}
