﻿// <auto-generated />
using System;
using Jemus.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Jemus.Persistence.Migrations
{
    [DbContext(typeof(appDbContext))]
    [Migration("20220425090305_mig4")]
    partial class mig4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Jemus.Domain.Auth.RefreshToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatedByIp")
                        .HasColumnType("text");

                    b.Property<DateTime>("Expires")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ReplacedByToken")
                        .HasColumnType("text");

                    b.Property<DateTime?>("Revoked")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("RevokedByIp")
                        .HasColumnType("text");

                    b.Property<string>("Token")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("RefreshToken");
                });

            modelBuilder.Entity("Jemus.Domain.Auth.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("Ad")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<byte[]>("Image")
                        .HasColumnType("bytea");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("text");

                    b.Property<string>("Ou")
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PbikId")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<string>("Soyad")
                        .HasColumnType("text");

                    b.Property<string>("TelefonGSM")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("User", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "7feb693c-864f-46c7-8ce7-4c5558905b3f",
                            AccessFailedCount = 0,
                            Ad = "Mehmet",
                            ConcurrencyStamp = "34dd346f-a885-4e10-b7c6-21b43e69a9b7",
                            Email = "sistemAdmin@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "SUPERADMIN@GMAIL.COM",
                            NormalizedUserName = "SUPERADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "22731e42-02cd-471a-9617-ed8107a8c24e",
                            Soyad = "YILMAZ",
                            TwoFactorEnabled = false,
                            UserName = "sistemAdmin"
                        },
                        new
                        {
                            Id = "0e57293c-e168-4a1e-9e6b-e21f704bd4b3",
                            AccessFailedCount = 0,
                            Ad = "Ali",
                            ConcurrencyStamp = "98a1c844-87e2-44f6-aa91-a0606508359b",
                            Email = "iladmin@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "BASICUSER@GMAIL.COM",
                            NormalizedUserName = "BASICUSER",
                            PasswordHash = "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3e950752-13ac-4dda-a727-89404592aa7d",
                            Soyad = "DERİN",
                            TwoFactorEnabled = false,
                            UserName = "iladmin"
                        });
                });

            modelBuilder.Entity("Jemus.Entities.Models.files_merkez", b =>
                {
                    b.Property<string>("aciklama")
                        .HasColumnType("text");

                    b.Property<string>("boylam")
                        .HasColumnType("text");

                    b.Property<long>("clientid")
                        .HasColumnType("bigint");

                    b.Property<string>("clientname")
                        .HasColumnType("text");

                    b.Property<string>("confidence")
                        .HasColumnType("text");

                    b.Property<DateTime>("datetime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("detectionnumber")
                        .HasColumnType("text");

                    b.Property<string>("dogrulukorani")
                        .HasColumnType("text");

                    b.Property<string>("enlem")
                        .HasColumnType("text");

                    b.Property<string>("filepath")
                        .HasColumnType("text");

                    b.Property<long>("gedoid")
                        .HasColumnType("bigint");

                    b.Property<string>("hiz")
                        .HasColumnType("text");

                    b.Property<string>("il")
                        .HasColumnType("text");

                    b.Property<string>("islemtipi")
                        .HasColumnType("text");

                    b.Property<bool?>("isprocessed")
                        .HasColumnType("boolean");

                    b.Property<string>("marka")
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<string>("plaka")
                        .HasColumnType("text");

                    b.Property<string>("plakakoordinati")
                        .HasColumnType("text");

                    b.Property<string>("plakaokumasayisi")
                        .HasColumnType("text");

                    b.Property<string>("ptsyonu")
                        .HasColumnType("text");

                    b.Property<string>("renk")
                        .HasColumnType("text");

                    b.Property<string>("result")
                        .HasColumnType("text");

                    b.Property<string>("sakincadurumu")
                        .HasColumnType("text");

                    b.Property<string>("tescilcinsi")
                        .HasColumnType("text");

                    b.Property<string>("tescilmarka")
                        .HasColumnType("text");

                    b.Property<string>("tescilmodel")
                        .HasColumnType("text");

                    b.Property<string>("tescilrenk")
                        .HasColumnType("text");

                    b.Property<string>("tescilsinif")
                        .HasColumnType("text");

                    b.Property<string>("tesciltip")
                        .HasColumnType("text");

                    b.Property<string>("tescilyil")
                        .HasColumnType("text");

                    b.Property<DateTime?>("tescilzamani")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("tip")
                        .HasColumnType("text");

                    b.Property<string>("ulke")
                        .HasColumnType("text");

                    b.Property<string>("yonbilgisi")
                        .HasColumnType("text");

                    b.ToTable("files_merkez");
                });

            modelBuilder.Entity("Jemus.Entities.Models.Il", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnOrder(0);

                    b.Property<string>("Ad")
                        .HasColumnType("text");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Kod")
                        .HasColumnType("text");

                    b.Property<int>("Sira")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Il");
                });

            modelBuilder.Entity("Jemus.Entities.Models.Ilce", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnOrder(0);

                    b.Property<string>("Ad")
                        .HasColumnType("text");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("IlId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("IlId");

                    b.ToTable("Ilce");
                });

            modelBuilder.Entity("Jemus.Entities.Models.Menu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnOrder(0);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Icon")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Label")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<Guid?>("ParentMenuId")
                        .HasColumnType("uuid");

                    b.Property<string>("RouteLink")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("Id");

                    b.HasIndex("ParentMenuId");

                    b.ToTable("Menu");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1574b190-af14-45c0-a9ce-44995a9acf4b"),
                            Icon = "pi pi-fw pi-globe",
                            Label = "Panel",
                            RouteLink = "/"
                        },
                        new
                        {
                            Id = new Guid("a1605cb9-b74c-4749-820c-d6511a7bae10"),
                            Icon = "fa fa-gavel",
                            Label = "Kullanıcı",
                            RouteLink = "/kullanıcı"
                        },
                        new
                        {
                            Id = new Guid("4f702cb1-115c-4360-a033-c3f262d11108"),
                            Icon = "fa fa-balance-scale",
                            Label = "Kullanıcı Grup",
                            RouteLink = "/kullanicigrup"
                        });
                });

            modelBuilder.Entity("Jemus.Entities.Models.MenuPermission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnOrder(0);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("MenuId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("PermissionId")
                        .HasColumnType("uuid");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.HasIndex("PermissionId");

                    b.ToTable("MenuPermission");
                });

            modelBuilder.Entity("Jemus.Entities.Models.Permission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnOrder(0);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Permission");

                    b.HasData(
                        new
                        {
                            Id = new Guid("88861925-bb56-48ca-920c-18bf5422bf5f"),
                            Name = "Permissions.Genel.All"
                        },
                        new
                        {
                            Id = new Guid("691f17b5-96af-4fd4-ab8c-1e6794e45756"),
                            Name = "Permissions.Ayarlar.All"
                        },
                        new
                        {
                            Id = new Guid("124a8bd5-3fd7-45c8-be8a-c61cbe113a34"),
                            Name = "Permissions.Credential.All"
                        },
                        new
                        {
                            Id = new Guid("cbb8c920-8570-4890-bdcf-d67bac38f829"),
                            Name = "Permissions.Grup.All"
                        },
                        new
                        {
                            Id = new Guid("7cb0987e-8c33-4385-97ff-da7a1937143a"),
                            Name = "Permissions.Il.All"
                        },
                        new
                        {
                            Id = new Guid("12fc4fad-21c0-4f07-984b-2e0b2984a0d1"),
                            Name = "Permissions.Ilce.All"
                        },
                        new
                        {
                            Id = new Guid("9178b8c4-7065-440a-bd19-f0e1dbeeaad9"),
                            Name = "Permissions.Kullanici.All"
                        },
                        new
                        {
                            Id = new Guid("38c8920f-0fc7-45f0-9314-1c5cccefd240"),
                            Name = "Permissions.KullaniciGrup.All"
                        },
                        new
                        {
                            Id = new Guid("5287b272-90b8-441c-9473-0c4a50a9722b"),
                            Name = "Permissions.Log.All"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Role", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "8421bc72-dfe3-4645-8949-b61fbe23d3b8",
                            ConcurrencyStamp = "60a303b8-a2bb-4f59-a925-a367b9d59a21",
                            Name = "sıstemadmın",
                            NormalizedName = "SISTEMADMIN"
                        },
                        new
                        {
                            Id = "a53fb92d-884f-4fb4-8aa7-47bd958cbeeb",
                            ConcurrencyStamp = "4d165c25-1240-45b5-a0f7-ebd1dc98fd9f",
                            Name = "ıladmın",
                            NormalizedName = "ILADMIN"
                        },
                        new
                        {
                            Id = "0f294b1d-05a5-4f50-980b-034747df35ea",
                            ConcurrencyStamp = "e65a9fed-c56f-4c11-bd4d-c0dcf892669a",
                            Name = "ılceadmın",
                            NormalizedName = "ILCEADMIN"
                        },
                        new
                        {
                            Id = "4de7677d-05d8-454b-aa6c-005abea3605a",
                            ConcurrencyStamp = "685df13f-bad0-4c46-b630-a08ed4f01c43",
                            Name = "karakol",
                            NormalizedName = "KARAKOL"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("RoleClaim", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("UserClaim", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.HasKey("UserId", "ProviderKey");

                    b.ToTable("UserLogin", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("UserRole", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("UserId", "Value");

                    b.ToTable("UserToken", (string)null);
                });

            modelBuilder.Entity("Jemus.Domain.Auth.RefreshToken", b =>
                {
                    b.HasOne("Jemus.Domain.Auth.User", null)
                        .WithMany("RefreshTokens")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Jemus.Entities.Models.Ilce", b =>
                {
                    b.HasOne("Jemus.Entities.Models.Il", "Il")
                        .WithMany("Ilce")
                        .HasForeignKey("IlId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Il");
                });

            modelBuilder.Entity("Jemus.Entities.Models.Menu", b =>
                {
                    b.HasOne("Jemus.Entities.Models.Menu", "ParentMenu")
                        .WithMany("items")
                        .HasForeignKey("ParentMenuId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("ParentMenu");
                });

            modelBuilder.Entity("Jemus.Entities.Models.MenuPermission", b =>
                {
                    b.HasOne("Jemus.Entities.Models.Menu", "Menu")
                        .WithMany("MenuPermission")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Menu");

                    b.HasOne("Jemus.Entities.Models.Permission", "Permission")
                        .WithMany("MenuPermission")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_MenuPermission");

                    b.Navigation("Menu");

                    b.Navigation("Permission");
                });

            modelBuilder.Entity("Jemus.Domain.Auth.User", b =>
                {
                    b.Navigation("RefreshTokens");
                });

            modelBuilder.Entity("Jemus.Entities.Models.Il", b =>
                {
                    b.Navigation("Ilce");
                });

            modelBuilder.Entity("Jemus.Entities.Models.Menu", b =>
                {
                    b.Navigation("MenuPermission");

                    b.Navigation("items");
                });

            modelBuilder.Entity("Jemus.Entities.Models.Permission", b =>
                {
                    b.Navigation("MenuPermission");
                });
#pragma warning restore 612, 618
        }
    }
}
