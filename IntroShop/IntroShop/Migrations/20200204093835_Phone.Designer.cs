﻿// <auto-generated />
using System;
using IntroShop.Main;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IntroShop.Migrations
{
    [DbContext(typeof(DBContent))]
    [Migration("20200204093835_Phone")]
    partial class Phone
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IntroShop.Main.Models.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("categoryDescription");

                    b.Property<string>("categoryName");

                    b.HasKey("id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("IntroShop.Main.Models.MotherBoard", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Categoryid");

                    b.Property<string>("description");

                    b.Property<string>("img");

                    b.Property<string>("name");

                    b.Property<long>("price");

                    b.HasKey("id");

                    b.HasIndex("Categoryid");

                    b.ToTable("MotherBoard");
                });

            modelBuilder.Entity("IntroShop.Main.Models.MotherBoardCategory", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("categoryDescription");

                    b.Property<string>("categoryName");

                    b.HasKey("id");

                    b.ToTable("MotherBoardCategory");
                });

            modelBuilder.Entity("IntroShop.Main.Models.Phone", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Categoryid");

                    b.Property<string>("description");

                    b.Property<string>("img");

                    b.Property<string>("name");

                    b.Property<long>("price");

                    b.HasKey("id");

                    b.HasIndex("Categoryid");

                    b.ToTable("Phone");
                });

            modelBuilder.Entity("IntroShop.Main.Models.Processor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ProcessorCategoryid");

                    b.Property<string>("description");

                    b.Property<string>("img");

                    b.Property<string>("name");

                    b.Property<long>("price");

                    b.HasKey("id");

                    b.HasIndex("ProcessorCategoryid");

                    b.ToTable("Processor");
                });

            modelBuilder.Entity("IntroShop.Main.Models.ProcessorCategory", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("categoryDescription");

                    b.Property<string>("categoryName");

                    b.HasKey("id");

                    b.ToTable("ProcessorCategory");
                });

            modelBuilder.Entity("IntroShop.Main.Models.SSD", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("SSDCategoryid");

                    b.Property<string>("description");

                    b.Property<string>("img");

                    b.Property<string>("name");

                    b.Property<long>("price");

                    b.HasKey("id");

                    b.HasIndex("SSDCategoryid");

                    b.ToTable("SSD");
                });

            modelBuilder.Entity("IntroShop.Main.Models.SSDCategory", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("categoryDescription");

                    b.Property<string>("categoryName");

                    b.HasKey("id");

                    b.ToTable("SSDCategory");
                });

            modelBuilder.Entity("IntroShop.Main.Models.MotherBoard", b =>
                {
                    b.HasOne("IntroShop.Main.Models.MotherBoardCategory", "Category")
                        .WithMany("phones")
                        .HasForeignKey("Categoryid");
                });

            modelBuilder.Entity("IntroShop.Main.Models.Phone", b =>
                {
                    b.HasOne("IntroShop.Main.Models.Category", "Category")
                        .WithMany("phones")
                        .HasForeignKey("Categoryid");
                });

            modelBuilder.Entity("IntroShop.Main.Models.Processor", b =>
                {
                    b.HasOne("IntroShop.Main.Models.ProcessorCategory", "ProcessorCategory")
                        .WithMany("processors")
                        .HasForeignKey("ProcessorCategoryid");
                });

            modelBuilder.Entity("IntroShop.Main.Models.SSD", b =>
                {
                    b.HasOne("IntroShop.Main.Models.SSDCategory", "SSDCategory")
                        .WithMany("SSDs")
                        .HasForeignKey("SSDCategoryid");
                });
#pragma warning restore 612, 618
        }
    }
}
