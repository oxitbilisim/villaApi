using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Villa.Persistence.Migrations
{
    public partial class mig21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "VillaImage");

            migrationBuilder.AddColumn<int>(
                name: "BlogKategoriId",
                table: "BlogIcerik",
                type: "integer",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0ee0aac1-f93e-4837-af57-12eb696a91fa", "a97b5860-b1f1-45cd-92a0-b6ccc43c8d44", "admin", "ADMİN" },
                    { "9bc4727b-7c69-42bd-bdac-4fe7b8a2502a", "35afc142-110d-44d4-9015-73e4504fbbb4", "sistemadmin", "SİSTEMADMİN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7f6b0f00-a204-48b7-8596-43a67de9e65f", 0, "Ali", "18e23218-3000-4201-ab45-aac519a2fde7", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "54a1d6bb-5e64-4ea8-8c53-3881b7810eef", "DERİN", null, false, "iladmin" },
                    { "c0488dba-0ae5-454c-bdd0-1d31fd489138", 0, "Mehmet", "85b3c392-f8e8-4ab5-903c-d0d31bf70bba", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "633fe4f2-6a7d-4439-8a30-7a300a44a25b", "YILMAZ", null, false, "sistemAdmin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogIcerik_BlogKategoriId",
                table: "BlogIcerik",
                column: "BlogKategoriId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogIcerik_BlogKategori_BlogKategoriId",
                table: "BlogIcerik",
                column: "BlogKategoriId",
                principalTable: "BlogKategori",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogIcerik_BlogKategori_BlogKategoriId",
                table: "BlogIcerik");

            migrationBuilder.DropIndex(
                name: "IX_BlogIcerik_BlogKategoriId",
                table: "BlogIcerik");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "0ee0aac1-f93e-4837-af57-12eb696a91fa");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "9bc4727b-7c69-42bd-bdac-4fe7b8a2502a");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "7f6b0f00-a204-48b7-8596-43a67de9e65f");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "c0488dba-0ae5-454c-bdd0-1d31fd489138");

            migrationBuilder.DropColumn(
                name: "BlogKategoriId",
                table: "BlogIcerik");

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
    }
}
