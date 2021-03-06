﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelAPI.Models;

namespace TravelAPI.Migrations
{
    [DbContext(typeof(TravelAPIContext))]
    [Migration("20200402203400_RestructureDirectory")]
    partial class RestructureDirectory
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

                    b.Property<string>("Description");

                    b.Property<string>("Destination")
                        .HasMaxLength(15);

                    b.Property<int>("Rating");

                    b.Property<string>("Title")
                        .HasMaxLength(30);

                    b.Property<string>("user_name")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("ReviewId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
                            Description = "Always ask for them.",
                            Destination = "Hawaii",
                            Rating = 3,
                            Title = "Coconuts Yes!",
                            user_name = "Amy"
                        },
                        new
                        {
                            ReviewId = 2,
                            Description = "Mhm",
                            Destination = "Seattle",
                            Rating = 3,
                            Title = "The Emerald City",
                            user_name = "Bob"
                        },
                        new
                        {
                            ReviewId = 3,
                            Description = "Bring your hiking shoes with you!",
                            Destination = "Denver",
                            Rating = 3,
                            Title = "Hiking Paradise",
                            user_name = "Amy"
                        },
                        new
                        {
                            ReviewId = 4,
                            Description = "So little time, so much distance to travel",
                            Destination = "New York",
                            Rating = 5,
                            Title = "Walk, walk, walk",
                            user_name = "Bob"
                        },
                        new
                        {
                            ReviewId = 5,
                            Description = "Dunkin donuts all around!",
                            Destination = "Chicago",
                            Rating = 5,
                            Title = "Good 'ol Chicago",
                            user_name = "Amy"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
