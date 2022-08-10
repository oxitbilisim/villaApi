using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Villa.Persistence.Migrations
{
    public partial class mig19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "IconName",
                table: "Kategori",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a18a5fb-9289-4727-8cb8-192aa3fe37ab", "6acf7bf1-b56b-4f4b-a5b2-39a7524f2b54", "sistemadmin", "SİSTEMADMİN" },
                    { "5cfa46b1-a378-47d3-a2b3-9a58c22ffc99", "24da8e88-770a-4b34-bb79-33faea2d92a8", "admin", "ADMİN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "98484467-1c42-4a77-855b-9aba4448ef58", 0, "Ali", "85d43589-7c4b-4faf-b057-d295074d7da3", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "a0f4c7c9-98c8-4159-9bc6-181b245dbf33", "DERİN", null, false, "iladmin" },
                    { "f8cbe930-a2a4-423e-914c-a9a05c760c65", 0, "Mehmet", "ef4b683a-6f68-4b2d-9d85-3f6d83edba3e", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "b0dfceb1-6887-4af7-ac87-6d7336a9ba2c", "YILMAZ", null, false, "sistemAdmin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "0a18a5fb-9289-4727-8cb8-192aa3fe37ab");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "5cfa46b1-a378-47d3-a2b3-9a58c22ffc99");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "98484467-1c42-4a77-855b-9aba4448ef58");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "f8cbe930-a2a4-423e-914c-a9a05c760c65");

            migrationBuilder.DropColumn(
                name: "IconName",
                table: "Kategori");

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
    }
}
