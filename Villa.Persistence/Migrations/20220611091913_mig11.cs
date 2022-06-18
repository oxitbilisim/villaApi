using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Villa.Persistence.Migrations
{
    public partial class mig11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "MarktUzaklik",
                table: "VillaLokasyon",
                type: "text",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "MarktUzaklik",
                table: "VillaLokasyon");

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
    }
}
