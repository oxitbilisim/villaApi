using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Villa.Persistence.Migrations
{
    public partial class mig26 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "1e5531e7-d925-4b00-8510-bb45dc511757");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "c33e84ca-f6e5-4b6e-9ff7-f456a15a19c1");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "20ebd8e6-9770-46fb-a51d-509bb9d65f16");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "4be67265-0f18-4f8b-b014-79077a0fe035");

            migrationBuilder.AddColumn<DateOnly>(
                name: "EndDate",
                table: "CollectionVillas",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<DateOnly>(
                name: "StartDate",
                table: "CollectionVillas",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "CollectionVillas");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "CollectionVillas");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1e5531e7-d925-4b00-8510-bb45dc511757", "0b3c62c0-496b-4f4b-b91b-6efea5afdd49", "sistemadmin", "SISTEMADMIN" },
                    { "c33e84ca-f6e5-4b6e-9ff7-f456a15a19c1", "0f61fcb7-3167-4dd0-a505-f72f432e78b2", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "20ebd8e6-9770-46fb-a51d-509bb9d65f16", 0, "Ali", "f6287cfb-5447-4abe-baa7-fb8342677397", "iladmin@gmail.com", false, null, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "6a138b43-1986-491b-aef0-25d7635f5e2e", "DERİN", null, false, "iladmin" },
                    { "4be67265-0f18-4f8b-b014-79077a0fe035", 0, "Mehmet", "32855df2-ae77-498a-ad0a-329169c3cd2a", "sistemAdmin@gmail.com", false, null, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "3e66b8f8-728a-467f-afff-140314ebd5fd", "YILMAZ", null, false, "sistemAdmin" }
                });
        }
    }
}
