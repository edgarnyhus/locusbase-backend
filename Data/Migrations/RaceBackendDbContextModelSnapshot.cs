﻿// <auto-generated />
using System;
using Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetTopologySuite.Geometries;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    [DbContext(typeof(RaceBackendDbContext))]
    partial class RaceBackendDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Models.Driver", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Email")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Name")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<Guid?>("OrganizationId")
                        .HasColumnType("char(36)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<Guid?>("RaceId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.HasIndex("RaceId");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("Domain.Models.Location", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<double>("Latitude")
                        .HasColumnType("double");

                    b.Property<double>("Longitude")
                        .HasColumnType("double");

                    b.Property<Guid?>("SignpostId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("Timestamp")
                        .IsRequired()
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("WaypointId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("SignpostId")
                        .IsUnique();

                    b.HasIndex("WaypointId")
                        .IsUnique();

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Domain.Models.Organization", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("CustomerNumber")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Identifier")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("OrganizationNumber")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("ParentId");

                    b.HasIndex("TenantId");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("Domain.Models.Race", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Name")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Notes")
                        .HasMaxLength(512)
                        .HasColumnType("varchar(512)");

                    b.Property<Guid?>("OrganizationId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("ScheduledAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Races");
                });

            modelBuilder.Entity("Domain.Models.Sign", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Notes")
                        .HasMaxLength(512)
                        .HasColumnType("varchar(512)");

                    b.Property<Guid?>("OrganizationId")
                        .HasColumnType("char(36)");

                    b.Property<string>("QrCode")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<int?>("SequenceNumber")
                        .HasColumnType("int");

                    b.Property<Guid?>("SignGroupId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("SignpostId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("OrganizationId");

                    b.HasIndex("QrCode")
                        .IsUnique();

                    b.HasIndex("SignpostId")
                        .IsUnique();

                    b.ToTable("Signs");
                });

            modelBuilder.Entity("Domain.Models.SignGroup", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Notes")
                        .HasMaxLength(512)
                        .HasColumnType("varchar(512)");

                    b.Property<Guid?>("OrganizationId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("OrganizationId");

                    b.ToTable("SignGroups");
                });

            modelBuilder.Entity("Domain.Models.Signpost", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Alias")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<Point>("GeoLocation")
                        .HasColumnType("point");

                    b.Property<DateTime?>("LastScanned")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("LastScannedBy")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Notes")
                        .HasMaxLength(512)
                        .HasColumnType("varchar(512)");

                    b.Property<Guid?>("RaceId")
                        .HasColumnType("char(36)");

                    b.Property<string>("State")
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.HasKey("Id");

                    b.HasIndex("RaceId");

                    b.ToTable("Signposts");
                });

            modelBuilder.Entity("Domain.Models.SignType", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Description")
                        .HasMaxLength(512)
                        .HasColumnType("varchar(512)");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Name")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.ToTable("SignTypes");
                });

            modelBuilder.Entity("Domain.Models.Tenant", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Description")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Identifier")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Tenants");
                });

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Email")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Name")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Nickname")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<Guid?>("OrganizationId")
                        .HasColumnType("char(36)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnType("char(36)");

                    b.Property<string>("UserId")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("OrganizationId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Models.UserSettings", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int?>("CertificationWarning")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Widgets")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserSettings");
                });

            modelBuilder.Entity("Domain.Models.Waypoint", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Alias")
                        .HasMaxLength(64)
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Notes")
                        .HasMaxLength(512)
                        .HasColumnType("varchar(512)");

                    b.Property<Guid?>("RaceId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("RaceId");

                    b.ToTable("Waypoints");
                });

            modelBuilder.Entity("Domain.Models.Driver", b =>
                {
                    b.HasOne("Domain.Models.Organization", "Organization")
                        .WithMany("Drivers")
                        .HasForeignKey("OrganizationId");

                    b.HasOne("Domain.Models.Race", "Race")
                        .WithMany()
                        .HasForeignKey("RaceId");

                    b.Navigation("Organization");

                    b.Navigation("Race");
                });

            modelBuilder.Entity("Domain.Models.Location", b =>
                {
                    b.HasOne("Domain.Models.Signpost", "Signpost")
                        .WithOne("Location")
                        .HasForeignKey("Domain.Models.Location", "SignpostId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Models.Waypoint", "Waypoint")
                        .WithOne("Location")
                        .HasForeignKey("Domain.Models.Location", "WaypointId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Signpost");

                    b.Navigation("Waypoint");
                });

            modelBuilder.Entity("Domain.Models.Organization", b =>
                {
                    b.HasOne("Domain.Models.Organization", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");

                    b.HasOne("Domain.Models.Tenant", null)
                        .WithMany("Children")
                        .HasForeignKey("TenantId");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("Domain.Models.Race", b =>
                {
                    b.HasOne("Domain.Models.Organization", "Organization")
                        .WithMany("Routes")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("Domain.Models.Sign", b =>
                {
                    b.HasOne("Domain.Models.Organization", "Organization")
                        .WithMany("Signs")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Models.SignGroup", "SignGroup")
                        .WithMany("Signs")
                        .HasForeignKey("SignpostId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Models.SignType", "SignType")
                        .WithMany("Signs")
                        .HasForeignKey("SignpostId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Domain.Models.Signpost", "Signpost")
                        .WithOne("Sign")
                        .HasForeignKey("Domain.Models.Sign", "SignpostId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Organization");

                    b.Navigation("SignGroup");

                    b.Navigation("SignType");

                    b.Navigation("Signpost");
                });

            modelBuilder.Entity("Domain.Models.SignGroup", b =>
                {
                    b.HasOne("Domain.Models.Organization", "Organization")
                        .WithMany()
                        .HasForeignKey("OrganizationId");

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("Domain.Models.Signpost", b =>
                {
                    b.HasOne("Domain.Models.Race", "Race")
                        .WithMany("Signposts")
                        .HasForeignKey("RaceId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Race");
                });

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.HasOne("Domain.Models.Organization", "Organization")
                        .WithMany("Users")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("Domain.Models.UserSettings", b =>
                {
                    b.HasOne("Domain.Models.User", "User")
                        .WithOne("UserSettings")
                        .HasForeignKey("Domain.Models.UserSettings", "UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Models.Waypoint", b =>
                {
                    b.HasOne("Domain.Models.Race", "Race")
                        .WithMany("Waypoints")
                        .HasForeignKey("RaceId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Race");
                });

            modelBuilder.Entity("Domain.Models.Organization", b =>
                {
                    b.Navigation("Children");

                    b.Navigation("Drivers");

                    b.Navigation("Routes");

                    b.Navigation("Signs");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Domain.Models.Race", b =>
                {
                    b.Navigation("Signposts");

                    b.Navigation("Waypoints");
                });

            modelBuilder.Entity("Domain.Models.SignGroup", b =>
                {
                    b.Navigation("Signs");
                });

            modelBuilder.Entity("Domain.Models.Signpost", b =>
                {
                    b.Navigation("Location");

                    b.Navigation("Sign");
                });

            modelBuilder.Entity("Domain.Models.SignType", b =>
                {
                    b.Navigation("Signs");
                });

            modelBuilder.Entity("Domain.Models.Tenant", b =>
                {
                    b.Navigation("Children");
                });

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.Navigation("UserSettings");
                });

            modelBuilder.Entity("Domain.Models.Waypoint", b =>
                {
                    b.Navigation("Location");
                });
#pragma warning restore 612, 618
        }
    }
}
