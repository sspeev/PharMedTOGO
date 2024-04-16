using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharMedTOGO.Infrastrucure.Migrations
{
    public partial class new13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Carts",
                table: "Carts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carts",
                table: "Carts",
                columns: new[] { "PatientId", "MedicineId" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fb66dc7-697a-48fc-a009-3169578464bc",
                column: "ConcurrencyStamp",
                value: "8f9f8bf9-02cd-47c0-953a-813d04634ec6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fe16750-157b-4110-a05f-0d2ba0812b3c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24880e80-d282-4cf3-b4e1-e81bbe016192", "AQAAAAEAACcQAAAAEPpmIoFPQDPUX2HM8qZBjq0ISfYRr8AGtKTCja1nlzihIyVVEnp0WuqEJ0yJc6hrHQ==", "102e7a8e-d5ad-442b-aa4b-fe04d0c18278" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d42ae752-35a7-4ba3-a9c0-190484b6c253",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d70a8d5-29a4-43ba-bc69-34cd1b34bc76", "AQAAAAEAACcQAAAAEJUpeJ19qjWdR9iOASnHx6zxnGJhgk4Mb7kT8I+FrTVuBVLjg4E9Y582uzms9DvSXw==", "203e8005-51a5-4bfd-bfda-37d7aaee3166" });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 16, 16, 56, 54, 192, DateTimeKind.Local).AddTicks(3952), new DateTime(2024, 4, 26, 16, 56, 54, 192, DateTimeKind.Local).AddTicks(3996) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 5, 13, 56, 54, 192, DateTimeKind.Utc).AddTicks(4000), new DateTime(2024, 4, 16, 16, 56, 54, 192, DateTimeKind.Local).AddTicks(4001) });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_MedicineId",
                table: "Carts",
                column: "MedicineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_AspNetUsers_PatientId",
                table: "Carts",
                column: "PatientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Medicines_MedicineId",
                table: "Carts",
                column: "MedicineId",
                principalTable: "Medicines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_AspNetUsers_PatientId",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Medicines_MedicineId",
                table: "Carts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carts",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_MedicineId",
                table: "Carts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carts",
                table: "Carts",
                column: "PatientId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fb66dc7-697a-48fc-a009-3169578464bc",
                column: "ConcurrencyStamp",
                value: "1407d71a-f82a-47b1-b6e3-8ed507213749");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fe16750-157b-4110-a05f-0d2ba0812b3c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33e93d1e-ac52-43d1-9950-60d17beacf46", "AQAAAAEAACcQAAAAEBNzBPoLAA7v/7k4JYqRD3Yj2K2+7zVW44BIOObaOeriLjHRGPX6ZWdDuPNant/6ig==", "f18dd32a-051d-4776-88a1-e1dadc455524" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d42ae752-35a7-4ba3-a9c0-190484b6c253",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7895e375-7a71-406a-9ad8-e658700c981a", "AQAAAAEAACcQAAAAEMaSYxPreLrQz1HBSWjgs0X6H5KtXaDZsq3OKNgL+tw1EV/lZQKgBMg02qnAw4DPww==", "d6508a3f-3160-4d8c-a3f8-e58fa568ea9a" });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 16, 15, 55, 45, 841, DateTimeKind.Local).AddTicks(7577), new DateTime(2024, 4, 26, 15, 55, 45, 841, DateTimeKind.Local).AddTicks(7612) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 5, 12, 55, 45, 841, DateTimeKind.Utc).AddTicks(7616), new DateTime(2024, 4, 16, 15, 55, 45, 841, DateTimeKind.Local).AddTicks(7617) });
        }
    }
}
