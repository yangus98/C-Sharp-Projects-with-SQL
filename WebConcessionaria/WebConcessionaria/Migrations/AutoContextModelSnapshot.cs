﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebConcessionaria.Models;

#nullable disable

namespace WebConcessionaria.Migrations
{
    [DbContext(typeof(AutoContext))]
    partial class AutoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebConcessionaria.Models.Auto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AnnoUscita")
                        .HasColumnType("int");

                    b.Property<int>("CasaProduttrice")
                        .HasColumnType("int");

                    b.Property<string>("Modello")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Prezzo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Autos");
                });
#pragma warning restore 612, 618
        }
    }
}