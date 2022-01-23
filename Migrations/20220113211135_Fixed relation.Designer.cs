﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace wdpr.Migrations
{
    [DbContext(typeof(KliniekContext))]
    [Migration("20220113211135_Fixed relation")]
    partial class Fixedrelation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.2");

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.Models.Gebruiker", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

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

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Models.Gebruiker");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.Models.GebruikerClaim<string>", b =>
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.Models.GebruikerLogin<string>", b =>
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.Models.GebruikerRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.Models.GebruikerToken<string>", b =>
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

                    b.Property<string>("BehandelaarId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("GeboorteDatum")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gebruikersnaam")
                        .HasColumnType("TEXT");

                    b.Property<string>("Voornaam")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BehandelaarId");

                    b.ToTable("Aanmeldingen");
                });

            modelBuilder.Entity("Models.Afspraak", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BehandelaarId")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClientId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("TEXT");

                    b.Property<int?>("_BehandelingId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BehandelaarId");

                    b.HasIndex("ClientId");

                    b.HasIndex("_BehandelingId");

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

                    b.HasKey("Id");

                    b.HasIndex("BehandelaarId");

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

            modelBuilder.Entity("Models.Gebruiker", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.Models.Gebruiker");

                    b.Property<DateTime>("Geboortedatum")
                        .HasColumnType("TEXT");

                    b.Property<string>("VoogdId")
                        .HasColumnType("TEXT");

                    b.HasIndex("VoogdId");

                    b.HasDiscriminator().HasValue("Gebruiker");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.Models.GebruikerClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.Models.Gebruiker", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.Models.GebruikerLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.Models.Gebruiker", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.Models.GebruikerRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.Models.Gebruiker", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.Models.GebruikerToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.Models.Gebruiker", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Models.Aanmelding", b =>
                {
                    b.HasOne("Models.Gebruiker", "Behandelaar")
                        .WithMany()
                        .HasForeignKey("BehandelaarId");

                    b.Navigation("Behandelaar");
                });

            modelBuilder.Entity("Models.Afspraak", b =>
                {
                    b.HasOne("Models.Gebruiker", "Behandelaar")
                        .WithMany()
                        .HasForeignKey("BehandelaarId");

                    b.HasOne("Models.Gebruiker", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId");

                    b.HasOne("Models.Behandeling", "_Behandeling")
                        .WithMany()
                        .HasForeignKey("_BehandelingId");

                    b.Navigation("_Behandeling");

                    b.Navigation("Behandelaar");

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
                        .WithMany()
                        .HasForeignKey("BehandelaarId");

                    b.Navigation("Behandelaar");
                });

            modelBuilder.Entity("Models.Deelname", b =>
                {
                    b.HasOne("Models.Chat", "Chat")
                        .WithMany("Deelnames")
                        .HasForeignKey("ChatId");

                    b.HasOne("Models.Gebruiker", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId");

                    b.Navigation("Chat");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Models.ZelfhulpDeelname", b =>
                {
                    b.HasOne("Models.Gebruiker", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId");

                    b.HasOne("Models.Zelfhulpgroep", "Zelfhulpgroep")
                        .WithMany()
                        .HasForeignKey("ZelfhulpgroepId");

                    b.Navigation("Client");

                    b.Navigation("Zelfhulpgroep");
                });

            modelBuilder.Entity("Models.Gebruiker", b =>
                {
                    b.HasOne("Models.Gebruiker", "Voogd")
                        .WithMany()
                        .HasForeignKey("VoogdId");

                    b.Navigation("Voogd");
                });

            modelBuilder.Entity("Models.Chat", b =>
                {
                    b.Navigation("Berichten");

                    b.Navigation("Deelnames");
                });
#pragma warning restore 612, 618
        }
    }
}
