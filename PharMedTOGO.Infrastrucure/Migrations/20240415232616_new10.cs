using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharMedTOGO.Infrastrucure.Migrations
{
    public partial class new10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsReviewd",
                table: "Prescriptions");

            migrationBuilder.DropColumn(
                name: "IsValid",
                table: "Prescriptions");

            migrationBuilder.AddColumn<int>(
                name: "PrescriptionState",
                table: "Prescriptions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Shows the current stated of validating the prescription");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fb66dc7-697a-48fc-a009-3169578464bc",
                column: "ConcurrencyStamp",
                value: "25f2eb5b-ea45-4306-b13a-bbca1cab72b3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fe16750-157b-4110-a05f-0d2ba0812b3c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8657180e-2384-4845-935f-de49873d8fd2", "AQAAAAEAACcQAAAAEDgHnpyPtcvs/dsLREILxKEXhB9+zxWZg5yrSxVpDWTgpj2Fsa6hh7bwwXE1bMPaPA==", "52b2de8b-39df-461c-bc4f-0d7148628ee4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d42ae752-35a7-4ba3-a9c0-190484b6c253",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8bc9e66-5e1e-4213-b17b-32f37b04d39b", "AQAAAAEAACcQAAAAEAqhmUnCzr0quulh4FGfZYgNztZHBEP61gbEv944/qQk90GeZ1O6YLs+fJ0zOqHCZA==", "73a03edf-48f4-4d84-8de7-eabd65aebf5a" });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 16, 2, 26, 15, 737, DateTimeKind.Local).AddTicks(7895), new DateTime(2024, 4, 26, 2, 26, 15, 737, DateTimeKind.Local).AddTicks(7935) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 4, 23, 26, 15, 737, DateTimeKind.Utc).AddTicks(7938), new DateTime(2024, 4, 16, 2, 26, 15, 737, DateTimeKind.Local).AddTicks(7939) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrescriptionState",
                table: "Prescriptions");

            migrationBuilder.AddColumn<bool>(
                name: "IsReviewd",
                table: "Prescriptions",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Boolean property which shows if the current prescription is reviewed from the admin");

            migrationBuilder.AddColumn<bool>(
                name: "IsValid",
                table: "Prescriptions",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Boolean property which shows if the current prescription is valid");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fb66dc7-697a-48fc-a009-3169578464bc",
                column: "ConcurrencyStamp",
                value: "3cccd4c5-9eb2-4c16-b2b2-91407eb4b7f0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fe16750-157b-4110-a05f-0d2ba0812b3c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b5b2a2a-3433-4e37-8161-70879bd21f52", "AQAAAAEAACcQAAAAEMBDENeQiiBwHUoeRrUAcoMEf0Q7o+zEErzlxV+4D3f9GF4Q+w8L0IMxed0IGF0k6Q==", "9806b78d-abeb-4c05-8b67-5283347dbd49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d42ae752-35a7-4ba3-a9c0-190484b6c253",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9aded681-7e94-4720-8e6b-e02ddbc77be2", "AQAAAAEAACcQAAAAEC0/lfD25gzJ11KKt5DRda7roU6ndGv3W8NTUna2Bw1Iqtqhb6wyFhJZziWXPxBsKg==", "f4a48a39-5408-455a-b566-44255b5eb8cb" });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 16, 1, 48, 32, 410, DateTimeKind.Local).AddTicks(6466), new DateTime(2024, 4, 26, 1, 48, 32, 410, DateTimeKind.Local).AddTicks(6509) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 48, 32, 410, DateTimeKind.Utc).AddTicks(6514), new DateTime(2024, 4, 16, 1, 48, 32, 410, DateTimeKind.Local).AddTicks(6514) });
        }
    }
}
