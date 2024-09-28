﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Partage.Data;

#nullable disable

namespace Partage.Migrations
{
    [DbContext(typeof(PartageDbContext))]
    [Migration("20240716230619_RechercherEvaluation")]
    partial class RechercherEvaluation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Partage.Models.Adresse", b =>
                {
                    b.Property<int>("AdresseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdresseId"), 1L, 1);

                    b.Property<string>("CodePostal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("NomRue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumCivique")
                        .HasColumnType("int");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ville")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdresseId");

                    b.ToTable("Adresses");

                    b.HasData(
                        new
                        {
                            AdresseId = 1,
                            CodePostal = "J4K4V8",
                            Latitude = 45.524972200000001,
                            Longitude = -73.500443300000001,
                            NomRue = "Joliette",
                            NumCivique = 1033,
                            Province = "Québec",
                            Ville = "Longueuil"
                        },
                        new
                        {
                            AdresseId = 2,
                            CodePostal = "J3V2K4",
                            Latitude = 45.516668699999997,
                            Longitude = -73.3453169,
                            NomRue = "Dunant",
                            NumCivique = 1775,
                            Province = "Québec",
                            Ville = "Saint-Bruno-de-Montarville"
                        },
                        new
                        {
                            AdresseId = 3,
                            CodePostal = "H2L3T1",
                            Latitude = 45.516143999999997,
                            Longitude = -73.557227999999995,
                            NomRue = "Saint-andré",
                            NumCivique = 1245,
                            Province = "Québec",
                            Ville = "Montréal"
                        },
                        new
                        {
                            AdresseId = 4,
                            CodePostal = "H3V1A2",
                            Latitude = 45.502122999999997,
                            Longitude = -73.619888000000003,
                            NomRue = "Côte-des-Neiges",
                            NumCivique = 3200,
                            Province = "Québec",
                            Ville = "Montréal"
                        },
                        new
                        {
                            AdresseId = 5,
                            CodePostal = "H3H1J8",
                            Latitude = 45.495789000000002,
                            Longitude = -73.577678000000006,
                            NomRue = "de Maisonneuve",
                            NumCivique = 2200,
                            Province = "Québec",
                            Ville = "Montréal"
                        },
                        new
                        {
                            AdresseId = 6,
                            CodePostal = "H3G2E8",
                            Latitude = 45.499302,
                            Longitude = -73.576673,
                            NomRue = "Bishop",
                            NumCivique = 1400,
                            Province = "Québec",
                            Ville = "Montréal"
                        },
                        new
                        {
                            AdresseId = 7,
                            CodePostal = "H7S1N2",
                            Latitude = 45.565455999999998,
                            Longitude = -73.752044999999995,
                            NomRue = "Saint-Martin Ouest",
                            NumCivique = 2550,
                            Province = "Québec",
                            Ville = "Laval"
                        },
                        new
                        {
                            AdresseId = 8,
                            CodePostal = "H7P2P1",
                            Latitude = 45.618724,
                            Longitude = -73.791781,
                            NomRue = "Boulevard Curé-Labelle",
                            NumCivique = 1600,
                            Province = "Québec",
                            Ville = "Laval"
                        },
                        new
                        {
                            AdresseId = 9,
                            CodePostal = "J5B1X6",
                            Latitude = 45.362993000000003,
                            Longitude = -73.541481000000005,
                            NomRue = "Montée Saint-Régis",
                            NumCivique = 230,
                            Province = "Québec",
                            Ville = "Delson"
                        },
                        new
                        {
                            AdresseId = 10,
                            CodePostal = "J5B1Y1",
                            Latitude = 45.365138000000002,
                            Longitude = -73.542956000000004,
                            NomRue = "Rue Beauvais",
                            NumCivique = 150,
                            Province = "Québec",
                            Ville = "Delson"
                        },
                        new
                        {
                            AdresseId = 11,
                            CodePostal = "H9S3G3",
                            Latitude = 45.446677999999999,
                            Longitude = -73.759450999999999,
                            NomRue = "Boulevard des Sources",
                            NumCivique = 55,
                            Province = "Québec",
                            Ville = "Dorval"
                        },
                        new
                        {
                            AdresseId = 12,
                            CodePostal = "H9S1R7",
                            Latitude = 45.448937000000001,
                            Longitude = -73.750784999999993,
                            NomRue = "Rue Elm",
                            NumCivique = 1,
                            Province = "Québec",
                            Ville = "Dorval"
                        },
                        new
                        {
                            AdresseId = 13,
                            CodePostal = "J3Y3M8",
                            Latitude = 45.502896,
                            Longitude = -73.423557000000002,
                            NomRue = "Rue Marmier",
                            NumCivique = 2085,
                            Province = "Québec",
                            Ville = "Saint Hubert"
                        },
                        new
                        {
                            AdresseId = 14,
                            CodePostal = "J3Y6V5",
                            Latitude = 45.508716,
                            Longitude = -73.415841,
                            NomRue = "Rue Victoria",
                            NumCivique = 2120,
                            Province = "Québec",
                            Ville = "Saint Hubert"
                        },
                        new
                        {
                            AdresseId = 15,
                            CodePostal = "J3E1Y2",
                            Latitude = 45.590801999999996,
                            Longitude = -73.318055000000001,
                            NomRue = "Rue Principale",
                            NumCivique = 1985,
                            Province = "Québec",
                            Ville = "Saint Julie"
                        },
                        new
                        {
                            AdresseId = 16,
                            CodePostal = "J3E1W9",
                            Latitude = 45.593840999999998,
                            Longitude = -73.319755999999998,
                            NomRue = "Rue Saint-Joseph",
                            NumCivique = 105,
                            Province = "Québec",
                            Ville = "Saint Julie"
                        });
                });

            modelBuilder.Entity("Partage.Models.Borne", b =>
                {
                    b.Property<int>("BorneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BorneId"), 1L, 1);

                    b.Property<int>("AdresseId")
                        .HasColumnType("int");

                    b.Property<int>("Puissance")
                        .HasColumnType("int");

                    b.Property<string>("TypeConnecteur")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("BorneId");

                    b.HasIndex("AdresseId");

                    b.HasIndex("UserId");

                    b.ToTable("Bornes");

                    b.HasData(
                        new
                        {
                            BorneId = 1,
                            AdresseId = 1,
                            Puissance = 50,
                            TypeConnecteur = "J1772"
                        },
                        new
                        {
                            BorneId = 2,
                            AdresseId = 2,
                            Puissance = 150,
                            TypeConnecteur = "J1772"
                        },
                        new
                        {
                            BorneId = 3,
                            AdresseId = 3,
                            Puissance = 250,
                            TypeConnecteur = "J1772"
                        },
                        new
                        {
                            BorneId = 4,
                            AdresseId = 4,
                            Puissance = 50,
                            TypeConnecteur = "NACS"
                        },
                        new
                        {
                            BorneId = 5,
                            AdresseId = 5,
                            Puissance = 150,
                            TypeConnecteur = "NACS"
                        },
                        new
                        {
                            BorneId = 6,
                            AdresseId = 6,
                            Puissance = 250,
                            TypeConnecteur = "NACS"
                        },
                        new
                        {
                            BorneId = 7,
                            AdresseId = 7,
                            Puissance = 50,
                            TypeConnecteur = "J1772"
                        },
                        new
                        {
                            BorneId = 8,
                            AdresseId = 8,
                            Puissance = 150,
                            TypeConnecteur = "NACS"
                        },
                        new
                        {
                            BorneId = 9,
                            AdresseId = 9,
                            Puissance = 250,
                            TypeConnecteur = "J1772"
                        },
                        new
                        {
                            BorneId = 10,
                            AdresseId = 10,
                            Puissance = 50,
                            TypeConnecteur = "NACS"
                        },
                        new
                        {
                            BorneId = 11,
                            AdresseId = 11,
                            Puissance = 150,
                            TypeConnecteur = "J1772"
                        },
                        new
                        {
                            BorneId = 12,
                            AdresseId = 12,
                            Puissance = 250,
                            TypeConnecteur = "NACS"
                        },
                        new
                        {
                            BorneId = 13,
                            AdresseId = 13,
                            Puissance = 7,
                            TypeConnecteur = "J1772"
                        },
                        new
                        {
                            BorneId = 14,
                            AdresseId = 14,
                            Puissance = 25,
                            TypeConnecteur = "NACS"
                        },
                        new
                        {
                            BorneId = 15,
                            AdresseId = 15,
                            Puissance = 50,
                            TypeConnecteur = "J1772"
                        },
                        new
                        {
                            BorneId = 16,
                            AdresseId = 16,
                            Puissance = 150,
                            TypeConnecteur = "NACS"
                        });
                });

            modelBuilder.Entity("Partage.Models.Evaluation", b =>
                {
                    b.Property<int>("EvaluationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EvaluationId"), 1L, 1);

                    b.Property<int>("BorneId")
                        .HasColumnType("int");

                    b.Property<string>("Commentaire")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Note")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("EvaluationId");

                    b.HasIndex("BorneId");

                    b.HasIndex("UserId");

                    b.ToTable("Evaluations");
                });

            modelBuilder.Entity("Partage.Models.Favoris", b =>
                {
                    b.Property<int>("FavorisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FavorisId"), 1L, 1);

                    b.Property<int>("BorneId")
                        .HasColumnType("int");

                    b.Property<bool>("IsFavoris")
                        .HasColumnType("bit");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("FavorisId");

                    b.HasIndex("BorneId");

                    b.HasIndex("UserId");

                    b.ToTable("Favoris");
                });

            modelBuilder.Entity("Partage.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c30f7306-c6f8-4cb6-b55b-e073acbcb8b2",
                            Email = "admin@example.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            Nom = "Adil",
                            NormalizedEmail = "ADMIN@EXAMPLE.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEDlKRrmjxvCWEX3be7sMckVWgxw4gI+WYMIr75zstFFUa7rHdJvPdvuagc1duOYCjw==",
                            PhoneNumberConfirmed = false,
                            Prenom = "Allessi",
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Partage.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Partage.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Partage.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Partage.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Partage.Models.Borne", b =>
                {
                    b.HasOne("Partage.Models.Adresse", "Adresse")
                        .WithMany()
                        .HasForeignKey("AdresseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Partage.Models.User", "User")
                        .WithMany("Bornes")
                        .HasForeignKey("UserId");

                    b.Navigation("Adresse");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Partage.Models.Evaluation", b =>
                {
                    b.HasOne("Partage.Models.Borne", "Borne")
                        .WithMany("Evaluations")
                        .HasForeignKey("BorneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Partage.Models.User", "User")
                        .WithMany("Evaluations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Borne");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Partage.Models.Favoris", b =>
                {
                    b.HasOne("Partage.Models.Borne", "Borne")
                        .WithMany("ListFavoris")
                        .HasForeignKey("BorneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Partage.Models.User", "User")
                        .WithMany("Favoris")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Borne");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Partage.Models.Borne", b =>
                {
                    b.Navigation("Evaluations");

                    b.Navigation("ListFavoris");
                });

            modelBuilder.Entity("Partage.Models.User", b =>
                {
                    b.Navigation("Bornes");

                    b.Navigation("Evaluations");

                    b.Navigation("Favoris");
                });
#pragma warning restore 612, 618
        }
    }
}
