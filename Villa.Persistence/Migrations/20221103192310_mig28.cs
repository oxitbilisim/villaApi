using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Villa.Persistence.Migrations
{
    public partial class mig28 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "f3e7cbc3-b5c7-40ca-86dc-8534ba048896");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "f99c5449-6a9d-4ffe-be64-000fd944ed40");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "84dca492-1fe3-4a3c-a895-67fc42aa4f9b");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "a9df1fda-ed33-496b-b56e-f8be21dc8989");

            migrationBuilder.CreateTable(
                name: "Parameters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "text", nullable: true),
                    Value = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parameters", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6d5b6957-d789-4861-84e0-0f199cf6a0a3", "3494297e-3132-4c8d-976e-7dcf8e19d0cb", "sistemadmin", "SISTEMADMIN" },
                    { "ba4ddd03-841c-43d2-9cde-cb8c7cd1c8f9", "c2ed17b2-0b59-41ec-b700-3a5b702b58c3", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "63f09e18-db73-4884-bc2b-a9c865827e7d", 0, "Ali", "b85d8ba3-8c5d-43cb-b185-e1fbb57cfba1", "iladmin@gmail.com", false, null, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "b1ce7fd4-1b1e-4ee0-bc9b-f95da51e11d0", "DERİN", null, false, "iladmin" },
                    { "ba3e03c9-922a-4a0c-9a73-85c75f9dfdf2", 0, "Mehmet", "75002996-0320-43ab-b20c-ce8279e88827", "sistemAdmin@gmail.com", false, null, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "b9aecf6a-9b79-4b4d-8a78-0b3f1f0c4616", "YILMAZ", null, false, "sistemAdmin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parameters");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "6d5b6957-d789-4861-84e0-0f199cf6a0a3");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "ba4ddd03-841c-43d2-9cde-cb8c7cd1c8f9");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "63f09e18-db73-4884-bc2b-a9c865827e7d");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "ba3e03c9-922a-4a0c-9a73-85c75f9dfdf2");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "f3e7cbc3-b5c7-40ca-86dc-8534ba048896", "0bb55b00-b20a-4c26-9631-455692e7ce4c", "admin", "ADMIN" },
                    { "f99c5449-6a9d-4ffe-be64-000fd944ed40", "6022c821-bb4c-4c38-ab37-90be5f910113", "sistemadmin", "SISTEMADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "84dca492-1fe3-4a3c-a895-67fc42aa4f9b", 0, "Mehmet", "6c24ec31-ff3b-4005-82eb-c39fd94119b8", "sistemAdmin@gmail.com", false, null, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "6fb67d0d-829d-4217-ade7-8d70a209756f", "YILMAZ", null, false, "sistemAdmin" },
                    { "a9df1fda-ed33-496b-b56e-f8be21dc8989", 0, "Ali", "2be9bd6f-2ae4-4d60-87ff-cc315ebdc703", "iladmin@gmail.com", false, null, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "075c5a5e-1258-412e-9a77-b14167be64bd", "DERİN", null, false, "iladmin" }
                });
        }
    }
}
