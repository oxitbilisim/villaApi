using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Villa.Persistence.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "3a05b7f7-cc15-46c2-bb36-b43d76a3287c");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "e67923be-6eff-461a-8649-28685bce5b7f");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "100d8768-8013-4d79-914f-63ee2314cf75");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3b2fb9ef-e4a6-4834-9aa9-9eedfb96397e");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Ou",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "PbikId",
                table: "User",
                newName: "Eposta");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01cd9adc-74ab-44c0-a957-b7aaa349174b", "df47d7c0-4002-493d-a88c-02173a705e78", "sistemadmin", "SistemAdmin" },
                    { "6e2d8a62-6045-44dd-aeb1-58897d9df2af", "d437545b-b65c-40c9-ae85-f0f900bd7b7a", "admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "568a892c-6bdd-4aeb-b62d-a701cd77cc74", 0, "Mehmet", "6899835c-e0ed-41d2-a701-058fa8ebeed9", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "efd158a9-085f-4ea3-856f-169a1550c882", "YILMAZ", null, false, "sistemAdmin" },
                    { "833a91fb-9f35-40de-9608-a95b20030324", 0, "Ali", "7f7f3d1a-7a56-437c-8a54-a4b439ce36b5", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "be876edf-4b73-4aa1-a87c-8f451880cdff", "DERİN", null, false, "iladmin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "01cd9adc-74ab-44c0-a957-b7aaa349174b");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "6e2d8a62-6045-44dd-aeb1-58897d9df2af");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "568a892c-6bdd-4aeb-b62d-a701cd77cc74");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "833a91fb-9f35-40de-9608-a95b20030324");

            migrationBuilder.RenameColumn(
                name: "Eposta",
                table: "User",
                newName: "PbikId");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "User",
                type: "bytea",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ou",
                table: "User",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3a05b7f7-cc15-46c2-bb36-b43d76a3287c", "8cc7e148-76fa-421b-af14-916c288450b2", "sistemadmin", "SistemAdmin" },
                    { "e67923be-6eff-461a-8649-28685bce5b7f", "739d0467-206f-4575-9913-2d4b897ffd6d", "admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Image", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Ou", "PasswordHash", "PbikId", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "100d8768-8013-4d79-914f-63ee2314cf75", 0, "Mehmet", "dc99418f-1a1f-4d5c-8861-f4e9bec6c0f6", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", null, "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, null, false, "dd61fc60-55d7-44b3-b7cd-d22df5ea21d8", "YILMAZ", null, false, "sistemAdmin" },
                    { "3b2fb9ef-e4a6-4834-9aa9-9eedfb96397e", 0, "Ali", "5703a6d0-d174-4f5d-b645-960e658c8b41", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", null, "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, null, false, "03754a22-6105-4155-8e79-5bf5d02251d7", "DERİN", null, false, "iladmin" }
                });
        }
    }
}
