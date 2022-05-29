using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Villa.Persistence.Migrations
{
    public partial class mig9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "3b89b853-52f3-4f73-af19-15c95d39066a", "552315d2-152c-4fac-ab00-2352fd15b2ce", "sistemadmin", "SISTEMADMIN" },
                    { "78b6071e-6aae-44f8-8165-9e41c9decd35", "bbcdb865-f29a-4197-b6c6-9a364d327b4f", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9b8ac750-1e47-494e-be87-5ecb0efc9861", 0, "Ali", "acca9be3-26ac-4497-a9db-9b88b1449ae5", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "3ae49e21-b1b9-437e-b2cc-d99458c19b2c", "DERİN", null, false, "iladmin" },
                    { "ea82b974-3219-42bd-a994-7de296785cb0", 0, "Mehmet", "1c9fe368-f3f7-44a7-80e2-0d8ba3dc36dc", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "80b9abc9-664f-4ba1-b7fa-76e5ddac4205", "YILMAZ", null, false, "sistemAdmin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "3b89b853-52f3-4f73-af19-15c95d39066a");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "78b6071e-6aae-44f8-8165-9e41c9decd35");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "9b8ac750-1e47-494e-be87-5ecb0efc9861");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "ea82b974-3219-42bd-a994-7de296785cb0");

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
    }
}
