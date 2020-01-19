﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SafeGuard.Data;

namespace SafeGuard.Migrations
{
    [DbContext(typeof(LocationDbContext))]
    partial class LocationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("SafeGuard.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("location_id");

                    b.Property<string>("Latitude")
                        .HasColumnName("latitude");

                    b.Property<string>("Longitude")
                        .HasColumnName("longitude");

                    b.Property<string>("UserChoice")
                        .HasColumnName("user_choice");

                    b.Property<string>("UserName")
                        .HasColumnName("username");

                    b.HasKey("LocationId");

                    b.ToTable("location");
                });
#pragma warning restore 612, 618
        }
    }
}
