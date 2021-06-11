﻿// <auto-generated />
using DeepState.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DeepState.Data.Migrations.HungerGames
{
    [DbContext(typeof(HungerGamesContext))]
    [Migration("20210611031937_AddAdditionalChannelAnnouncement")]
    partial class AddAdditionalChannelAnnouncement
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DeepState.Data.Models.HungerGamesPrizePool", b =>
                {
                    b.Property<int>("PrizePoolID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("DiscordGuildId")
                        .HasColumnType("decimal(20,0)");

                    b.Property<double>("PrizePool")
                        .HasColumnType("float");

                    b.HasKey("PrizePoolID");

                    b.ToTable("PrizePools");
                });

            modelBuilder.Entity("DeepState.Data.Models.HungerGamesServerConfiguration", b =>
                {
                    b.Property<int>("ConfigurationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("CorpseAnnouncementChannelId")
                        .HasColumnType("decimal(20,0)");

                    b.Property<decimal>("DiscordGuildId")
                        .HasColumnType("decimal(20,0)");

                    b.Property<decimal>("TributeAnnouncementChannelId")
                        .HasColumnType("decimal(20,0)");

                    b.HasKey("ConfigurationId");

                    b.ToTable("GuildConfigurations");
                });

            modelBuilder.Entity("DeepState.Data.Models.HungerGamesTribute", b =>
                {
                    b.Property<int>("TributeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DeathMessage")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("");

                    b.Property<decimal>("DiscordGuildId")
                        .HasColumnType("decimal(20,0)");

                    b.Property<decimal>("DiscordUserId")
                        .HasColumnType("decimal(20,0)");

                    b.Property<int>("District")
                        .HasColumnType("int");

                    b.Property<bool>("IsAlive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("ObituaryMessage")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("");

                    b.HasKey("TributeId");

                    b.ToTable("Tributes");
                });
#pragma warning restore 612, 618
        }
    }
}
