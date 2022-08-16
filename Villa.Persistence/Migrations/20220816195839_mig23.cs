using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Villa.Persistence.Migrations
{
    public partial class mig23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "5d1d80ea-8964-4fdf-baf8-e943d0285367");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "912a9452-ae96-4ffc-ac67-648130ec8d37");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "0a088e4f-c311-4ee0-8d6d-f3f2b6f22f63");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "15b31bb4-0f10-48e0-85ae-ddb81392f56c");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "User",
                type: "bytea",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Image",
                table: "User");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5d1d80ea-8964-4fdf-baf8-e943d0285367", "acb89d8d-f3bb-40bc-838a-c20b06188dcb", "admin", "ADMİN" },
                    { "912a9452-ae96-4ffc-ac67-648130ec8d37", "f3fc1899-67c8-4f07-b208-2f3e9610adea", "sistemadmin", "SİSTEMADMİN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0a088e4f-c311-4ee0-8d6d-f3f2b6f22f63", 0, "Mehmet", "f57c30d1-0ea5-4cdd-bc9f-f92c46dd470b", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "928eebc7-0fba-420d-8d15-101324cfa787", "YILMAZ", null, false, "sistemAdmin" },
                    { "15b31bb4-0f10-48e0-85ae-ddb81392f56c", 0, "Ali", "f4121af0-4d86-4d6c-bda7-bdd3a36de4cd", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "81344bed-8cdb-49d6-8838-24a4249d0941", "DERİN", null, false, "iladmin" }
                });
        }
    }
}
