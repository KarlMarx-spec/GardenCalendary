﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(GardenCalendaryContext))]
    [Migration("20230814194216_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Plant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("PlantName")
                        .HasColumnType("character varying")
                        .HasColumnName("plant_name");

                    b.Property<int?>("SoilMoistureMax")
                        .HasColumnType("integer")
                        .HasColumnName("soil_moisture_max");

                    b.Property<int?>("SoilMoistureMin")
                        .HasColumnType("integer")
                        .HasColumnName("soil_moisture_min");

                    b.Property<int?>("TempMax")
                        .HasColumnType("integer")
                        .HasColumnName("temp_max");

                    b.Property<int?>("TempMin")
                        .HasColumnType("integer")
                        .HasColumnName("temp_min");

                    b.HasKey("Id")
                        .HasName("plant_pkey");

                    b.ToTable("plant", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.RPrecipitation", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<string>("Precipitation")
                        .HasColumnType("character varying")
                        .HasColumnName("precipitation");

                    b.HasKey("Id")
                        .HasName("precipitation_pkey");

                    b.ToTable("r$precipitation", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.RReestrObject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("AccuweatherId")
                        .HasColumnType("integer")
                        .HasColumnName("accuweather_id");

                    b.Property<string>("ObjectName")
                        .HasColumnType("character varying")
                        .HasColumnName("object_name");

                    b.Property<int?>("RegionCodeId")
                        .HasColumnType("integer")
                        .HasColumnName("region_code_id");

                    b.HasKey("Id")
                        .HasName("r$reestr_object_pkey");

                    b.HasIndex("RegionCodeId");

                    b.ToTable("r$reestr_object", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Region", b =>
                {
                    b.Property<int>("RegionCodeId")
                        .HasColumnType("integer")
                        .HasColumnName("region_code_id");

                    b.Property<string>("RegionName")
                        .HasColumnType("character varying")
                        .HasColumnName("region_name");

                    b.HasKey("RegionCodeId")
                        .HasName("region_pkey");

                    b.ToTable("region", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("Role", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Stead", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("ObjectId")
                        .HasColumnType("integer")
                        .HasColumnName("object_id");

                    b.Property<int?>("PlantId")
                        .HasColumnType("integer")
                        .HasColumnName("plant_id");

                    b.Property<int?>("RegionCodeId")
                        .HasColumnType("integer")
                        .HasColumnName("region_code_id");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("start_date");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("stead_pkey");

                    b.HasIndex("ObjectId");

                    b.HasIndex("PlantId");

                    b.HasIndex("RegionCodeId");

                    b.HasIndex("UserId");

                    b.ToTable("stead", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .HasColumnType("character varying")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .HasColumnType("character varying")
                        .HasColumnName("last_name");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("character varying")
                        .HasColumnName("phone_number");

                    b.Property<int?>("RegionCodeId")
                        .HasColumnType("integer")
                        .HasColumnName("region_code_id");

                    b.Property<string>("SecondName")
                        .HasColumnType("character varying")
                        .HasColumnName("second_name");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("Login");

                    b.HasKey("Id")
                        .HasName("users_pkey");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.HasIndex("RegionCodeId");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.UserToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserToken", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.WeatherCalendarModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DateTame")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_tame");

                    b.Property<int?>("ObjectId")
                        .HasColumnType("integer")
                        .HasColumnName("object_id");

                    b.Property<int?>("PrecipitationId")
                        .HasColumnType("integer")
                        .HasColumnName("precipitation_id");

                    b.Property<int?>("RegionCodeId")
                        .HasColumnType("integer")
                        .HasColumnName("region_code_id");

                    b.Property<int?>("TemperaturaMax")
                        .HasColumnType("integer")
                        .HasColumnName("temperatura_max");

                    b.Property<int?>("TemperaturaMin")
                        .HasColumnType("integer")
                        .HasColumnName("temperatura_min");

                    b.HasKey("Id")
                        .HasName("weather_calendar_pkey");

                    b.HasIndex("ObjectId");

                    b.HasIndex("PrecipitationId");

                    b.HasIndex("RegionCodeId");

                    b.ToTable("weather_calendar", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRole", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.RReestrObject", b =>
                {
                    b.HasOne("Domain.Entities.Region", "RegionCode")
                        .WithMany("RReestrObjects")
                        .HasForeignKey("RegionCodeId");

                    b.Navigation("RegionCode");
                });

            modelBuilder.Entity("Domain.Entities.Stead", b =>
                {
                    b.HasOne("Domain.Entities.RReestrObject", "Object")
                        .WithMany("Steads")
                        .HasForeignKey("ObjectId")
                        .HasConstraintName("stead_object_id_fkey");

                    b.HasOne("Domain.Entities.Plant", "Plant")
                        .WithMany("Steads")
                        .HasForeignKey("PlantId")
                        .HasConstraintName("stead_plant_id_fkey");

                    b.HasOne("Domain.Entities.Region", "RegionCode")
                        .WithMany("Steads")
                        .HasForeignKey("RegionCodeId")
                        .HasConstraintName("stead_region_code_fkey");

                    b.HasOne("Domain.Entities.User", "User")
                        .WithMany("Steads")
                        .HasForeignKey("UserId")
                        .HasConstraintName("stead_user_id_fkey");

                    b.Navigation("Object");

                    b.Navigation("Plant");

                    b.Navigation("RegionCode");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.HasOne("Domain.Entities.Region", "RegionCode")
                        .WithMany("Users")
                        .HasForeignKey("RegionCodeId")
                        .HasConstraintName("users_region_code_fkey");

                    b.Navigation("RegionCode");
                });

            modelBuilder.Entity("Domain.Entities.UserToken", b =>
                {
                    b.HasOne("Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.WeatherCalendarModel", b =>
                {
                    b.HasOne("Domain.Entities.RReestrObject", "Object")
                        .WithMany("WeatherCalendars")
                        .HasForeignKey("ObjectId")
                        .HasConstraintName("weather_calendar_object_id_fkey");

                    b.HasOne("Domain.Entities.RPrecipitation", "Precipitation")
                        .WithMany("WeatherCalendars")
                        .HasForeignKey("PrecipitationId")
                        .HasConstraintName("weather_calendar_precipitation_id_fkey");

                    b.HasOne("Domain.Entities.Region", "RegionCode")
                        .WithMany("WeatherCalendars")
                        .HasForeignKey("RegionCodeId")
                        .HasConstraintName("weather_calendar_region_code_fkey");

                    b.Navigation("Object");

                    b.Navigation("Precipitation");

                    b.Navigation("RegionCode");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Domain.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Plant", b =>
                {
                    b.Navigation("Steads");
                });

            modelBuilder.Entity("Domain.Entities.RPrecipitation", b =>
                {
                    b.Navigation("WeatherCalendars");
                });

            modelBuilder.Entity("Domain.Entities.RReestrObject", b =>
                {
                    b.Navigation("Steads");

                    b.Navigation("WeatherCalendars");
                });

            modelBuilder.Entity("Domain.Entities.Region", b =>
                {
                    b.Navigation("RReestrObjects");

                    b.Navigation("Steads");

                    b.Navigation("Users");

                    b.Navigation("WeatherCalendars");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Navigation("Steads");
                });
#pragma warning restore 612, 618
        }
    }
}
