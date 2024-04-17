using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharMedTOGO.Infrastrucure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrescriptionState = table.Column<int>(type: "int", nullable: false, comment: "Shows the current stated of validating the prescription"),
                    IsValid = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "The creation date of the prescription"),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "The expire date of the prescription"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Prescription's description"),
                    PatientId = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Patient's identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescriptions", x => x.Id);
                },
                comment: "The prescription entity");

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Discount = table.Column<int>(type: "int", nullable: false, comment: "Decimal value for the sale percentage"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "When the sale starts"),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "When the sale ends"),
                    IsEnded = table.Column<bool>(type: "bit", nullable: false, comment: "Is the sale ended")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SessionIntendId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, comment: "The patient's first name"),
                    LastName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, comment: "The patient's last name"),
                    EGN = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "The egn of the patient"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "The address of the patient"),
                    PrescriptionId = table.Column<int>(type: "int", nullable: true, comment: "Prescription's identifier"),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Prescriptions_PrescriptionId",
                        column: x => x.PrescriptionId,
                        principalTable: "Prescriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "The patient entity");

            migrationBuilder.CreateTable(
                name: "Medicines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "The identifier of the medicine")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false, comment: "The name of the medicine"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "The url of the medicine's image"),
                    RequiresPrescription = table.Column<bool>(type: "bit", nullable: false, comment: "Boolean property which shows if the current medicine requires prescription"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "The price of the medicine"),
                    HasSaleApplied = table.Column<bool>(type: "bit", nullable: false, comment: "Is the sale applied"),
                    Category = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "A byte array for pdf file where is stored the description of the medicine"),
                    SaleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medicines_Sales_SaleId",
                        column: x => x.SaleId,
                        principalTable: "Sales",
                        principalColumn: "Id");
                },
                comment: "Medicine Entity");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    PatientId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MedicineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => new { x.PatientId, x.MedicineId });
                    table.ForeignKey(
                        name: "FK_Carts_AspNetUsers_PatientId",
                        column: x => x.PatientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carts_Medicines_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "9fb66dc7-697a-48fc-a009-3169578464bc", "7d34517d-eb62-4e18-94ce-a863ab7d2921", "IdentityRole", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "EGN", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PrescriptionId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3fe16750-157b-4110-a05f-0d2ba0812b3c", 0, "Pomorie-Mahala-N1", "26ad3643-9426-4a0b-a1c8-49162f749d40", "0506047819", "kristalin@mail.com", false, "Kristalin", "Zhelezhchev", false, null, "KRISTALIN@MAIL.COM", "KRISTALIN@MAIL.COM", "AQAAAAEAACcQAAAAEE2LlLqgZ703fxxksz6uO/sGjDCXiBTFdzWwpHSUuCli5jElGn1TeStVANomGorAuQ==", null, false, null, "b245619d-312a-4ff6-9356-8c8a0097ff7f", false, "kristalin@mail.com" },
                    { "d42ae752-35a7-4ba3-a9c0-190484b6c253", 0, "Burgas-Slaveikov", "3b7c3b92-3659-4ebd-9ccd-dfd1bd515b66", "0549050487", "stoyan@mail.com", false, "Stoyan", "Peev", false, null, "STOYAN@MAIL.COM", "STOYAN@MAIL.COM", "AQAAAAEAACcQAAAAEHEZZ86j6DwzRvpb+5w6CRHIkyyTnhGFVlgEMXnr5y6WXQXDSJS/nPuVq9VltP7EfA==", null, false, null, "29113b7f-268b-48bc-805f-6e0d772ca431", false, "stoyan@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "Medicines",
                columns: new[] { "Id", "Category", "Description", "HasSaleApplied", "ImageUrl", "Name", "Price", "RequiresPrescription", "SaleId" },
                values: new object[,]
                {
                    { 1, 5, "Главоболие и температура", false, "https://subra.bg/files/richeditor/os-product-images/11/nurofen-24-200mg.jpg", "Нурофен", 7.98m, false, null },
                    { 2, 5, "Главоболие", false, "https://sopharmacy.bg/media/sys_master/h3b/h9d/9063126761502.jpg", "Беналгин", 11.16m, false, null },
                    { 3, 5, "При раздразнен стомах и диария", false, "https://static.framar.bg/product/sopharma-buskolizin-tabletki-bolezneni-spazmi-hioscinov-butilbromid.jpg", "Бусколизин", 11.16m, false, null },
                    { 4, 3, "Хрема, запушен нос и синузит", false, "https://alpenpharma-bulgaria.bg/wp-content/uploads/2021/02/cinabsin-1.png", "Цинабсин", 17m, false, null },
                    { 5, 1, "", false, "https://depobebemag.bg/wp-content/uploads/2019/02/%D0%B1%D0%BE%D1%87%D0%BA%D0%BE-%D0%BC%D0%BE%D0%BA%D1%80%D0%B8-%D0%BA%D1%8A%D1%80%D0%BF%D0%B8-%D1%81%D0%BC%D1%80%D0%B0%D0%B4%D0%BB%D0%B8%D0%BA%D0%B0-90%D0%B1%D1%80.png", "Мокри кърпи БОЧКО", 2.6m, false, null },
                    { 6, 2, "Продуктът предлага цялостна подкрепа за организма, особено през есенно-зимния сезон. Той укрепва имунната система благодарение на незаменимите мастни киселини и мощното антиоксидантно действие. Също така, стимулира метаболизма и помага на тялото да се справи със стреса. Подпомага сърдечно-съдовата система и умствената дейност, допринася за намаляване на умората и изтощението, и спомага за предпазването на клетките от окислителен стрес.", false, "https://balevski.eu/cdn/shop/files/18-3._3-6-9.jpg?v=1688235019&width=823", "Шипково масло с Омега 3, 6 и 9", 34.9m, false, null },
                    { 7, 5, "Сумамед съдържа азитромицин, който принадлежи към групата на антибактериалните лекарствени продукти за системно приложение, макролиден антибиотик.\r\n\r\nСумамед се прилага за лечение на пациенти с инфекции, причинени от един или повече от един чувствителни на азитромицин микроорганизми:\r\n\r\nинфекции на горните дихателни пътища: фарингит/тонзилит, синуит и възпаление на средното ухо\r\nинфекции на долните дихателни пътища: бронхит и пневмонии, придобити в обществото \r\nинфекции на кожата и меките тъкани: средно изразена форма на acne vulgaris, еритема хроника мигранс (първи стадий на Лаймска болест), еризипел, импетиго и вторична пиодермия\r\nполово предавани болести: неусложнени генитални инфекции причинени от Chlamydia trachomatis", false, "https://uploads.remediumapi.com/5ecc3d1b6af72c3ad4d460e1/103/257fe60e2311dced12194a77b5f7ffd2/720.jpeg", "Сумамед", 17.6m, true, null }
                });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "Id", "CreatedOn", "Description", "ExpireDate", "IsValid", "PatientId", "PrescriptionState" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 17, 14, 11, 4, 8, DateTimeKind.Local).AddTicks(1048), "Flu", new DateTime(2024, 4, 27, 14, 11, 4, 8, DateTimeKind.Local).AddTicks(1092), false, "f13628c2-5ff0-4d1c-a0e2-2527ec425aa4", 0 },
                    { 2, new DateTime(2024, 4, 6, 11, 11, 4, 8, DateTimeKind.Utc).AddTicks(1098), "COVID-19", new DateTime(2024, 4, 17, 14, 11, 4, 8, DateTimeKind.Local).AddTicks(1098), false, "3fe16750-157b-4110-a05f-0d2ba0812b3c", 0 }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "Discount", "EndDate", "IsEnded", "StartDate" },
                values: new object[,]
                {
                    { 1, 50, new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2, 30, new DateTime(2024, 4, 27, 0, 0, 0, 0, DateTimeKind.Local), false, new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9fb66dc7-697a-48fc-a009-3169578464bc", "d42ae752-35a7-4ba3-a9c0-190484b6c253" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_EGN",
                table: "AspNetUsers",
                column: "EGN",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PrescriptionId",
                table: "AspNetUsers",
                column: "PrescriptionId",
                unique: true,
                filter: "[PrescriptionId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_MedicineId",
                table: "Carts",
                column: "MedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_SaleId",
                table: "Medicines",
                column: "SaleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Medicines");

            migrationBuilder.DropTable(
                name: "Prescriptions");

            migrationBuilder.DropTable(
                name: "Sales");
        }
    }
}
