using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Villa.Persistence.Migrations
{
    public partial class mig17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "1afb403c-dc3e-4dec-ad8d-80d13f575a4a");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "1e67d35f-8e3d-4d6e-acd9-aa6c6a560114");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "c80a4bf6-635f-4391-94cb-7c83e79a5476");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "e0487165-b6c1-4be1-8d9f-2ab0485f9172");

            migrationBuilder.AddColumn<string>(
                name: "BulletinNo",
                table: "ExchangeRates",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "533befc1-6d9a-4f46-a983-36f2b52b8c14", "99ca61c8-0e99-4857-9aba-5a9cce334e92", "sistemadmin", "SISTEMADMIN" },
                    { "ce895bc7-7a9a-46db-b363-15b3387a98d6", "45d4379a-8486-4f24-a542-69b8bf55ef3f", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "05cf12bc-8e08-4bc1-afaf-c7271a37318e", 0, "Mehmet", "fc8c1bdb-5dd6-485b-ba6e-2ea28e958ab6", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "63e5f720-e2c3-4586-97c4-f1113e53540f", "YILMAZ", null, false, "sistemAdmin" },
                    { "c879ac89-134a-493d-848b-75be0c1d504c", 0, "Ali", "3a4d13b9-c38d-498c-9bed-e61c88134409", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "4a7d6eda-fd21-42ec-9106-afacbb18768f", "DERİN", null, false, "iladmin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "533befc1-6d9a-4f46-a983-36f2b52b8c14");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "ce895bc7-7a9a-46db-b363-15b3387a98d6");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "05cf12bc-8e08-4bc1-afaf-c7271a37318e");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "c879ac89-134a-493d-848b-75be0c1d504c");

            migrationBuilder.DropColumn(
                name: "BulletinNo",
                table: "ExchangeRates");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1afb403c-dc3e-4dec-ad8d-80d13f575a4a", "9ef04c66-b3ce-46b7-86fb-945f2c47b143", "admin", "ADMIN" },
                    { "1e67d35f-8e3d-4d6e-acd9-aa6c6a560114", "ae2ef62b-cbf1-4e85-8480-6a84f445a221", "sistemadmin", "SISTEMADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "c80a4bf6-635f-4391-94cb-7c83e79a5476", 0, "Ali", "01c6de86-b498-4119-a673-5bacda72a69b", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "5fdee7fd-d4f6-4546-a40d-f9616c7f8e61", "DERİN", null, false, "iladmin" },
                    { "e0487165-b6c1-4be1-8d9f-2ab0485f9172", 0, "Mehmet", "f8c0213d-ecf0-44c4-a50b-6d90c858d3e0", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "0d8624b5-6294-4a7f-a1d7-9ca448cfc09a", "YILMAZ", null, false, "sistemAdmin" }
                });
        }
    }
}
