﻿// <auto-generated />
using System;
using Appointment_system_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Appointment_system_API.Migrations
{
    [DbContext(typeof(Database))]
    [Migration("20210210202515_Appointment_API")]
    partial class Appointment_API
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Appointment_system_API.model.table", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Appointment_date_time")
                        .HasColumnType("datetime2");

                    b.Property<string>("Clinic_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Doctor_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patient_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("table");
                });
#pragma warning restore 612, 618
        }
    }
}