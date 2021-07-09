﻿// <auto-generated />
using System;
using GuessMyNation.Infra.Data.Sql.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GuessMyNation.Infra.Data.Sql.Migrations
{
    [DbContext(typeof(GuessMyNationDbContext))]
    [Migration("20210709145616_AddGameDetailToGameHeader")]
    partial class AddGameDetailToGameHeader
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GuessMyNation.Core.Domain.Blogs.Blog", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Desciption")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("EnName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("GuessMyNation.Core.Domain.Game.GameDetail", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("GameHeaderId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("GameHeaderId");

                    b.ToTable("GameDetail");
                });

            modelBuilder.Entity("GuessMyNation.Core.Domain.Game.GameHeader", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("EndDateTime")
                        .HasColumnType("datetime2");

                    b.Property<long>("PlayerId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("ToralScore")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("GuessMyNation.Core.Domain.Nation.Nation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Nations");
                });

            modelBuilder.Entity("GuessMyNation.Core.Domain.Nation.NationItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AnswerCode")
                        .HasColumnType("int");

                    b.Property<long?>("GameDetailId")
                        .HasColumnType("bigint");

                    b.Property<byte[]>("Photo")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte?>("Point")
                        .HasColumnType("tinyint");

                    b.Property<long?>("nationId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("GameDetailId");

                    b.HasIndex("nationId");

                    b.ToTable("NationItem");
                });

            modelBuilder.Entity("GuessMyNation.Core.Domain.Game.GameDetail", b =>
                {
                    b.HasOne("GuessMyNation.Core.Domain.Game.GameHeader", null)
                        .WithMany("Details")
                        .HasForeignKey("GameHeaderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GuessMyNation.Core.Domain.Nation.NationItem", b =>
                {
                    b.HasOne("GuessMyNation.Core.Domain.Game.GameDetail", null)
                        .WithMany("nationItems")
                        .HasForeignKey("GameDetailId");

                    b.HasOne("GuessMyNation.Core.Domain.Nation.Nation", "nation")
                        .WithMany()
                        .HasForeignKey("nationId");

                    b.Navigation("nation");
                });

            modelBuilder.Entity("GuessMyNation.Core.Domain.Game.GameDetail", b =>
                {
                    b.Navigation("nationItems");
                });

            modelBuilder.Entity("GuessMyNation.Core.Domain.Game.GameHeader", b =>
                {
                    b.Navigation("Details");
                });
#pragma warning restore 612, 618
        }
    }
}
