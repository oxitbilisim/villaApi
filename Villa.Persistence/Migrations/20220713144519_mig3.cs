using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Villa.Persistence.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PeriyodikFiyatAyarlari_ParaBirimi_ParaBirimiId",
                table: "PeriyodikFiyatAyarlari");

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

            migrationBuilder.AlterColumn<decimal>(
                name: "TemizlikUcreti",
                table: "PeriyodikFiyatAyarlari",
                type: "numeric",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<int>(
                name: "ParaBirimiId",
                table: "PeriyodikFiyatAyarlari",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<decimal>(
                name: "MinumumUcret",
                table: "PeriyodikFiyatAyarlari",
                type: "numeric",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<bool>(
                name: "KrediKartTahsilat",
                table: "PeriyodikFiyatAyarlari",
                type: "boolean",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<int>(
                name: "Komisyon",
                table: "PeriyodikFiyatAyarlari",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "Kapora",
                table: "PeriyodikFiyatAyarlari",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<decimal>(
                name: "Depozito",
                table: "PeriyodikFiyatAyarlari",
                type: "numeric",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "42babb0b-f1a1-4a22-a039-cb0dba3af24d", "1835e265-820a-47cd-9818-edf279c8ee7e", "sistemadmin", "SISTEMADMIN" },
                    { "657cc649-78c7-4382-b411-e9c1a3a58ca3", "c73bc918-df1c-4dfa-9144-2da7f01006a1", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8a283667-4379-4805-8497-4d0f38f88b2c", 0, "Ali", "016dbaea-490f-430c-a8f3-be4455892301", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "77c1839c-e87a-4c3b-b6fa-ee9cb3b5ea4d", "DERİN", null, false, "iladmin" },
                    { "c6e6cfa4-5260-435d-9cf7-eca80bbc929a", 0, "Mehmet", "f1d79258-5c3a-46f0-8126-3fde643515ba", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "8245c08d-e471-4ba0-b108-a7feb4c7dad8", "YILMAZ", null, false, "sistemAdmin" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_PeriyodikFiyatAyarlari_ParaBirimi_ParaBirimiId",
                table: "PeriyodikFiyatAyarlari",
                column: "ParaBirimiId",
                principalTable: "ParaBirimi",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PeriyodikFiyatAyarlari_ParaBirimi_ParaBirimiId",
                table: "PeriyodikFiyatAyarlari");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "42babb0b-f1a1-4a22-a039-cb0dba3af24d");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "657cc649-78c7-4382-b411-e9c1a3a58ca3");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "8a283667-4379-4805-8497-4d0f38f88b2c");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "c6e6cfa4-5260-435d-9cf7-eca80bbc929a");

            migrationBuilder.AlterColumn<decimal>(
                name: "TemizlikUcreti",
                table: "PeriyodikFiyatAyarlari",
                type: "numeric",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "numeric",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ParaBirimiId",
                table: "PeriyodikFiyatAyarlari",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "MinumumUcret",
                table: "PeriyodikFiyatAyarlari",
                type: "numeric",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "numeric",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "KrediKartTahsilat",
                table: "PeriyodikFiyatAyarlari",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Komisyon",
                table: "PeriyodikFiyatAyarlari",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Kapora",
                table: "PeriyodikFiyatAyarlari",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Depozito",
                table: "PeriyodikFiyatAyarlari",
                type: "numeric",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "numeric",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_PeriyodikFiyatAyarlari_ParaBirimi_ParaBirimiId",
                table: "PeriyodikFiyatAyarlari",
                column: "ParaBirimiId",
                principalTable: "ParaBirimi",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
