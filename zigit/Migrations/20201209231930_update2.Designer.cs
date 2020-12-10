﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using zigit.Data;

namespace zigit.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20201209231930_update2")]
    partial class update2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("zigit.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BugsCount")
                        .HasColumnType("int");

                    b.Property<byte>("DurationInDays")
                        .HasColumnType("tinyint");

                    b.Property<bool>("MadeDadeline")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Score")
                        .HasColumnType("tinyint");

                    b.HasKey("Id");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BugsCount = 3,
                            DurationInDays = (byte)7,
                            MadeDadeline = true,
                            Name = "Full Stack Dev",
                            Score = (byte)100
                        },
                        new
                        {
                            Id = 2,
                            BugsCount = 1,
                            DurationInDays = (byte)20,
                            MadeDadeline = true,
                            Name = "Python Web Scraping",
                            Score = (byte)93
                        },
                        new
                        {
                            Id = 3,
                            BugsCount = 6,
                            DurationInDays = (byte)2,
                            MadeDadeline = true,
                            Name = "Fintech Marketing",
                            Score = (byte)88
                        });
                });

            modelBuilder.Entity("zigit.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "ormizrahi777@gmail.com",
                            Password = "aaa111",
                            ProjectId = 1
                        },
                        new
                        {
                            Id = 2,
                            Email = "yifatpaldi@gmail.com",
                            Password = "bbb222",
                            ProjectId = 2
                        },
                        new
                        {
                            Id = 3,
                            Email = "shmuelm@gmail.com",
                            Password = "ccc333",
                            ProjectId = 3
                        });
                });

            modelBuilder.Entity("zigit.Models.User", b =>
                {
                    b.HasOne("zigit.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
