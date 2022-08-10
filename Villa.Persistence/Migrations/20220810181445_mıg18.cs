using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Villa.Persistence.Migrations
{
    public partial class mıg18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "533befc1-6d9a-4f46-a983-36f2b52b8c14");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "ce895bc7-7a9a-46db-b363-15b3387a98d6");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "05cf12bc-8e08-4bc1-afaf-c7271a37318e");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "c879ac89-134a-493d-848b-75be0c1d504c");

            migrationBuilder.AddColumn<double>(
                name: "Boylam",
                table: "Ilce",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Enlem",
                table: "Ilce",
                type: "double precision",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8b13e2bd-cb9e-4ea3-bca3-97971ee926fe", "08fe508f-4b40-4643-ad1e-e32492d73e1e", "sistemadmin", "SİSTEMADMİN" },
                    { "a3efce1a-2a50-41bb-bf9c-629018379394", "245fa118-e043-4f55-8f4b-42add9c57473", "admin", "ADMİN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4f2c7049-34b9-4584-b0b5-20c3307cf18a", 0, "Mehmet", "45e46e02-bea4-4322-be97-601dce116321", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "ab1539c2-8c94-4e1f-9c2f-3b96a9de2c70", "YILMAZ", null, false, "sistemAdmin" },
                    { "5c440b9b-514d-4322-815a-4141399d2af3", 0, "Ali", "eec12211-a1a0-42eb-8b10-bcea6427f071", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "8c299ec2-2c4b-4ae5-8bd9-24d466d6ef88", "DERİN", null, false, "iladmin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "8b13e2bd-cb9e-4ea3-bca3-97971ee926fe");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "a3efce1a-2a50-41bb-bf9c-629018379394");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "4f2c7049-34b9-4584-b0b5-20c3307cf18a");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "5c440b9b-514d-4322-815a-4141399d2af3");

            migrationBuilder.DropColumn(
                name: "Boylam",
                table: "Ilce");

            migrationBuilder.DropColumn(
                name: "Enlem",
                table: "Ilce");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "533befc1-6d9a-4f46-a983-36f2b52b8c14", "99ca61c8-0e99-4857-9aba-5a9cce334e92", "sistemadmin", "SISTEMADMIN" },
                    { "ce895bc7-7a9a-46db-b363-15b3387a98d6", "45d4379a-8486-4f24-a542-69b8bf55ef3f", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "05cf12bc-8e08-4bc1-afaf-c7271a37318e", 0, "Mehmet", "fc8c1bdb-5dd6-485b-ba6e-2ea28e958ab6", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "63e5f720-e2c3-4586-97c4-f1113e53540f", "YILMAZ", null, false, "sistemAdmin" },
                    { "c879ac89-134a-493d-848b-75be0c1d504c", 0, "Ali", "3a4d13b9-c38d-498c-9bed-e61c88134409", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "4a7d6eda-fd21-42ec-9106-afacbb18768f", "DERİN", null, false, "iladmin" }
                });
        }
    }
}
