﻿// <auto-generated />
using System;
using MathexGaming.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MathexGaming.Data.Migrations
{
    [DbContext(typeof(MathexGamingContext))]
    partial class MathexGamingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MathexGaming.Models.Challenge", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("Completed")
                        .HasColumnType("bit");

                    b.Property<int>("GameMapID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("GameMapID");

                    b.ToTable("Challenges");
                });

            modelBuilder.Entity("MathexGaming.Models.Diablo3.D3Achievement", b =>
                {
                    b.Property<int>("D3AchievementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AchievementName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AchievementText")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Group")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("SeasonRoll")
                        .HasColumnType("int");

                    b.Property<string>("SubGroup")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("D3AchievementId");

                    b.ToTable("DiabloAchievements");

                    b.HasData(
                        new
                        {
                            D3AchievementId = 1,
                            AchievementName = "Boss Mode",
                            AchievementText = "Kill all bosses (except Vidian) in 20 mins",
                            Group = "ScConquests",
                            SeasonRoll = 24,
                            SubGroup = "ScConquests"
                        });
                });

            modelBuilder.Entity("MathexGaming.Models.Diablo3.D3UserCompletion", b =>
                {
                    b.Property<int>("D3UserCompletionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompletedColor")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<int?>("GamerID")
                        .HasColumnType("int");

                    b.HasKey("D3UserCompletionID");

                    b.HasIndex("GamerID");

                    b.ToTable("D3UserCompletion");
                });

            modelBuilder.Entity("MathexGaming.Models.Diablo3.JourneyObjective", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Chapter")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Group")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ObjectiveName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Season")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("JourneyObjectives");
                });

            modelBuilder.Entity("MathexGaming.Models.Diablo3.JourneyObjectiveGroup", b =>
                {
                    b.Property<int>("JourneyObjectiveGroupID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("JourneyObjectiveGroupName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("JourneyObjectiveGroupID");

                    b.ToTable("JourneyObjectiveGroups");

                    b.HasData(
                        new
                        {
                            JourneyObjectiveGroupID = 1,
                            JourneyObjectiveGroupName = "Bosses"
                        },
                        new
                        {
                            JourneyObjectiveGroupID = 2,
                            JourneyObjectiveGroupName = "Kanai's Cube"
                        });
                });

            modelBuilder.Entity("MathexGaming.Models.FIFA.EAsFCxp", b =>
                {
                    b.Property<int>("EAsFCxpID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NextLevel")
                        .HasColumnType("int");

                    b.Property<int>("XPThreshold")
                        .HasColumnType("int");

                    b.HasKey("EAsFCxpID");

                    b.ToTable("EAsFCxps");
                });

            modelBuilder.Entity("MathexGaming.Models.FIFA.FUTgame", b =>
                {
                    b.Property<int>("FUTgameID")
                        .HasColumnType("int")
                        .HasColumnName("FUTgame");

                    b.HasKey("FUTgameID");

                    b.ToTable("FUTGames");

                    b.HasData(
                        new
                        {
                            FUTgameID = 17
                        },
                        new
                        {
                            FUTgameID = 18
                        },
                        new
                        {
                            FUTgameID = 19
                        });
                });

            modelBuilder.Entity("MathexGaming.Models.FIFA.UserCoin", b =>
                {
                    b.Property<int>("CoinID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Coins")
                        .HasColumnType("int");

                    b.Property<int>("DraftsBought")
                        .HasColumnType("int");

                    b.Property<int>("FUTgameID")
                        .HasColumnType("int");

                    b.Property<int?>("GamerId")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("CoinID");

                    b.HasIndex("FUTgameID");

                    b.HasIndex("GamerId");

                    b.ToTable("UserCoins");
                });

            modelBuilder.Entity("MathexGaming.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("MathexGaming.Models.Gamer", b =>
                {
                    b.Property<int>("GamerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PSEmail")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PSUser")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("RealName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("GamerId");

                    b.ToTable("Gamers");

                    b.HasData(
                        new
                        {
                            GamerId = 1,
                            PSEmail = "mn83gamer@gmail.com",
                            PSUser = "mn83gamer",
                            RealName = "Martin Nørholm"
                        });
                });

            modelBuilder.Entity("MathexGaming.Models.THPS.GameMap", b =>
                {
                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("RWLocation")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("GameMaps");
                });

            modelBuilder.Entity("MathexGaming.Models.Challenge", b =>
                {
                    b.HasOne("MathexGaming.Models.THPS.GameMap", "GameMap")
                        .WithMany()
                        .HasForeignKey("GameMapID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GameMap");
                });

            modelBuilder.Entity("MathexGaming.Models.Diablo3.D3UserCompletion", b =>
                {
                    b.HasOne("MathexGaming.Models.Gamer", "Gamer")
                        .WithMany("D3UserCompletions")
                        .HasForeignKey("GamerID");

                    b.Navigation("Gamer");
                });

            modelBuilder.Entity("MathexGaming.Models.FIFA.UserCoin", b =>
                {
                    b.HasOne("MathexGaming.Models.FIFA.FUTgame", "FUTgame")
                        .WithMany("UserCoins")
                        .HasForeignKey("FUTgameID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MathexGaming.Models.Gamer", "Gamer")
                        .WithMany("UserCoins")
                        .HasForeignKey("GamerId");

                    b.Navigation("FUTgame");

                    b.Navigation("Gamer");
                });

            modelBuilder.Entity("MathexGaming.Models.FIFA.FUTgame", b =>
                {
                    b.Navigation("UserCoins");
                });

            modelBuilder.Entity("MathexGaming.Models.Gamer", b =>
                {
                    b.Navigation("D3UserCompletions");

                    b.Navigation("UserCoins");
                });
#pragma warning restore 612, 618
        }
    }
}
