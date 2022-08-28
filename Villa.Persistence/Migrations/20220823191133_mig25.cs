using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Villa.Persistence.Migrations
{
    public partial class mig25 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "b2ce721e-ff02-4dfc-b50a-152006961318");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "c1bdcd98-5487-41a8-b13a-0ab74d53f57b");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "60125a63-89bd-4e0b-891c-bd46b0987b05");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "6c560ede-63cb-4b1f-babf-43210e6358b2");

            migrationBuilder.AddColumn<decimal>(
                name: "TryOran",
                table: "ParaBirimi",
                type: "numeric",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1e5531e7-d925-4b00-8510-bb45dc511757", "0b3c62c0-496b-4f4b-b91b-6efea5afdd49", "sistemadmin", "SISTEMADMIN" },
                    { "c33e84ca-f6e5-4b6e-9ff7-f456a15a19c1", "0f61fcb7-3167-4dd0-a505-f72f432e78b2", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "20ebd8e6-9770-46fb-a51d-509bb9d65f16", 0, "Ali", "f6287cfb-5447-4abe-baa7-fb8342677397", "iladmin@gmail.com", false, null, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "6a138b43-1986-491b-aef0-25d7635f5e2e", "DERİN", null, false, "iladmin" },
                    { "4be67265-0f18-4f8b-b014-79077a0fe035", 0, "Mehmet", "32855df2-ae77-498a-ad0a-329169c3cd2a", "sistemAdmin@gmail.com", false, null, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "3e66b8f8-728a-467f-afff-140314ebd5fd", "YILMAZ", null, false, "sistemAdmin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "1e5531e7-d925-4b00-8510-bb45dc511757");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "c33e84ca-f6e5-4b6e-9ff7-f456a15a19c1");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "20ebd8e6-9770-46fb-a51d-509bb9d65f16");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "4be67265-0f18-4f8b-b014-79077a0fe035");

            migrationBuilder.DropColumn(
                name: "TryOran",
                table: "ParaBirimi");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b2ce721e-ff02-4dfc-b50a-152006961318", "b3da7ede-81f3-4a4e-b69b-60a20a2d9248", "admin", "ADMİN" },
                    { "c1bdcd98-5487-41a8-b13a-0ab74d53f57b", "8343a4e7-83d4-4443-96e2-15241a3c68a3", "sistemadmin", "SİSTEMADMİN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "60125a63-89bd-4e0b-891c-bd46b0987b05", 0, "Mehmet", "53305e8d-13a8-42f4-9f2d-fd11b64a0312", "sistemAdmin@gmail.com", false, null, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "93447023-6721-4857-b07b-543b5b45d769", "YILMAZ", null, false, "sistemAdmin" },
                    { "6c560ede-63cb-4b1f-babf-43210e6358b2", 0, "Ali", "4544e97e-68fe-42ff-9c0d-e8d1f1f49432", "iladmin@gmail.com", false, null, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "b4077b02-face-4d9a-8663-2e071a91466d", "DERİN", null, false, "iladmin" }
                });
        }
    }
}
