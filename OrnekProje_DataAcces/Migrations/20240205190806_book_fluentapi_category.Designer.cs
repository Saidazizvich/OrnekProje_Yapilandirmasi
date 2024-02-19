﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrnekProje_DataAcces.Data;

#nullable disable

namespace OrnekProje_DataAcces.Migrations
{
    [DbContext(typeof(OrnekDbContext))]
    [Migration("20240205190806_book_fluentapi_category")]
    partial class book_fluentapi_category
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OrnekProje_Entity.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"), 1L, 1);

                    b.Property<string>("Barkod")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("BookDetailsId")
                        .HasColumnType("int");

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("PublisherId")
                        .HasColumnType("int");

                    b.HasKey("BookId");

                    b.HasIndex("BookDetailsId")
                        .IsUnique();

                    b.HasIndex("CategoryId");

                    b.HasIndex("PublisherId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("OrnekProje_Entity.Models.Book_Writer", b =>
                {
                    b.Property<int>("WriterId")
                        .HasColumnType("int");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.HasKey("WriterId", "BookId");

                    b.HasIndex("BookId");

                    b.ToTable("Book_Writers");
                });

            modelBuilder.Entity("OrnekProje_Entity.Models.BookDetail", b =>
                {
                    b.Property<int>("BookDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookDetailId"), 1L, 1);

                    b.Property<int>("BookDetailWeight")
                        .HasColumnType("int");

                    b.Property<int>("ChapterPage")
                        .HasColumnType("int");

                    b.Property<int>("NumberofChapters")
                        .HasColumnType("int");

                    b.HasKey("BookDetailId");

                    b.ToTable("BookDetails");
                });

            modelBuilder.Entity("OrnekProje_Entity.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CategoryName");

                    b.HasKey("CategoryId");

                    b.ToTable("tbl_CategoryNew", (string)null);
                });

            modelBuilder.Entity("OrnekProje_Entity.Models.FluentApiBook", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"), 1L, 1);

                    b.Property<string>("Barkod")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DetailId")
                        .HasColumnType("int");

                    b.Property<double>("DiscountPrice")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("BookId");

                    b.HasIndex("DetailId")
                        .IsUnique();

                    b.ToTable("FluentApiBooks");
                });

            modelBuilder.Entity("OrnekProje_Entity.Models.FluentApiBookDetail", b =>
                {
                    b.Property<int>("DetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DetailId"), 1L, 1);

                    b.Property<int>("BookDetailWeight")
                        .HasColumnType("int");

                    b.Property<int>("ChapterPage")
                        .HasColumnType("int");

                    b.Property<int>("NumberofChapters")
                        .HasColumnType("int");

                    b.HasKey("DetailId");

                    b.ToTable("FluentApiBookDetails");
                });

            modelBuilder.Entity("OrnekProje_Entity.Models.FluentApiPublisher", b =>
                {
                    b.Property<int>("PublisherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PublisherId"), 1L, 1);

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PublisherId");

                    b.ToTable("FluentApiPublishers");
                });

            modelBuilder.Entity("OrnekProje_Entity.Models.FluentApiWriter", b =>
                {
                    b.Property<int>("WriterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WriterId"), 1L, 1);

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WriterName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WriterSurName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WriterId");

                    b.ToTable("FluentApiWriters");
                });

            modelBuilder.Entity("OrnekProje_Entity.Models.Publisher", b =>
                {
                    b.Property<int>("PublisherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PublisherId"), 1L, 1);

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PublisherId");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("OrnekProje_Entity.Models.Round", b =>
                {
                    b.Property<int>("RoundId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoundId"), 1L, 1);

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoundId");

                    b.ToTable("Rounds");
                });

            modelBuilder.Entity("OrnekProje_Entity.Models.Writer", b =>
                {
                    b.Property<int>("WriterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WriterId"), 1L, 1);

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WriterName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WriterSurName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WriterId");

                    b.ToTable("Writers");
                });

            modelBuilder.Entity("OrnekProje_Entity.Models.Book", b =>
                {
                    b.HasOne("OrnekProje_Entity.Models.BookDetail", "BookDetails")
                        .WithOne("Book")
                        .HasForeignKey("OrnekProje_Entity.Models.Book", "BookDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrnekProje_Entity.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrnekProje_Entity.Models.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookDetails");

                    b.Navigation("Category");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("OrnekProje_Entity.Models.Book_Writer", b =>
                {
                    b.HasOne("OrnekProje_Entity.Models.Book", "Books")
                        .WithMany("Book_Writers")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OrnekProje_Entity.Models.Writer", "Writer")
                        .WithMany("Book_Writers")
                        .HasForeignKey("WriterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Books");

                    b.Navigation("Writer");
                });

            modelBuilder.Entity("OrnekProje_Entity.Models.FluentApiBook", b =>
                {
                    b.HasOne("OrnekProje_Entity.Models.FluentApiBookDetail", "FluentApiBookDetail")
                        .WithOne("FluentApiBook")
                        .HasForeignKey("OrnekProje_Entity.Models.FluentApiBook", "DetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FluentApiBookDetail");
                });

            modelBuilder.Entity("OrnekProje_Entity.Models.Book", b =>
                {
                    b.Navigation("Book_Writers");
                });

            modelBuilder.Entity("OrnekProje_Entity.Models.BookDetail", b =>
                {
                    b.Navigation("Book")
                        .IsRequired();
                });

            modelBuilder.Entity("OrnekProje_Entity.Models.FluentApiBookDetail", b =>
                {
                    b.Navigation("FluentApiBook")
                        .IsRequired();
                });

            modelBuilder.Entity("OrnekProje_Entity.Models.Publisher", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("OrnekProje_Entity.Models.Writer", b =>
                {
                    b.Navigation("Book_Writers");
                });
#pragma warning restore 612, 618
        }
    }
}
