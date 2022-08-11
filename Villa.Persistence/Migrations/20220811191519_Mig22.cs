using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Villa.Persistence.Migrations
{
    public partial class Mig22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "BlogKategoriId",
                table: "Blog",
                type: "integer",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5d1d80ea-8964-4fdf-baf8-e943d0285367", "acb89d8d-f3bb-40bc-838a-c20b06188dcb", "admin", "ADMİN" },
                    { "912a9452-ae96-4ffc-ac67-648130ec8d37", "f3fc1899-67c8-4f07-b208-2f3e9610adea", "sistemadmin", "SİSTEMADMİN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0a088e4f-c311-4ee0-8d6d-f3f2b6f22f63", 0, "Mehmet", "f57c30d1-0ea5-4cdd-bc9f-f92c46dd470b", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "928eebc7-0fba-420d-8d15-101324cfa787", "YILMAZ", null, false, "sistemAdmin" },
                    { "15b31bb4-0f10-48e0-85ae-ddb81392f56c", 0, "Ali", "f4121af0-4d86-4d6c-bda7-bdd3a36de4cd", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "81344bed-8cdb-49d6-8838-24a4249d0941", "DERİN", null, false, "iladmin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blog_BlogKategoriId",
                table: "Blog",
                column: "BlogKategoriId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blog_BlogKategori_BlogKategoriId",
                table: "Blog",
                column: "BlogKategoriId",
                principalTable: "BlogKategori",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blog_BlogKategori_BlogKategoriId",
                table: "Blog");

            migrationBuilder.DropIndex(
                name: "IX_Blog_BlogKategoriId",
                table: "Blog");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "5d1d80ea-8964-4fdf-baf8-e943d0285367");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "912a9452-ae96-4ffc-ac67-648130ec8d37");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "0a088e4f-c311-4ee0-8d6d-f3f2b6f22f63");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "15b31bb4-0f10-48e0-85ae-ddb81392f56c");

            migrationBuilder.DropColumn(
                name: "BlogKategoriId",
                table: "Blog");

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
    }
}
