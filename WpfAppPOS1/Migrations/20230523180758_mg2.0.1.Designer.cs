﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WpfAppPOS1.Models;

#nullable disable

namespace WpfAppPOS1.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20230523180758_mg2.0.1")]
    partial class mg201
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("WpfAppPOS1.Models.CartItem", b =>
                {
                    b.Property<int>("CartItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Discount")
                        .HasColumnType("REAL");

                    b.Property<int>("InvoiceID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("REAL");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("REAL");

                    b.HasKey("CartItemID");

                    b.HasIndex("InvoiceID");

                    b.HasIndex("ProductID");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("WpfAppPOS1.Models.Invoice", b =>
                {
                    b.Property<int>("InvoiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("AmountTendered")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Change")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Total")
                        .HasColumnType("TEXT");

                    b.HasKey("InvoiceID");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("WpfAppPOS1.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("WpfAppPOS1.Models.Stock", b =>
                {
                    b.Property<int>("StockId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("CostPrice")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<double>("SellingPrice")
                        .HasColumnType("REAL");

                    b.HasKey("StockId");

                    b.HasIndex("ProductID");

                    b.ToTable("Stocks");
                });

            modelBuilder.Entity("WpfAppPOS1.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<int>("Phone")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1002,
                            FirstName = "Default",
                            IsAdmin = true,
                            LastName = "Admin",
                            PasswordHash = new byte[] { 28, 218, 112, 251, 207, 233, 53, 167, 255, 52, 138, 109, 194, 8, 212, 58, 142, 84, 87, 240, 88, 50, 48, 139, 175, 7, 30, 251, 138, 96, 73, 92, 111, 67, 222, 84, 98, 206, 112, 45, 144, 82, 221, 235, 31, 197, 144, 199, 49, 1, 45, 224, 214, 255, 45, 232, 209, 135, 168, 54, 152, 68, 65, 175 },
                            PasswordSalt = new byte[] { 142, 163, 11, 99, 63, 237, 242, 241, 230, 90, 233, 128, 205, 182, 74, 203, 223, 8, 163, 140, 180, 198, 142, 118, 160, 170, 177, 51, 217, 41, 4, 249, 234, 239, 79, 159, 66, 91, 83, 132, 169, 244, 190, 37, 62, 64, 109, 17, 47, 157, 18, 4, 252, 78, 126, 158, 123, 216, 27, 133, 237, 82, 201, 63, 211, 157, 179, 180, 244, 106, 153, 171, 65, 190, 216, 215, 51, 85, 66, 219, 116, 1, 201, 83, 137, 105, 137, 192, 182, 23, 135, 207, 186, 4, 62, 169, 7, 117, 179, 117, 65, 89, 195, 121, 139, 97, 83, 75, 88, 9, 152, 185, 235, 91, 68, 142, 241, 218, 168, 127, 148, 179, 96, 237, 140, 56, 137, 153 },
                            Phone = 123456789,
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("WpfAppPOS1.Models.CartItem", b =>
                {
                    b.HasOne("WpfAppPOS1.Models.Invoice", "Invoice")
                        .WithMany("CartItems")
                        .HasForeignKey("InvoiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WpfAppPOS1.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Invoice");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WpfAppPOS1.Models.Stock", b =>
                {
                    b.HasOne("WpfAppPOS1.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WpfAppPOS1.Models.Invoice", b =>
                {
                    b.Navigation("CartItems");
                });
#pragma warning restore 612, 618
        }
    }
}
