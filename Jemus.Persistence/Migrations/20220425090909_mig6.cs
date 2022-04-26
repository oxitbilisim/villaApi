using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jemus.Persistence.Migrations
{
    public partial class mig6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("257d2d0d-0160-4b96-ab92-8cb74c0f3418"));

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("2c0ee904-e306-405e-b463-af793bf04a15"));

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("3f87a634-b80b-4f33-9fb3-551a7728c821"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("25999008-27ba-47d0-bcc6-ab93ee23e8c9"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("60c000a9-5ef2-4b06-bd08-d8bba345b249"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("68b7f6bb-e5b3-4ea1-95a8-4e534750358d"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("90dd5a55-f4f3-464f-95e0-ce1487266b7c"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("b596085c-7d5f-4fd6-9702-70341c101295"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("ba9f7131-6485-4568-b30d-04ef25c6a344"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("ec71334d-203f-4945-b780-d2c3f62c29ba"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("ed10487d-be21-49c9-9d35-54a25ca64081"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("f4d1e31d-6d3f-49cd-8c82-d97bfa911fcb"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "84975e0f-38fa-4d13-9896-ae39e04e3200");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "98bae1d1-2c50-4fa6-9737-636e0ea8258f");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "adf981e7-b649-4199-8a2e-aa6e4dc44f9b");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "d384cb88-b253-4653-a766-8a53e5bb4418");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "b650d79c-f3c5-4e9a-a93c-c527a6f561bb");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "f3de01f0-e383-48a4-b4cb-bdf61f14ac6a");

            migrationBuilder.RenameColumn(
                name: "ParentMenuId",
                table: "SorumlulukAlani",
                newName: "ParentSorumlulukId");

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "CreateDate", "Icon", "Label", "ParentMenuId", "RouteLink" },
                values: new object[,]
                {
                    { new Guid("50b1f015-03a9-4935-9d30-90e8c49966d3"), null, "fa fa-balance-scale", "Kullanıcı Grup", null, "/kullanicigrup" },
                    { new Guid("6ed5ee03-7983-44fb-8860-3c06b6cc1a4a"), null, "fa fa-gavel", "Kullanıcı", null, "/kullanıcı" },
                    { new Guid("7b517f65-724a-49db-9523-c506ae6afa27"), null, "pi pi-fw pi-globe", "Panel", null, "/" }
                });

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "Id", "CreateDate", "Name" },
                values: new object[,]
                {
                    { new Guid("41ae1b63-2ce8-42b0-b1db-e55e73715ab8"), null, "Permissions.Kullanici.All" },
                    { new Guid("4cd26874-a50b-4538-9ae9-46886f8b4df3"), null, "Permissions.Il.All" },
                    { new Guid("5188dbc3-9f30-43d8-a64f-43686450325c"), null, "Permissions.Log.All" },
                    { new Guid("7724e663-96d0-4274-b920-878d230b0bb2"), null, "Permissions.Grup.All" },
                    { new Guid("82578bb7-86ba-43fa-8a76-da864051fbc1"), null, "Permissions.KullaniciGrup.All" },
                    { new Guid("9db02143-390c-4416-8df7-cbf2aff54292"), null, "Permissions.Ilce.All" },
                    { new Guid("bc4297b8-227e-4eca-9c4d-09eae0e7b823"), null, "Permissions.Genel.All" },
                    { new Guid("e7ff1cce-6c15-4c7c-b15f-7b1b58c7fbf1"), null, "Permissions.Ayarlar.All" },
                    { new Guid("f559fc1c-1114-4bfa-b967-5d9d092dcd43"), null, "Permissions.Credential.All" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1c90fa1d-af09-4ab4-bede-094f72319140", "e625c018-3cda-462d-bfa8-1b1b1e05bba2", "ıladmın", "ILADMIN" },
                    { "23566e7c-d445-4336-a8a7-276d5c391ac8", "22dcfa75-41af-4899-898e-2fec370e1a2e", "karakol", "KARAKOL" },
                    { "27606f01-90ee-4afc-97b2-224c7f2a7c50", "1334b932-658c-4ae3-a95e-28bf48fb31b8", "ılceadmın", "ILCEADMIN" },
                    { "3ca52bc8-e54b-4795-bb5b-c4c7aadb1551", "b1d4796b-cfab-45af-836f-497d5ca4cecd", "sıstemadmın", "SISTEMADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Image", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Ou", "PasswordHash", "PbikId", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a112ee59-60a4-4287-a7ec-58a282363d3e", 0, "Ali", "cc33a6b6-f114-48c6-9565-86260830c4b3", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", null, "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, null, false, "5a7363b7-b438-4183-b4fe-0a1a02636beb", "DERİN", null, false, "iladmin" },
                    { "fba9e190-a994-4290-b92a-a73462f8cd9c", 0, "Mehmet", "c3b40ec1-3eb9-4565-9f2f-41f44b1875be", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", null, "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, null, false, "9fec4d05-cc30-4b00-8e24-d613c7afdc66", "YILMAZ", null, false, "sistemAdmin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("50b1f015-03a9-4935-9d30-90e8c49966d3"));

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("6ed5ee03-7983-44fb-8860-3c06b6cc1a4a"));

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("7b517f65-724a-49db-9523-c506ae6afa27"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("41ae1b63-2ce8-42b0-b1db-e55e73715ab8"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("4cd26874-a50b-4538-9ae9-46886f8b4df3"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("5188dbc3-9f30-43d8-a64f-43686450325c"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("7724e663-96d0-4274-b920-878d230b0bb2"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("82578bb7-86ba-43fa-8a76-da864051fbc1"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("9db02143-390c-4416-8df7-cbf2aff54292"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("bc4297b8-227e-4eca-9c4d-09eae0e7b823"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("e7ff1cce-6c15-4c7c-b15f-7b1b58c7fbf1"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("f559fc1c-1114-4bfa-b967-5d9d092dcd43"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "1c90fa1d-af09-4ab4-bede-094f72319140");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "23566e7c-d445-4336-a8a7-276d5c391ac8");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "27606f01-90ee-4afc-97b2-224c7f2a7c50");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "3ca52bc8-e54b-4795-bb5b-c4c7aadb1551");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "a112ee59-60a4-4287-a7ec-58a282363d3e");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "fba9e190-a994-4290-b92a-a73462f8cd9c");

            migrationBuilder.RenameColumn(
                name: "ParentSorumlulukId",
                table: "SorumlulukAlani",
                newName: "ParentMenuId");

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "CreateDate", "Icon", "Label", "ParentMenuId", "RouteLink" },
                values: new object[,]
                {
                    { new Guid("257d2d0d-0160-4b96-ab92-8cb74c0f3418"), null, "pi pi-fw pi-globe", "Panel", null, "/" },
                    { new Guid("2c0ee904-e306-405e-b463-af793bf04a15"), null, "fa fa-balance-scale", "Kullanıcı Grup", null, "/kullanicigrup" },
                    { new Guid("3f87a634-b80b-4f33-9fb3-551a7728c821"), null, "fa fa-gavel", "Kullanıcı", null, "/kullanıcı" }
                });

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "Id", "CreateDate", "Name" },
                values: new object[,]
                {
                    { new Guid("25999008-27ba-47d0-bcc6-ab93ee23e8c9"), null, "Permissions.Ayarlar.All" },
                    { new Guid("60c000a9-5ef2-4b06-bd08-d8bba345b249"), null, "Permissions.KullaniciGrup.All" },
                    { new Guid("68b7f6bb-e5b3-4ea1-95a8-4e534750358d"), null, "Permissions.Log.All" },
                    { new Guid("90dd5a55-f4f3-464f-95e0-ce1487266b7c"), null, "Permissions.Il.All" },
                    { new Guid("b596085c-7d5f-4fd6-9702-70341c101295"), null, "Permissions.Genel.All" },
                    { new Guid("ba9f7131-6485-4568-b30d-04ef25c6a344"), null, "Permissions.Kullanici.All" },
                    { new Guid("ec71334d-203f-4945-b780-d2c3f62c29ba"), null, "Permissions.Ilce.All" },
                    { new Guid("ed10487d-be21-49c9-9d35-54a25ca64081"), null, "Permissions.Credential.All" },
                    { new Guid("f4d1e31d-6d3f-49cd-8c82-d97bfa911fcb"), null, "Permissions.Grup.All" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "84975e0f-38fa-4d13-9896-ae39e04e3200", "a3e87f47-d23d-4146-a235-34a6b9584418", "ıladmın", "ILADMIN" },
                    { "98bae1d1-2c50-4fa6-9737-636e0ea8258f", "97d5dc7c-2e57-4148-9153-1a6db5b20647", "karakol", "KARAKOL" },
                    { "adf981e7-b649-4199-8a2e-aa6e4dc44f9b", "eb375d77-9181-49a7-bd50-9ea2efb5bbb9", "ılceadmın", "ILCEADMIN" },
                    { "d384cb88-b253-4653-a766-8a53e5bb4418", "0d2bb4c7-d508-49e4-be74-64feb6e51403", "sıstemadmın", "SISTEMADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Image", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Ou", "PasswordHash", "PbikId", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b650d79c-f3c5-4e9a-a93c-c527a6f561bb", 0, "Ali", "2874a6c9-b16f-4d9e-a01a-9f758d958658", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", null, "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, null, false, "153fb07b-ece7-4e93-b8ec-a8cc7c33882d", "DERİN", null, false, "iladmin" },
                    { "f3de01f0-e383-48a4-b4cb-bdf61f14ac6a", 0, "Mehmet", "dacc9c68-1a40-43f4-a72b-9947bcf747c4", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", null, "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, null, false, "f8b753ca-d6b9-4633-9935-5390eeba8a79", "YILMAZ", null, false, "sistemAdmin" }
                });
        }
    }
}
