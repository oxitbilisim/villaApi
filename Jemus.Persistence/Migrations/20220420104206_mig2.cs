using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jemus.Persistence.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("b251d417-b588-4f41-bf9a-1ed4424d36de"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("c2d2f896-7edb-48c6-8d73-fc665740cb57"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("e6cf09cc-6ec1-438f-ae08-ac09a699320d"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("ee165138-1363-42ad-8111-55a5fa77259d"));

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("3b7efa78-c576-41a0-b672-f93f83da9888"));

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("8f17dabc-cdad-452c-b3da-4f2a7727cfa3"));

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("98b2bf6c-adef-41a4-8a8b-583a4d91477f"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("0243e604-6b96-47e5-b754-e8cbb3a110ff"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("484f282c-3a2c-4406-a0c2-38d261df3577"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("74c41309-8b16-4e56-b25f-a9849db9a2fb"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("754c1bad-b1dd-4f10-b69c-6b3101d1c586"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("9f84fc68-3e63-4249-a352-3440f009a44d"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("a03bb7ec-4bd4-4b58-9fb7-5a641e46328b"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("b4e07b49-9d1f-4ff7-987e-557e05e5c502"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("e17d58d4-5343-4b41-b0f6-91ca3ab92359"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("ea489323-0502-45c2-a94a-d1d5cd5c71be"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "543e5bed-0f15-4b0a-bcfd-8e0753f0afaf");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "80fae57b-3412-489c-a901-ac34060ee2b6");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "d6bf7d5b-e9cb-40a1-be11-763fc676c971");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "f5102bf0-a9ba-429b-a70e-76eb696de6cc");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "aabc986a-9074-4a6f-9ceb-b2cd0516d074");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "c3ed2503-6841-4fa4-897a-276c1137ffd1");

            migrationBuilder.AddColumn<string>(
                name: "RoleId",
                table: "MenuPermission",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Group",
                columns: new[] { "Id", "Ad", "CreateDate", "Tanim" },
                values: new object[,]
                {
                    { new Guid("1b915007-4932-4958-8bd3-06b987409f38"), "IlAdmin", null, "IlAdmin" },
                    { new Guid("279f96c8-cf9b-48f1-819b-d570fc805dda"), "IlceAdmin", null, "IlceAdmin" },
                    { new Guid("728bf5ab-533a-45ff-a120-6fd11f5ec013"), "Karakol", null, "Karakol" },
                    { new Guid("d2e0025d-4fd6-4409-bf94-33f5e1eb1ed3"), "SistemAdmin", null, "SistemAdmin" }
                });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "CreateDate", "Icon", "Label", "ParentMenuId", "RouteLink" },
                values: new object[,]
                {
                    { new Guid("83600a37-fd80-47b2-ad97-4e8b536ca952"), null, "fa fa-gavel", "Kullanıcı", null, "/kullanıcı" },
                    { new Guid("dde8638e-0658-4185-aab9-9606bd509ea4"), null, "fa fa-balance-scale", "Kullanıcı Grup", null, "/kullanicigrup" },
                    { new Guid("fe7ccf46-4abc-465b-84c5-8f1bccb63d46"), null, "pi pi-fw pi-globe", "Panel", null, "/" }
                });

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "Id", "CreateDate", "Name" },
                values: new object[,]
                {
                    { new Guid("1c118d9e-a59e-44ac-8eba-2a1c40ad8d01"), null, "Permissions.Ayarlar.All" },
                    { new Guid("689fa0bf-116e-4b0f-b702-361148e71c11"), null, "Permissions.Il.All" },
                    { new Guid("6fa9a7e8-eb94-449f-916d-c957113191a1"), null, "Permissions.Grup.All" },
                    { new Guid("9f1da2ac-f072-4c85-8254-03c2d044ad43"), null, "Permissions.Ilce.All" },
                    { new Guid("b757d139-1179-4775-9102-c1a3904d0b84"), null, "Permissions.Credential.All" },
                    { new Guid("e162209c-b860-4f25-b43d-d6922a09a620"), null, "Permissions.Log.All" },
                    { new Guid("ef6979c5-df45-4c50-adcb-b83d0e747c85"), null, "Permissions.Kullanici.All" },
                    { new Guid("efc11940-0c72-47bd-b050-94e132dc9ad7"), null, "Permissions.KullaniciGrup.All" },
                    { new Guid("f0cb3e7c-3870-4ecf-a871-54946fca527b"), null, "Permissions.Genel.All" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1ad4fcc2-8f77-46c5-b423-f33d6529a77c", "40dd71ee-59a0-4c31-8313-7f051df13ec9", "karakol", "KARAKOL" },
                    { "2400078e-b522-44a4-96fe-2282f84b3c60", "fe8aa6e4-28f8-4d5b-b605-3b44dc52d68f", "ıladmın", "ILADMIN" },
                    { "a4835668-8079-4721-8908-c4ec6a1f1d54", "26171606-4d13-44ac-b32b-599a5d34d120", "sıstemadmın", "SISTEMADMIN" },
                    { "d12dceb3-2572-4d27-a3d4-ccbd4eca71c8", "ddfc0f82-e50d-472e-851c-f466b944d891", "ılceadmın", "ILCEADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Eposta", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SicilNo", "Soyad", "TCKN", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1695af24-60ba-464f-a7af-4befdf9df3d9", 0, null, "88049f55-2cce-44cb-bc74-9cad81b43688", "User", "iladmin@gmail.com", false, null, "iladmin", "User", false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "ef8659e7-7d20-4b7a-bae0-709c267c0171", null, null, null, null, false, "iladmin" },
                    { "411deddf-cd09-4491-90f1-643cece43596", 0, null, "5e27c48f-2ccd-46d4-87a2-9b5f11248b97", "User", "sistemAdmin@gmail.com", false, null, "sistemAdmin", "sistemAdmin", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "044b6c69-4eac-46f4-b55e-d72f66611a0b", null, null, null, null, false, "sistemAdmin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("1b915007-4932-4958-8bd3-06b987409f38"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("279f96c8-cf9b-48f1-819b-d570fc805dda"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("728bf5ab-533a-45ff-a120-6fd11f5ec013"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("d2e0025d-4fd6-4409-bf94-33f5e1eb1ed3"));

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("83600a37-fd80-47b2-ad97-4e8b536ca952"));

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("dde8638e-0658-4185-aab9-9606bd509ea4"));

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("fe7ccf46-4abc-465b-84c5-8f1bccb63d46"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("1c118d9e-a59e-44ac-8eba-2a1c40ad8d01"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("689fa0bf-116e-4b0f-b702-361148e71c11"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("6fa9a7e8-eb94-449f-916d-c957113191a1"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("9f1da2ac-f072-4c85-8254-03c2d044ad43"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("b757d139-1179-4775-9102-c1a3904d0b84"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("e162209c-b860-4f25-b43d-d6922a09a620"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("ef6979c5-df45-4c50-adcb-b83d0e747c85"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("efc11940-0c72-47bd-b050-94e132dc9ad7"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("f0cb3e7c-3870-4ecf-a871-54946fca527b"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "1ad4fcc2-8f77-46c5-b423-f33d6529a77c");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "2400078e-b522-44a4-96fe-2282f84b3c60");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "a4835668-8079-4721-8908-c4ec6a1f1d54");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "d12dceb3-2572-4d27-a3d4-ccbd4eca71c8");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "1695af24-60ba-464f-a7af-4befdf9df3d9");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "411deddf-cd09-4491-90f1-643cece43596");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "MenuPermission");

            migrationBuilder.InsertData(
                table: "Group",
                columns: new[] { "Id", "Ad", "CreateDate", "Tanim" },
                values: new object[,]
                {
                    { new Guid("b251d417-b588-4f41-bf9a-1ed4424d36de"), "Karakol", null, "Karakol" },
                    { new Guid("c2d2f896-7edb-48c6-8d73-fc665740cb57"), "IlAdmin", null, "IlAdmin" },
                    { new Guid("e6cf09cc-6ec1-438f-ae08-ac09a699320d"), "SistemAdmin", null, "SistemAdmin" },
                    { new Guid("ee165138-1363-42ad-8111-55a5fa77259d"), "IlceAdmin", null, "IlceAdmin" }
                });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "CreateDate", "Icon", "Label", "ParentMenuId", "RouteLink" },
                values: new object[,]
                {
                    { new Guid("3b7efa78-c576-41a0-b672-f93f83da9888"), null, "pi pi-fw pi-globe", "Panel", null, "/" },
                    { new Guid("8f17dabc-cdad-452c-b3da-4f2a7727cfa3"), null, "fa fa-balance-scale", "Kullanıcı Grup", null, "/kullanicigrup" },
                    { new Guid("98b2bf6c-adef-41a4-8a8b-583a4d91477f"), null, "fa fa-gavel", "Kullanıcı", null, "/kullanıcı" }
                });

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "Id", "CreateDate", "Name" },
                values: new object[,]
                {
                    { new Guid("0243e604-6b96-47e5-b754-e8cbb3a110ff"), null, "Permissions.Ayarlar.All" },
                    { new Guid("484f282c-3a2c-4406-a0c2-38d261df3577"), null, "Permissions.Grup.All" },
                    { new Guid("74c41309-8b16-4e56-b25f-a9849db9a2fb"), null, "Permissions.Il.All" },
                    { new Guid("754c1bad-b1dd-4f10-b69c-6b3101d1c586"), null, "Permissions.Log.All" },
                    { new Guid("9f84fc68-3e63-4249-a352-3440f009a44d"), null, "Permissions.KullaniciGrup.All" },
                    { new Guid("a03bb7ec-4bd4-4b58-9fb7-5a641e46328b"), null, "Permissions.Kullanici.All" },
                    { new Guid("b4e07b49-9d1f-4ff7-987e-557e05e5c502"), null, "Permissions.Genel.All" },
                    { new Guid("e17d58d4-5343-4b41-b0f6-91ca3ab92359"), null, "Permissions.Credential.All" },
                    { new Guid("ea489323-0502-45c2-a94a-d1d5cd5c71be"), null, "Permissions.Ilce.All" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "543e5bed-0f15-4b0a-bcfd-8e0753f0afaf", "bff03242-5265-4d6d-860b-b29938b12fb3", "ılceadmın", "ILCEADMIN" },
                    { "80fae57b-3412-489c-a901-ac34060ee2b6", "98ae082a-35ee-45d8-9f03-92e2cbbe6189", "ıladmın", "ILADMIN" },
                    { "d6bf7d5b-e9cb-40a1-be11-763fc676c971", "b539f5f1-2f46-4bc2-baa3-25977c4e654c", "sıstemadmın", "SISTEMADMIN" },
                    { "f5102bf0-a9ba-429b-a70e-76eb696de6cc", "4067118b-9e0e-4dc0-9f61-57c1bd6ae7db", "karakol", "KARAKOL" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Eposta", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SicilNo", "Soyad", "TCKN", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "aabc986a-9074-4a6f-9ceb-b2cd0516d074", 0, null, "6890656e-437e-445f-9f7d-e9b2025e9902", "User", "sistemAdmin@gmail.com", false, null, "sistemAdmin", "sistemAdmin", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "0175e7ad-47c9-40b8-a2eb-265b7098fb80", null, null, null, null, false, "sistemAdmin" },
                    { "c3ed2503-6841-4fa4-897a-276c1137ffd1", 0, null, "592d6b51-58f7-4543-b680-d8338ff90fd0", "User", "iladmin@gmail.com", false, null, "iladmin", "User", false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "41c669cd-532b-4532-a816-ef53bde2a202", null, null, null, null, false, "iladmin" }
                });
        }
    }
}
