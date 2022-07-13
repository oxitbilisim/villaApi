using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Villa.Persistence.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Etiket",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ad = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etiket", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Il",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ad = table.Column<string>(type: "text", nullable: true),
                    Kod = table.Column<string>(type: "text", nullable: true),
                    Sira = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Il", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kategori",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ad = table.Column<string>(type: "text", nullable: true),
                    Baslik = table.Column<string>(type: "text", nullable: true),
                    Etiket = table.Column<string>(type: "text", nullable: true),
                    Url = table.Column<string>(type: "text", nullable: true),
                    Tipi = table.Column<int>(type: "integer", nullable: false),
                    Image = table.Column<byte[]>(type: "bytea", nullable: true),
                    ParentKategoriId = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategori", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kategori_Kategori_ParentKategoriId",
                        column: x => x.ParentKategoriId,
                        principalTable: "Kategori",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Label = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    Icon = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    RouteLink = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    ParentMenuId = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menu_Menu_ParentMenuId",
                        column: x => x.ParentMenuId,
                        principalTable: "Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mulk",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ad = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mulk", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ozellik",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ad = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ozellik", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParaBirimi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ad = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParaBirimi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permission",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    NormalizedName = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: true),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Ad = table.Column<string>(type: "text", nullable: true),
                    Soyad = table.Column<string>(type: "text", nullable: true),
                    Eposta = table.Column<string>(type: "text", nullable: true),
                    TelefonGSM = table.Column<string>(type: "text", nullable: true),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "text", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogin",
                columns: table => new
                {
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogin", x => new { x.UserId, x.ProviderKey });
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "UserToken",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserToken", x => new { x.UserId, x.Value });
                });

            migrationBuilder.CreateTable(
                name: "EtiketDetay",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EtiketId = table.Column<int>(type: "integer", nullable: false),
                    EtiketTipi = table.Column<int>(type: "integer", nullable: false),
                    AdresId = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EtiketDetay", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EtiketDetay_Etiket_EtiketId",
                        column: x => x.EtiketId,
                        principalTable: "Etiket",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bolge",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ad = table.Column<string>(type: "text", nullable: true),
                    Baslik = table.Column<string>(type: "text", nullable: true),
                    Url = table.Column<string>(type: "text", nullable: true),
                    IlId = table.Column<int>(type: "integer", nullable: false),
                    Image = table.Column<byte[]>(type: "bytea", nullable: true),
                    Map = table.Column<string>(type: "text", nullable: true),
                    Etiket = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolge", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bolge_Il_IlId",
                        column: x => x.IlId,
                        principalTable: "Il",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ilce",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ad = table.Column<string>(type: "text", nullable: true),
                    IlId = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilce", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ilce_Il_IlId",
                        column: x => x.IlId,
                        principalTable: "Il",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuPermission",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MenuId = table.Column<int>(type: "integer", nullable: false),
                    PermissionId = table.Column<int>(type: "integer", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuPermission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menu",
                        column: x => x.MenuId,
                        principalTable: "Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Permission_MenuPermission",
                        column: x => x.PermissionId,
                        principalTable: "Permission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RefreshToken",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Token = table.Column<string>(type: "text", nullable: true),
                    Expires = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedByIp = table.Column<string>(type: "text", nullable: true),
                    Revoked = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    RevokedByIp = table.Column<string>(type: "text", nullable: true),
                    ReplacedByToken = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshToken_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Villa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ad = table.Column<string>(type: "text", nullable: true),
                    Baslik = table.Column<string>(type: "text", nullable: true),
                    Url = table.Column<string>(type: "text", nullable: true),
                    Kapasite = table.Column<int>(type: "integer", nullable: true),
                    YatakOdaSayisi = table.Column<int>(type: "integer", nullable: true),
                    OdaSayisi = table.Column<int>(type: "integer", nullable: true),
                    BanyoSayisi = table.Column<int>(type: "integer", nullable: true),
                    MulkId = table.Column<int>(type: "integer", nullable: false),
                    IlceId = table.Column<int>(type: "integer", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Villa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Villa_Ilce_IlceId",
                        column: x => x.IlceId,
                        principalTable: "Ilce",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Villa_Mulk_MulkId",
                        column: x => x.MulkId,
                        principalTable: "Mulk",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PeriyodikFiyat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VillaId = table.Column<int>(type: "integer", nullable: false),
                    ParaBirimiId = table.Column<int>(type: "integer", nullable: false),
                    Baslangic = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    Bitis = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    Fiyat = table.Column<decimal>(type: "numeric", nullable: false),
                    FiyatTuru = table.Column<int>(type: "integer", nullable: false),
                    Indirim = table.Column<int>(type: "integer", nullable: false),
                    EnAzKiralama = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeriyodikFiyat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PeriyodikFiyat_ParaBirimi_ParaBirimiId",
                        column: x => x.ParaBirimiId,
                        principalTable: "ParaBirimi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PeriyodikFiyat_Villa_VillaId",
                        column: x => x.VillaId,
                        principalTable: "Villa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PeriyodikFiyatAyarlari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VillaId = table.Column<int>(type: "integer", nullable: false),
                    ParaBirimiId = table.Column<int>(type: "integer", nullable: false),
                    Komisyon = table.Column<int>(type: "integer", nullable: false),
                    Kapora = table.Column<int>(type: "integer", nullable: false),
                    Depozito = table.Column<decimal>(type: "numeric", nullable: false),
                    TemizlikUcreti = table.Column<decimal>(type: "numeric", nullable: false),
                    MinumumUcret = table.Column<decimal>(type: "numeric", nullable: false),
                    KrediKartTahsilat = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeriyodikFiyatAyarlari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PeriyodikFiyatAyarlari_ParaBirimi_ParaBirimiId",
                        column: x => x.ParaBirimiId,
                        principalTable: "ParaBirimi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PeriyodikFiyatAyarlari_Villa_VillaId",
                        column: x => x.VillaId,
                        principalTable: "Villa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rezervasyon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VillaId = table.Column<int>(type: "integer", nullable: false),
                    Baslangic = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    Bitis = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
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
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
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
                name: "VillaGorunum",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VillaId = table.Column<int>(type: "integer", nullable: false),
                    OneCikanOzellik = table.Column<string>(type: "text", nullable: true),
                    Etiket = table.Column<string>(type: "text", nullable: true),
                    HavuzOzellik = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VillaGorunum", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VillaGorunum_Villa_VillaId",
                        column: x => x.VillaId,
                        principalTable: "Villa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VillaGosterim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VillaId = table.Column<int>(type: "integer", nullable: false),
                    Gosterim = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VillaGosterim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VillaGosterim_Villa_VillaId",
                        column: x => x.VillaId,
                        principalTable: "Villa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VillaIcerik",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VillaId = table.Column<int>(type: "integer", nullable: false),
                    Icerik = table.Column<string>(type: "text", nullable: true),
                    IcerikBasligi = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VillaIcerik", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VillaIcerik_Villa_VillaId",
                        column: x => x.VillaId,
                        principalTable: "Villa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VillaImage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VillaId = table.Column<int>(type: "integer", nullable: false),
                    Image = table.Column<byte[]>(type: "bytea", nullable: true),
                    VideoUrl = table.Column<string>(type: "text", nullable: true),
                    SiraNo = table.Column<int>(type: "integer", nullable: false),
                    Url = table.Column<bool>(type: "boolean", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VillaImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VillaImage_Villa_VillaId",
                        column: x => x.VillaId,
                        principalTable: "Villa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VillaKategori",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VillaId = table.Column<int>(type: "integer", nullable: false),
                    KategoriId = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VillaKategori", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VillaKategori_Kategori_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VillaKategori_Villa_VillaId",
                        column: x => x.VillaId,
                        principalTable: "Villa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VillaLokasyon",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VillaId = table.Column<int>(type: "integer", nullable: false),
                    BolgeId = table.Column<int>(type: "integer", nullable: false),
                    IlceId = table.Column<int>(type: "integer", nullable: false),
                    Mevki = table.Column<string>(type: "text", nullable: true),
                    Adres = table.Column<string>(type: "text", nullable: true),
                    Map = table.Column<string>(type: "text", nullable: true),
                    MrkUzaklik = table.Column<string>(type: "text", nullable: true),
                    MarktUzaklik = table.Column<string>(type: "text", nullable: true),
                    HvlUzaklik = table.Column<string>(type: "text", nullable: true),
                    PljUzaklik = table.Column<string>(type: "text", nullable: true),
                    RstUzaklik = table.Column<string>(type: "text", nullable: true),
                    SglUzaklik = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VillaLokasyon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VillaLokasyon_Bolge_BolgeId",
                        column: x => x.BolgeId,
                        principalTable: "Bolge",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VillaLokasyon_Ilce_IlceId",
                        column: x => x.IlceId,
                        principalTable: "Ilce",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VillaLokasyon_Villa_VillaId",
                        column: x => x.VillaId,
                        principalTable: "Villa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VillaOzellik",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VillaId = table.Column<int>(type: "integer", nullable: false),
                    OzellikId = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VillaOzellik", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VillaOzellik_Ozellik_OzellikId",
                        column: x => x.OzellikId,
                        principalTable: "Ozellik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VillaOzellik_Villa_VillaId",
                        column: x => x.VillaId,
                        principalTable: "Villa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VillaSeo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VillaId = table.Column<int>(type: "integer", nullable: false),
                    Baslik = table.Column<string>(type: "text", nullable: true),
                    Aciklama = table.Column<string>(type: "text", nullable: true),
                    AnahtarKelime = table.Column<string>(type: "text", nullable: true),
                    HtmlMetaEtiket = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VillaSeo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VillaSeo_Villa_VillaId",
                        column: x => x.VillaId,
                        principalTable: "Villa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    TahsilatTarihi = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    TahsilatBanka = table.Column<string>(type: "text", nullable: true),
                    KkOdemeTutar = table.Column<double>(type: "double precision", nullable: true),
                    EvSahibiOdenenTutar = table.Column<double>(type: "double precision", nullable: true),
                    EvSahibineOdemeTarihi = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
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
                    FaturaTarihi = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    TransferGeliri = table.Column<double>(type: "double precision", nullable: true),
                    RentGeliri = table.Column<double>(type: "double precision", nullable: true),
                    YemekSatisi = table.Column<double>(type: "double precision", nullable: true),
                    KahvaltiSatisi = table.Column<double>(type: "double precision", nullable: true),
                    Not = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
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
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
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
                    CreateDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    EditDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
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
                table: "Menu",
                columns: new[] { "Id", "Active", "CreateDate", "EditDate", "Icon", "IsDeleted", "Label", "ParentMenuId", "RouteLink" },
                values: new object[,]
                {
                    { 1, true, null, null, "pi pi-fw pi-globe", false, "Panel", null, "/" },
                    { 2, true, null, null, "fa fa-gavel", false, "Kullanıcı", null, "/kullanıcı" },
                    { 3, true, null, null, "fa fa-balance-scale", false, "Kullanıcı Grup", null, "/kullanicigrup" },
                    { 5, true, null, null, "pi pi-fw pi-id-card", false, "Tanımlar", null, "/tanimlar" }
                });

            migrationBuilder.InsertData(
                table: "Permission",
                columns: new[] { "Id", "Active", "CreateDate", "EditDate", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, true, null, null, false, "Permissions.Genel.All" },
                    { 2, true, null, null, false, "Permissions.Ayarlar.All" },
                    { 3, true, null, null, false, "Permissions.Kategori.All" },
                    { 4, true, null, null, false, "Permissions.Bolge.All" },
                    { 5, true, null, null, false, "Permissions.Rezarvasyon.All" },
                    { 6, true, null, null, false, "Permissions.Credential.All" },
                    { 7, true, null, null, false, "Permissions.Grup.All" },
                    { 8, true, null, null, false, "Permissions.Il.All" },
                    { 9, true, null, null, false, "Permissions.Ilce.All" },
                    { 10, true, null, null, false, "Permissions.Kullanici.All" },
                    { 11, true, null, null, false, "Permissions.KullaniciGrup.All" },
                    { 12, true, null, null, false, "Permissions.Log.All" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4d57206e-9286-491e-96a8-f9898bd1f00b", "e00ce3a8-6b08-4685-ad92-0b160824bf25", "sistemadmin", "SISTEMADMIN" },
                    { "c01baf98-caf8-4f8e-8885-d377ae0f735c", "81f43c1b-9e9b-4fcf-92e1-14c6bac9a42b", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Ad", "ConcurrencyStamp", "Email", "EmailConfirmed", "Eposta", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Soyad", "TelefonGSM", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1a9464fa-fafe-4de0-890e-7ec88d7652d5", 0, "Ali", "8a914b02-6ce5-4157-95ba-f41364f066fd", "iladmin@gmail.com", false, null, false, null, "BASICUSER@GMAIL.COM", "BASICUSER", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "285baab4-46e2-46ad-8f43-787b71a5cf25", "DERİN", null, false, "iladmin" },
                    { "59adaa38-ff81-46ee-9f3b-496346d87ec4", 0, "Mehmet", "44706192-e907-4c6c-98d0-63217edbd10c", "sistemAdmin@gmail.com", false, null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN", "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==", null, false, "644f9f23-a2cf-45d1-ad51-6c0c0f83d468", "YILMAZ", null, false, "sistemAdmin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bolge_IlId",
                table: "Bolge",
                column: "IlId");

            migrationBuilder.CreateIndex(
                name: "IX_EtiketDetay_EtiketId",
                table: "EtiketDetay",
                column: "EtiketId");

            migrationBuilder.CreateIndex(
                name: "IX_Ilce_IlId",
                table: "Ilce",
                column: "IlId");

            migrationBuilder.CreateIndex(
                name: "IX_Kategori_ParentKategoriId",
                table: "Kategori",
                column: "ParentKategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_ParentMenuId",
                table: "Menu",
                column: "ParentMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuPermission_MenuId",
                table: "MenuPermission",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuPermission_PermissionId",
                table: "MenuPermission",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_PeriyodikFiyat_ParaBirimiId",
                table: "PeriyodikFiyat",
                column: "ParaBirimiId");

            migrationBuilder.CreateIndex(
                name: "IX_PeriyodikFiyat_VillaId",
                table: "PeriyodikFiyat",
                column: "VillaId");

            migrationBuilder.CreateIndex(
                name: "IX_PeriyodikFiyatAyarlari_ParaBirimiId",
                table: "PeriyodikFiyatAyarlari",
                column: "ParaBirimiId");

            migrationBuilder.CreateIndex(
                name: "IX_PeriyodikFiyatAyarlari_VillaId",
                table: "PeriyodikFiyatAyarlari",
                column: "VillaId");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshToken_UserId",
                table: "RefreshToken",
                column: "UserId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Villa_IlceId",
                table: "Villa",
                column: "IlceId");

            migrationBuilder.CreateIndex(
                name: "IX_Villa_MulkId",
                table: "Villa",
                column: "MulkId");

            migrationBuilder.CreateIndex(
                name: "IX_VillaGorunum_VillaId",
                table: "VillaGorunum",
                column: "VillaId");

            migrationBuilder.CreateIndex(
                name: "IX_VillaGosterim_VillaId",
                table: "VillaGosterim",
                column: "VillaId");

            migrationBuilder.CreateIndex(
                name: "IX_VillaIcerik_VillaId",
                table: "VillaIcerik",
                column: "VillaId");

            migrationBuilder.CreateIndex(
                name: "IX_VillaImage_VillaId",
                table: "VillaImage",
                column: "VillaId");

            migrationBuilder.CreateIndex(
                name: "IX_VillaKategori_KategoriId",
                table: "VillaKategori",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_VillaKategori_VillaId",
                table: "VillaKategori",
                column: "VillaId");

            migrationBuilder.CreateIndex(
                name: "IX_VillaLokasyon_BolgeId",
                table: "VillaLokasyon",
                column: "BolgeId");

            migrationBuilder.CreateIndex(
                name: "IX_VillaLokasyon_IlceId",
                table: "VillaLokasyon",
                column: "IlceId");

            migrationBuilder.CreateIndex(
                name: "IX_VillaLokasyon_VillaId",
                table: "VillaLokasyon",
                column: "VillaId");

            migrationBuilder.CreateIndex(
                name: "IX_VillaOzellik_OzellikId",
                table: "VillaOzellik",
                column: "OzellikId");

            migrationBuilder.CreateIndex(
                name: "IX_VillaOzellik_VillaId",
                table: "VillaOzellik",
                column: "VillaId");

            migrationBuilder.CreateIndex(
                name: "IX_VillaSeo_VillaId",
                table: "VillaSeo",
                column: "VillaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EtiketDetay");

            migrationBuilder.DropTable(
                name: "MenuPermission");

            migrationBuilder.DropTable(
                name: "PeriyodikFiyat");

            migrationBuilder.DropTable(
                name: "PeriyodikFiyatAyarlari");

            migrationBuilder.DropTable(
                name: "RefreshToken");

            migrationBuilder.DropTable(
                name: "RezervasyonMaliBilgi");

            migrationBuilder.DropTable(
                name: "RezervasyonMisafir");

            migrationBuilder.DropTable(
                name: "RezervasyonOperasyon");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "RoleClaim");

            migrationBuilder.DropTable(
                name: "UserClaim");

            migrationBuilder.DropTable(
                name: "UserLogin");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "UserToken");

            migrationBuilder.DropTable(
                name: "VillaGorunum");

            migrationBuilder.DropTable(
                name: "VillaGosterim");

            migrationBuilder.DropTable(
                name: "VillaIcerik");

            migrationBuilder.DropTable(
                name: "VillaImage");

            migrationBuilder.DropTable(
                name: "VillaKategori");

            migrationBuilder.DropTable(
                name: "VillaLokasyon");

            migrationBuilder.DropTable(
                name: "VillaOzellik");

            migrationBuilder.DropTable(
                name: "VillaSeo");

            migrationBuilder.DropTable(
                name: "Etiket");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Permission");

            migrationBuilder.DropTable(
                name: "ParaBirimi");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Rezervasyon");

            migrationBuilder.DropTable(
                name: "Kategori");

            migrationBuilder.DropTable(
                name: "Bolge");

            migrationBuilder.DropTable(
                name: "Ozellik");

            migrationBuilder.DropTable(
                name: "Villa");

            migrationBuilder.DropTable(
                name: "Ilce");

            migrationBuilder.DropTable(
                name: "Mulk");

            migrationBuilder.DropTable(
                name: "Il");
        }
    }
}
