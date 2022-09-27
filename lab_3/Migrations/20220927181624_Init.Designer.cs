﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using lab_3;

#nullable disable

namespace lab_3.Migrations
{
    [DbContext(typeof(MachineContext))]
    [Migration("20220927181624_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("lab_3.Drink", b =>
                {
                    b.Property<int>("DrinkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Machine_componentsId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name_Drink")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Portion_Drink")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Price_Drink")
                        .HasColumnType("INTEGER");

                    b.HasKey("DrinkId");

                    b.HasIndex("Machine_componentsId");

                    b.ToTable("Drinks");
                });

            modelBuilder.Entity("lab_3.Machine_components", b =>
                {
                    b.Property<int>("Machine_componentsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CheckPaper")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cups")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Sugar")
                        .HasColumnType("INTEGER");

                    b.HasKey("Machine_componentsId");

                    b.ToTable("Components");
                });

            modelBuilder.Entity("lab_3.Drink", b =>
                {
                    b.HasOne("lab_3.Machine_components", null)
                        .WithMany("Drinks")
                        .HasForeignKey("Machine_componentsId");
                });

            modelBuilder.Entity("lab_3.Machine_components", b =>
                {
                    b.Navigation("Drinks");
                });
#pragma warning restore 612, 618
        }
    }
}
