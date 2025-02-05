﻿// <auto-generated />
using System;
using API_Login.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API_Login.Migrations
{
    [DbContext(typeof(DbContextClass))]
    [Migration("20240707082923_Initial-migration")]
    partial class Initialmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("API_Login.Models.LoginUser_mdl", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime")
                        .HasColumnName("Created");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("varchar(250)")
                        .HasColumnName("CreatedBy");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("varchar(250)")
                        .HasColumnName("Department");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime")
                        .HasColumnName("Dob");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(250)")
                        .HasColumnName("Email");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("IsActive");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("IsDeleted");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(250)")
                        .HasColumnName("Name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(250)")
                        .HasColumnName("Password");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("varchar(250)")
                        .HasColumnName("PhoneNumber");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("varchar(250)")
                        .HasColumnName("UserName");

                    b.HasKey("UserId");

                    b.ToTable("LoginUser", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
