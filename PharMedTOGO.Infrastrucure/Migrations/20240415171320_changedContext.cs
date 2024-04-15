using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharMedTOGO.Infrastrucure.Migrations
{
    public partial class changedContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_EGN",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fb66dc7-697a-48fc-a009-3169578464bc");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                comment: "The patient's last name",
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldNullable: true,
                oldComment: "The patient's last name");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                comment: "The patient's first name",
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldNullable: true,
                oldComment: "The patient's first name");

            migrationBuilder.AlterColumn<string>(
                name: "EGN",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                comment: "The egn of the patient",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true,
                oldComment: "The egn of the patient");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "The address of the patient",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "The address of the patient");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetRoles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[] { "9fb66dc7-697a-48fc-a009-3169578464bc", "d0007842-66a1-44c5-9365-708f1168b80a", "IdentityRole", "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fe16750-157b-4110-a05f-0d2ba0812b3c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "114b3e95-9f46-420c-bd0e-ee5af05d40d4", "AQAAAAEAACcQAAAAEHEwsp4mMnvlirqbASY11mqadChDBG4Pg3YZuynheRBfZGZ6dJ0TWBbdU4mf6dPlQA==", "7edb4363-33cf-4433-ae4c-fbe5ce501116" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d42ae752-35a7-4ba3-a9c0-190484b6c253",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d77ac45f-bcc6-4a7f-b90e-6e3c055c92bb", "AQAAAAEAACcQAAAAEOmT5FXK/BCYNt+m/Tp4nFumLyYijnsryYrLw8JPv+xbD02Sl/mltrxLeFITq1TPzw==", "5d0e188c-ceed-4080-b9ba-9551f4b21624" });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 15, 20, 13, 19, 633, DateTimeKind.Local).AddTicks(1658), new DateTime(2024, 4, 25, 20, 13, 19, 633, DateTimeKind.Local).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 4, 17, 13, 19, 633, DateTimeKind.Utc).AddTicks(1710), new DateTime(2024, 4, 15, 20, 13, 19, 633, DateTimeKind.Local).AddTicks(1711) });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_EGN",
                table: "AspNetUsers",
                column: "EGN",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_EGN",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fe16750-157b-4110-a05f-0d2ba0812b3c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d42ae752-35a7-4ba3-a9c0-190484b6c253");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetRoles");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true,
                comment: "The patient's last name",
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldComment: "The patient's last name");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true,
                comment: "The patient's first name",
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldComment: "The patient's first name");

            migrationBuilder.AlterColumn<string>(
                name: "EGN",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: true,
                comment: "The egn of the patient",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldComment: "The egn of the patient");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                comment: "The address of the patient",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "The address of the patient");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fb66dc7-697a-48fc-a009-3169578464bc",
                column: "ConcurrencyStamp",
                value: "69aac090-dcc8-4e1a-ada5-6ea5691a862f");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Discriminator", "EGN", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3fe16750-157b-4110-a05f-0d2ba0812b3c", 0, "Pomorie-Mahala-N1", "d76ee5cb-d2b2-4e0d-8544-5634c1566293", "Patient", "0506047819", "kristalin@mail.com", false, "Kristalin", "Zhelezhchev", false, null, null, null, "AQAAAAEAACcQAAAAEKKun+feXig0l8WDo3FqomYATGjGsyEbOoBdlrnWm7VUYLuBEeeFfAoDg8SiWDMP7Q==", null, false, "57ff3e94-8e0b-4ec5-9468-b5083f468b5a", false, "Kristalin" },
                    { "d42ae752-35a7-4ba3-a9c0-190484b6c253", 0, "Burgas-Slaveikov", "1e19dbc6-c5d1-421e-a0e7-ff442884b06a", "Patient", "0549050487", "stoyan@mail.com", false, "Stoyan", "Peev", false, null, null, null, "AQAAAAEAACcQAAAAEHOQkBoExeS1ursOg9wO9u/6tVpO6OH3TBPzaGhCmX8wmdGFtSv5UIEc+d5cBgw+0w==", null, false, "f32c3c74-0ac5-4438-aa54-c6d6945315d8", false, "Stoyan" }
                });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 15, 39, 717, DateTimeKind.Local).AddTicks(9953), new DateTime(2024, 4, 25, 13, 15, 39, 717, DateTimeKind.Local).AddTicks(9998) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 4, 10, 15, 39, 718, DateTimeKind.Utc).AddTicks(7), new DateTime(2024, 4, 15, 13, 15, 39, 718, DateTimeKind.Local).AddTicks(8) });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_EGN",
                table: "AspNetUsers",
                column: "EGN",
                unique: true,
                filter: "[EGN] IS NOT NULL");
        }
    }
}
