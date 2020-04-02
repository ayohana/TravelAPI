﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelAPI.Models;

namespace TravelAPI.Migrations
{
    [DbContext(typeof(TravelAPIContext))]
    [Migration("20200330200629_Validations")]
    partial class Validations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TravelAPI.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<int>("Rating");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("ReviewId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
                            Description = "Always ask for them.",
                            Destination = "Hawaii",
                            Rating = 3,
                            Title = "Coconuts Yes!"
                        },
                        new
                        {
                            ReviewId = 2,
                            Description = "Mhm",
                            Destination = "Seattle",
                            Rating = 3,
                            Title = "The Emerald City"
                        },
                        new
                        {
                            ReviewId = 3,
                            Description = "Bring your hiking shoes with you!",
                            Destination = "Denver",
                            Rating = 3,
                            Title = "Hiking Paradise"
                        },
                        new
                        {
                            ReviewId = 4,
                            Description = "So little time, so much distance to travel",
                            Destination = "New York",
                            Rating = 6,
                            Title = "Walk, walk, walk"
                        },
                        new
                        {
                            ReviewId = 5,
                            Description = "Dunkin donuts all around!",
                            Destination = "Chicago",
                            Rating = 5,
                            Title = "Good 'ol Chicago"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}