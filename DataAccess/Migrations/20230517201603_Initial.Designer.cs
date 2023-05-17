﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(CinemaDbContext))]
    [Migration("20230517201603_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Data.Entities.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Place_of_birth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Birthday = new DateTime(1964, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Russell Crowe",
                            Place_of_birth = "Wellington"
                        },
                        new
                        {
                            Id = 2,
                            Birthday = new DateTime(1969, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Matthew McConaughey",
                            Place_of_birth = "Uvalde, Texas"
                        },
                        new
                        {
                            Id = 3,
                            Birthday = new DateTime(1983, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Alexandre Rodrigues",
                            Place_of_birth = "Rio de Janeiro"
                        },
                        new
                        {
                            Id = 4,
                            Birthday = new DateTime(1974, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Christian Bale",
                            Place_of_birth = "Haverfordwest"
                        });
                });

            modelBuilder.Entity("Data.Entities.Session", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Film_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Film_raiting")
                        .HasColumnType("float");

                    b.Property<DateTime>("Next_session")
                        .HasColumnType("datetime2");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Sessions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O., but his tragic past may doom the project and his team to disaster.",
                            Film_name = "Inception",
                            Film_raiting = 8.8000000000000007,
                            Next_session = new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 100.0
                        },
                        new
                        {
                            Id = 2,
                            Description = "The story of Henry Hill and his life in the mafia, covering his relationship with his wife Karen and his mob partners Jimmy Conway and Tommy DeVito.",
                            Film_name = "Goodfellas",
                            Film_raiting = 8.6999999999999993,
                            Next_session = new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 150.0
                        },
                        new
                        {
                            Id = 3,
                            Description = "In the slums of Rio, two kids' paths diverge as one struggles to become a photographer and the other a kingpin.",
                            Film_name = "City of God",
                            Film_raiting = 8.5999999999999996,
                            Next_session = new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 100.0
                        },
                        new
                        {
                            Id = 4,
                            Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                            Film_name = "The Dark Knight",
                            Film_raiting = 9.0,
                            Next_session = new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 170.0
                        },
                        new
                        {
                            Id = 5,
                            Description = "A former Roman General sets out to exact vengeance against the corrupt emperor who murdered his family and sent him into slavery.",
                            Film_name = "Gladiator",
                            Film_raiting = 8.5,
                            Next_session = new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Price = 100.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
