﻿// <auto-generated />
using MathexGaming.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MathexGaming.Migrations
{
    [DbContext(typeof(MathexGamingDbContext))]
    [Migration("20211004174328_initialMigration")]
    partial class initialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MathexGaming.Models.Challenge", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("Completed")
                        .HasColumnType("bit");

                    b.Property<int>("GameMapId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GameMapId");

                    b.ToTable("Challenges");
                });

            modelBuilder.Entity("MathexGaming.Models.Gamer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PSEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PSUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Gamers");
                });

            modelBuilder.Entity("MathexGaming.Models.PSTrophy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PSTrophies");
                });

            modelBuilder.Entity("MathexGaming.Models.THPS.GameMap", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RWLocation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GameMap");
                });

            modelBuilder.Entity("MathexGaming.Models.Challenge", b =>
                {
                    b.HasOne("MathexGaming.Models.THPS.GameMap", null)
                        .WithMany("GameMapChallenges")
                        .HasForeignKey("GameMapId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MathexGaming.Models.THPS.GameMap", b =>
                {
                    b.Navigation("GameMapChallenges");
                });
#pragma warning restore 612, 618
        }
    }
}
