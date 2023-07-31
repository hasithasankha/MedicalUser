﻿// <auto-generated />
using MedicalUser.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MedicalUser.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MedicalUser.Model.Appointment", b =>
                {
                    b.Property<int>("APPOI_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Appointment_List")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CusId")
                        .HasColumnType("int");

                    b.HasKey("APPOI_Id");

                    b.HasIndex("CusId");

                    b.ToTable("Appointment");
                });

            modelBuilder.Entity("MedicalUser.Model.Customer", b =>
                {
                    b.Property<int>("CusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("CusId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("MedicalUser.Model.Drug", b =>
                {
                    b.Property<int>("DrugId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Generic_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Trde_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DrugId");

                    b.ToTable("Drug");
                });

            modelBuilder.Entity("MedicalUser.Model.Test", b =>
                {
                    b.Property<int>("TestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Test_Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Test_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TestId");

                    b.ToTable("Test");
                });

            modelBuilder.Entity("MedicalUser.Model.Appointment", b =>
                {
                    b.HasOne("MedicalUser.Model.Customer", "Customers")
                        .WithMany()
                        .HasForeignKey("CusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
