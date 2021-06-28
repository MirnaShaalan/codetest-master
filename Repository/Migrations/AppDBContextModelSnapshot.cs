﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

namespace Repository.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DomainModels.EF_Models.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("AddedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("11223344-5566-7788-99aa-bbccddeeff00"),
                            CreatedAt = new DateTime(2021, 6, 29, 0, 53, 48, 989, DateTimeKind.Local).AddTicks(8170),
                            Email = "Mirna@mail.com",
                            Name = "Mirna",
                            PhoneNumber = "01000000",
                            UserName = "Mirna"
                        },
                        new
                        {
                            Id = new Guid("12223344-2566-7788-99aa-bbccddeeff00"),
                            CreatedAt = new DateTime(2021, 6, 29, 0, 53, 48, 991, DateTimeKind.Local).AddTicks(1820),
                            Email = "sam@mail.com",
                            Name = "Sam",
                            PhoneNumber = "01000000",
                            UserName = "Sam"
                        },
                        new
                        {
                            Id = new Guid("13223344-3566-7788-99aa-bbccddeeff00"),
                            CreatedAt = new DateTime(2021, 6, 29, 0, 53, 48, 991, DateTimeKind.Local).AddTicks(1853),
                            Email = "John@mail.com",
                            Name = "John",
                            PhoneNumber = "01000000",
                            UserName = "John"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}