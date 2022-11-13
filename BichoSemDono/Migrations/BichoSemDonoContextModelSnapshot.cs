﻿// <auto-generated />
using System;
using BichoSemDono.Core.Infrastructure.ContextConfiguration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BichoSemDono.Migrations
{
    [DbContext(typeof(BichoSemDonoContext))]
    partial class BichoSemDonoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-preview.7.22376.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BichoSemDono.Domain.Post.Entities.OwnerlessPetPost", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("FinishedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("PetSpecies")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("OwnerlessPetPosts");
                });

            modelBuilder.Entity("BichoSemDono.Domain.Post.Entities.OwnerlessPetPost", b =>
                {
                    b.OwnsOne("BichoSemDono.Domain.Post.ValueObjects.Localization", "Localization", b1 =>
                        {
                            b1.Property<Guid>("OwnerlessPetPostId")
                                .HasColumnType("uuid");

                            b1.Property<string>("Address")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<double>("Latitude")
                                .HasColumnType("double precision");

                            b1.Property<double>("Longitude")
                                .HasColumnType("double precision");

                            b1.HasKey("OwnerlessPetPostId");

                            b1.ToTable("OwnerlessPetPosts");

                            b1.WithOwner()
                                .HasForeignKey("OwnerlessPetPostId");
                        });

                    b.Navigation("Localization")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
