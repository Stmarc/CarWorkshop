﻿// <auto-generated />
using System;
using CarWorkShop.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarWorkShop.Infrastructure.Migrations
{
    [DbContext(typeof(CarWorkShopDbContext))]
    [Migration("20240121170741_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CarWorkShop.Domain.Entities.CarWorkShop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EncodedName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CarWorkShops");
                });

            modelBuilder.Entity("CarWorkShop.Domain.Entities.CarWorkShop", b =>
                {
                    b.OwnsOne("CarWorkShop.Domain.Entities.CarWorkShopContactDetails", "ContactDetails", b1 =>
                        {
                            b1.Property<int>("CarWorkShopId")
                                .HasColumnType("int");

                            b1.Property<string>("City")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("PostalCode")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Street")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("phoneNumber")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("CarWorkShopId");

                            b1.ToTable("CarWorkShops");

                            b1.WithOwner()
                                .HasForeignKey("CarWorkShopId");
                        });

                    b.Navigation("ContactDetails")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
