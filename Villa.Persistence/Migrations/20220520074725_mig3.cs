using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Villa.Persistence.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "0c118ae8-b5b3-4a4f-906d-2b241d64a8b5", "ef3c8319-ba55-4ea4-b6be-8c85f0c017a2", "admin", "ADMIN" },
                    { "b30c3a92-ac7e-43e6-b2cf-fc669b73ddc0", "98bb3e68-584b-4d7f-a8ce-f91d6a74d9c0", "sistemadmin", "SISTEMADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "81e5b92a-23d2-4481-9772-6158ca7f28ee", 0, "Ali", "1da7642b-c3b9-4f1e-83df-ee47c76c4d4a", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "a6b9dfeb-0c06-44b8-9a9c-ed5144268e02", "DERİN", null, false, "iladmin" },
                    { "91686229-a445-4609-883c-3e896a6325ac", 0, "Mehmet", "5cd59ce7-de9b-4a42-888b-6fe3b9818196", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "2a498d06-29a0-4ec8-8198-6b3e7ed10034", "YILMAZ", null, false, "sistemAdmin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "0c118ae8-b5b3-4a4f-906d-2b241d64a8b5");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "b30c3a92-ac7e-43e6-b2cf-fc669b73ddc0");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "81e5b92a-23d2-4481-9772-6158ca7f28ee");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "91686229-a445-4609-883c-3e896a6325ac");

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
    }
}
