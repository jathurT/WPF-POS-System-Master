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
    [Migration("20230409125445_mg3")]
    partial class mg3
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

                    b.Property<decimal>("Discount")
                        .HasColumnType("TEXT");

                    b.Property<int>("InvoiceID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("TEXT");

                    b.HasKey("CartItemID");

                    b.HasIndex("InvoiceID");

                    b.HasIndex("ProductID");

                    b.ToTable("CartItem");
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
                            PasswordHash = new byte[] { 216, 148, 7, 44, 42, 72, 120, 17, 70, 75, 173, 36, 109, 5, 207, 63, 246, 239, 27, 153, 153, 117, 218, 254, 12, 174, 3, 15, 84, 46, 168, 26, 66, 39, 17, 20, 66, 219, 170, 21, 60, 178, 12, 128, 36, 48, 5, 251, 217, 221, 183, 75, 29, 96, 187, 197, 137, 198, 101, 72, 112, 76, 204, 65 },
                            PasswordSalt = new byte[] { 113, 164, 255, 192, 60, 239, 142, 68, 106, 32, 12, 66, 76, 54, 24, 152, 183, 19, 180, 87, 121, 58, 207, 199, 102, 71, 191, 198, 58, 20, 114, 63, 14, 94, 236, 160, 181, 128, 176, 142, 78, 140, 121, 187, 135, 237, 23, 106, 45, 133, 178, 124, 175, 72, 219, 6, 71, 76, 25, 37, 162, 74, 78, 198, 26, 22, 89, 32, 35, 194, 41, 61, 189, 227, 237, 152, 29, 86, 234, 234, 225, 198, 214, 39, 61, 151, 58, 195, 19, 242, 81, 220, 159, 83, 196, 144, 36, 217, 248, 36, 64, 167, 132, 136, 20, 87, 138, 148, 140, 37, 224, 161, 46, 10, 241, 16, 135, 239, 11, 19, 73, 205, 227, 213, 254, 136, 85, 175 },
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
