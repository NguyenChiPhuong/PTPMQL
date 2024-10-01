﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebMvc;

#nullable disable

namespace WebMvc.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241001061206_Create_Table_Employee")]
    partial class Create_Table_Employee
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("WebMvc.Models.Person", b =>
                {
                    b.Property<string>("CCCD")
                        .HasColumnType("TEXT");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("TEXT");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CCCD");

                    b.ToTable("Person");

                    b.HasDiscriminator().HasValue("Person");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("WebMvc.Models.Student", b =>
                {
                    b.Property<string>("FullName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("FullName");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("WebMvc.Models.Employee", b =>
                {
                    b.HasBaseType("WebMvc.Models.Person");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasDiscriminator().HasValue("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
