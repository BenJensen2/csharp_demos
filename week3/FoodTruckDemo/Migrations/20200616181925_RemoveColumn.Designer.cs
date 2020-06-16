﻿// <auto-generated />
using System;
using FoodTruckDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FoodTruckDemo.Migrations
{
    [DbContext(typeof(FoodTruckContext))]
    [Migration("20200616181925_RemoveColumn")]
    partial class RemoveColumn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FoodTruckDemo.Models.FoodTruck", b =>
                {
                    b.Property<int>("FoodTruckId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("Style");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int>("UserId");

                    b.HasKey("FoodTruckId");

                    b.HasIndex("UserId");

                    b.ToTable("FoodTrucks");
                });

            modelBuilder.Entity("FoodTruckDemo.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("FoodTruckId");

                    b.Property<int>("Rating");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int>("UserId");

                    b.HasKey("ReviewId");

                    b.HasIndex("FoodTruckId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("FoodTruckDemo.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FoodTruckDemo.Models.FoodTruck", b =>
                {
                    b.HasOne("FoodTruckDemo.Models.User", "UploadedBy")
                        .WithMany("UploadedTrucks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FoodTruckDemo.Models.Review", b =>
                {
                    b.HasOne("FoodTruckDemo.Models.FoodTruck", "FoodTruck")
                        .WithMany("Reviews")
                        .HasForeignKey("FoodTruckId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FoodTruckDemo.Models.User", "Author")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
