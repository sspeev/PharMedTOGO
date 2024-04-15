using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharMedTOGO.Infrastrucure.Migrations
{
    public partial class new6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Prescriptions_PrescriptionId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_PrescriptionId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PrescriptionId",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fb66dc7-697a-48fc-a009-3169578464bc",
                column: "ConcurrencyStamp",
                value: "bcba3774-5d44-4bc7-8bf5-51e603af5354");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fe16750-157b-4110-a05f-0d2ba0812b3c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e196ea87-16d3-46cd-913c-5095506c9fc5", "AQAAAAEAACcQAAAAEPawwRnuoOFVQ+N5mHnNIuDmnubjzizn/2wuEka8jC8w836/oNYIXju1ELyF2U6Y7A==", "fdd9fcc8-7247-4780-93d0-e69c901cfc06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d42ae752-35a7-4ba3-a9c0-190484b6c253",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92d110ab-e3f7-47aa-b86a-a2f6f4c4359f", "AQAAAAEAACcQAAAAEJUoRYYL9r1/kjFnfhe0UpFMWMDJYurjK5zlat2m9Oj59WfaNg0Kv8wuyKHNeILszQ==", "d91d72cf-ea92-410e-a05c-8009a6a05a5a" });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 15, 21, 10, 26, 905, DateTimeKind.Local).AddTicks(6807), new DateTime(2024, 4, 25, 21, 10, 26, 905, DateTimeKind.Local).AddTicks(6849) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 4, 18, 10, 26, 905, DateTimeKind.Utc).AddTicks(6856), new DateTime(2024, 4, 15, 21, 10, 26, 905, DateTimeKind.Local).AddTicks(6857) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PrescriptionId",
                table: "Orders",
                type: "int",
                nullable: true);

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
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "PrescriptionId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "PrescriptionId",
                value: 2);

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
                name: "IX_Orders_PrescriptionId",
                table: "Orders",
                column: "PrescriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Prescriptions_PrescriptionId",
                table: "Orders",
                column: "PrescriptionId",
                principalTable: "Prescriptions",
                principalColumn: "Id");
        }
    }
}
