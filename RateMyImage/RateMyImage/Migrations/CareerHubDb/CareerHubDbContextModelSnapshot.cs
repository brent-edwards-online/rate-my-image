﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CareerHub.Entities;

namespace CareerHub.Migrations.CareerHubDb
{
    [DbContext(typeof(CareerHubDbContext))]
    partial class CareerHubDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CareerHub.Entities.UserImage", b =>
                {
                    b.Property<int>("UserImageId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ImageUrls");

                    b.Property<string>("ImageUser");

                    b.Property<bool>("IsLiked");

                    b.Property<string>("UserId");

                    b.HasKey("UserImageId");

                    b.ToTable("UserImages");
                });
        }
    }
}
