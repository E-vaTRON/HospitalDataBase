﻿// <auto-generated />
using System;
using HospitalDataBase.Core.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HospitalDataBase.Core.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core.Entities.UserIdentifile.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Core.Entities.UserIdentifile.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateJoin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Function")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsExpired")
                        .HasColumnType("bit");

                    b.Property<string>("Job")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("RoomID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("Guid")
                        .IsUnique()
                        .HasFilter("[Guid] IS NOT NULL");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("Core.Entities.UserIdentifile.UserRole", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("HospitalDataBase.Core.Entities.AnalysationTest", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DSymptom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PatientID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("DeviceID");

                    b.HasIndex("PatientID");

                    b.ToTable("AnalysationTests");
                });

            modelBuilder.Entity("HospitalDataBase.Core.Entities.DeviceService", b =>
                {
                    b.Property<string>("DeviceID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GroupID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HealthInsurancePrice")
                        .HasColumnType("int");

                    b.Property<string>("ManagementID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Max")
                        .HasColumnType("int");

                    b.Property<int>("Min")
                        .HasColumnType("int");

                    b.Property<string>("Result")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ResultFromType")
                        .HasColumnType("int");

                    b.Property<int>("ServicePrice")
                        .HasColumnType("int");

                    b.Property<string>("SmallID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Unit")
                        .HasColumnType("int");

                    b.Property<int>("UnitPrice")
                        .HasColumnType("int");

                    b.HasKey("DeviceID");

                    b.ToTable("DeviceServices");
                });

            modelBuilder.Entity("HospitalDataBase.Core.Entities.Drug", b =>
                {
                    b.Property<string>("GoodID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ActiveIngredientName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GoodName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GoodType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GroupID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HealthInsurancePrice")
                        .HasColumnType("int");

                    b.Property<string>("ManagementID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Unit")
                        .HasColumnType("int");

                    b.Property<string>("UnitPrice")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GoodID");

                    b.ToTable("Drugs");
                });

            modelBuilder.Entity("HospitalDataBase.Core.Entities.GoodsExportation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("GoodID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("PatientID")
                        .HasColumnType("int");

                    b.Property<string>("PatientName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RecordDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShipmentID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StorageID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("GoodID");

                    b.ToTable("GoodsExportations");
                });

            modelBuilder.Entity("HospitalDataBase.Core.Entities.GoodsImportation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amout")
                        .HasColumnType("int");

                    b.Property<string>("BillID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("GoodID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("ReceiptDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReceiptID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RecordDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShipmentID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StorageID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tax")
                        .HasColumnType("int");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("GoodID");

                    b.ToTable("GetGoodsImportations");
                });

            modelBuilder.Entity("HospitalDataBase.Core.Entities.HistoryMedicalExam", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateReExam")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateTakeExam")
                        .HasColumnType("datetime2");

                    b.Property<string>("Diagnose")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExamID")
                        .HasColumnType("int");

                    b.Property<string>("PatientID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PatientRecipient")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("PatientID");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("HospitalDataBase.Core.Entities.Inventory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CurrentAmount")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("GoodID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ShipmentID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("GoodID");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("HospitalDataBase.Core.Entities.Patient", b =>
                {
                    b.Property<string>("PatientID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("CardID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DayOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PnoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Sex")
                        .HasColumnType("bit");

                    b.HasKey("PatientID");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("HospitalDataBase.Core.Entities.DoctorList", b =>
                {
                    b.HasBaseType("Core.Entities.UserIdentifile.User");

                    b.Property<bool>("Verified")
                        .HasColumnType("bit");

                    b.HasDiscriminator().HasValue("DoctorList");
                });

            modelBuilder.Entity("HospitalDataBase.Core.Entities.EmployeeList", b =>
                {
                    b.HasBaseType("Core.Entities.UserIdentifile.User");

                    b.Property<bool>("Verified")
                        .HasColumnType("bit")
                        .HasColumnName("EmployeeList_Verified");

                    b.HasDiscriminator().HasValue("EmployeeList");
                });

            modelBuilder.Entity("Core.Entities.UserIdentifile.UserRole", b =>
                {
                    b.HasOne("Core.Entities.UserIdentifile.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.UserIdentifile.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HospitalDataBase.Core.Entities.AnalysationTest", b =>
                {
                    b.HasOne("HospitalDataBase.Core.Entities.DeviceService", "DeviceService")
                        .WithMany("AnalysationTests")
                        .HasForeignKey("DeviceID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("HospitalDataBase.Core.Entities.Patient", "Patient")
                        .WithMany("AnalysationTests")
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("DeviceService");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("HospitalDataBase.Core.Entities.GoodsExportation", b =>
                {
                    b.HasOne("HospitalDataBase.Core.Entities.Drug", "Drug")
                        .WithMany("Exportations")
                        .HasForeignKey("GoodID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Drug");
                });

            modelBuilder.Entity("HospitalDataBase.Core.Entities.GoodsImportation", b =>
                {
                    b.HasOne("HospitalDataBase.Core.Entities.Drug", "Drug")
                        .WithMany("Importations")
                        .HasForeignKey("GoodID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Drug");
                });

            modelBuilder.Entity("HospitalDataBase.Core.Entities.HistoryMedicalExam", b =>
                {
                    b.HasOne("HospitalDataBase.Core.Entities.Patient", "Patient")
                        .WithMany("Exams")
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("HospitalDataBase.Core.Entities.Inventory", b =>
                {
                    b.HasOne("HospitalDataBase.Core.Entities.Drug", "Drug")
                        .WithMany("Inventories")
                        .HasForeignKey("GoodID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Drug");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Core.Entities.UserIdentifile.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Core.Entities.UserIdentifile.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Core.Entities.UserIdentifile.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Core.Entities.UserIdentifile.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Core.Entities.UserIdentifile.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("Core.Entities.UserIdentifile.User", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("HospitalDataBase.Core.Entities.DeviceService", b =>
                {
                    b.Navigation("AnalysationTests");
                });

            modelBuilder.Entity("HospitalDataBase.Core.Entities.Drug", b =>
                {
                    b.Navigation("Exportations");

                    b.Navigation("Importations");

                    b.Navigation("Inventories");
                });

            modelBuilder.Entity("HospitalDataBase.Core.Entities.Patient", b =>
                {
                    b.Navigation("AnalysationTests");

                    b.Navigation("Exams");
                });
#pragma warning restore 612, 618
        }
    }
}
