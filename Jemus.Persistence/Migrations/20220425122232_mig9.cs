using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jemus.Persistence.Migrations
{
    public partial class mig9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SorumlulukAlani_SorumlulukAlani_ParentSorumlulukAlaniId",
                table: "SorumlulukAlani");

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

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "CreateDate", "Icon", "Label", "ParentMenuId", "RouteLink" },
                values: new object[,]
                {
                    { new Guid("008120af-98a1-4044-9d3e-4922ccfad7e1"), null, "fa fa-gavel", "Kullanıcı", null, "/kullanıcı" },
                    { new Guid("97aab1ca-95cb-44a3-a558-fa8311f078e9"), null, "pi pi-fw pi-globe", "Panel", null, "/" },
                    { new Guid("c39242e8-3609-4634-a970-0b7bd5f7bef3"), null, "fa fa-balance-scale", "Kullanıcı Grup", null, "/kullanicigrup" }
                });

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "Id", "CreateDate", "Name" },
                values: new object[,]
                {
                    { new Guid("08eac205-cd77-44a4-a7d6-e0bd1a9f82eb"), null, "Permissions.Genel.All" },
                    { new Guid("0cb88082-90ce-4b1c-be3e-1b8bfe5a5673"), null, "Permissions.Kullanici.All" },
                    { new Guid("29be8319-f882-41f9-93b0-eb01c82af9dc"), null, "Permissions.Ilce.All" },
                    { new Guid("44f6eb7e-15b1-4aaa-b756-4cff42634eb9"), null, "Permissions.Ayarlar.All" },
                    { new Guid("5c0bb5c5-48ce-4ab3-9243-32b0b7bd03e7"), null, "Permissions.Credential.All" },
                    { new Guid("a4cea78d-ea67-4785-99df-4cc39d9ddb1f"), null, "Permissions.KullaniciGrup.All" },
                    { new Guid("ad993b0d-8991-43c3-8d93-7ab2772633ca"), null, "Permissions.Grup.All" },
                    { new Guid("b5499afc-c7df-4be9-903a-e77602a891ae"), null, "Permissions.Il.All" },
                    { new Guid("f675c29b-977d-4bc1-91ee-1da0d12e922d"), null, "Permissions.Log.All" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3459ba06-a400-4695-b819-7f91899d825b", "c4c3a2c8-5344-4330-ac1d-f39f7d66df8d", "karakol", "KARAKOL" },
                    { "3f61a1a1-21c1-4575-860a-e42cc7ad9233", "93e2d50e-ac61-4283-923d-315f9fd1f08f", "ılceadmın", "ILCEADMIN" },
                    { "97df95eb-f8a0-4a67-8bf6-4ffdf592c9b2", "03127205-e7d6-4ae9-8135-707058899ec8", "sıstemadmın", "SISTEMADMIN" },
                    { "edba3ed5-08be-4636-ab9d-49de1264111d", "eb78a842-b19a-4e46-8760-e93252be13f6", "ıladmın", "ILADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Image", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Ou", "PasswordHash", "PbikId", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5d7065cc-096a-4d56-9d83-f9f34d3e1c26", 0, "Mehmet", "a4ffef89-0f24-4f9f-9162-c37ee554cbc6", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", null, "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, null, false, "81013cf3-f776-40bf-940f-d020d7148ef2", "YILMAZ", null, false, "sistemAdmin" },
                    { "b151c507-68c7-4613-a29a-68fdb4b5050a", 0, "Ali", "7ea8d9bf-ce56-44a7-984f-d58f01f5f8d3", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", null, "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, null, false, "9f54be63-dfeb-405b-9040-af1d7c644337", "DERİN", null, false, "iladmin" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_SorumlulukAlani_SorumlulukAlani_ParentSorumlulukAlaniId",
                table: "SorumlulukAlani",
                column: "ParentSorumlulukAlaniId",
                principalTable: "SorumlulukAlani",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SorumlulukAlani_SorumlulukAlani_ParentSorumlulukAlaniId",
                table: "SorumlulukAlani");

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("008120af-98a1-4044-9d3e-4922ccfad7e1"));

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("97aab1ca-95cb-44a3-a558-fa8311f078e9"));

            migrationBuilder.DeleteData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("c39242e8-3609-4634-a970-0b7bd5f7bef3"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("08eac205-cd77-44a4-a7d6-e0bd1a9f82eb"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("0cb88082-90ce-4b1c-be3e-1b8bfe5a5673"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("29be8319-f882-41f9-93b0-eb01c82af9dc"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("44f6eb7e-15b1-4aaa-b756-4cff42634eb9"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("5c0bb5c5-48ce-4ab3-9243-32b0b7bd03e7"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("a4cea78d-ea67-4785-99df-4cc39d9ddb1f"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("ad993b0d-8991-43c3-8d93-7ab2772633ca"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("b5499afc-c7df-4be9-903a-e77602a891ae"));

            migrationBuilder.DeleteData(
                table: "Permission",
                keyColumn: "Id",
                keyValue: new Guid("f675c29b-977d-4bc1-91ee-1da0d12e922d"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "3459ba06-a400-4695-b819-7f91899d825b");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "3f61a1a1-21c1-4575-860a-e42cc7ad9233");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "97df95eb-f8a0-4a67-8bf6-4ffdf592c9b2");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "edba3ed5-08be-4636-ab9d-49de1264111d");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "5d7065cc-096a-4d56-9d83-f9f34d3e1c26");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "b151c507-68c7-4613-a29a-68fdb4b5050a");

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

            migrationBuilder.AddForeignKey(
                name: "FK_SorumlulukAlani_SorumlulukAlani_ParentSorumlulukAlaniId",
                table: "SorumlulukAlani",
                column: "ParentSorumlulukAlaniId",
                principalTable: "SorumlulukAlani",
                principalColumn: "Id");
        }
    }
}
