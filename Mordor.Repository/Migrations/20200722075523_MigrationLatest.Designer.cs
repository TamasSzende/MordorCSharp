﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mordor.Repository;

namespace Mordor.Repository.Migrations
{
    [DbContext(typeof(IzeContext))]
    [Migration("20200722075523_MigrationLatest")]
    partial class MigrationLatest
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Mordor.Repository.Entities.DbHorda", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("LastFight")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(767)");

                    b.HasKey("ID");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("HordaTable");
                });

            modelBuilder.Entity("Mordor.Repository.Entities.DbOrk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("HordaID")
                        .HasColumnType("int");

                    b.Property<int>("KillCount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(767)");

                    b.HasKey("Id");

                    b.HasIndex("HordaID");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("OrkTable");
                });

            modelBuilder.Entity("Mordor.Repository.Entities.DbOrkWeapon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("DbOrkId")
                        .HasColumnType("int");

                    b.Property<string>("Weapon")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DbOrkId");

                    b.ToTable("Weapons");
                });

            modelBuilder.Entity("Mordor.Repository.Entities.DbOrk", b =>
                {
                    b.HasOne("Mordor.Repository.Entities.DbHorda", "Horda")
                        .WithMany("Orks")
                        .HasForeignKey("HordaID");
                });

            modelBuilder.Entity("Mordor.Repository.Entities.DbOrkWeapon", b =>
                {
                    b.HasOne("Mordor.Repository.Entities.DbOrk", null)
                        .WithMany("Weapons")
                        .HasForeignKey("DbOrkId");
                });
#pragma warning restore 612, 618
        }
    }
}
