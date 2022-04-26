using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jemus.Persistence.Migrations
{
    public partial class mig5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "SorumlulukAlani",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Tanim = table.Column<string>(type: "text", nullable: true),
                    ParentMenuId = table.Column<Guid>(type: "uuid", nullable: true),
                    ParentSorumlulukAlaniId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SorumlulukAlani", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SorumlulukAlani_SorumlulukAlani_ParentSorumlulukAlaniId",
                        column: x => x.ParentSorumlulukAlaniId,
                        principalTable: "SorumlulukAlani",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_SorumlulukAlani_ParentSorumlulukAlaniId",
                table: "SorumlulukAlani",
                column: "ParentSorumlulukAlaniId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SorumlulukAlani");

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
    }
}
