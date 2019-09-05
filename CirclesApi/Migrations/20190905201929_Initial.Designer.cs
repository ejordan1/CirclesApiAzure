﻿// <auto-generated />
using Circles_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MessagesServer.Solution.Migrations
{
    [DbContext(typeof(Circles_APIContext))]
    [Migration("20190905201929_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("Circles_API.Models.Circle", b =>
                {
                    b.Property<int>("CircleId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserId");

                    b.Property<string>("Name");

                    b.HasKey("CircleId");

                    b.ToTable("circles");
                });

            modelBuilder.Entity("Circles_API.Models.CircleUserprofile", b =>
                {
                    b.Property<int>("CircleUserprofileId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CircleId");

                    b.Property<int>("UserprofileId");

                    b.HasKey("CircleUserprofileId");

                    b.HasIndex("CircleId");

                    b.HasIndex("UserprofileId");

                    b.ToTable("CircleUserprofiles");
                });

            modelBuilder.Entity("Circles_API.Models.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("TagId");

                    b.ToTable("tags");
                });

            modelBuilder.Entity("Circles_API.Models.TagUserprofile", b =>
                {
                    b.Property<int>("TagUserprofileId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("TagId");

                    b.Property<int>("UserprofileId");

                    b.HasKey("TagUserprofileId");

                    b.HasIndex("TagId");

                    b.HasIndex("UserprofileId");

                    b.ToTable("TagUserprofiles");
                });

            modelBuilder.Entity("Circles_API.Models.Userprofile", b =>
                {
                    b.Property<int>("UserprofileId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("ApplicationUserId");

                    b.Property<string>("Bio");

                    b.Property<string>("Gender");

                    b.Property<string>("Location");

                    b.Property<string>("Name");

                    b.Property<string>("Photo");

                    b.HasKey("UserprofileId");

                    b.ToTable("userprofiles");
                });

            modelBuilder.Entity("Circles_API.Models.CircleUserprofile", b =>
                {
                    b.HasOne("Circles_API.Models.Circle", "Circle")
                        .WithMany("Userprofiles")
                        .HasForeignKey("CircleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Circles_API.Models.Userprofile", "Userprofile")
                        .WithMany()
                        .HasForeignKey("UserprofileId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Circles_API.Models.TagUserprofile", b =>
                {
                    b.HasOne("Circles_API.Models.Tag", "Tag")
                        .WithMany("Userprofiles")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Circles_API.Models.Userprofile", "Userprofile")
                        .WithMany()
                        .HasForeignKey("UserprofileId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
