﻿// <auto-generated />
using System;
using AccuMicroService;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AccuMicroService.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20231119174708_1Fix")]
    partial class _1Fix
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AccuMicroService.Enitites.RPrecipitation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Precipitation")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("RPrecipitations");
                });

            modelBuilder.Entity("AccuMicroService.Enitites.RReestrObject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AccuweatherId")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("RReestrObjects");
                });

            modelBuilder.Entity("AccuMicroService.Enitites.WeatherCalendar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("ObjectId")
                        .HasColumnType("integer");

                    b.Property<int?>("PrecipitationId")
                        .HasColumnType("integer");

                    b.Property<int?>("TemperaturaMax")
                        .HasColumnType("integer");

                    b.Property<int?>("TemperaturaMin")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ObjectId");

                    b.HasIndex("PrecipitationId");

                    b.ToTable("WeatherCalendars");
                });

            modelBuilder.Entity("AccuMicroService.Enitites.WeatherCalendar", b =>
                {
                    b.HasOne("AccuMicroService.Enitites.RReestrObject", "Object")
                        .WithMany("WeatherCalendars")
                        .HasForeignKey("ObjectId");

                    b.HasOne("AccuMicroService.Enitites.RPrecipitation", "Precipitation")
                        .WithMany()
                        .HasForeignKey("PrecipitationId");

                    b.Navigation("Object");

                    b.Navigation("Precipitation");
                });

            modelBuilder.Entity("AccuMicroService.Enitites.RReestrObject", b =>
                {
                    b.Navigation("WeatherCalendars");
                });
#pragma warning restore 612, 618
        }
    }
}
