using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Villa.Persistence.Migrations
{
    public partial class mig13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "04f8540f-132e-4871-85a4-138aa5b1ff38");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "b25cbb02-eaa3-4461-841a-e55912fa64e3");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "0df3282c-7f31-4a2e-8197-babeb769db71");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "aa3cf29b-5d96-4382-a3f3-1950118d8b71");

            migrationBuilder.CreateTable(
                name: "Rezervasyon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VillaId = table.Column<int>(type: "integer", nullable: false),
                    Baslangic = table.Column<DateOnly>(type: "date", nullable: false),
                    Bitis = table.Column<DateOnly>(type: "date", nullable: false),
                    MusteriAdSoyad = table.Column<string>(type: "text", nullable: true),
                    MSYetiskin = table.Column<int>(type: "integer", nullable: true),
                    MSCocuk = table.Column<int>(type: "integer", nullable: true),
                    MSBebek = table.Column<int>(type: "integer", nullable: true),
                    TelefonNo = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    RezervasyonDurum = table.Column<int>(type: "integer", nullable: false),
                    Not = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervasyon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rezervasyon_Villa_VillaId",
                        column: x => x.VillaId,
                        principalTable: "Villa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RezervasyonMaliBilgi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RezervasyonId = table.Column<int>(type: "integer", nullable: false),
                    DepozitoDurum = table.Column<int>(type: "integer", nullable: false),
                    IndırımsızTutar = table.Column<double>(type: "double precision", nullable: true),
                    ToplamTutar = table.Column<double>(type: "double precision", nullable: true),
                    KiralamaKaporasi = table.Column<double>(type: "double precision", nullable: true),
                    TahsitTutar = table.Column<double>(type: "double precision", nullable: true),
                    TahsilatTarihi = table.Column<DateOnly>(type: "date", nullable: true),
                    TahsilatBanka = table.Column<string>(type: "text", nullable: true),
                    KkOdemeTutar = table.Column<double>(type: "double precision", nullable: true),
                    EvSahibiOdenenTutar = table.Column<double>(type: "double precision", nullable: true),
                    EvSahibineOdemeTarihi = table.Column<DateOnly>(type: "date", nullable: true),
                    Depozito = table.Column<double>(type: "double precision", nullable: true),
                    KomisyondanIndirim = table.Column<double>(type: "double precision", nullable: true),
                    VillaSahibindenIndirim = table.Column<double>(type: "double precision", nullable: true),
                    KomisyonTutari = table.Column<double>(type: "double precision", nullable: true),
                    TemizlikGideri = table.Column<double>(type: "double precision", nullable: true),
                    HavuzGideri = table.Column<double>(type: "double precision", nullable: true),
                    DigerGider = table.Column<double>(type: "double precision", nullable: true),
                    TahsilExtraTemizlik = table.Column<double>(type: "double precision", nullable: true),
                    Harcama = table.Column<double>(type: "double precision", nullable: true),
                    Konaklama = table.Column<double>(type: "double precision", nullable: true),
                    Komisyon = table.Column<double>(type: "double precision", nullable: true),
                    FaturaNumarasi = table.Column<string>(type: "text", nullable: true),
                    FaturaTarihi = table.Column<DateOnly>(type: "date", nullable: false),
                    TransferGeliri = table.Column<double>(type: "double precision", nullable: true),
                    RentGeliri = table.Column<double>(type: "double precision", nullable: true),
                    YemekSatisi = table.Column<double>(type: "double precision", nullable: true),
                    KahvaltiSatisi = table.Column<double>(type: "double precision", nullable: true),
                    Not = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RezervasyonMaliBilgi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RezervasyonMaliBilgi_Rezervasyon_RezervasyonId",
                        column: x => x.RezervasyonId,
                        principalTable: "Rezervasyon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RezervasyonMisafir",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RezervasyonId = table.Column<int>(type: "integer", nullable: false),
                    MisafirAdSoyad = table.Column<string>(type: "text", nullable: true),
                    Yas = table.Column<string>(type: "text", nullable: true),
                    TcNo = table.Column<string>(type: "text", nullable: true),
                    Cinsiyet = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RezervasyonMisafir", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RezervasyonMisafir_Rezervasyon_RezervasyonId",
                        column: x => x.RezervasyonId,
                        principalTable: "Rezervasyon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RezervasyonOperasyon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RezervasyonId = table.Column<int>(type: "integer", nullable: false),
                    Temizlik = table.Column<bool>(type: "boolean", nullable: true),
                    Havuz = table.Column<bool>(type: "boolean", nullable: true),
                    Kepozito = table.Column<bool>(type: "boolean", nullable: true),
                    Kapora = table.Column<bool>(type: "boolean", nullable: true),
                    Karşılama = table.Column<bool>(type: "boolean", nullable: true),
                    Tahsilat = table.Column<bool>(type: "boolean", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RezervasyonOperasyon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RezervasyonOperasyon_Rezervasyon_RezervasyonId",
                        column: x => x.RezervasyonId,
                        principalTable: "Rezervasyon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1629ef14-0590-41a6-b871-033ad6548737", "5b8cfda7-f506-4006-a136-1279501fd79b", "sistemadmin", "SISTEMADMIN" },
                    { "68dd5f2d-df84-4324-9408-bbe0509ccdec", "4d47b67e-283b-4aa5-bac6-4328e5f0d5ae", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1c6cc87c-e86c-47f9-affa-4897507b8518", 0, "Ali", "4efcbc4c-b8cd-453f-827b-89e0ae423c43", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "c7d75231-b5a5-4325-8276-31c607e67910", "DERİN", null, false, "iladmin" },
                    { "877022e9-564a-4879-9713-56579e2711e4", 0, "Mehmet", "4301f535-7fd8-46d3-b3a4-ffa6b651d234", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "97432688-48fd-435e-9fb1-c3e0ef3586b1", "YILMAZ", null, false, "sistemAdmin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rezervasyon_VillaId",
                table: "Rezervasyon",
                column: "VillaId");

            migrationBuilder.CreateIndex(
                name: "IX_RezervasyonMaliBilgi_RezervasyonId",
                table: "RezervasyonMaliBilgi",
                column: "RezervasyonId");

            migrationBuilder.CreateIndex(
                name: "IX_RezervasyonMisafir_RezervasyonId",
                table: "RezervasyonMisafir",
                column: "RezervasyonId");

            migrationBuilder.CreateIndex(
                name: "IX_RezervasyonOperasyon_RezervasyonId",
                table: "RezervasyonOperasyon",
                column: "RezervasyonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RezervasyonMaliBilgi");

            migrationBuilder.DropTable(
                name: "RezervasyonMisafir");

            migrationBuilder.DropTable(
                name: "RezervasyonOperasyon");

            migrationBuilder.DropTable(
                name: "Rezervasyon");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "1629ef14-0590-41a6-b871-033ad6548737");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "68dd5f2d-df84-4324-9408-bbe0509ccdec");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "1c6cc87c-e86c-47f9-affa-4897507b8518");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "877022e9-564a-4879-9713-56579e2711e4");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "04f8540f-132e-4871-85a4-138aa5b1ff38", "0ac0222e-3228-4349-9505-9ed06791f22e", "admin", "ADMIN" },
                    { "b25cbb02-eaa3-4461-841a-e55912fa64e3", "701bb59c-b321-4315-a36d-c9c0b6aa6f62", "sistemadmin", "SISTEMADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0df3282c-7f31-4a2e-8197-babeb769db71", 0, "Ali", "f54aedfa-fb82-4049-b726-d4ce382e63a1", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "ad03c17d-106f-44a0-9928-d4571a24aa5d", "DERİN", null, false, "iladmin" },
                    { "aa3cf29b-5d96-4382-a3f3-1950118d8b71", 0, "Mehmet", "14613e5e-13cf-419b-826b-f55a158ea7f2", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "dcdb638b-a066-4baf-8f9c-b2cc53a64aee", "YILMAZ", null, false, "sistemAdmin" }
                });
        }
    }
}
