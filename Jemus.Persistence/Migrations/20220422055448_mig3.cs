using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jemus.Persistence.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("703d0bbb-ecdf-4402-9bc1-cf60384fb8ef"));

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("a553ddbd-219c-457b-a37a-41cf5ec8d7ab"));

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("e1c1dc1c-e346-471e-8141-dc5f9c3c5328"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("2e1ada02-ce74-4d99-8fef-31a3798097d7"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("2fbcb26e-7164-46c9-a9e5-6042893cce46"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("5042520a-919e-4c1a-8243-3f67690bb9ed"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("78734159-b68c-4fd6-832a-ec18a6879137"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("84936a2d-f89d-4789-ab36-c80ca7a7a26e"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("b676d942-f3f7-450d-8e7d-a00b32747256"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("c957e04c-3d3f-4e4b-a7ae-2e3aeee34d29"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("cffb1f69-709d-471c-9311-610a9c95e819"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("fce2c2b6-ffcd-4e72-ba3e-74997a21779b"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "0eec2cdd-0f20-4017-a657-5e007e0d813b");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "9eca2436-a0b8-49d9-bd5f-617bfd1efbce");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "d6ee5854-7b1a-4b6c-9012-2d6bb615e249");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "f363aabf-4825-4581-9215-add6ecfdd666");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "6c937a62-8596-4c83-b0f4-c897ebaf8fd3");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "754484b4-b2d3-43c5-8ec3-d587a6935621");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "User",
                type: "bytea",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "CreateDate", "Icon", "Label", "ParentMenuId", "RouteLink" },
                values: new object[,]
                {
                    { new Guid("4c5a7c02-3c47-4cc4-bf6b-eaeca8fe5c8f"), null, "fa fa-gavel", "Kullanıcı", null, "/kullanıcı" },
                    { new Guid("59cd63fe-403f-4aa1-8202-baaffb636a5a"), null, "pi pi-fw pi-globe", "Panel", null, "/" },
                    { new Guid("6fb65d0b-b839-4fdf-92f4-d8905285808e"), null, "fa fa-balance-scale", "Kullanıcı Grup", null, "/kullanicigrup" }
                });

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "Id", "CreateDate", "Name" },
                values: new object[,]
                {
                    { new Guid("0301b15b-f132-4817-9c1e-ead4e6cd7283"), null, "Permissions.Grup.All" },
                    { new Guid("09ad355a-fffe-46fa-8b74-79cb99316a1d"), null, "Permissions.Log.All" },
                    { new Guid("2360e0db-ad5e-449c-b33e-ac9e03407e68"), null, "Permissions.Credential.All" },
                    { new Guid("2776ffeb-6006-4d6c-bbb0-facde473a108"), null, "Permissions.Ilce.All" },
                    { new Guid("2ed60f60-125e-493b-b3a6-d68e552e887e"), null, "Permissions.Genel.All" },
                    { new Guid("c86f918a-1b82-42ac-9937-5fa1bab21778"), null, "Permissions.KullaniciGrup.All" },
                    { new Guid("c89095f3-3a9b-4046-b2ac-f778fea7e903"), null, "Permissions.Kullanici.All" },
                    { new Guid("f2e03049-9922-46ac-879f-2dbd9b72e253"), null, "Permissions.Ayarlar.All" },
                    { new Guid("f9e008b3-ff08-4bde-976b-de206eb2b24d"), null, "Permissions.Il.All" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0580b1f8-802e-4383-9496-6cb4faaac96c", "58e0d2b3-fb8b-4423-ba99-1f3bd0a7636d", "karakol", "KARAKOL" },
                    { "12ba0291-f94f-4a23-a0de-e2010900fa89", "7c79592c-2599-45d9-bde8-dcf4a13b9b23", "ılceadmın", "ILCEADMIN" },
                    { "e082339f-3db0-4e32-a6b0-b8f87c28386c", "859710b2-a970-4108-aa8c-5bd5bf42f998", "sıstemadmın", "SISTEMADMIN" },
                    { "f10b48ca-4b8a-40cc-83c7-f55d36d1dee6", "3f44f5c6-7d91-444b-8a65-0c5d7ee5a6bc", "ıladmın", "ILADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "Image", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SicilNo", "Soyad", "TCKN", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "362f51b6-0874-4726-aacd-49cc0bc720d3", 0, "Mehmet", "365f7eda-6641-4161-8fb9-283903e745d9", "sistemAdmin@gmail.com", false, null, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "030190b7-c57d-4d7d-8d4a-e62040deed70", null, "YILMAZ", null, null, false, "sistemAdmin" },
                    { "bc4c009c-065d-4a5f-b200-427b05f66776", 0, "Ali", "7d2bcb2b-4910-4ae5-9e1d-ccb7edf558a9", "iladmin@gmail.com", false, null, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "d2a2d172-931f-4e4d-b19d-55511bb833f6", null, "DERİN", null, null, false, "iladmin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("4c5a7c02-3c47-4cc4-bf6b-eaeca8fe5c8f"));

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("59cd63fe-403f-4aa1-8202-baaffb636a5a"));

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("6fb65d0b-b839-4fdf-92f4-d8905285808e"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("0301b15b-f132-4817-9c1e-ead4e6cd7283"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("09ad355a-fffe-46fa-8b74-79cb99316a1d"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("2360e0db-ad5e-449c-b33e-ac9e03407e68"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("2776ffeb-6006-4d6c-bbb0-facde473a108"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("2ed60f60-125e-493b-b3a6-d68e552e887e"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("c86f918a-1b82-42ac-9937-5fa1bab21778"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("c89095f3-3a9b-4046-b2ac-f778fea7e903"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("f2e03049-9922-46ac-879f-2dbd9b72e253"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("f9e008b3-ff08-4bde-976b-de206eb2b24d"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "0580b1f8-802e-4383-9496-6cb4faaac96c");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "12ba0291-f94f-4a23-a0de-e2010900fa89");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "e082339f-3db0-4e32-a6b0-b8f87c28386c");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "f10b48ca-4b8a-40cc-83c7-f55d36d1dee6");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "362f51b6-0874-4726-aacd-49cc0bc720d3");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "bc4c009c-065d-4a5f-b200-427b05f66776");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "User");

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "CreateDate", "Icon", "Label", "ParentMenuId", "RouteLink" },
                values: new object[,]
                {
                    { new Guid("703d0bbb-ecdf-4402-9bc1-cf60384fb8ef"), null, "fa fa-gavel", "Kullanıcı", null, "/kullanıcı" },
                    { new Guid("a553ddbd-219c-457b-a37a-41cf5ec8d7ab"), null, "fa fa-balance-scale", "Kullanıcı Grup", null, "/kullanicigrup" },
                    { new Guid("e1c1dc1c-e346-471e-8141-dc5f9c3c5328"), null, "pi pi-fw pi-globe", "Panel", null, "/" }
                });

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "Id", "CreateDate", "Name" },
                values: new object[,]
                {
                    { new Guid("2e1ada02-ce74-4d99-8fef-31a3798097d7"), null, "Permissions.Grup.All" },
                    { new Guid("2fbcb26e-7164-46c9-a9e5-6042893cce46"), null, "Permissions.Log.All" },
                    { new Guid("5042520a-919e-4c1a-8243-3f67690bb9ed"), null, "Permissions.Genel.All" },
                    { new Guid("78734159-b68c-4fd6-832a-ec18a6879137"), null, "Permissions.Ayarlar.All" },
                    { new Guid("84936a2d-f89d-4789-ab36-c80ca7a7a26e"), null, "Permissions.Ilce.All" },
                    { new Guid("b676d942-f3f7-450d-8e7d-a00b32747256"), null, "Permissions.KullaniciGrup.All" },
                    { new Guid("c957e04c-3d3f-4e4b-a7ae-2e3aeee34d29"), null, "Permissions.Credential.All" },
                    { new Guid("cffb1f69-709d-471c-9311-610a9c95e819"), null, "Permissions.Il.All" },
                    { new Guid("fce2c2b6-ffcd-4e72-ba3e-74997a21779b"), null, "Permissions.Kullanici.All" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0eec2cdd-0f20-4017-a657-5e007e0d813b", "3e4042a8-bd97-47fe-9cba-deb16d2c69d8", "ılceadmın", "ILCEADMIN" },
                    { "9eca2436-a0b8-49d9-bd5f-617bfd1efbce", "1e2206ed-baaa-4f4a-99d3-8f3d988f47a5", "karakol", "KARAKOL" },
                    { "d6ee5854-7b1a-4b6c-9012-2d6bb615e249", "ace32bf5-ed4c-446a-a80c-e128b357227e", "ıladmın", "ILADMIN" },
                    { "f363aabf-4825-4581-9215-add6ecfdd666", "114e328c-dc28-4e77-9df3-bd6fea157a59", "sıstemadmın", "SISTEMADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SicilNo", "Soyad", "TCKN", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6c937a62-8596-4c83-b0f4-c897ebaf8fd3", 0, "Mehmet", "2ee8b2f9-dae1-4448-9f33-854719af19b6", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "b7a2918d-5352-48e2-b886-8ad65494011e", null, "YILMAZ", null, null, false, "sistemAdmin" },
                    { "754484b4-b2d3-43c5-8ec3-d587a6935621", 0, "Ali", "37d3760c-12dd-4603-8192-8e8b055f9a19", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "f909284a-fd0b-4288-813a-5c9ca3448415", null, "DERİN", null, null, false, "iladmin" }
                });
        }
    }
}
