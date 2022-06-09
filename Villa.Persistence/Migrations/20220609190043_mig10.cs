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
                keyValue: "8b5ab507-2768-4b1f-814b-79325e572e3b");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "c821e915-84c9-45ce-8587-867d3b409abf");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "41fe2f24-06a7-4591-be5e-2af6875b041a");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "4c9961ef-39d6-4c7e-b130-ff6372fb0664");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0356625e-3e38-489c-a617-b94db26b368d", "11b1a26d-fe32-48df-9238-56c54efd5f82", "admin", "ADMIN" },
                    { "50569992-a145-4a03-b5bd-b4e5e1095077", "b0b9d624-d3f1-495c-9657-7fde4ebb016a", "sistemadmin", "SISTEMADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3ea50d5e-3e73-4a6c-a54f-ff8613193a50", 0, "Mehmet", "5e63d76a-2125-45f8-86d8-3506b5d0a1e2", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "218155ed-d430-4740-9a4c-6bfa7731cd9e", "YILMAZ", null, false, "sistemAdmin" },
                    { "7d5906fa-7214-4ad6-ab0f-18f529f8e361", 0, "Ali", "124ace1a-1ba7-4962-9045-1752b7605343", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "9631e19b-34a0-4720-b405-dbeec8e5b8b0", "DERİN", null, false, "iladmin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "0356625e-3e38-489c-a617-b94db26b368d");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "50569992-a145-4a03-b5bd-b4e5e1095077");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3ea50d5e-3e73-4a6c-a54f-ff8613193a50");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "7d5906fa-7214-4ad6-ab0f-18f529f8e361");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8b5ab507-2768-4b1f-814b-79325e572e3b", "807a13e9-a469-4ec6-bb6d-7f50e0afcb7c", "sistemadmin", "SISTEMADMIN" },
                    { "c821e915-84c9-45ce-8587-867d3b409abf", "9fcc6ac0-0b92-4461-aa7a-455ffb7893b6", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "41fe2f24-06a7-4591-be5e-2af6875b041a", 0, "Mehmet", "80c0d44e-47b5-4028-bf3d-2a2e53b760ef", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "3784d1ad-1f6f-4fe4-8d3d-c18a44411517", "YILMAZ", null, false, "sistemAdmin" },
                    { "4c9961ef-39d6-4c7e-b130-ff6372fb0664", 0, "Ali", "ef7ad575-04c8-42ef-873a-5c1b48183176", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "cd544da6-e0ce-4880-9bba-62de46157dd3", "DERİN", null, false, "iladmin" }
                });
        }
    }
}
