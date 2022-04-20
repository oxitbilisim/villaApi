using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jemus.Persistence.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menu_Menu_ParentMenuId",
                table: "Menu");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuPermission_Menu_MenuId",
                table: "MenuPermission");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuPermission_Permission_PermissionId",
                table: "MenuPermission");

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("41057b45-4437-4ef8-8e1c-d79b4f33b822"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("69b0c7f1-a457-4404-ba32-c9304b1fe44e"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("b65a6e1e-5df1-4000-8e8f-19ca5b2f1cce"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("c54a120c-a3ca-4fee-b333-4ad17f44fd9c"));

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("0aa947e4-d4af-4bcf-9b41-8df29182fbe1"));

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("2a8dc175-cc48-451e-b316-7befcf98dd7b"));

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("85ee0c38-11a5-4642-87f1-ed8e378ab1a6"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("780a3b3a-47a2-4135-ad3b-48ee50388c5f"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("83dcc63b-e8cd-4115-ad81-a65c29084c72"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("8d8a8942-1597-4b6a-bf18-3c81e10febeb"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("8f680ce8-d47e-4c52-a84e-5b9515a76f1e"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("a85801c7-d02b-4f50-b117-6de8a5724678"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("bd664ece-1cad-46b7-8ee0-fba7157758e5"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("e3b7310e-8d9f-4a76-80ee-60bfb10130d0"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("f5ec7e6b-0361-4c84-95b7-f18698e6fe3c"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("f5fc1295-03d6-4497-af44-6da5bf4e24ac"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "1e7c6cb8-b840-4b75-9964-35eb82dd5861");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "3db197d1-3baf-42ca-a3e0-084663d3ea2e");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "6c50f24a-5151-4d5d-ba5c-73cf6536f2a9");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "d59a1830-4ea6-4948-8d4d-cbe602802bec");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "722323ab-3633-4622-8843-b35dd42271c5");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "a59744e2-2fcb-496c-8192-b62aa65d5131");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Menu_Menu_ParentMenuId",
                table: "Menu",
                column: "ParentMenuId",
                principalTable: "Menu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Menu",
                table: "MenuPermission",
                column: "MenuId",
                principalTable: "Menu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuPermission",
                table: "MenuPermission",
                column: "PermissionId",
                principalTable: "Permission",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menu_Menu_ParentMenuId",
                table: "Menu");

            migrationBuilder.DropForeignKey(
                name: "FK_Menu",
                table: "MenuPermission");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuPermission",
                table: "MenuPermission");

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

            migrationBuilder.InsertData(
                table: "Group",
                columns: new[] { "Id", "Ad", "CreateDate", "Tanim" },
                values: new object[,]
                {
                    { new Guid("41057b45-4437-4ef8-8e1c-d79b4f33b822"), "Karakol", null, "Karakol" },
                    { new Guid("69b0c7f1-a457-4404-ba32-c9304b1fe44e"), "SistemAdmin", null, "SistemAdmin" },
                    { new Guid("b65a6e1e-5df1-4000-8e8f-19ca5b2f1cce"), "IlAdmin", null, "IlAdmin" },
                    { new Guid("c54a120c-a3ca-4fee-b333-4ad17f44fd9c"), "IlceAdmin", null, "IlceAdmin" }
                });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "CreateDate", "Icon", "Label", "ParentMenuId", "RouteLink" },
                values: new object[,]
                {
                    { new Guid("0aa947e4-d4af-4bcf-9b41-8df29182fbe1"), null, "fa fa-gavel", "Kullanıcı", null, "/kullanıcı" },
                    { new Guid("2a8dc175-cc48-451e-b316-7befcf98dd7b"), null, "fa fa-balance-scale", "Kullanıcı Grup", null, "/kullanicigrup" },
                    { new Guid("85ee0c38-11a5-4642-87f1-ed8e378ab1a6"), null, "pi pi-fw pi-globe", "Panel", null, "/" }
                });

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "Id", "CreateDate", "Name" },
                values: new object[,]
                {
                    { new Guid("780a3b3a-47a2-4135-ad3b-48ee50388c5f"), null, "Permissions.Grup.All" },
                    { new Guid("83dcc63b-e8cd-4115-ad81-a65c29084c72"), null, "Permissions.Genel.All" },
                    { new Guid("8d8a8942-1597-4b6a-bf18-3c81e10febeb"), null, "Permissions.Il.All" },
                    { new Guid("8f680ce8-d47e-4c52-a84e-5b9515a76f1e"), null, "Permissions.Ayarlar.All" },
                    { new Guid("a85801c7-d02b-4f50-b117-6de8a5724678"), null, "Permissions.Ilce.All" },
                    { new Guid("bd664ece-1cad-46b7-8ee0-fba7157758e5"), null, "Permissions.Kullanici.All" },
                    { new Guid("e3b7310e-8d9f-4a76-80ee-60bfb10130d0"), null, "Permissions.KullaniciGrup.All" },
                    { new Guid("f5ec7e6b-0361-4c84-95b7-f18698e6fe3c"), null, "Permissions.Log.All" },
                    { new Guid("f5fc1295-03d6-4497-af44-6da5bf4e24ac"), null, "Permissions.Credential.All" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1e7c6cb8-b840-4b75-9964-35eb82dd5861", "96cd6a3d-7351-40d6-bdfc-64c30230be35", "karakol", "KARAKOL" },
                    { "3db197d1-3baf-42ca-a3e0-084663d3ea2e", "2765501f-afdc-4425-9b97-28d3d8c1a57d", "ılceadmın", "ILCEADMIN" },
                    { "6c50f24a-5151-4d5d-ba5c-73cf6536f2a9", "aa951862-31ff-4f05-b1b9-08becd36dee6", "ıladmın", "ILADMIN" },
                    { "d59a1830-4ea6-4948-8d4d-cbe602802bec", "8f498514-1cb5-4729-a0ad-fc814ed6a890", "sıstemadmın", "SISTEMADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Eposta", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SicilNo", "Soyad", "TCKN", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "722323ab-3633-4622-8843-b35dd42271c5", 0, null, "7424b7e0-7f6b-4ce1-a03f-d8cb03287d9d", "User", "sistemAdmin@gmail.com", false, null, "sistemAdmin", "sistemAdmin", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "0d08900d-1dc2-4afb-9a30-f64ffe2b26f2", null, null, null, null, false, "sistemAdmin" },
                    { "a59744e2-2fcb-496c-8192-b62aa65d5131", 0, null, "a70ed1bc-045f-4c7f-b395-4d296cfe0389", "User", "iladmin@gmail.com", false, null, "iladmin", "User", false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "585bf34f-a3bb-4529-acee-938cf4879d7b", null, null, null, null, false, "iladmin" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Menu_Menu_ParentMenuId",
                table: "Menu",
                column: "ParentMenuId",
                principalTable: "Menu",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuPermission_Menu_MenuId",
                table: "MenuPermission",
                column: "MenuId",
                principalTable: "Menu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuPermission_Permission_PermissionId",
                table: "MenuPermission",
                column: "PermissionId",
                principalTable: "Permission",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
