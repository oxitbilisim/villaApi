using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Villa.Persistence.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kategori_Kategori_ParentKategoriId",
                table: "Kategori");

            migrationBuilder.DropIndex(
                name: "IX_Kategori_ParentKategoriId",
                table: "Kategori");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "4d57206e-9286-491e-96a8-f9898bd1f00b");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "c01baf98-caf8-4f8e-8885-d377ae0f735c");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "1a9464fa-fafe-4de0-890e-7ec88d7652d5");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "59adaa38-ff81-46ee-9f3b-496346d87ec4");

            migrationBuilder.AddColumn<int>(
                name: "KategoriId",
                table: "Kategori",
                type: "integer",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1ffd73f6-29e4-469d-bfe4-50967fa0e639", "74afe192-8d4c-4fb1-a577-561848cfff10", "admin", "ADMIN" },
                    { "5e2512bc-0716-402e-9e74-3f6a6e9ac9c1", "db42b294-eea9-465b-962e-fee6d3d87011", "sistemadmin", "SISTEMADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7f6fdddf-63ea-437b-b38c-5707544ca518", 0, "Mehmet", "53d5e86c-52c1-4d40-8183-c99a51abf71d", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "24d484eb-e3ee-495f-b5d6-fae1ac415ad3", "YILMAZ", null, false, "sistemAdmin" },
                    { "93e571d7-04c4-4c6c-94b4-1bcbecfe421e", 0, "Ali", "0f5bfd55-9323-4e79-a1cd-0959ababcb65", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "b04677dd-0475-4de3-b67c-fb34ba3508db", "DERİN", null, false, "iladmin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kategori_KategoriId",
                table: "Kategori",
                column: "KategoriId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kategori_Kategori_KategoriId",
                table: "Kategori",
                column: "KategoriId",
                principalTable: "Kategori",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kategori_Kategori_KategoriId",
                table: "Kategori");

            migrationBuilder.DropIndex(
                name: "IX_Kategori_KategoriId",
                table: "Kategori");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "1ffd73f6-29e4-469d-bfe4-50967fa0e639");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "5e2512bc-0716-402e-9e74-3f6a6e9ac9c1");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "7f6fdddf-63ea-437b-b38c-5707544ca518");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "93e571d7-04c4-4c6c-94b4-1bcbecfe421e");

            migrationBuilder.DropColumn(
                name: "KategoriId",
                table: "Kategori");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4d57206e-9286-491e-96a8-f9898bd1f00b", "e00ce3a8-6b08-4685-ad92-0b160824bf25", "sistemadmin", "SISTEMADMIN" },
                    { "c01baf98-caf8-4f8e-8885-d377ae0f735c", "81f43c1b-9e9b-4fcf-92e1-14c6bac9a42b", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1a9464fa-fafe-4de0-890e-7ec88d7652d5", 0, "Ali", "8a914b02-6ce5-4157-95ba-f41364f066fd", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "285baab4-46e2-46ad-8f43-787b71a5cf25", "DERİN", null, false, "iladmin" },
                    { "59adaa38-ff81-46ee-9f3b-496346d87ec4", 0, "Mehmet", "44706192-e907-4c6c-98d0-63217edbd10c", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "644f9f23-a2cf-45d1-ad51-6c0c0f83d468", "YILMAZ", null, false, "sistemAdmin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kategori_ParentKategoriId",
                table: "Kategori",
                column: "ParentKategoriId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kategori_Kategori_ParentKategoriId",
                table: "Kategori",
                column: "ParentKategoriId",
                principalTable: "Kategori",
                principalColumn: "Id");
        }
    }
}
