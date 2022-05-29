using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Villa.Persistence.Migrations
{
    public partial class Mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "01cd9adc-74ab-44c0-a957-b7aaa349174b");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "6e2d8a62-6045-44dd-aeb1-58897d9df2af");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "568a892c-6bdd-4aeb-b62d-a701cd77cc74");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "833a91fb-9f35-40de-9608-a95b20030324");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3ef68887-72ea-4766-987b-ad5a50590870", "ccf4f7bb-9fc3-4daf-a950-ebf09e5b8c7f", "admin", "ADMIN" },
                    { "9647c946-2f3a-447f-a673-7348f39c74b8", "20429f18-44b2-46be-9e3d-ccaa1cf5daf2", "sistemadmin", "SISTEMADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1db0d779-4c7c-485a-bd6d-04adf9aea90a", 0, "Ali", "51b697f3-f320-4513-9c5a-600b4bc0eee2", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "9080f2b4-d70d-47a9-b7a9-960fa0a49588", "DERİN", null, false, "iladmin" },
                    { "6381b058-e213-41eb-aaf7-8be846d3884f", 0, "Mehmet", "a27cadb2-dffd-450b-888e-82f35298e671", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "71e6486d-8124-4067-99c6-1674d1f91119", "YILMAZ", null, false, "sistemAdmin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "3ef68887-72ea-4766-987b-ad5a50590870");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "9647c946-2f3a-447f-a673-7348f39c74b8");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "1db0d779-4c7c-485a-bd6d-04adf9aea90a");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "6381b058-e213-41eb-aaf7-8be846d3884f");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01cd9adc-74ab-44c0-a957-b7aaa349174b", "df47d7c0-4002-493d-a88c-02173a705e78", "sistemadmin", "SistemAdmin" },
                    { "6e2d8a62-6045-44dd-aeb1-58897d9df2af", "d437545b-b65c-40c9-ae85-f0f900bd7b7a", "admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "568a892c-6bdd-4aeb-b62d-a701cd77cc74", 0, "Mehmet", "6899835c-e0ed-41d2-a701-058fa8ebeed9", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "efd158a9-085f-4ea3-856f-169a1550c882", "YILMAZ", null, false, "sistemAdmin" },
                    { "833a91fb-9f35-40de-9608-a95b20030324", 0, "Ali", "7f7f3d1a-7a56-437c-8a54-a4b439ce36b5", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "be876edf-4b73-4aa1-a87c-8f451880cdff", "DERİN", null, false, "iladmin" }
                });
        }
    }
}
