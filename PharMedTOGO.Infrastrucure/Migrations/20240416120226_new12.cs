using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharMedTOGO.Infrastrucure.Migrations
{
    public partial class new12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Carts",
                table: "Carts");

            migrationBuilder.AlterColumn<int>(
                name: "MedicineId",
                table: "Carts",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carts",
                table: "Carts",
                column: "PatientId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fb66dc7-697a-48fc-a009-3169578464bc",
                column: "ConcurrencyStamp",
                value: "b0490992-db55-4fd6-9dcd-3408cfdb602d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fe16750-157b-4110-a05f-0d2ba0812b3c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24d8d76a-fed2-4b92-8f83-8866951bb183", "AQAAAAEAACcQAAAAEB9Pjc4exl86BdkLQoV+W7X9C28WGbE5O28rwzw3FnxaZn1Dp9DklLcLzn4Xk8UnXQ==", "617266b6-a802-46a9-a879-793f163a0527" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d42ae752-35a7-4ba3-a9c0-190484b6c253",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0e852d9-df40-4ed4-bdcf-dbaea1929311", "AQAAAAEAACcQAAAAELB+oL9pv3lhweuFQSQNwEkiWKWIk/SB3qV+UJzCfNFtqwuxAHQHfQcTAbpgQht+Pg==", "26a9aa86-83d0-43e4-a599-5c88304d5abc" });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 16, 15, 2, 25, 842, DateTimeKind.Local).AddTicks(2168), new DateTime(2024, 4, 26, 15, 2, 25, 842, DateTimeKind.Local).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 5, 12, 2, 25, 842, DateTimeKind.Utc).AddTicks(2210), new DateTime(2024, 4, 16, 15, 2, 25, 842, DateTimeKind.Local).AddTicks(2211) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Carts",
                table: "Carts");

            migrationBuilder.AlterColumn<string>(
                name: "MedicineId",
                table: "Carts",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carts",
                table: "Carts",
                columns: new[] { "PatientId", "MedicineId" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fb66dc7-697a-48fc-a009-3169578464bc",
                column: "ConcurrencyStamp",
                value: "81134bf0-5d73-4d91-b18f-fe3abc9eae02");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fe16750-157b-4110-a05f-0d2ba0812b3c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a34f1ee-b065-4370-a56a-48f407ff325f", "AQAAAAEAACcQAAAAECGZi69ez6+vus0nFBodPYUaTIm0lwYhBZe/sE3/UzbUXQK2a+c9AWlFWD2BFvAMEg==", "3fbd0c3b-ee73-4f9f-b721-001083a9d19b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d42ae752-35a7-4ba3-a9c0-190484b6c253",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d37e04ea-0e16-4793-8096-9e8f07999a7d", "AQAAAAEAACcQAAAAEFAiI3hJxwZcj6idRvBB119lh12KjagkplwVGIAIG/5n/BdhOT4cRnqTXnThv85OzQ==", "a17b452b-844e-4eb2-9887-7accdd9d8d16" });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 16, 14, 15, 53, 329, DateTimeKind.Local).AddTicks(3367), new DateTime(2024, 4, 26, 14, 15, 53, 329, DateTimeKind.Local).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 5, 11, 15, 53, 329, DateTimeKind.Utc).AddTicks(3410), new DateTime(2024, 4, 16, 14, 15, 53, 329, DateTimeKind.Local).AddTicks(3411) });
        }
    }
}
