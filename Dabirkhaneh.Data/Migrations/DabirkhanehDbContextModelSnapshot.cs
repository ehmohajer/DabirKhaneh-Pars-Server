﻿// <auto-generated />
using System;
using Dabirkhaneh.Data.DataBaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Dabirkhaneh.Data.Migrations
{
    [DbContext(typeof(DabirkhanehDbContext))]
    partial class DabirkhanehDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Dabirkhaneh.Data.Attach", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Alt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LetterID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LetterInId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LetterInterId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LetterOutId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<byte>("Type")
                        .HasColumnType("tinyint");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LetterInId");

                    b.HasIndex("LetterInterId");

                    b.HasIndex("LetterOutId");

                    b.ToTable("Attaches");
                });

            modelBuilder.Entity("Dabirkhaneh.Data.DataBaseContext.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("DateOfBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("SectionId")
                        .HasColumnType("smallint");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Dabirkhaneh.Data.LetterIn", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date_Enter")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date_Reg")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrganId")
                        .HasColumnType("int");

                    b.Property<bool>("Remove")
                        .HasColumnType("bit");

                    b.Property<int?>("SectionId")
                        .HasColumnType("int");

                    b.Property<int>("SectionId_In")
                        .HasColumnType("int");

                    b.Property<int>("SectionId_Out")
                        .HasColumnType("int");

                    b.Property<int>("TArchiveId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("OrganId");

                    b.HasIndex("SectionId");

                    b.HasIndex("TArchiveId");

                    b.HasIndex("UserId");

                    b.ToTable("LetterIns");
                });

            modelBuilder.Entity("Dabirkhaneh.Data.LetterInter", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date_Enter")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date_Reg")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Remove")
                        .HasColumnType("bit");

                    b.Property<int?>("SectionId")
                        .HasColumnType("int");

                    b.Property<int>("SectionId_In")
                        .HasColumnType("int");

                    b.Property<int>("SectionId_Out")
                        .HasColumnType("int");

                    b.Property<int>("TArchiveId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("SectionId");

                    b.HasIndex("TArchiveId");

                    b.HasIndex("UserId");

                    b.ToTable("letterInters");
                });

            modelBuilder.Entity("Dabirkhaneh.Data.LetterOut", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date_Enter")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date_Reg")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrganId")
                        .HasColumnType("int");

                    b.Property<bool>("Remove")
                        .HasColumnType("bit");

                    b.Property<int?>("SectionId")
                        .HasColumnType("int");

                    b.Property<int>("SectionId_In")
                        .HasColumnType("int");

                    b.Property<int>("SectionId_Out")
                        .HasColumnType("int");

                    b.Property<int>("TArchiveId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("OrganId");

                    b.HasIndex("SectionId");

                    b.HasIndex("TArchiveId");

                    b.HasIndex("UserId");

                    b.ToTable("LetterOuts");
                });

            modelBuilder.Entity("Dabirkhaneh.Data.Organ", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Organs");
                });

            modelBuilder.Entity("Dabirkhaneh.Data.OrganPerson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrganId")
                        .HasColumnType("int");

                    b.Property<string>("PersonName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OrganId");

                    b.ToTable("OrganPersons");
                });

            modelBuilder.Entity("Dabirkhaneh.Data.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Alt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsMain")
                        .HasColumnType("bit");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("Dabirkhaneh.Data.Section", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("SectionId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("Dabirkhaneh.Data.TArchive", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TArchives");
                });

            modelBuilder.Entity("Dabirkhaneh.Data.Attach", b =>
                {
                    b.HasOne("Dabirkhaneh.Data.LetterIn", "LetterIn")
                        .WithMany("Attaches")
                        .HasForeignKey("LetterInId");

                    b.HasOne("Dabirkhaneh.Data.LetterInter", "LetterInter")
                        .WithMany("Attaches")
                        .HasForeignKey("LetterInterId");

                    b.HasOne("Dabirkhaneh.Data.LetterOut", "LetterOut")
                        .WithMany("Attaches")
                        .HasForeignKey("LetterOutId");

                    b.Navigation("LetterIn");

                    b.Navigation("LetterInter");

                    b.Navigation("LetterOut");
                });

            modelBuilder.Entity("Dabirkhaneh.Data.LetterIn", b =>
                {
                    b.HasOne("Dabirkhaneh.Data.Organ", null)
                        .WithMany("LetterIns")
                        .HasForeignKey("OrganId");

                    b.HasOne("Dabirkhaneh.Data.Section", "Section")
                        .WithMany()
                        .HasForeignKey("SectionId");

                    b.HasOne("Dabirkhaneh.Data.TArchive", "TArchive")
                        .WithMany("LetterIns")
                        .HasForeignKey("TArchiveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dabirkhaneh.Data.DataBaseContext.User", "User")
                        .WithMany("LetterIns")
                        .HasForeignKey("UserId");

                    b.Navigation("Section");

                    b.Navigation("TArchive");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Dabirkhaneh.Data.LetterInter", b =>
                {
                    b.HasOne("Dabirkhaneh.Data.Section", "Section")
                        .WithMany("LetterInters")
                        .HasForeignKey("SectionId");

                    b.HasOne("Dabirkhaneh.Data.TArchive", "TArchive")
                        .WithMany("LetterInters")
                        .HasForeignKey("TArchiveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dabirkhaneh.Data.DataBaseContext.User", "User")
                        .WithMany("LetterInters")
                        .HasForeignKey("UserId");

                    b.Navigation("Section");

                    b.Navigation("TArchive");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Dabirkhaneh.Data.LetterOut", b =>
                {
                    b.HasOne("Dabirkhaneh.Data.Organ", null)
                        .WithMany("LetterOuts")
                        .HasForeignKey("OrganId");

                    b.HasOne("Dabirkhaneh.Data.Section", "Section")
                        .WithMany()
                        .HasForeignKey("SectionId");

                    b.HasOne("Dabirkhaneh.Data.TArchive", "TArchive")
                        .WithMany("LetterOuts")
                        .HasForeignKey("TArchiveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dabirkhaneh.Data.DataBaseContext.User", "User")
                        .WithMany("LetterOuts")
                        .HasForeignKey("UserId");

                    b.Navigation("Section");

                    b.Navigation("TArchive");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Dabirkhaneh.Data.OrganPerson", b =>
                {
                    b.HasOne("Dabirkhaneh.Data.Organ", "Organ")
                        .WithMany("OrganPersons")
                        .HasForeignKey("OrganId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organ");
                });

            modelBuilder.Entity("Dabirkhaneh.Data.Photo", b =>
                {
                    b.HasOne("Dabirkhaneh.Data.DataBaseContext.User", "User")
                        .WithMany("Photos")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Dabirkhaneh.Data.Section", b =>
                {
                    b.HasOne("Dabirkhaneh.Data.DataBaseContext.User", "User")
                        .WithOne("Section")
                        .HasForeignKey("Dabirkhaneh.Data.Section", "UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Dabirkhaneh.Data.DataBaseContext.User", b =>
                {
                    b.Navigation("LetterIns");

                    b.Navigation("LetterInters");

                    b.Navigation("LetterOuts");

                    b.Navigation("Photos");

                    b.Navigation("Section");
                });

            modelBuilder.Entity("Dabirkhaneh.Data.LetterIn", b =>
                {
                    b.Navigation("Attaches");
                });

            modelBuilder.Entity("Dabirkhaneh.Data.LetterInter", b =>
                {
                    b.Navigation("Attaches");
                });

            modelBuilder.Entity("Dabirkhaneh.Data.LetterOut", b =>
                {
                    b.Navigation("Attaches");
                });

            modelBuilder.Entity("Dabirkhaneh.Data.Organ", b =>
                {
                    b.Navigation("LetterIns");

                    b.Navigation("LetterOuts");

                    b.Navigation("OrganPersons");
                });

            modelBuilder.Entity("Dabirkhaneh.Data.Section", b =>
                {
                    b.Navigation("LetterInters");
                });

            modelBuilder.Entity("Dabirkhaneh.Data.TArchive", b =>
                {
                    b.Navigation("LetterIns");

                    b.Navigation("LetterInters");

                    b.Navigation("LetterOuts");
                });
#pragma warning restore 612, 618
        }
    }
}
