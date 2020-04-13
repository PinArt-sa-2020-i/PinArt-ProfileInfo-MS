﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PinArt_ProfileInfo_MS.Models;

namespace PinArt_ProfileInfo_MS.Migrations
{
    [DbContext(typeof(InfoContext))]
    [Migration("20200411174043_AuthAdd")]
    partial class AuthAdd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PinArt_ProfileInfo_MS.Models.Authentication", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Authentications");
                });

            modelBuilder.Entity("PinArt_ProfileInfo_MS.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apellido")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Correo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Nick")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("Privado")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PinArt_ProfileInfo_MS.Models.Authentication", b =>
                {
                    b.HasOne("PinArt_ProfileInfo_MS.Models.User", "User")
                        .WithMany("Auth")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
