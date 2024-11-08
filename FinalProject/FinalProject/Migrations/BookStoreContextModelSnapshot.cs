﻿// <auto-generated />
using System;
using FinalProject.BookDatabase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinalProject.Migrations
{
    [DbContext(typeof(BookStoreContext))]
    partial class BookStoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookCategory", b =>
                {
                    b.Property<Guid>("BookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("BookId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("BookCategory");

                    b.HasData(
                        new
                        {
                            BookId = new Guid("7d1d91e8-c035-4c10-bfb6-26d38c3d16a9"),
                            CategoryId = new Guid("3cd6294c-3843-46d8-9cdc-9c5bb7d8e3c1")
                        },
                        new
                        {
                            BookId = new Guid("61b5f98a-34ce-4810-a2d7-d282dad7ee30"),
                            CategoryId = new Guid("3cd6294c-3843-46d8-9cdc-9c5bb7d8e3c1")
                        },
                        new
                        {
                            BookId = new Guid("3b941931-5d34-4cd6-af85-91a16004a0fd"),
                            CategoryId = new Guid("3cd6294c-3843-46d8-9cdc-9c5bb7d8e3c1")
                        },
                        new
                        {
                            BookId = new Guid("fbb2e64e-aa90-4d48-8821-1c5e0de05da1"),
                            CategoryId = new Guid("b30fe510-ddd3-4f3d-8b15-9ba21dfd7723")
                        },
                        new
                        {
                            BookId = new Guid("4d0f9ec9-b2d1-4a10-8866-9bdf1b711e86"),
                            CategoryId = new Guid("b30fe510-ddd3-4f3d-8b15-9ba21dfd7723")
                        });
                });

            modelBuilder.Entity("FinalProject.BookDatabase.DbEntities.Author", b =>
                {
                    b.Property<Guid>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = new Guid("f1020500-e210-4cde-8e4b-fddd613a06a0"),
                            Bio = "Russian writer, author of 'War and Peace' and 'Anna Karenina'.",
                            Name = "Leo Tolstoy"
                        },
                        new
                        {
                            AuthorId = new Guid("89ef728b-e992-4900-94aa-fefe045ebdb8"),
                            Bio = "German writer and statesman, known for 'Faust'.",
                            Name = "Johann Wolfgang von Goethe"
                        },
                        new
                        {
                            AuthorId = new Guid("7f0c8abf-ac90-4ea2-95ca-5d95fd885e7d"),
                            Bio = "Italian Renaissance diplomat, philosopher, and writer, best known for 'Il Principe'.",
                            Name = "Niccolò Machiavelli"
                        },
                        new
                        {
                            AuthorId = new Guid("652685b1-9506-49f0-bc32-96706fc35b19"),
                            Bio = "Ancient Greek philosopher, founder of the Academy in Athens, known for works like 'Republic'.",
                            Name = "Plato"
                        });
                });

            modelBuilder.Entity("FinalProject.BookDatabase.DbEntities.Book", b =>
                {
                    b.Property<Guid>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("PublishedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PublisherId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("ISBN")
                        .IsUnique();

                    b.HasIndex("PublisherId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = new Guid("7d1d91e8-c035-4c10-bfb6-26d38c3d16a9"),
                            AuthorId = new Guid("f1020500-e210-4cde-8e4b-fddd613a06a0"),
                            ISBN = "9780307266934",
                            PublishedDate = new DateTime(1869, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PublisherId = new Guid("991b8954-2122-4235-b73f-74fe03f25ad6"),
                            Title = "War and Peace"
                        },
                        new
                        {
                            BookId = new Guid("61b5f98a-34ce-4810-a2d7-d282dad7ee30"),
                            AuthorId = new Guid("f1020500-e210-4cde-8e4b-fddd613a06a0"),
                            ISBN = "9780143035008",
                            PublishedDate = new DateTime(1877, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PublisherId = new Guid("a0747560-c3fd-40c3-b270-91a40ef006c6"),
                            Title = "Anna Karenina"
                        },
                        new
                        {
                            BookId = new Guid("3b941931-5d34-4cd6-af85-91a16004a0fd"),
                            AuthorId = new Guid("89ef728b-e992-4900-94aa-fefe045ebdb8"),
                            ISBN = "9780140449013",
                            PublishedDate = new DateTime(1808, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PublisherId = new Guid("a0747560-c3fd-40c3-b270-91a40ef006c6"),
                            Title = "Faust"
                        },
                        new
                        {
                            BookId = new Guid("fbb2e64e-aa90-4d48-8821-1c5e0de05da1"),
                            AuthorId = new Guid("7f0c8abf-ac90-4ea2-95ca-5d95fd885e7d"),
                            ISBN = "9780199535699",
                            PublishedDate = new DateTime(1532, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PublisherId = new Guid("bf011832-ad9d-4864-b855-55daffc45af3"),
                            Title = "Il Principe"
                        },
                        new
                        {
                            BookId = new Guid("4d0f9ec9-b2d1-4a10-8866-9bdf1b711e86"),
                            AuthorId = new Guid("652685b1-9506-49f0-bc32-96706fc35b19"),
                            ISBN = "9780521484435",
                            PublishedDate = new DateTime(380, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PublisherId = new Guid("a027489f-a54c-4ada-8e3e-890141ba528c"),
                            Title = "Republic"
                        });
                });

            modelBuilder.Entity("FinalProject.BookDatabase.DbEntities.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = new Guid("b30fe510-ddd3-4f3d-8b15-9ba21dfd7723"),
                            CategoryName = "Philosophy"
                        },
                        new
                        {
                            CategoryId = new Guid("3cd6294c-3843-46d8-9cdc-9c5bb7d8e3c1"),
                            CategoryName = "Classic Literature"
                        });
                });

            modelBuilder.Entity("FinalProject.BookDatabase.DbEntities.Review", b =>
                {
                    b.Property<Guid>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("ReviewerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ReviewId");

                    b.HasIndex("BookId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewId = new Guid("f15e4c38-f5d9-41bf-b9b4-38ef1eaa9516"),
                            BookId = new Guid("7d1d91e8-c035-4c10-bfb6-26d38c3d16a9"),
                            Content = "A monumental work, Tolstoy's 'War and Peace' is unparalleled.",
                            Rating = 5,
                            ReviewerName = "Alexander Ivanov"
                        },
                        new
                        {
                            ReviewId = new Guid("c29b3117-2b73-4ef7-ab4e-83acfddf0f25"),
                            BookId = new Guid("61b5f98a-34ce-4810-a2d7-d282dad7ee30"),
                            Content = "Tolstoy's 'Anna Karenina' is a beautiful tragedy.",
                            Rating = 5,
                            ReviewerName = "Maria Petrova"
                        },
                        new
                        {
                            ReviewId = new Guid("5b8dbe3f-5032-4ed6-8b25-7442a2347a03"),
                            BookId = new Guid("3b941931-5d34-4cd6-af85-91a16004a0fd"),
                            Content = "Goethe's 'Faust' explores profound existential themes.",
                            Rating = 5,
                            ReviewerName = "Hans Müller"
                        },
                        new
                        {
                            ReviewId = new Guid("7d229e91-73d4-44cc-b058-23fb7a192097"),
                            BookId = new Guid("fbb2e64e-aa90-4d48-8821-1c5e0de05da1"),
                            Content = "Machiavelli's 'Il Principe' is still relevant today in political philosophy.",
                            Rating = 4,
                            ReviewerName = "Lorenzo Rossi"
                        },
                        new
                        {
                            ReviewId = new Guid("262b671c-6d84-453b-af28-af9a65924790"),
                            BookId = new Guid("4d0f9ec9-b2d1-4a10-8866-9bdf1b711e86"),
                            Content = "Plato's 'Republic' is a cornerstone of Western philosophy.",
                            Rating = 5,
                            ReviewerName = "Sophia Demetriou"
                        });
                });

            modelBuilder.Entity("Publisher", b =>
                {
                    b.Property<Guid>("PublisherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("PublisherId");

                    b.ToTable("Publishers");

                    b.HasData(
                        new
                        {
                            PublisherId = new Guid("991b8954-2122-4235-b73f-74fe03f25ad6"),
                            Address = "New York, USA",
                            Name = "Random House"
                        },
                        new
                        {
                            PublisherId = new Guid("bf011832-ad9d-4864-b855-55daffc45af3"),
                            Address = "Oxford, UK",
                            Name = "Oxford University Press"
                        },
                        new
                        {
                            PublisherId = new Guid("a0747560-c3fd-40c3-b270-91a40ef006c6"),
                            Address = "London, UK",
                            Name = "Penguin Classics"
                        },
                        new
                        {
                            PublisherId = new Guid("a027489f-a54c-4ada-8e3e-890141ba528c"),
                            Address = "Cambridge, UK",
                            Name = "Cambridge University Press"
                        });
                });

            modelBuilder.Entity("BookCategory", b =>
                {
                    b.HasOne("FinalProject.BookDatabase.DbEntities.Book", null)
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FinalProject.BookDatabase.DbEntities.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FinalProject.BookDatabase.DbEntities.Book", b =>
                {
                    b.HasOne("FinalProject.BookDatabase.DbEntities.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("FinalProject.BookDatabase.DbEntities.Review", b =>
                {
                    b.HasOne("FinalProject.BookDatabase.DbEntities.Book", "Book")
                        .WithMany("Reviews")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("FinalProject.BookDatabase.DbEntities.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("FinalProject.BookDatabase.DbEntities.Book", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("Publisher", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
