using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharMedTOGO.Infrastrucure.Migrations
{
    public partial class changedProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsValidated",
                table: "Prescriptions",
                newName: "IsValid");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fb66dc7-697a-48fc-a009-3169578464bc",
                column: "ConcurrencyStamp",
                value: "c9c74ed9-498d-48dd-a950-2b5928073dae");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fe16750-157b-4110-a05f-0d2ba0812b3c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da2c1c57-4d9f-4a89-9608-451b2fdf90ee", "AQAAAAEAACcQAAAAEC9RNH9suTTCXzZhdsyIAwrTP1vTO6WttGISO6JGl85dP5dfIHuNB2wiUsvKOD3i5A==", "0ef75875-3adc-427f-9b3c-7183a8c7001b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d42ae752-35a7-4ba3-a9c0-190484b6c253",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f5b24cf-f91b-4106-8e2d-aeb8323953ac", "AQAAAAEAACcQAAAAEDs05ROYGf3EgSqgzO6iOXOojhrHVavM5c25Mc0u6KSOQTl6k8Qztp99F5i3XJgGKg==", "2f506035-5b56-45c0-8fbb-d621a762cb2f" });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 15, 22, 46, 25, 153, DateTimeKind.Local).AddTicks(9959), new DateTime(2024, 4, 25, 22, 46, 25, 154, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 4, 19, 46, 25, 154, DateTimeKind.Utc).AddTicks(7), new DateTime(2024, 4, 15, 22, 46, 25, 154, DateTimeKind.Local).AddTicks(8) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsValid",
                table: "Prescriptions",
                newName: "IsValidated");

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
    }
}
