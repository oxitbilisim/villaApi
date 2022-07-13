using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Villa.Persistence.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "1c0ab9b1-782f-4d34-85e6-bb6a2bc9a640");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "9f86fb7a-d5ca-4b6b-97b9-26aa7b71889d");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "c3619bac-bb15-4f58-b4a7-de75d0dfc8ee");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "d4e9f863-b8d1-44ab-984c-614937e570f3");

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "VillaImage",
                type: "text",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c8336dcf-58a9-4a57-a9ee-faaa0a5b4596", "388802b2-8f4c-431c-aaad-a2eded62606f", "admin", "ADMIN" },
                    { "f218c16f-3992-4547-94ae-03b314409797", "864d531d-4d38-4ea1-8d8b-6483a7329181", "sistemadmin", "SISTEMADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7c0107d7-ed2b-4947-aba6-24a75c6acd99", 0, "Mehmet", "8f1bbd9e-5e78-43d9-a6ce-ce601ca7bdf4", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "7e213a80-7559-470e-8597-d83d6219c855", "YILMAZ", null, false, "sistemAdmin" },
                    { "be3ababd-a661-4617-893a-0e7c66d4ad4c", 0, "Ali", "5189d1b1-49c4-4189-8454-77eaab39fd0d", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "95f424f4-1e74-48af-a652-f15f70ae3c87", "DERİN", null, false, "iladmin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "c8336dcf-58a9-4a57-a9ee-faaa0a5b4596");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "f218c16f-3992-4547-94ae-03b314409797");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "7c0107d7-ed2b-4947-aba6-24a75c6acd99");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "be3ababd-a661-4617-893a-0e7c66d4ad4c");

            migrationBuilder.AlterColumn<bool>(
                name: "Url",
                table: "VillaImage",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1c0ab9b1-782f-4d34-85e6-bb6a2bc9a640", "a61daf96-21cd-4308-bf93-fffc4f75c766", "sistemadmin", "SISTEMADMIN" },
                    { "9f86fb7a-d5ca-4b6b-97b9-26aa7b71889d", "4d752b67-a18e-43a1-a519-46fa6afc6b1b", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "c3619bac-bb15-4f58-b4a7-de75d0dfc8ee", 0, "Ali", "e9851e21-86b5-4f71-8e58-99df5c172ad4", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "284a305b-863e-4b5f-9cd4-ac29e705c14c", "DERİN", null, false, "iladmin" },
                    { "d4e9f863-b8d1-44ab-984c-614937e570f3", 0, "Mehmet", "0938ddb5-af8a-4cad-939d-df135076d8af", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "7cdf822e-35e3-4773-8a02-0c9aeb56bb0e", "YILMAZ", null, false, "sistemAdmin" }
                });
        }
    }
}
