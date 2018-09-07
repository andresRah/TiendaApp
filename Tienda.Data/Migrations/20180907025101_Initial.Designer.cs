﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tienda.Data;

namespace Tienda.Data.Migrations
{
    [DbContext(typeof(TiendaDbContext))]
    [Migration("20180907025101_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Tienda.Models.ManualModels.Balance", b =>
                {
                    b.Property<int>("BalanceId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateTime");

                    b.Property<DateTime>("DateBalance");

                    b.Property<decimal>("TotalBuy");

                    b.Property<decimal>("TotalSold");

                    b.Property<DateTime>("UpdateTime");

                    b.HasKey("BalanceId");

                    b.ToTable("Balance");
                });

            modelBuilder.Entity("Tienda.Models.ManualModels.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime>("UpdateTime");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Tienda.Models.ManualModels.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("BirthDate");

                    b.Property<string>("ContactPhone");

                    b.Property<DateTime>("CreateTime");

                    b.Property<decimal>("CreditLimit");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<DateTime>("UpdateTime");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Tienda.Models.ManualModels.Invoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateTime");

                    b.Property<DateTime>("DateInvoice");

                    b.Property<string>("Description");

                    b.Property<decimal>("Iva");

                    b.Property<DateTime>("PaymentDate");

                    b.Property<int>("ProviderId");

                    b.Property<string>("State");

                    b.Property<decimal>("SubTotal");

                    b.Property<decimal>("Total");

                    b.Property<int>("TotalArticles");

                    b.Property<DateTime>("UpdateTime");

                    b.HasKey("InvoiceId");

                    b.HasIndex("ProviderId");

                    b.ToTable("Invoice");
                });

            modelBuilder.Entity("Tienda.Models.ManualModels.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("BuyPrice");

                    b.Property<decimal>("BuySale");

                    b.Property<int>("CategoryId");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("QuantityInStock");

                    b.Property<string>("Serial");

                    b.Property<DateTime>("UpdateTime");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Tienda.Models.ManualModels.Provider", b =>
                {
                    b.Property<int>("ProviderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactPerson");

                    b.Property<string>("ContactPhone");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("VisitingDays");

                    b.HasKey("ProviderId");

                    b.ToTable("Provider");
                });

            modelBuilder.Entity("Tienda.Models.ManualModels.Purchase", b =>
                {
                    b.Property<int>("PurchaseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Description");

                    b.Property<int>("InvoiceId");

                    b.Property<decimal>("Iva");

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<decimal>("SubTotalUnitPrice");

                    b.Property<decimal>("TotalUnitPrice");

                    b.Property<decimal>("UnitPrice");

                    b.Property<DateTime>("UpdateTime");

                    b.HasKey("PurchaseId");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("ProductId");

                    b.ToTable("Purchase");
                });

            modelBuilder.Entity("Tienda.Models.ManualModels.Sales", b =>
                {
                    b.Property<int>("SalesId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("CustomerId");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<decimal>("Iva");

                    b.Property<decimal>("SubTotal");

                    b.Property<DateTime>("UpdateTime");

                    b.HasKey("SalesId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("Tienda.Models.ManualModels.SalesDetails", b =>
                {
                    b.Property<int>("SalesDetailsId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateTime");

                    b.Property<decimal>("Iva");

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<int>("SalesId");

                    b.Property<decimal>("SubTotalUnitPrice");

                    b.Property<decimal>("TotalUnitPrice");

                    b.Property<decimal>("UnitPrice");

                    b.Property<DateTime>("UpdateTime");

                    b.HasKey("SalesDetailsId");

                    b.HasIndex("ProductId");

                    b.HasIndex("SalesId");

                    b.ToTable("SalesDetails");
                });

            modelBuilder.Entity("Tienda.Models.ManualModels.Invoice", b =>
                {
                    b.HasOne("Tienda.Models.ManualModels.Provider", "Provider")
                        .WithMany("Invoices")
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Tienda.Models.ManualModels.Product", b =>
                {
                    b.HasOne("Tienda.Models.ManualModels.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Tienda.Models.ManualModels.Purchase", b =>
                {
                    b.HasOne("Tienda.Models.ManualModels.Invoice", "Invoice")
                        .WithMany("Purchases")
                        .HasForeignKey("InvoiceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Tienda.Models.ManualModels.Product", "Product")
                        .WithMany("Purchases")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Tienda.Models.ManualModels.Sales", b =>
                {
                    b.HasOne("Tienda.Models.ManualModels.Customer", "Customer")
                        .WithMany("Sales")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Tienda.Models.ManualModels.SalesDetails", b =>
                {
                    b.HasOne("Tienda.Models.ManualModels.Product", "Product")
                        .WithMany("SalesDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Tienda.Models.ManualModels.Sales", "Sales")
                        .WithMany("SalesDetails")
                        .HasForeignKey("SalesId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}