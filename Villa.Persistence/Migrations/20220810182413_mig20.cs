using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Villa.Persistence.Migrations
{
    public partial class mig20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "0a18a5fb-9289-4727-8cb8-192aa3fe37ab");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "5cfa46b1-a378-47d3-a2b3-9a58c22ffc99");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "98484467-1c42-4a77-855b-9aba4448ef58");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "f8cbe930-a2a4-423e-914c-a9a05c760c65");

            migrationBuilder.AddColumn<bool>(
                name: "KapakResmi",
                table: "VillaImageDetay",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "KapakResmi",
                table: "VillaImage",
                type: "boolean",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ca161381-9e85-4e99-ac13-6cd607e6cbea", "8d2847c6-d147-43d8-aa7d-5d4da3b6c3d2", "admin", "ADMİN" },
                    { "ded1131d-6e4a-4e7f-a370-9df9536386c5", "2546a6cd-1590-4573-bae7-e286634fdf64", "sistemadmin", "SİSTEMADMİN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6c7a111b-2f70-4043-96b7-d540cfdcc364", 0, "Mehmet", "e707fb96-14aa-4948-898d-976b6e192ae7", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "36cbbdd6-0a48-44b7-84a2-104eb718607d", "YILMAZ", null, false, "sistemAdmin" },
                    { "7608571d-1536-48d8-a19e-520e43b19052", 0, "Ali", "25ab32e6-1dfe-40a7-8cb4-ea8fcc0a550f", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "6798748c-d954-4141-a9c1-f50950fe0a53", "DERİN", null, false, "iladmin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "ca161381-9e85-4e99-ac13-6cd607e6cbea");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "ded1131d-6e4a-4e7f-a370-9df9536386c5");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "6c7a111b-2f70-4043-96b7-d540cfdcc364");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "7608571d-1536-48d8-a19e-520e43b19052");

            migrationBuilder.DropColumn(
                name: "KapakResmi",
                table: "VillaImageDetay");

            migrationBuilder.DropColumn(
                name: "KapakResmi",
                table: "VillaImage");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a18a5fb-9289-4727-8cb8-192aa3fe37ab", "6acf7bf1-b56b-4f4b-a5b2-39a7524f2b54", "sistemadmin", "SİSTEMADMİN" },
                    { "5cfa46b1-a378-47d3-a2b3-9a58c22ffc99", "24da8e88-770a-4b34-bb79-33faea2d92a8", "admin", "ADMİN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "98484467-1c42-4a77-855b-9aba4448ef58", 0, "Ali", "85d43589-7c4b-4faf-b057-d295074d7da3", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "a0f4c7c9-98c8-4159-9bc6-181b245dbf33", "DERİN", null, false, "iladmin" },
                    { "f8cbe930-a2a4-423e-914c-a9a05c760c65", 0, "Mehmet", "ef4b683a-6f68-4b2d-9d85-3f6d83edba3e", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "b0dfceb1-6887-4af7-ac87-6d7336a9ba2c", "YILMAZ", null, false, "sistemAdmin" }
                });
        }
    }
}
