using Microsoft.EntityFrameworkCore.Migrations;

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
                keyValue: "59a77b2c-f88e-4ca4-ab13-67079b681bb2");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "c6fd87da-eec8-43b4-98af-6ce22a0bfa45");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "c5f7c4d9-fb37-4175-9e47-637e2955be13");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "cbe72b4b-009b-48c3-9eb4-3dadcd9566a6");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0c52049a-87aa-419d-9d6a-01eaad421ac0", "3035a2ec-6a38-4341-b5ff-c2e6511938f0", "sistemadmin", "SİSTEMADMİN" },
                    { "ceda8628-c1ca-43d8-8d12-fa5d9b73f73f", "18e3b132-296d-4b50-be72-1dcf662d7b31", "admin", "ADMİN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "403983a9-551c-42e1-8be6-e765b73e5c1f", 0, "Ali", "880fd9b7-a9b3-4f7d-b558-df6ff6dd1828", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "9ef17417-04ba-4660-a239-dce2e886e63e", "DERİN", null, false, "iladmin" },
                    { "cc62ca50-08f0-4601-966a-34291b45350c", 0, "Mehmet", "7de5aa39-2d59-499d-8a55-93784ddf4d6d", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "e7cc811e-3284-496b-ae96-2dee7e269657", "YILMAZ", null, false, "sistemAdmin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "0c52049a-87aa-419d-9d6a-01eaad421ac0");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "ceda8628-c1ca-43d8-8d12-fa5d9b73f73f");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "403983a9-551c-42e1-8be6-e765b73e5c1f");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "cc62ca50-08f0-4601-966a-34291b45350c");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "59a77b2c-f88e-4ca4-ab13-67079b681bb2", "ed8aa70c-5721-430d-866b-83ac35447ce0", "sistemadmin", "SİSTEMADMİN" },
                    { "c6fd87da-eec8-43b4-98af-6ce22a0bfa45", "861e2b97-3ac0-43b9-a99a-20634cabbe87", "admin", "ADMİN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "c5f7c4d9-fb37-4175-9e47-637e2955be13", 0, "Ali", "78a6c322-c76b-47b8-9247-9343c0799b16", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "c1985767-7d8c-43e7-8083-66a5bbbef46b", "DERİN", null, false, "iladmin" },
                    { "cbe72b4b-009b-48c3-9eb4-3dadcd9566a6", 0, "Mehmet", "990b2b43-9410-4b81-ac09-e054871b0666", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "82f341cc-bfcd-45b6-b138-46ef58d3c4ab", "YILMAZ", null, false, "sistemAdmin" }
                });
        }
    }
}
