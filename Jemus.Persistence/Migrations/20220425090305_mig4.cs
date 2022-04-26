using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jemus.Persistence.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "Eposta",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "TCKN",
                table: "User",
                newName: "PbikId");

            migrationBuilder.RenameColumn(
                name: "SicilNo",
                table: "User",
                newName: "Ou");

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "CreateDate", "Icon", "Label", "ParentMenuId", "RouteLink" },
                values: new object[,]
                {
                    { new Guid("1574b190-af14-45c0-a9ce-44995a9acf4b"), null, "pi pi-fw pi-globe", "Panel", null, "/" },
                    { new Guid("4f702cb1-115c-4360-a033-c3f262d11108"), null, "fa fa-balance-scale", "Kullanıcı Grup", null, "/kullanicigrup" },
                    { new Guid("a1605cb9-b74c-4749-820c-d6511a7bae10"), null, "fa fa-gavel", "Kullanıcı", null, "/kullanıcı" }
                });

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "Id", "CreateDate", "Name" },
                values: new object[,]
                {
                    { new Guid("124a8bd5-3fd7-45c8-be8a-c61cbe113a34"), null, "Permissions.Credential.All" },
                    { new Guid("12fc4fad-21c0-4f07-984b-2e0b2984a0d1"), null, "Permissions.Ilce.All" },
                    { new Guid("38c8920f-0fc7-45f0-9314-1c5cccefd240"), null, "Permissions.KullaniciGrup.All" },
                    { new Guid("5287b272-90b8-441c-9473-0c4a50a9722b"), null, "Permissions.Log.All" },
                    { new Guid("691f17b5-96af-4fd4-ab8c-1e6794e45756"), null, "Permissions.Ayarlar.All" },
                    { new Guid("7cb0987e-8c33-4385-97ff-da7a1937143a"), null, "Permissions.Il.All" },
                    { new Guid("88861925-bb56-48ca-920c-18bf5422bf5f"), null, "Permissions.Genel.All" },
                    { new Guid("9178b8c4-7065-440a-bd19-f0e1dbeeaad9"), null, "Permissions.Kullanici.All" },
                    { new Guid("cbb8c920-8570-4890-bdcf-d67bac38f829"), null, "Permissions.Grup.All" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0f294b1d-05a5-4f50-980b-034747df35ea", "e65a9fed-c56f-4c11-bd4d-c0dcf892669a", "ılceadmın", "ILCEADMIN" },
                    { "4de7677d-05d8-454b-aa6c-005abea3605a", "685df13f-bad0-4c46-b630-a08ed4f01c43", "karakol", "KARAKOL" },
                    { "8421bc72-dfe3-4645-8949-b61fbe23d3b8", "60a303b8-a2bb-4f59-a925-a367b9d59a21", "sıstemadmın", "SISTEMADMIN" },
                    { "a53fb92d-884f-4fb4-8aa7-47bd958cbeeb", "4d165c25-1240-45b5-a0f7-ebd1dc98fd9f", "ıladmın", "ILADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Image", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Ou", "PasswordHash", "PbikId", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0e57293c-e168-4a1e-9e6b-e21f704bd4b3", 0, "Ali", "98a1c844-87e2-44f6-aa91-a0606508359b", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", null, "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, null, false, "3e950752-13ac-4dda-a727-89404592aa7d", "DERİN", null, false, "iladmin" },
                    { "7feb693c-864f-46c7-8ce7-4c5558905b3f", 0, "Mehmet", "34dd346f-a885-4e10-b7c6-21b43e69a9b7", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", null, "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, null, false, "22731e42-02cd-471a-9617-ed8107a8c24e", "YILMAZ", null, false, "sistemAdmin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("1574b190-af14-45c0-a9ce-44995a9acf4b"));

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("4f702cb1-115c-4360-a033-c3f262d11108"));

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("a1605cb9-b74c-4749-820c-d6511a7bae10"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("124a8bd5-3fd7-45c8-be8a-c61cbe113a34"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("12fc4fad-21c0-4f07-984b-2e0b2984a0d1"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("38c8920f-0fc7-45f0-9314-1c5cccefd240"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("5287b272-90b8-441c-9473-0c4a50a9722b"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("691f17b5-96af-4fd4-ab8c-1e6794e45756"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("7cb0987e-8c33-4385-97ff-da7a1937143a"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("88861925-bb56-48ca-920c-18bf5422bf5f"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("9178b8c4-7065-440a-bd19-f0e1dbeeaad9"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("cbb8c920-8570-4890-bdcf-d67bac38f829"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "0f294b1d-05a5-4f50-980b-034747df35ea");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "4de7677d-05d8-454b-aa6c-005abea3605a");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "8421bc72-dfe3-4645-8949-b61fbe23d3b8");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "a53fb92d-884f-4fb4-8aa7-47bd958cbeeb");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "0e57293c-e168-4a1e-9e6b-e21f704bd4b3");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "7feb693c-864f-46c7-8ce7-4c5558905b3f");

            migrationBuilder.RenameColumn(
                name: "PbikId",
                table: "User",
                newName: "TCKN");

            migrationBuilder.RenameColumn(
                name: "Ou",
                table: "User",
                newName: "SicilNo");

            migrationBuilder.AddColumn<string>(
                name: "Eposta",
                table: "User",
                type: "text",
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
    }
}
