﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace wdpr.Migrations
{
    [DbContext(typeof(KliniekContext))]
    [Migration("20220121170454_objectedity")]
    partial class objectedity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Behandeld", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BehandelaarId")
                        .HasColumnType("TEXT");

                    b.Property<int?>("BehandelingId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BehandelaarId");

                    b.HasIndex("BehandelingId");

                    b.ToTable("BehandelendeGebruikers");
                });

            modelBuilder.Entity("Melding", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BerichtId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Beschrijving")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BerichtId");

                    b.ToTable("Meldingen");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "3d0ea45b-7b11-447c-b255-0362c2b59736",
                            ConcurrencyStamp = "fa2b17b4-6700-42ed-b784-2b4af5defc6e",
                            Name = "Voogd",
                            NormalizedName = "Voogd"
                        },
                        new
                        {
                            Id = "8fc33049-5883-4f35-988a-2496d1340fd4",
                            ConcurrencyStamp = "4d22bc64-f9e8-44a2-be78-723b2cf051ae",
                            Name = "Client",
                            NormalizedName = "Client"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Models.Aanmelding", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Achternaam")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("GeboorteDatum")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gebruikersnaam")
                        .HasColumnType("TEXT");

                    b.Property<string>("VoogdId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Voornaam")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("VoogdId");

                    b.ToTable("Aanmeldingen");
                });

            modelBuilder.Entity("Models.Afspraak", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BehandelaarId")
                        .HasColumnType("TEXT");

                    b.Property<int?>("BehandelingId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClientId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BehandelaarId");

                    b.HasIndex("BehandelingId");

                    b.HasIndex("ClientId");

                    b.ToTable("Afspraken");
                });

            modelBuilder.Entity("Models.Behandeling", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Naam")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Behandelingen");
                });

            modelBuilder.Entity("Models.Bericht", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Beschrijving")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ChatId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("TEXT");

                    b.Property<string>("VerzenderId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.HasIndex("VerzenderId");

                    b.ToTable("Berichten");
                });

            modelBuilder.Entity("Models.Chat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Actief")
                        .HasColumnType("INTEGER");

                    b.Property<string>("BehandelaarId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Naam")
                        .HasColumnType("TEXT");

                    b.Property<int>("ZelfhulpgroepInt")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BehandelaarId");

                    b.HasIndex("ZelfhulpgroepInt")
                        .IsUnique();

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("Models.Deelname", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Actief")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ChatId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClientId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Toetredingsdatum")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.HasIndex("ClientId");

                    b.ToTable("Deelnames");
                });

            modelBuilder.Entity("Models.Gebruiker", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Geboortedatum")
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("VoogdId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.HasIndex("VoogdId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Models.ZelfhulpDeelname", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClientId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Toetredingsdatum")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ZelfhulpgroepId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("ZelfhulpgroepId");

                    b.ToTable("ZelfhulpDeelnames");
                });

            modelBuilder.Entity("Models.Zelfhulpgroep", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Naam")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Zelfhulpgroepen");
                });

            modelBuilder.Entity("Behandeld", b =>
                {
                    b.HasOne("Models.Gebruiker", "Behandelaar")
                        .WithMany("Behandelingen")
                        .HasForeignKey("BehandelaarId");

                    b.HasOne("Models.Behandeling", "Behandeling")
                        .WithMany("Behandelaren")
                        .HasForeignKey("BehandelingId");

                    b.Navigation("Behandelaar");

                    b.Navigation("Behandeling");
                });

            modelBuilder.Entity("Melding", b =>
                {
                    b.HasOne("Models.Bericht", "Bericht")
                        .WithMany("Meldingen")
                        .HasForeignKey("BerichtId");

                    b.Navigation("Bericht");
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
                    b.HasOne("Models.Gebruiker", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Models.Gebruiker", null)
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

                    b.HasOne("Models.Gebruiker", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Models.Gebruiker", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Models.Aanmelding", b =>
                {
                    b.HasOne("Models.Gebruiker", "Voogd")
                        .WithMany()
                        .HasForeignKey("VoogdId");

                    b.Navigation("Voogd");
                });

            modelBuilder.Entity("Models.Afspraak", b =>
                {
                    b.HasOne("Models.Gebruiker", "Behandelaar")
                        .WithMany()
                        .HasForeignKey("BehandelaarId");

                    b.HasOne("Models.Behandeling", "Behandeling")
                        .WithMany()
                        .HasForeignKey("BehandelingId");

                    b.HasOne("Models.Gebruiker", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId");

                    b.Navigation("Behandelaar");

                    b.Navigation("Behandeling");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Models.Bericht", b =>
                {
                    b.HasOne("Models.Chat", "Chat")
                        .WithMany("Berichten")
                        .HasForeignKey("ChatId");

                    b.HasOne("Models.Gebruiker", "Verzender")
                        .WithMany()
                        .HasForeignKey("VerzenderId");

                    b.Navigation("Chat");

                    b.Navigation("Verzender");
                });

            modelBuilder.Entity("Models.Chat", b =>
                {
                    b.HasOne("Models.Gebruiker", "Behandelaar")
                        .WithMany("Chats")
                        .HasForeignKey("BehandelaarId");

                    b.HasOne("Models.Zelfhulpgroep", "Zelfhulpgroep")
                        .WithOne("Chat")
                        .HasForeignKey("Models.Chat", "ZelfhulpgroepInt")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Behandelaar");

                    b.Navigation("Zelfhulpgroep");
                });

            modelBuilder.Entity("Models.Deelname", b =>
                {
                    b.HasOne("Models.Chat", "Chat")
                        .WithMany("Deelnames")
                        .HasForeignKey("ChatId");

                    b.HasOne("Models.Gebruiker", "Client")
                        .WithMany("Deelnames")
                        .HasForeignKey("ClientId");

                    b.Navigation("Chat");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Models.Gebruiker", b =>
                {
                    b.HasOne("Models.Gebruiker", "Voogd")
                        .WithMany("Voogdij")
                        .HasForeignKey("VoogdId");

                    b.Navigation("Voogd");
                });

            modelBuilder.Entity("Models.ZelfhulpDeelname", b =>
                {
                    b.HasOne("Models.Gebruiker", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId");

                    b.HasOne("Models.Zelfhulpgroep", "Zelfhulpgroep")
                        .WithMany("ZelfhulpDeelnames")
                        .HasForeignKey("ZelfhulpgroepId");

                    b.Navigation("Client");

                    b.Navigation("Zelfhulpgroep");
                });

            modelBuilder.Entity("Models.Behandeling", b =>
                {
                    b.Navigation("Behandelaren");
                });

            modelBuilder.Entity("Models.Bericht", b =>
                {
                    b.Navigation("Meldingen");
                });

            modelBuilder.Entity("Models.Chat", b =>
                {
                    b.Navigation("Berichten");

                    b.Navigation("Deelnames");
                });

            modelBuilder.Entity("Models.Gebruiker", b =>
                {
                    b.Navigation("Behandelingen");

                    b.Navigation("Chats");

                    b.Navigation("Deelnames");

                    b.Navigation("Voogdij");
                });

            modelBuilder.Entity("Models.Zelfhulpgroep", b =>
                {
                    b.Navigation("Chat");

                    b.Navigation("ZelfhulpDeelnames");
                });
#pragma warning restore 612, 618
        }
    }
}
