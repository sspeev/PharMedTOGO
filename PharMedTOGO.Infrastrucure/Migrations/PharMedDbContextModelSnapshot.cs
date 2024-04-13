﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PharMedTOGO.Infrastrucure.Data;

#nullable disable

namespace PharMedTOGO.Infrastrucure.Migrations
{
    [DbContext(typeof(PharMedDbContext))]
    partial class PharMedDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
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

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

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

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "d42ae752-35a7-4ba3-a9c0-190484b6c253",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "cb0b7481-5ccb-473f-8f15-bfa6671731ea",
                            Email = "stoyan@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEKg8pGY+V6irw1X/ZgzfoEQ/aXB5OF9vVWY339eNl5/fP6iUkiEdK99jP+E6cO4NMw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d43982ab-14d7-47b9-b5af-780a74d06187",
                            TwoFactorEnabled = false,
                            UserName = "Stoyan"
                        },
                        new
                        {
                            Id = "3fe16750-157b-4110-a05f-0d2ba0812b3c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f6db6099-54a1-424c-9b6d-f78bf1fc46df",
                            Email = "kristalin@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEIyny883VZrNNCJ9jk/g7hlaUMzBTjaxvqgE8xzuauu9UJhribDXxijKXACiL8yjIQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b67085d0-5c78-4581-83db-e3b9f3a3f51e",
                            TwoFactorEnabled = false,
                            UserName = "Kristalin"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("PharMedTOGO.Infrastrucure.Data.Models.Medicine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("The identifier of the medicine");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("A byte array for pdf file where is stored the description of the medicine");

                    b.Property<bool>("HasSaleApplied")
                        .HasColumnType("bit")
                        .HasComment("Is the sale applied");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("The url of the medicine's image");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasComment("The name of the medicine");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int?>("PrescriptionId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)")
                        .HasComment("The price of the medicine");

                    b.Property<bool>("RequiresPrescription")
                        .HasColumnType("bit")
                        .HasComment("Boolean property which shows if the current medicine requires prescription");

                    b.Property<int?>("SaleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("PrescriptionId");

                    b.HasIndex("SaleId");

                    b.ToTable("Medicines");

                    b.HasComment("Medicine Entity");
                });

            modelBuilder.Entity("PharMedTOGO.Infrastrucure.Data.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<int>("PharmacyId")
                        .HasColumnType("int");

                    b.Property<int>("PrescriptionId")
                        .HasColumnType("int");

                    b.Property<int>("SaleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.HasIndex("PharmacyId");

                    b.HasIndex("PrescriptionId");

                    b.HasIndex("SaleId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("PharMedTOGO.Infrastrucure.Data.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("The patient's identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("The address of the patient");

                    b.Property<string>("EGN")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasComment("The egn of the patient");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasComment("The patient's first name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasComment("The patient's last name");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasComment("The user's identifier");

                    b.HasKey("Id");

                    b.HasIndex("EGN")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Patients");

                    b.HasComment("The patient entity");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Burgas-Slaveikov",
                            EGN = "1234567890",
                            FirstName = "Stoyan",
                            LastName = "Peev",
                            UserId = "d42ae752-35a7-4ba3-a9c0-190484b6c253"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Pomorie-Mahala-N1",
                            EGN = "908765432",
                            FirstName = "Kristalin",
                            LastName = "Zhelezhchev",
                            UserId = "3fe16750-157b-4110-a05f-0d2ba0812b3c"
                        });
                });

            modelBuilder.Entity("PharMedTOGO.Infrastrucure.Data.Models.Pharmacy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Pharmacies");
                });

            modelBuilder.Entity("PharMedTOGO.Infrastrucure.Data.Models.Prescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2")
                        .HasComment("The creation date of the prescription");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Prescription's description");

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("datetime2")
                        .HasComment("The expire date of the prescription");

                    b.Property<bool>("IsValidated")
                        .HasColumnType("bit")
                        .HasComment("Boolean property which shows if the current prescription is validated from the admin");

                    b.Property<int>("PatientId")
                        .HasColumnType("int")
                        .HasComment("Patient's identifier");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("Prescriptions");

                    b.HasComment("The prescription entity");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedOn = new DateTime(2024, 4, 13, 19, 51, 39, 903, DateTimeKind.Utc).AddTicks(9946),
                            Description = "Grip",
                            ExpireDate = new DateTime(2024, 4, 23, 22, 51, 39, 903, DateTimeKind.Local).AddTicks(9949),
                            IsValidated = true,
                            PatientId = 2
                        },
                        new
                        {
                            Id = 2,
                            CreatedOn = new DateTime(2024, 4, 2, 19, 51, 39, 903, DateTimeKind.Utc).AddTicks(9991),
                            Description = "COVID-19",
                            ExpireDate = new DateTime(2024, 4, 13, 22, 51, 39, 903, DateTimeKind.Local).AddTicks(9991),
                            IsValidated = false,
                            PatientId = 2
                        });
                });

            modelBuilder.Entity("PharMedTOGO.Infrastrucure.Data.Models.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)")
                        .HasComment("Decimal value for the sale percentage");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2")
                        .HasComment("When the sale ends");

                    b.Property<bool>("IsEnded")
                        .HasColumnType("bit")
                        .HasComment("Is the sale ended");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2")
                        .HasComment("When the sale starts");

                    b.HasKey("Id");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PharMedTOGO.Infrastrucure.Data.Models.Medicine", b =>
                {
                    b.HasOne("PharMedTOGO.Infrastrucure.Data.Models.Order", null)
                        .WithMany("Medicines")
                        .HasForeignKey("OrderId");

                    b.HasOne("PharMedTOGO.Infrastrucure.Data.Models.Prescription", null)
                        .WithMany("Medicines")
                        .HasForeignKey("PrescriptionId");

                    b.HasOne("PharMedTOGO.Infrastrucure.Data.Models.Sale", "Sale")
                        .WithMany("Medicines")
                        .HasForeignKey("SaleId");

                    b.Navigation("Sale");
                });

            modelBuilder.Entity("PharMedTOGO.Infrastrucure.Data.Models.Order", b =>
                {
                    b.HasOne("PharMedTOGO.Infrastrucure.Data.Models.Patient", "Patient")
                        .WithMany("Orders")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("PharMedTOGO.Infrastrucure.Data.Models.Pharmacy", "Pharmacy")
                        .WithMany("Orders")
                        .HasForeignKey("PharmacyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("PharMedTOGO.Infrastrucure.Data.Models.Prescription", "Prescription")
                        .WithMany()
                        .HasForeignKey("PrescriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PharMedTOGO.Infrastrucure.Data.Models.Sale", "Sale")
                        .WithMany()
                        .HasForeignKey("SaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");

                    b.Navigation("Pharmacy");

                    b.Navigation("Prescription");

                    b.Navigation("Sale");
                });

            modelBuilder.Entity("PharMedTOGO.Infrastrucure.Data.Models.Patient", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PharMedTOGO.Infrastrucure.Data.Models.Prescription", b =>
                {
                    b.HasOne("PharMedTOGO.Infrastrucure.Data.Models.Patient", "Patient")
                        .WithMany("Prescriptions")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("PharMedTOGO.Infrastrucure.Data.Models.Order", b =>
                {
                    b.Navigation("Medicines");
                });

            modelBuilder.Entity("PharMedTOGO.Infrastrucure.Data.Models.Patient", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("PharMedTOGO.Infrastrucure.Data.Models.Pharmacy", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("PharMedTOGO.Infrastrucure.Data.Models.Prescription", b =>
                {
                    b.Navigation("Medicines");
                });

            modelBuilder.Entity("PharMedTOGO.Infrastrucure.Data.Models.Sale", b =>
                {
                    b.Navigation("Medicines");
                });
#pragma warning restore 612, 618
        }
    }
}
