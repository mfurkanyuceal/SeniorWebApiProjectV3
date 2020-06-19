﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SeniorWebAPIProjectV3.DBContext;

namespace SeniorWebAPIProjectV3.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200619165708_swapUpdateMigrate")]
    partial class swapUpdateMigrate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("SeniorWebAPIProjectV3.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<double>("Latitude")
                        .HasColumnType("double precision");

                    b.Property<double>("Longitude")
                        .HasColumnType("double precision");

                    b.HasKey("AddressId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("SeniorWebAPIProjectV3.Models.Swap", b =>
                {
                    b.Property<string>("SwapId")
                        .HasColumnType("text");

                    b.Property<DateTime>("AcceptTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsAccepted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsContinue")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDone")
                        .HasColumnType("boolean");

                    b.Property<string>("ReceiverField")
                        .HasColumnType("text");

                    b.Property<string>("ReceiverUserId")
                        .HasColumnType("text");

                    b.Property<string>("ReceiverUserName")
                        .HasColumnType("text");

                    b.Property<string>("ReceiverUserPhotoUrl")
                        .HasColumnType("text");

                    b.Property<DateTime>("SendTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("SenderField")
                        .HasColumnType("text");

                    b.Property<string>("SenderUserId")
                        .HasColumnType("text");

                    b.Property<string>("SenderUserName")
                        .HasColumnType("text");

                    b.Property<string>("SenderUserPhotoUrl")
                        .HasColumnType("text");

                    b.Property<int?>("SwapAddressAddressId")
                        .HasColumnType("integer");

                    b.Property<int>("SwapRate")
                        .HasColumnType("integer");

                    b.Property<DateTime>("SwapTime")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("SwapId");

                    b.HasIndex("SwapAddressAddressId");

                    b.ToTable("Swaps");
                });

            modelBuilder.Entity("SeniorWebAPIProjectV3.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int?>("AddressId")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .HasColumnType("text");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("ProfilePhotoUrl")
                        .HasColumnType("text");

                    b.Property<List<string>>("UserAbilities")
                        .HasColumnType("text[]");

                    b.Property<List<string>>("UserFancies")
                        .HasColumnType("text[]");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SeniorWebAPIProjectV3.Models.Swap", b =>
                {
                    b.HasOne("SeniorWebAPIProjectV3.Models.Address", "SwapAddress")
                        .WithMany()
                        .HasForeignKey("SwapAddressAddressId");
                });

            modelBuilder.Entity("SeniorWebAPIProjectV3.Models.User", b =>
                {
                    b.HasOne("SeniorWebAPIProjectV3.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");
                });
#pragma warning restore 612, 618
        }
    }
}
