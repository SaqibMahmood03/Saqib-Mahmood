﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace RazorPagesMovie.Migrations
{
    [DbContext(typeof(RazorPagesCollegeContext))]
    partial class RazorPagesCollegeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.14");

            modelBuilder.Entity("RazorPagesCollege.Models.College", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CollegeName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EstablishmentDate")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("NumberOfStudents")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("College");
                });
#pragma warning restore 612, 618
        }
    }
}
