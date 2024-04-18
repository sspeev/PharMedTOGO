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
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<string>", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
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

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole<string>");
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

                    b.HasData(
                        new
                        {
                            UserId = "d42ae752-35a7-4ba3-a9c0-190484b6c253",
                            RoleId = "9fb66dc7-697a-48fc-a009-3169578464bc"
                        });
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

            modelBuilder.Entity("PharMedTOGO.Infrastrucure.Data.Models.Cart", b =>
                {
                    b.Property<string>("PatientId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("MedicineId")
                        .HasColumnType("int");

                    b.HasKey("PatientId", "MedicineId");

                    b.HasIndex("MedicineId");

                    b.ToTable("Carts");
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

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)")
                        .HasComment("The price of the medicine");

                    b.Property<bool>("RequiresPrescription")
                        .HasColumnType("bit")
                        .HasComment("Boolean property which shows if the current medicine requires prescription");

                    b.Property<int?>("SaleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SaleId");

                    b.ToTable("Medicines");

                    b.HasComment("Medicine Entity");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = 5,
                            Description = "Главоболие и температура",
                            HasSaleApplied = false,
                            ImageUrl = "https://subra.bg/files/richeditor/os-product-images/11/nurofen-24-200mg.jpg",
                            Name = "Нурофен",
                            Price = 7.98m,
                            RequiresPrescription = false
                        },
                        new
                        {
                            Id = 2,
                            Category = 5,
                            Description = "Главоболие",
                            HasSaleApplied = false,
                            ImageUrl = "https://sopharmacy.bg/media/sys_master/h3b/h9d/9063126761502.jpg",
                            Name = "Беналгин",
                            Price = 11.16m,
                            RequiresPrescription = false
                        },
                        new
                        {
                            Id = 3,
                            Category = 5,
                            Description = "При раздразнен стомах и диария",
                            HasSaleApplied = false,
                            ImageUrl = "https://static.framar.bg/product/sopharma-buskolizin-tabletki-bolezneni-spazmi-hioscinov-butilbromid.jpg",
                            Name = "Бусколизин",
                            Price = 11.16m,
                            RequiresPrescription = false
                        },
                        new
                        {
                            Id = 4,
                            Category = 3,
                            Description = "Хрема, запушен нос и синузит",
                            HasSaleApplied = false,
                            ImageUrl = "https://alpenpharma-bulgaria.bg/wp-content/uploads/2021/02/cinabsin-1.png",
                            Name = "Цинабсин",
                            Price = 17m,
                            RequiresPrescription = false
                        },
                        new
                        {
                            Id = 5,
                            Category = 1,
                            Description = "",
                            HasSaleApplied = false,
                            ImageUrl = "https://depobebemag.bg/wp-content/uploads/2019/02/%D0%B1%D0%BE%D1%87%D0%BA%D0%BE-%D0%BC%D0%BE%D0%BA%D1%80%D0%B8-%D0%BA%D1%8A%D1%80%D0%BF%D0%B8-%D1%81%D0%BC%D1%80%D0%B0%D0%B4%D0%BB%D0%B8%D0%BA%D0%B0-90%D0%B1%D1%80.png",
                            Name = "Мокри кърпи БОЧКО",
                            Price = 2.6m,
                            RequiresPrescription = false
                        },
                        new
                        {
                            Id = 6,
                            Category = 2,
                            Description = "Продуктът предлага цялостна подкрепа за организма, особено през есенно-зимния сезон. Той укрепва имунната система благодарение на незаменимите мастни киселини и мощното антиоксидантно действие. Също така, стимулира метаболизма и помага на тялото да се справи със стреса. Подпомага сърдечно-съдовата система и умствената дейност, допринася за намаляване на умората и изтощението, и спомага за предпазването на клетките от окислителен стрес.",
                            HasSaleApplied = false,
                            ImageUrl = "https://balevski.eu/cdn/shop/files/18-3._3-6-9.jpg?v=1688235019&width=823",
                            Name = "Шипково масло с Омега 3, 6 и 9",
                            Price = 34.9m,
                            RequiresPrescription = false
                        },
                        new
                        {
                            Id = 7,
                            Category = 5,
                            Description = "Сумамед съдържа азитромицин, който принадлежи към групата на антибактериалните лекарствени продукти за системно приложение, макролиден антибиотик.\r\n\r\nСумамед се прилага за лечение на пациенти с инфекции, причинени от един или повече от един чувствителни на азитромицин микроорганизми:\r\n\r\nинфекции на горните дихателни пътища: фарингит/тонзилит, синуит и възпаление на средното ухо\r\nинфекции на долните дихателни пътища: бронхит и пневмонии, придобити в обществото \r\nинфекции на кожата и меките тъкани: средно изразена форма на acne vulgaris, еритема хроника мигранс (първи стадий на Лаймска болест), еризипел, импетиго и вторична пиодермия\r\nполово предавани болести: неусложнени генитални инфекции причинени от Chlamydia trachomatis",
                            HasSaleApplied = false,
                            ImageUrl = "https://uploads.remediumapi.com/5ecc3d1b6af72c3ad4d460e1/103/257fe60e2311dced12194a77b5f7ffd2/720.jpeg",
                            Name = "Сумамед",
                            Price = 17.6m,
                            RequiresPrescription = true
                        });
                });

            modelBuilder.Entity("PharMedTOGO.Infrastrucure.Data.Models.Patient", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("The address of the patient");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EGN")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasComment("The egn of the patient");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

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

                    b.Property<int?>("PrescriptionId")
                        .HasColumnType("int")
                        .HasComment("Prescription's identifier");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("EGN")
                        .IsUnique();

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("PrescriptionId")
                        .IsUnique()
                        .HasFilter("[PrescriptionId] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasComment("The patient entity");

                    b.HasData(
                        new
                        {
                            Id = "d42ae752-35a7-4ba3-a9c0-190484b6c253",
                            AccessFailedCount = 0,
                            Address = "Burgas-Slaveikov",
                            ConcurrencyStamp = "4390100c-716d-45c7-b38c-0f386ae0ec86",
                            EGN = "0549050487",
                            Email = "admin@mail.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            LastName = "Adminov",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@MAIL.COM",
                            NormalizedUserName = "ADMIN@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEB6VGoPMpwt6AOMTy45SVKm+1no6SecVMiVG5BU/z8cDzvU+P+qJDc5EFn78Ylxk5A==",
                            PhoneNumberConfirmed = false,
                            PrescriptionId = 1,
                            SecurityStamp = "2ae78a5a-8583-48eb-bcdf-4537529de981",
                            TwoFactorEnabled = false,
                            UserName = "admin@mail.com"
                        },
                        new
                        {
                            Id = "3fe16750-157b-4110-a05f-0d2ba0812b3c",
                            AccessFailedCount = 0,
                            Address = "Pomorie-Mahala-N1",
                            ConcurrencyStamp = "4ec44b7a-5325-41da-adad-13378d5a4294",
                            EGN = "0506047819",
                            Email = "test@mail.com",
                            EmailConfirmed = false,
                            FirstName = "Test",
                            LastName = "Testov",
                            LockoutEnabled = false,
                            NormalizedEmail = "TEST@MAIL.COM",
                            NormalizedUserName = "TEST@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEBJHaCZ/Kt56OAhHw96KA8wcrxCHFQcRK6rBY0K3aQCMB+k3SYqtKKOuOrOiwPvJsg==",
                            PhoneNumberConfirmed = false,
                            PrescriptionId = 2,
                            SecurityStamp = "14a77a40-0bac-49c8-b30e-4ba030973efa",
                            TwoFactorEnabled = false,
                            UserName = "test@mail.com"
                        });
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

                    b.Property<bool>("IsValid")
                        .HasColumnType("bit");

                    b.Property<string>("PatientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Patient's identifier");

                    b.Property<int>("PrescriptionState")
                        .HasColumnType("int")
                        .HasComment("Shows the current stated of validating the prescription");

                    b.HasKey("Id");

                    b.ToTable("Prescriptions");

                    b.HasComment("The prescription entity");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedOn = new DateTime(2024, 4, 18, 19, 17, 48, 138, DateTimeKind.Local).AddTicks(9101),
                            Description = "Flu",
                            ExpireDate = new DateTime(2024, 4, 28, 19, 17, 48, 138, DateTimeKind.Local).AddTicks(9102),
                            IsValid = false,
                            PatientId = "",
                            PrescriptionState = 0
                        },
                        new
                        {
                            Id = 2,
                            CreatedOn = new DateTime(2024, 4, 7, 16, 17, 48, 138, DateTimeKind.Utc).AddTicks(9248),
                            Description = "COVID-19",
                            ExpireDate = new DateTime(2024, 4, 18, 19, 17, 48, 138, DateTimeKind.Local).AddTicks(9248),
                            IsValid = false,
                            PatientId = "",
                            PrescriptionState = 0
                        });
                });

            modelBuilder.Entity("PharMedTOGO.Infrastrucure.Data.Models.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Discount")
                        .HasColumnType("int")
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Discount = 50,
                            EndDate = new DateTime(2024, 4, 19, 0, 0, 0, 0, DateTimeKind.Local),
                            IsEnded = false,
                            StartDate = new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 2,
                            Discount = 30,
                            EndDate = new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Local),
                            IsEnded = false,
                            StartDate = new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Local)
                        });
                });

            modelBuilder.Entity("PharMedTOGO.Infrastrucure.Data.Models.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SessionIntendId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole<string>");

                    b.HasDiscriminator().HasValue("IdentityRole");

                    b.HasData(
                        new
                        {
                            Id = "9fb66dc7-697a-48fc-a009-3169578464bc",
                            ConcurrencyStamp = "07af76a2-6452-426b-9958-475dd64dc6da",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<string>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("PharMedTOGO.Infrastrucure.Data.Models.Patient", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("PharMedTOGO.Infrastrucure.Data.Models.Patient", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<string>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PharMedTOGO.Infrastrucure.Data.Models.Patient", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("PharMedTOGO.Infrastrucure.Data.Models.Patient", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PharMedTOGO.Infrastrucure.Data.Models.Cart", b =>
                {
                    b.HasOne("PharMedTOGO.Infrastrucure.Data.Models.Medicine", "Medicine")
                        .WithMany()
                        .HasForeignKey("MedicineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PharMedTOGO.Infrastrucure.Data.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medicine");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("PharMedTOGO.Infrastrucure.Data.Models.Medicine", b =>
                {
                    b.HasOne("PharMedTOGO.Infrastrucure.Data.Models.Sale", "Sale")
                        .WithMany("Medicines")
                        .HasForeignKey("SaleId");

                    b.Navigation("Sale");
                });

            modelBuilder.Entity("PharMedTOGO.Infrastrucure.Data.Models.Patient", b =>
                {
                    b.HasOne("PharMedTOGO.Infrastrucure.Data.Models.Prescription", "Prescription")
                        .WithOne("Patient")
                        .HasForeignKey("PharMedTOGO.Infrastrucure.Data.Models.Patient", "PrescriptionId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Prescription");
                });

            modelBuilder.Entity("PharMedTOGO.Infrastrucure.Data.Models.Prescription", b =>
                {
                    b.Navigation("Patient")
                        .IsRequired();
                });

            modelBuilder.Entity("PharMedTOGO.Infrastrucure.Data.Models.Sale", b =>
                {
                    b.Navigation("Medicines");
                });
#pragma warning restore 612, 618
        }
    }
}
