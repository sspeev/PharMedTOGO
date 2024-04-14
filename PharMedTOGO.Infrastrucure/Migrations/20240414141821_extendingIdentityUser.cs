using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharMedTOGO.Infrastrucure.Migrations
{
    public partial class extendingIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Patients_PatientId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Patients_PatientId",
                table: "Prescriptions");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fe16750-157b-4110-a05f-0d2ba0812b3c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d42ae752-35a7-4ba3-a9c0-190484b6c253");

            migrationBuilder.AlterTable(
                name: "AspNetUsers",
                comment: "The patient entity");

            migrationBuilder.AlterColumn<string>(
                name: "PatientId",
                table: "Prescriptions",
                type: "nvarchar(450)",
                nullable: false,
                comment: "Patient's identifier",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Patient's identifier");

            migrationBuilder.AlterColumn<string>(
                name: "PatientId",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                comment: "The address of the patient");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EGN",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: true,
                comment: "The egn of the patient");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true,
                comment: "The patient's first name");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true,
                comment: "The patient's last name");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Discriminator", "EGN", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3fe16750-157b-4110-a05f-0d2ba0812b3c", 0, "Pomorie-Mahala-N1", "a50c0745-9779-4370-b272-7d40021a7d6f", "Patient", "908765432", "kristalin@mail.com", false, "Kristalin", "Zhelezhchev", false, null, null, null, "AQAAAAEAACcQAAAAEE7P9bKg/1H/GWolV23ktri7g7SJZD89PGlcWeSCiEQMUrxE+iacJaSHng4n4XoZwg==", null, false, "5d800491-9c38-4b1e-bc4a-9a39e1958542", false, "Kristalin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Discriminator", "EGN", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d42ae752-35a7-4ba3-a9c0-190484b6c253", 0, "Burgas-Slaveikov", "5cb2ef43-0e88-406e-82c9-e22b2d7b04d7", "Patient", "1234567890", "stoyan@mail.com", false, "Stoyan", "Peev", false, null, null, null, "AQAAAAEAACcQAAAAEBUYqnJOy1XFcXZX89r+wz71qPxM3fVHdpyDI2qZcfWjys4aKwGxuhFE0794sGMaAA==", null, false, "e8131c93-8460-45f6-802f-d57ab1a0e49e", false, "Stoyan" });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ExpireDate", "PatientId" },
                values: new object[] { new DateTime(2024, 4, 14, 14, 18, 21, 145, DateTimeKind.Utc).AddTicks(2107), new DateTime(2024, 4, 24, 17, 18, 21, 145, DateTimeKind.Local).AddTicks(2111), "3fe16750-157b-4110-a05f-0d2ba0812b3c" });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ExpireDate", "PatientId" },
                values: new object[] { new DateTime(2024, 4, 3, 14, 18, 21, 145, DateTimeKind.Utc).AddTicks(2280), new DateTime(2024, 4, 14, 17, 18, 21, 145, DateTimeKind.Local).AddTicks(2281), "3fe16750-157b-4110-a05f-0d2ba0812b3c" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_EGN",
                table: "AspNetUsers",
                column: "EGN",
                unique: true,
                filter: "[EGN] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_PatientId",
                table: "Orders",
                column: "PatientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_AspNetUsers_PatientId",
                table: "Prescriptions",
                column: "PatientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_PatientId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_AspNetUsers_PatientId",
                table: "Prescriptions");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_EGN",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EGN",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.AlterTable(
                name: "AspNetUsers",
                oldComment: "The patient entity");

            migrationBuilder.AlterColumn<int>(
                name: "PatientId",
                table: "Prescriptions",
                type: "int",
                nullable: false,
                comment: "Patient's identifier",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldComment: "Patient's identifier");

            migrationBuilder.AlterColumn<int>(
                name: "PatientId",
                table: "Orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "The patient's identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "The user's identifier"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "The address of the patient"),
                    EGN = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "The egn of the patient"),
                    FirstName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, comment: "The patient's first name"),
                    LastName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, comment: "The patient's last name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "The patient entity");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fe16750-157b-4110-a05f-0d2ba0812b3c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6db6099-54a1-424c-9b6d-f78bf1fc46df", "AQAAAAEAACcQAAAAEIyny883VZrNNCJ9jk/g7hlaUMzBTjaxvqgE8xzuauu9UJhribDXxijKXACiL8yjIQ==", "b67085d0-5c78-4581-83db-e3b9f3a3f51e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d42ae752-35a7-4ba3-a9c0-190484b6c253",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb0b7481-5ccb-473f-8f15-bfa6671731ea", "AQAAAAEAACcQAAAAEKg8pGY+V6irw1X/ZgzfoEQ/aXB5OF9vVWY339eNl5/fP6iUkiEdK99jP+E6cO4NMw==", "d43982ab-14d7-47b9-b5af-780a74d06187" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "EGN", "FirstName", "LastName", "UserId" },
                values: new object[,]
                {
                    { 1, "Burgas-Slaveikov", "1234567890", "Stoyan", "Peev", "d42ae752-35a7-4ba3-a9c0-190484b6c253" },
                    { 2, "Pomorie-Mahala-N1", "908765432", "Kristalin", "Zhelezhchev", "3fe16750-157b-4110-a05f-0d2ba0812b3c" }
                });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ExpireDate", "PatientId" },
                values: new object[] { new DateTime(2024, 4, 13, 19, 51, 39, 903, DateTimeKind.Utc).AddTicks(9946), new DateTime(2024, 4, 23, 22, 51, 39, 903, DateTimeKind.Local).AddTicks(9949), 2 });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ExpireDate", "PatientId" },
                values: new object[] { new DateTime(2024, 4, 2, 19, 51, 39, 903, DateTimeKind.Utc).AddTicks(9991), new DateTime(2024, 4, 13, 22, 51, 39, 903, DateTimeKind.Local).AddTicks(9991), 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Patients_EGN",
                table: "Patients",
                column: "EGN",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patients_UserId",
                table: "Patients",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Patients_PatientId",
                table: "Orders",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Patients_PatientId",
                table: "Prescriptions",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
