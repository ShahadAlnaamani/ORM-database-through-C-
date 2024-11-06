﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ORMCodeFirst;

#nullable disable

namespace ORMCodeFirst.Migrations
{
    [DbContext(typeof(CustomDbContext))]
    [Migration("20241106031900_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ORMCodeFirst.Models.Department", b =>
                {
                    b.Property<int>("Dnumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Dnumber"));

                    b.Property<string>("Dname")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Mgr_SSN")
                        .HasColumnType("int");

                    b.Property<DateOnly>("Mgr_Start_Date")
                        .HasColumnType("date");

                    b.HasKey("Dnumber");

                    b.HasIndex("Dnumber")
                        .IsUnique();

                    b.HasIndex("Mgr_SSN");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("ORMCodeFirst.Models.Dependent", b =>
                {
                    b.Property<int>("Essn")
                        .HasColumnType("int");

                    b.Property<string>("Dependent_Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateOnly>("Bdate")
                        .HasColumnType("date");

                    b.Property<int>("relationship")
                        .HasColumnType("int");

                    b.Property<int>("sex")
                        .HasColumnType("int");

                    b.HasKey("Essn", "Dependent_Name");

                    b.ToTable("Dependents");
                });

            modelBuilder.Entity("ORMCodeFirst.Models.Dept_location", b =>
                {
                    b.Property<int>("Dnumber")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Dnumber", "Location");

                    b.ToTable("Dept_Locations");
                });

            modelBuilder.Entity("ORMCodeFirst.Models.Employee", b =>
                {
                    b.Property<int>("SSN")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SSN"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateOnly>("Bdate")
                        .HasColumnType("date");

                    b.Property<int>("Dno")
                        .HasColumnType("int");

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Lname")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Mname")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<float>("Salary")
                        .HasMaxLength(100000)
                        .HasColumnType("real");

                    b.Property<int>("SuperSSN")
                        .HasColumnType("int");

                    b.Property<int>("sex")
                        .HasColumnType("int");

                    b.HasKey("SSN");

                    b.HasIndex("Dno");

                    b.HasIndex("SuperSSN");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("ORMCodeFirst.Models.Project", b =>
                {
                    b.Property<int>("Pnumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Pnumber"));

                    b.Property<int>("Dnum")
                        .HasColumnType("int");

                    b.Property<string>("PLocation")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Pname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Pnumber");

                    b.HasIndex("Dnum");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("ORMCodeFirst.Models.Works_On", b =>
                {
                    b.Property<int>("Essn")
                        .HasColumnType("int");

                    b.Property<int>("Pno")
                        .HasColumnType("int");

                    b.Property<int>("Hours")
                        .HasColumnType("int");

                    b.HasKey("Essn", "Pno");

                    b.HasIndex("Pno");

                    b.ToTable("Work_On");
                });

            modelBuilder.Entity("ORMCodeFirst.Models.Department", b =>
                {
                    b.HasOne("ORMCodeFirst.Models.Employee", "Supervisor")
                        .WithMany("Department")
                        .HasForeignKey("Mgr_SSN")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Supervisor");
                });

            modelBuilder.Entity("ORMCodeFirst.Models.Dependent", b =>
                {
                    b.HasOne("ORMCodeFirst.Models.Employee", "Employee")
                        .WithMany("Dependents")
                        .HasForeignKey("Essn")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("ORMCodeFirst.Models.Dept_location", b =>
                {
                    b.HasOne("ORMCodeFirst.Models.Department", "Department")
                        .WithMany("Locations")
                        .HasForeignKey("Dnumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("ORMCodeFirst.Models.Employee", b =>
                {
                    b.HasOne("ORMCodeFirst.Models.Department", "Departments")
                        .WithMany("Employees")
                        .HasForeignKey("Dno")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ORMCodeFirst.Models.Employee", "Manager")
                        .WithMany("Managers")
                        .HasForeignKey("SuperSSN")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departments");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("ORMCodeFirst.Models.Project", b =>
                {
                    b.HasOne("ORMCodeFirst.Models.Department", "Department")
                        .WithMany("Project")
                        .HasForeignKey("Dnum")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("ORMCodeFirst.Models.Works_On", b =>
                {
                    b.HasOne("ORMCodeFirst.Models.Employee", "Employee")
                        .WithMany("Works_On")
                        .HasForeignKey("Essn")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ORMCodeFirst.Models.Project", "Project")
                        .WithMany("Works_On")
                        .HasForeignKey("Pno")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("ORMCodeFirst.Models.Department", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Locations");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("ORMCodeFirst.Models.Employee", b =>
                {
                    b.Navigation("Department");

                    b.Navigation("Dependents");

                    b.Navigation("Managers");

                    b.Navigation("Works_On");
                });

            modelBuilder.Entity("ORMCodeFirst.Models.Project", b =>
                {
                    b.Navigation("Works_On");
                });
#pragma warning restore 612, 618
        }
    }
}
