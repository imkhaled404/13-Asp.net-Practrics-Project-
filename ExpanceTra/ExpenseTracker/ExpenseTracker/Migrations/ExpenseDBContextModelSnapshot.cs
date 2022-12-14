// <auto-generated />
using System;
using ExpenseTracker.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExpenseTracker.Migrations
{
    [DbContext(typeof(ExpenseDBContext))]
    partial class ExpenseDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ExpenseTracker.Models.Expense", b =>
                {
                    b.Property<int>("ExpenseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("Expense Category");

                    b.Property<DateTime>("ExpenseDate")
                        .HasColumnType("date");

                    b.Property<string>("ExpenseType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExpenseID");

                    b.ToTable("Expenses");
                });

            modelBuilder.Entity("ExpenseTracker.Models.Items", b =>
                {
                    b.Property<string>("ItemNO")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GWTPC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Group")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HeightCtn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HsCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IfsCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LengthCtn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PackS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PackSUdom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PcsPerCtn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SbGroup")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Uom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WeightCtn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ifscode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ItemNO");

                    b.ToTable("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
