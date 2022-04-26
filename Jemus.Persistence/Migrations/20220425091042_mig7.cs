using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jemus.Persistence.Migrations
{
    public partial class mig7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ParentSorumlulukId",
                table: "SorumlulukAlani");

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "CreateDate", "Icon", "Label", "ParentMenuId", "RouteLink" },
                values: new object[,]
                {
                    { new Guid("512f807e-e11b-4867-9337-033f0c9d2b68"), null, "fa fa-balance-scale", "Kullanıcı Grup", null, "/kullanicigrup" },
                    { new Guid("51e54d59-15b6-4d9f-b201-08a4f1659995"), null, "pi pi-fw pi-globe", "Panel", null, "/" },
                    { new Guid("57e0895a-8d97-4ce3-9fa5-985268878524"), null, "fa fa-gavel", "Kullanıcı", null, "/kullanıcı" }
                });

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "Id", "CreateDate", "Name" },
                values: new object[,]
                {
                    { new Guid("0f1304ce-588b-4a2d-8e65-1932065f7da6"), null, "Permissions.Il.All" },
                    { new Guid("40027706-7eef-4657-89e8-51911c2754b9"), null, "Permissions.Ayarlar.All" },
                    { new Guid("8ac8853b-5b4f-4d24-ab44-e450b00777de"), null, "Permissions.Ilce.All" },
                    { new Guid("9c604913-98fc-463d-884e-a85db6765d9d"), null, "Permissions.KullaniciGrup.All" },
                    { new Guid("b8574c31-d243-4921-8a81-94acce219365"), null, "Permissions.Kullanici.All" },
                    { new Guid("c6ce6ba8-df8d-458e-b3f7-d983139bce6f"), null, "Permissions.Credential.All" },
                    { new Guid("cc48d718-5548-4ebe-8301-1624a1abd3ba"), null, "Permissions.Genel.All" },
                    { new Guid("ce7422cb-58ed-43a0-8bd3-522b14ef0704"), null, "Permissions.Grup.All" },
                    { new Guid("f0699f26-df86-4b62-a530-396d740af37c"), null, "Permissions.Log.All" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2a3edd81-c768-4e2c-9ecc-1c28c0512b7e", "0f7c00c5-9be9-4f7c-9833-674c9091b3e2", "ıladmın", "ILADMIN" },
                    { "4ad814a3-29ab-4c69-8d08-12ee06e4941f", "1d1f770c-abda-4df1-a785-3d23f9079943", "sıstemadmın", "SISTEMADMIN" },
                    { "a0694adf-7bf0-4375-b61b-8946828184e2", "76625d50-83c9-46c0-bed0-012c0d373a64", "ılceadmın", "ILCEADMIN" },
                    { "dac3f465-c377-4b74-872f-7b49996f0e10", "c062d254-a862-4f6d-8ae2-ad70aad52887", "karakol", "KARAKOL" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Image", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Ou", "PasswordHash", "PbikId", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "06343529-c613-440f-9228-13bb0ad6f374", 0, "Ali", "94544f16-4a58-4d42-9ff3-73ba0c301350", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", null, "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, null, false, "ade44c07-89f1-4e4e-9759-7a9dcfea6031", "DERİN", null, false, "iladmin" },
                    { "11cb33c0-07a2-4d61-a11b-475d8ee7b232", 0, "Mehmet", "faf432d3-647e-4a10-86a7-5707c5940ce1", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", null, "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, null, false, "422e92a2-9a91-4c10-83ba-8f5e43ee9770", "YILMAZ", null, false, "sistemAdmin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("512f807e-e11b-4867-9337-033f0c9d2b68"));

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("51e54d59-15b6-4d9f-b201-08a4f1659995"));

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("57e0895a-8d97-4ce3-9fa5-985268878524"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("0f1304ce-588b-4a2d-8e65-1932065f7da6"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("40027706-7eef-4657-89e8-51911c2754b9"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("8ac8853b-5b4f-4d24-ab44-e450b00777de"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("9c604913-98fc-463d-884e-a85db6765d9d"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("b8574c31-d243-4921-8a81-94acce219365"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("c6ce6ba8-df8d-458e-b3f7-d983139bce6f"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("cc48d718-5548-4ebe-8301-1624a1abd3ba"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("ce7422cb-58ed-43a0-8bd3-522b14ef0704"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("f0699f26-df86-4b62-a530-396d740af37c"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "2a3edd81-c768-4e2c-9ecc-1c28c0512b7e");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "4ad814a3-29ab-4c69-8d08-12ee06e4941f");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "a0694adf-7bf0-4375-b61b-8946828184e2");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "dac3f465-c377-4b74-872f-7b49996f0e10");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "06343529-c613-440f-9228-13bb0ad6f374");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "11cb33c0-07a2-4d61-a11b-475d8ee7b232");

            migrationBuilder.AddColumn<Guid>(
                name: "ParentSorumlulukId",
                table: "SorumlulukAlani",
                type: "uuid",
                nullable: true);

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
    }
}
