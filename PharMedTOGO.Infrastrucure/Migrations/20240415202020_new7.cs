using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharMedTOGO.Infrastrucure.Migrations
{
    public partial class new7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsValid",
                table: "Prescriptions",
                type: "bit",
                nullable: false,
                comment: "Boolean property which shows if the current prescription is valid",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "Boolean property which shows if the current prescription is validated from the admin");

            migrationBuilder.AddColumn<bool>(
                name: "IsReviewd",
                table: "Prescriptions",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Boolean property which shows if the current prescription is reviewed from the admin");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fb66dc7-697a-48fc-a009-3169578464bc",
                column: "ConcurrencyStamp",
                value: "0aba965d-ece1-4315-97ea-320369f05289");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fe16750-157b-4110-a05f-0d2ba0812b3c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31d51056-1466-4bc5-a2ec-92da955d4955", "AQAAAAEAACcQAAAAENqyIWqlB9xpGO9IkczMgbeCHQvGXHLsUNY3rs2z7x+mJ+LG1H/Q+CbQVkCf8/f5Nw==", "2b3ac96b-6ab5-4587-9828-078065c2985f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d42ae752-35a7-4ba3-a9c0-190484b6c253",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "973d2b9d-7708-49ca-a464-8df47033db18", "AQAAAAEAACcQAAAAEJsHs/jR6zRU7VjlNfqt9VJOZgJEk4VDJzXMl59w4MXIRyhMZGnTe2cZNAOVkMYejg==", "98b22847-2a9a-4059-bfde-503808d6fe2d" });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 15, 23, 20, 20, 342, DateTimeKind.Local).AddTicks(8700), new DateTime(2024, 4, 25, 23, 20, 20, 342, DateTimeKind.Local).AddTicks(8736) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 4, 20, 20, 20, 342, DateTimeKind.Utc).AddTicks(8744), new DateTime(2024, 4, 15, 23, 20, 20, 342, DateTimeKind.Local).AddTicks(8745) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsReviewd",
                table: "Prescriptions");

            migrationBuilder.AlterColumn<bool>(
                name: "IsValid",
                table: "Prescriptions",
                type: "bit",
                nullable: false,
                comment: "Boolean property which shows if the current prescription is validated from the admin",
                oldClrType: typeof(bool),
                oldType: "bit",
                oldComment: "Boolean property which shows if the current prescription is valid");

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
    }
}
