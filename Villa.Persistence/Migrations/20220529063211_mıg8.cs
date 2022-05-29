using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Villa.Persistence.Migrations
{
    public partial class mıg8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "7923438a-a562-45ad-921a-5d7cf29509b7");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "90c2fdc6-4ce2-43cc-aa24-0206e48d0848");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "8f2ce1c1-e9ec-4f29-9ec1-91d91dad50c5");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "d95d457d-090a-4f2a-b78e-e8d98e54c600");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "284359c3-d7be-4038-956b-7eb8087068c2", "a5b901cf-3f4a-4291-a80c-31726c01bcfe", "admin", "ADMIN" },
                    { "3270b98d-5c10-457a-b272-340b8e3cd076", "72bf5a22-022e-4eee-9e16-11adca3aa218", "sistemadmin", "SISTEMADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "51771b24-b7f9-43ca-8d47-99f59f51ecf6", 0, "Mehmet", "90faa4ed-953e-4d32-b2b0-061c03e7dc85", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "bb717399-5d8f-41e2-a5c9-e24583cb8436", "YILMAZ", null, false, "sistemAdmin" },
                    { "bd8faa4e-c877-41f0-b37c-7b7bda92fcdf", 0, "Ali", "696103a4-5513-43bc-a8ba-8f5ab0e0aee6", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "ee58b6f4-9947-44ae-a751-75b10f7bba86", "DERİN", null, false, "iladmin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "284359c3-d7be-4038-956b-7eb8087068c2");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "3270b98d-5c10-457a-b272-340b8e3cd076");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "51771b24-b7f9-43ca-8d47-99f59f51ecf6");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "bd8faa4e-c877-41f0-b37c-7b7bda92fcdf");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7923438a-a562-45ad-921a-5d7cf29509b7", "2f87d954-8a15-46ef-b6ad-92c26770f96e", "admin", "ADMIN" },
                    { "90c2fdc6-4ce2-43cc-aa24-0206e48d0848", "d28840c3-3c35-44ce-8180-d2a6e6fb61f4", "sistemadmin", "SISTEMADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8f2ce1c1-e9ec-4f29-9ec1-91d91dad50c5", 0, "Mehmet", "a2ee9438-5e73-4a2a-bd19-e8ee7e2fd4a9", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "92dd4e31-8d01-45eb-b4d5-b02fd4effe36", "YILMAZ", null, false, "sistemAdmin" },
                    { "d95d457d-090a-4f2a-b78e-e8d98e54c600", 0, "Ali", "611c4f29-317e-4f48-95cc-a6fd004b2d52", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "bfb899a5-d170-45ab-ae21-0ca7e0e4887e", "DERİN", null, false, "iladmin" }
                });
        }
    }
}
