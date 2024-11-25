﻿// <auto-generated />
using System;
using BookProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookProject.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241125184014_mig11")]
    partial class mig11
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookProject.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorName = "Лев Толстой",
                            BookName = "Война и Мир",
                            GenreId = 5,
                            Image = "/images/books/resized_war_and_peace.jfif",
                            Price = 20.5,
                            Quantity = 0
                        },
                        new
                        {
                            Id = 2,
                            AuthorName = "Лев Толстой",
                            BookName = "Ана Каренина",
                            GenreId = 3,
                            Image = "/images/books/resized_anna_karenina.jpg",
                            Price = 18.0,
                            Quantity = 0
                        },
                        new
                        {
                            Id = 3,
                            AuthorName = "Николо Макиавели",
                            BookName = "Владетелят",
                            GenreId = 1,
                            Image = "/images/books/resized_the_prince.jpg",
                            Price = 15.0,
                            Quantity = 0
                        },
                        new
                        {
                            Id = 4,
                            AuthorName = "Иван Вазов",
                            BookName = "Нова земя",
                            GenreId = 3,
                            Image = "/images/books/resized_new_earth.jpg",
                            Price = 12.5,
                            Quantity = 0
                        },
                        new
                        {
                            Id = 5,
                            AuthorName = "Платон",
                            BookName = "Държавата",
                            GenreId = 4,
                            Image = "/images/books/resized_the_republic.jpg",
                            Price = 14.0,
                            Quantity = 0
                        },
                        new
                        {
                            Id = 6,
                            AuthorName = "Йохан Волфганг Гьоте",
                            BookName = "Фауст",
                            GenreId = 3,
                            Image = "/images/books/resized_faust.jpg",
                            Price = 16.0,
                            Quantity = 0
                        },
                        new
                        {
                            Id = 7,
                            AuthorName = "Фридрих Ницше",
                            BookName = "Воля за власт",
                            GenreId = 4,
                            Image = "/images/books/resized_will_to_power.jpg",
                            Price = 17.989999999999998,
                            Quantity = 0
                        },
                        new
                        {
                            Id = 8,
                            AuthorName = "Пол Кенеди",
                            BookName = "Защо светът е такъв какъвто е",
                            GenreId = 4,
                            Image = "/images/books/resized_why_world_is.jpg",
                            Price = 22.989999999999998,
                            Quantity = 0
                        },
                        new
                        {
                            Id = 9,
                            AuthorName = "Робърт Грийн",
                            BookName = "48-те закона на властта",
                            GenreId = 1,
                            Image = "/images/books/resized_48_laws_of_power.jpg",
                            Price = 19.989999999999998,
                            Quantity = 0
                        },
                        new
                        {
                            Id = 10,
                            AuthorName = "Иван Вазов",
                            BookName = "Под Игото",
                            GenreId = 5,
                            Image = "/images/books/resized_under_the_yoke.jpg",
                            Price = 21.989999999999998,
                            Quantity = 0
                        },
                        new
                        {
                            Id = 11,
                            AuthorName = "Джордж Р. Р. Мартин",
                            BookName = "Песен за огън и лед",
                            GenreId = 6,
                            Image = "/images/books/resized_song_of_ice_and_water.jpg",
                            Price = 39.990000000000002,
                            Quantity = 0
                        },
                        new
                        {
                            Id = 12,
                            AuthorName = "Кентаро Миура",
                            BookName = "Берсерк",
                            GenreId = 6,
                            Image = "/images/books/resized_berserk.jpg",
                            Price = 109.98999999999999,
                            Quantity = 0
                        },
                        new
                        {
                            Id = 13,
                            AuthorName = "Такехико Иноуе",
                            BookName = "Вагабонд",
                            GenreId = 5,
                            Image = "/images/books/resized_vagabond.png",
                            Price = 59.990000000000002,
                            Quantity = 0
                        },
                        new
                        {
                            Id = 14,
                            AuthorName = "Макото Юкимура",
                            BookName = "Винланд Сага",
                            GenreId = 1,
                            Image = "/images/books/resized_vinland_saga.jpg",
                            Price = 19.989999999999998,
                            Quantity = 0
                        },
                        new
                        {
                            Id = 15,
                            AuthorName = "Ребека Яроз",
                            BookName = "Железен Пламък",
                            GenreId = 1,
                            Image = "/images/books/resized_iron_flame.jpg",
                            Price = 33.0,
                            Quantity = 0
                        },
                        new
                        {
                            Id = 16,
                            AuthorName = "Стивън Кинг",
                            BookName = "То",
                            GenreId = 2,
                            Image = "/images/books/resized_it.jpg",
                            Price = 19.989999999999998,
                            Quantity = 0
                        },
                        new
                        {
                            Id = 17,
                            AuthorName = "Робърт Грийн",
                            BookName = "33-те стратегии за войната",
                            GenreId = 1,
                            Image = "/images/books/resized_33_strategies_of_war.jpg",
                            Price = 33.0,
                            Quantity = 0
                        },
                        new
                        {
                            Id = 18,
                            AuthorName = "Фьодор Достоевски",
                            BookName = "Идиот",
                            GenreId = 5,
                            Image = "/images/books/resized_idiot.jpg",
                            Price = 59.990000000000002,
                            Quantity = 0
                        },
                        new
                        {
                            Id = 19,
                            AuthorName = "Фьодор Достоевски",
                            BookName = "Престъпление и наказание",
                            GenreId = 5,
                            Image = "/images/books/resized_crime_and_punishment.jpg",
                            Price = 30.0,
                            Quantity = 0
                        },
                        new
                        {
                            Id = 20,
                            AuthorName = "Алескандър Пушкин",
                            BookName = "Евгений Онегин",
                            GenreId = 5,
                            Image = "/images/books/resized_eugene_onegin.jpg",
                            Price = 50.0,
                            Quantity = 0
                        },
                        new
                        {
                            Id = 21,
                            AuthorName = "Виктор Юго",
                            BookName = "Клетниците",
                            GenreId = 5,
                            Image = "/images/books/resized_the_wretch.jpg",
                            Price = 30.0,
                            Quantity = 0
                        },
                        new
                        {
                            Id = 22,
                            AuthorName = "Христо Ботев",
                            BookName = "Борба",
                            GenreId = 7,
                            Image = "/images/books/resized_struggle.jpg",
                            Price = 25.0,
                            Quantity = 0
                        },
                        new
                        {
                            Id = 23,
                            AuthorName = "Христо Ботев",
                            BookName = "До моето първо либе",
                            GenreId = 7,
                            Image = "/images/books/resized_to_my_first_love.jpg",
                            Price = 21.989999999999998,
                            Quantity = 0
                        },
                        new
                        {
                            Id = 24,
                            AuthorName = "Димитър Димов",
                            BookName = "Тютюн",
                            GenreId = 1,
                            Image = "/images/books/resized_tobacco.jfif",
                            Price = 40.0,
                            Quantity = 0
                        });
                });

            modelBuilder.Entity("BookProject.Models.CartDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("ShoppingCartId")
                        .HasColumnType("int");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("ShoppingCartId");

                    b.ToTable("CartDetails");
                });

            modelBuilder.Entity("BookProject.Models.Details", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime?>("PublicationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("Details");
                });

            modelBuilder.Entity("BookProject.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GenreName = "Action"
                        },
                        new
                        {
                            Id = 2,
                            GenreName = "Horror"
                        },
                        new
                        {
                            Id = 3,
                            GenreName = "Romance"
                        },
                        new
                        {
                            Id = 4,
                            GenreName = "Science"
                        },
                        new
                        {
                            Id = 5,
                            GenreName = "Novel"
                        },
                        new
                        {
                            Id = 6,
                            GenreName = "Fantasy"
                        },
                        new
                        {
                            Id = 7,
                            GenreName = "Poem"
                        });
                });

            modelBuilder.Entity("BookProject.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("bit");

                    b.Property<string>("MobileNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("OrderStatusId")
                        .HasColumnType("int");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OrderStatusId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BookProject.Models.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("BookProject.Models.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("OrderStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            StatusId = 1,
                            StatusName = "Pending"
                        },
                        new
                        {
                            Id = 2,
                            StatusId = 2,
                            StatusName = "Shipped"
                        },
                        new
                        {
                            Id = 3,
                            StatusId = 3,
                            StatusName = "Delivered"
                        },
                        new
                        {
                            Id = 4,
                            StatusId = 4,
                            StatusName = "Cancelled"
                        },
                        new
                        {
                            Id = 5,
                            StatusId = 5,
                            StatusName = "Returned"
                        },
                        new
                        {
                            Id = 6,
                            StatusId = 6,
                            StatusName = "Refund"
                        });
                });

            modelBuilder.Entity("BookProject.Models.ShoppingCart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("BookProject.Models.Stock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId")
                        .IsUnique();

                    b.ToTable("Stock");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BookProject.Models.Book", b =>
                {
                    b.HasOne("BookProject.Models.Genre", "Genre")
                        .WithMany("Books")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("BookProject.Models.CartDetail", b =>
                {
                    b.HasOne("BookProject.Models.Book", "Book")
                        .WithMany("CartDetail")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookProject.Models.ShoppingCart", "ShoppingCart")
                        .WithMany("CartDetails")
                        .HasForeignKey("ShoppingCartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("ShoppingCart");
                });

            modelBuilder.Entity("BookProject.Models.Details", b =>
                {
                    b.HasOne("BookProject.Models.Book", "book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("book");
                });

            modelBuilder.Entity("BookProject.Models.Order", b =>
                {
                    b.HasOne("BookProject.Models.OrderStatus", "OrderStatus")
                        .WithMany()
                        .HasForeignKey("OrderStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderStatus");
                });

            modelBuilder.Entity("BookProject.Models.OrderDetail", b =>
                {
                    b.HasOne("BookProject.Models.Book", "Book")
                        .WithMany("OrderDetail")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookProject.Models.Order", "Order")
                        .WithMany("OrderDetail")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("BookProject.Models.Stock", b =>
                {
                    b.HasOne("BookProject.Models.Book", "Book")
                        .WithOne("Stock")
                        .HasForeignKey("BookProject.Models.Stock", "BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookProject.Models.Book", b =>
                {
                    b.Navigation("CartDetail");

                    b.Navigation("OrderDetail");

                    b.Navigation("Stock")
                        .IsRequired();
                });

            modelBuilder.Entity("BookProject.Models.Genre", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BookProject.Models.Order", b =>
                {
                    b.Navigation("OrderDetail");
                });

            modelBuilder.Entity("BookProject.Models.ShoppingCart", b =>
                {
                    b.Navigation("CartDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
