﻿// <auto-generated />
using System;
using KeerthiveeduAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KeerthiveeduAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KeerthiveeduAPI.Entities.AppUser", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<DateTime>("CreatedDttm");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("EmailAddress");

                    b.Property<int>("FamilyGroupId");

                    b.Property<string>("Gender");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsVerified");

                    b.Property<string>("Mobile");

                    b.Property<string>("Name");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("UserName");

                    b.Property<DateTime>("VerifiedDttm");

                    b.Property<long>("VerifiedUserId");

                    b.HasKey("Id");

                    b.HasIndex("FamilyGroupId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("KeerthiveeduAPI.Entities.Committee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MemberPositionId");

                    b.Property<string>("PhotoUrl");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("MemberPositionId");

                    b.HasIndex("UserId");

                    b.ToTable("Committees");
                });

            modelBuilder.Entity("KeerthiveeduAPI.Entities.Event", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<DateTime>("EndDttm");

                    b.Property<string>("Name");

                    b.Property<DateTime>("StartDttm");

                    b.HasKey("Id");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("KeerthiveeduAPI.Entities.FamilyGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FamilyTypeId");

                    b.Property<int?>("FamilyTypesId");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("FamilyTypesId");

                    b.ToTable("FamilyGroups");

                    b.HasData(
                        new { Id = 1, FamilyTypeId = 101, IsActive = true, Name = "PularaKeerthiyil" },
                        new { Id = 2, FamilyTypeId = 102, IsActive = true, Name = "OralasseryKeerthiyil" },
                        new { Id = 3, FamilyTypeId = 103, IsActive = true, Name = "PallarmangalamKeerthiyil" }
                    );
                });

            modelBuilder.Entity("KeerthiveeduAPI.Entities.Message", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Details");

                    b.Property<string>("Header");

                    b.Property<DateTime>("MessageDttm");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("KeerthiveeduAPI.Entities.Parameters", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("HeaderId");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name");

                    b.Property<int>("PrevId");

                    b.Property<string>("ShortCode");

                    b.HasKey("Id");

                    b.HasIndex("HeaderId");

                    b.ToTable("Parameters");

                    b.HasData(
                        new { Id = 1, IsActive = true, Name = "Family Types", PrevId = 0, ShortCode = "FT" },
                        new { Id = 2, IsActive = true, Name = "Committe Member Posts", PrevId = 0, ShortCode = "CMT" },
                        new { Id = 3, IsActive = true, Name = "Photo Categories", PrevId = 0, ShortCode = "PC" },
                        new { Id = 101, IsActive = true, Name = "Ezham Edam", PrevId = 1, ShortCode = "EE" },
                        new { Id = 102, IsActive = true, Name = "Naalam Edam", PrevId = 1, ShortCode = "NE" },
                        new { Id = 103, IsActive = true, Name = "Secretary", PrevId = 2, ShortCode = "SC" },
                        new { Id = 104, IsActive = true, Name = "President", PrevId = 2, ShortCode = "PST" },
                        new { Id = 105, IsActive = true, Name = "Executive Member", PrevId = 2, ShortCode = "EXMEM" },
                        new { Id = 106, IsActive = true, Name = "Committee Member Profile", PrevId = 3, ShortCode = "CMP" },
                        new { Id = 107, IsActive = true, Name = "Event Photos", PrevId = 3, ShortCode = "EVNTP" },
                        new { Id = 108, IsActive = true, Name = "Web Photos", PrevId = 3, ShortCode = "WEBP" }
                    );
                });

            modelBuilder.Entity("KeerthiveeduAPI.Entities.Photo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("EventId");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("KeerthiveeduAPI.Entities.Rights", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name");

                    b.Property<string>("ShortCode");

                    b.HasKey("Id");

                    b.ToTable("Rights");

                    b.HasData(
                        new { Id = 1, IsActive = true, Name = "Administrator", ShortCode = "ADMIN" },
                        new { Id = 2, IsActive = true, Name = "VerificationUser", ShortCode = "VERIFICATION" }
                    );
                });

            modelBuilder.Entity("KeerthiveeduAPI.Entities.Ritual", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.ToTable("Rituals");
                });

            modelBuilder.Entity("KeerthiveeduAPI.Entities.RitualBooking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BookedDate");

                    b.Property<decimal>("DiscountAmount");

                    b.Property<decimal>("NetAmount");

                    b.Property<DateTime>("RitualDate");

                    b.Property<int>("StatusId");

                    b.Property<decimal>("TotalAmount");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("StatusId");

                    b.HasIndex("UserId");

                    b.ToTable("RitualBookings");
                });

            modelBuilder.Entity("KeerthiveeduAPI.Entities.RitualBookingDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookingId");

                    b.Property<int>("Count");

                    b.Property<decimal>("DiscountAmount");

                    b.Property<decimal>("DiscountPrice");

                    b.Property<decimal>("NetAmount");

                    b.Property<decimal>("Price");

                    b.Property<int>("RitualId");

                    b.Property<decimal>("TotalAmount");

                    b.HasKey("Id");

                    b.HasIndex("RitualId");

                    b.ToTable("RitualBookingDetails");
                });

            modelBuilder.Entity("KeerthiveeduAPI.Entities.UserRights", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("AppUserId");

                    b.Property<bool>("IsActive");

                    b.Property<int>("RightsId");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("RightsId");

                    b.ToTable("UserRights");

                    b.HasData(
                        new { Id = 1L, IsActive = true, RightsId = 1, UserId = 1L }
                    );
                });

            modelBuilder.Entity("KeerthiveeduAPI.Entities.AppUser", b =>
                {
                    b.HasOne("KeerthiveeduAPI.Entities.FamilyGroup", "FamilyGroup")
                        .WithMany()
                        .HasForeignKey("FamilyGroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KeerthiveeduAPI.Entities.Committee", b =>
                {
                    b.HasOne("KeerthiveeduAPI.Entities.Parameters", "MemberPosition")
                        .WithMany()
                        .HasForeignKey("MemberPositionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KeerthiveeduAPI.Entities.AppUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KeerthiveeduAPI.Entities.FamilyGroup", b =>
                {
                    b.HasOne("KeerthiveeduAPI.Entities.Parameters", "FamilyTypes")
                        .WithMany()
                        .HasForeignKey("FamilyTypesId");
                });

            modelBuilder.Entity("KeerthiveeduAPI.Entities.Parameters", b =>
                {
                    b.HasOne("KeerthiveeduAPI.Entities.Parameters", "Header")
                        .WithMany()
                        .HasForeignKey("HeaderId");
                });

            modelBuilder.Entity("KeerthiveeduAPI.Entities.Photo", b =>
                {
                    b.HasOne("KeerthiveeduAPI.Entities.Event")
                        .WithMany("Photos")
                        .HasForeignKey("EventId");
                });

            modelBuilder.Entity("KeerthiveeduAPI.Entities.RitualBooking", b =>
                {
                    b.HasOne("KeerthiveeduAPI.Entities.Parameters", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KeerthiveeduAPI.Entities.AppUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KeerthiveeduAPI.Entities.RitualBookingDetail", b =>
                {
                    b.HasOne("KeerthiveeduAPI.Entities.Ritual", "Ritual")
                        .WithMany()
                        .HasForeignKey("RitualId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KeerthiveeduAPI.Entities.UserRights", b =>
                {
                    b.HasOne("KeerthiveeduAPI.Entities.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId");

                    b.HasOne("KeerthiveeduAPI.Entities.Rights", "Rights")
                        .WithMany()
                        .HasForeignKey("RightsId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
