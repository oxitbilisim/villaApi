using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Villa.Persistence.Migrations
{
    public partial class mig12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "19160512-707b-478e-b103-e80797f83f4f");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "f6944dd5-169b-49e5-aad1-3c27e478343a");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "0af5db32-962a-4c78-9a0e-c671ace58cf0");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3b560c80-fdc6-4e85-8dd7-fff02afa4ce6");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "VillaImage",
                type: "bytea",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParaBirimiId",
                table: "PeriyodikFiyat",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "04f8540f-132e-4871-85a4-138aa5b1ff38", "0ac0222e-3228-4349-9505-9ed06791f22e", "admin", "ADMIN" },
                    { "b25cbb02-eaa3-4461-841a-e55912fa64e3", "701bb59c-b321-4315-a36d-c9c0b6aa6f62", "sistemadmin", "SISTEMADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0df3282c-7f31-4a2e-8197-babeb769db71", 0, "Ali", "f54aedfa-fb82-4049-b726-d4ce382e63a1", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "ad03c17d-106f-44a0-9928-d4571a24aa5d", "DERİN", null, false, "iladmin" },
                    { "aa3cf29b-5d96-4382-a3f3-1950118d8b71", 0, "Mehmet", "14613e5e-13cf-419b-826b-f55a158ea7f2", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "dcdb638b-a066-4baf-8f9c-b2cc53a64aee", "YILMAZ", null, false, "sistemAdmin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PeriyodikFiyat_ParaBirimiId",
                table: "PeriyodikFiyat",
                column: "ParaBirimiId");

            migrationBuilder.AddForeignKey(
                name: "FK_PeriyodikFiyat_ParaBirimi_ParaBirimiId",
                table: "PeriyodikFiyat",
                column: "ParaBirimiId",
                principalTable: "ParaBirimi",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PeriyodikFiyat_ParaBirimi_ParaBirimiId",
                table: "PeriyodikFiyat");

            migrationBuilder.DropIndex(
                name: "IX_PeriyodikFiyat_ParaBirimiId",
                table: "PeriyodikFiyat");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "04f8540f-132e-4871-85a4-138aa5b1ff38");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "b25cbb02-eaa3-4461-841a-e55912fa64e3");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "0df3282c-7f31-4a2e-8197-babeb769db71");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "aa3cf29b-5d96-4382-a3f3-1950118d8b71");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "VillaImage");

            migrationBuilder.DropColumn(
                name: "ParaBirimiId",
                table: "PeriyodikFiyat");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "19160512-707b-478e-b103-e80797f83f4f", "c200a253-97e8-45d8-aff4-d1ba5672d8a2", "admin", "ADMIN" },
                    { "f6944dd5-169b-49e5-aad1-3c27e478343a", "12e2a7ec-5bab-43f9-940f-24aa9a1c2a59", "sistemadmin", "SISTEMADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0af5db32-962a-4c78-9a0e-c671ace58cf0", 0, "Ali", "2fe04c5d-5ba8-4562-a4e5-283a7c9b73f9", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "5ae3e1d4-5cf7-419f-8825-f07ef504974f", "DERİN", null, false, "iladmin" },
                    { "3b560c80-fdc6-4e85-8dd7-fff02afa4ce6", 0, "Mehmet", "b5333770-ad04-48d0-834f-2dfdc8e3c26d", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "a741d9fb-0e5f-4e78-a6bf-de5ad849974c", "YILMAZ", null, false, "sistemAdmin" }
                });
        }
    }
}
