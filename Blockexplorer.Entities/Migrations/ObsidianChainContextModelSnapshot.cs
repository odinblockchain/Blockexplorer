﻿// <auto-generated />
using Blockexplorer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Blockexplorer.Entities.Migrations
{
    [DbContext(typeof(ObsidianChainContext))]
    partial class ObsidianChainContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Blockexplorer.Entities.BlockEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BlockData");

                    b.Property<string>("BlockHash");

                    b.Property<int>("Height");

                    b.HasKey("Id");

                    b.ToTable("Blocks");
                });

            modelBuilder.Entity("Blockexplorer.Entities.TransactionAddressEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .HasMaxLength(34);

                    b.Property<string>("TransactionEntityId");

                    b.HasKey("Id");

                    b.HasIndex("Address")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.HasIndex("TransactionEntityId");

                    b.ToTable("TransactionAddresses");
                });

            modelBuilder.Entity("Blockexplorer.Entities.TransactionEntity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("BlockEntityId");

                    b.Property<string>("TransactionData");

                    b.HasKey("Id");

                    b.HasIndex("BlockEntityId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("Blockexplorer.Entities.TransactionAddressEntity", b =>
                {
                    b.HasOne("Blockexplorer.Entities.TransactionEntity", "TransactionEntity")
                        .WithMany("TransactionAddresses")
                        .HasForeignKey("TransactionEntityId");
                });

            modelBuilder.Entity("Blockexplorer.Entities.TransactionEntity", b =>
                {
                    b.HasOne("Blockexplorer.Entities.BlockEntity", "BlockEntity")
                        .WithMany("Transactions")
                        .HasForeignKey("BlockEntityId");
                });
#pragma warning restore 612, 618
        }
    }
}
