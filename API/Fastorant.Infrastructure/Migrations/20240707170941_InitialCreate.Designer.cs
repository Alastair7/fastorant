﻿// <auto-generated />
using Fastorant.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Fastorant.Infrastructure.Migrations
{
    [DbContext(typeof(FastorantContext))]
    [Migration("20240707170941_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("Fastorant.Infrastructure.Entities.Business", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AfternoonSchedule")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("CoordinateX")
                        .HasColumnType("REAL");

                    b.Property<double>("CoordinateY")
                        .HasColumnType("REAL");

                    b.Property<long>("LocalityID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MorningSchedule")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("ProvinceID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.Property<string>("WorkingDays")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("LocalityID");

                    b.HasIndex("ProvinceID");

                    b.ToTable("Business", (string)null);
                });

            modelBuilder.Entity("Fastorant.Infrastructure.Entities.Locality", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("ProvinceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProvinceId");

                    b.ToTable("Locality", (string)null);
                });

            modelBuilder.Entity("Fastorant.Infrastructure.Entities.Province", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Province", (string)null);
                });

            modelBuilder.Entity("Fastorant.Infrastructure.Entities.Business", b =>
                {
                    b.HasOne("Fastorant.Infrastructure.Entities.Locality", "Locality")
                        .WithMany()
                        .HasForeignKey("LocalityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fastorant.Infrastructure.Entities.Province", "Province")
                        .WithMany()
                        .HasForeignKey("ProvinceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Locality");

                    b.Navigation("Province");
                });

            modelBuilder.Entity("Fastorant.Infrastructure.Entities.Locality", b =>
                {
                    b.HasOne("Fastorant.Infrastructure.Entities.Province", "Province")
                        .WithMany("Localities")
                        .HasForeignKey("ProvinceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Province");
                });

            modelBuilder.Entity("Fastorant.Infrastructure.Entities.Province", b =>
                {
                    b.Navigation("Localities");
                });
#pragma warning restore 612, 618
        }
    }
}
