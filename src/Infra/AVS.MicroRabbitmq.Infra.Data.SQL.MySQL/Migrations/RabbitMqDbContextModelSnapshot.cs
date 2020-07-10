﻿// <auto-generated />
using System;
using AVS.MicroRabbitmq.Infra.Data.SQL.MySQL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AVS.MicroRabbitmq.Infra.Data.SQL.MySQL.Migrations
{
    [DbContext(typeof(RabbitMqDbContext))]
    partial class RabbitMqDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AVS.MicroRabbitmq.Domain.Banking.Models.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<decimal>("AccountBalance")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("AccountType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });
#pragma warning restore 612, 618
        }
    }
}