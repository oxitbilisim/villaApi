using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Villa.Persistence.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bolge_Il_IlId",
                table: "Bolge");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Bolge_Il_IlId",
                table: "Bolge",
                column: "IlId",
                principalTable: "Il",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bolge_Il_IlId",
                table: "Bolge");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Bolge_Il_IlId",
                table: "Bolge",
                column: "IlId",
                principalTable: "Il",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
