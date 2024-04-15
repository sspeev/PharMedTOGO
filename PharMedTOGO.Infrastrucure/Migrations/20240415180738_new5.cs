using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharMedTOGO.Infrastrucure.Migrations
{
    public partial class new5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicines_Prescriptions_PrescriptionId",
                table: "Medicines");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Prescriptions_PrescriptionId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_AspNetUsers_PatientId",
                table: "Prescriptions");

            migrationBuilder.DropIndex(
                name: "IX_Medicines_PrescriptionId",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "PrescriptionId",
                table: "Medicines");

            migrationBuilder.AlterColumn<int>(
                name: "PrescriptionId",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "PrescriptionId",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                comment: "Prescription's identifier");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fb66dc7-697a-48fc-a009-3169578464bc",
                column: "ConcurrencyStamp",
                value: "76da6d70-a15b-4d63-9b58-ad3b0498c8ec");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fe16750-157b-4110-a05f-0d2ba0812b3c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7446e7d-8fff-4b5d-ab42-72e296c02c34", "AQAAAAEAACcQAAAAEF0AZ7R7K3HIb7rMZnBi0LE7A8sLdNzmQds+Ug2tGl254eK8GKAVWlontrcF41kisA==", "f7db128a-73f8-45d8-a6be-c25d89ff4817" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d42ae752-35a7-4ba3-a9c0-190484b6c253",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f236e46-7217-484f-88b7-4d3e37f842a9", "AQAAAAEAACcQAAAAEEm4k5egpgIhYcswxSrVNotN8oYKQO9RpJ4s5LRsV3erhjulWMDL3xIH9Gn/Yq57HQ==", "7f19147f-8045-4b93-8019-625143503064" });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 15, 21, 7, 37, 655, DateTimeKind.Local).AddTicks(953), new DateTime(2024, 4, 25, 21, 7, 37, 655, DateTimeKind.Local).AddTicks(999) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 4, 18, 7, 37, 655, DateTimeKind.Utc).AddTicks(1007), new DateTime(2024, 4, 15, 21, 7, 37, 655, DateTimeKind.Local).AddTicks(1007) });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PrescriptionId",
                table: "AspNetUsers",
                column: "PrescriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Prescriptions_PrescriptionId",
                table: "AspNetUsers",
                column: "PrescriptionId",
                principalTable: "Prescriptions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Prescriptions_PrescriptionId",
                table: "Orders",
                column: "PrescriptionId",
                principalTable: "Prescriptions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_AspNetUsers_PatientId",
                table: "Prescriptions",
                column: "PatientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Prescriptions_PrescriptionId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Prescriptions_PrescriptionId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_AspNetUsers_PatientId",
                table: "Prescriptions");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PrescriptionId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PrescriptionId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "PrescriptionId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PrescriptionId",
                table: "Medicines",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fb66dc7-697a-48fc-a009-3169578464bc",
                column: "ConcurrencyStamp",
                value: "00157a7d-e9c5-412e-9014-2c2e6ac299f0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fe16750-157b-4110-a05f-0d2ba0812b3c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d44c957-803b-4d1f-acd2-260f5b027edb", "AQAAAAEAACcQAAAAEL7l0LygmSfwlVrLoKWEyi+Mn80vs8AuL0DKHbHID9IwIzwKDbAMMcEs2rP0J/7Sug==", "17cda5d3-ce0d-455b-8899-c5279274e27a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d42ae752-35a7-4ba3-a9c0-190484b6c253",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f757b921-7aa2-48da-810b-92691bb7ef09", "AQAAAAEAACcQAAAAELDwhvIpzK9nBsBenWOMRdMv8HIepSXEmsxVPZ0LmQ4ENYTs3r5YKTW5AHVQV8XWXw==", "d33ac580-6990-4782-9d88-edcbce58f57c" });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 15, 20, 17, 57, 131, DateTimeKind.Local).AddTicks(7607), new DateTime(2024, 4, 25, 20, 17, 57, 131, DateTimeKind.Local).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 4, 17, 17, 57, 131, DateTimeKind.Utc).AddTicks(7667), new DateTime(2024, 4, 15, 20, 17, 57, 131, DateTimeKind.Local).AddTicks(7667) });

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_PrescriptionId",
                table: "Medicines",
                column: "PrescriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicines_Prescriptions_PrescriptionId",
                table: "Medicines",
                column: "PrescriptionId",
                principalTable: "Prescriptions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Prescriptions_PrescriptionId",
                table: "Orders",
                column: "PrescriptionId",
                principalTable: "Prescriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_AspNetUsers_PatientId",
                table: "Prescriptions",
                column: "PatientId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
