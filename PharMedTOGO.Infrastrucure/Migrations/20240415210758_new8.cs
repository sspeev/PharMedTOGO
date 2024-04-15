using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharMedTOGO.Infrastrucure.Migrations
{
    public partial class new8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fb66dc7-697a-48fc-a009-3169578464bc",
                column: "ConcurrencyStamp",
                value: "4471a607-cdd4-4280-a910-8236aa64fa32");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fe16750-157b-4110-a05f-0d2ba0812b3c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e5bd246-f7d4-4155-bc38-b8ab2f0fb666", "AQAAAAEAACcQAAAAEKOx4sQn+6Qoa4YnetqXseGBTmYU16p1oOsOhB6CuZsgToUKM4+a6TsnIaWjPRRBSg==", "393acaeb-7eb3-49c8-9ebc-81890e9cbc90" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d42ae752-35a7-4ba3-a9c0-190484b6c253",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2381a84b-6996-45be-8ec1-b2bd0426b947", "AQAAAAEAACcQAAAAEJR0aH1DWpShJ7BQSfCbWc08OXm5G/KGp2vn39ruvGdnpf52MMIWo8GnzV6fuR/yUA==", "d6d440bb-e78a-4247-b6c7-fd650ede2ad0" });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ExpireDate", "PatientId" },
                values: new object[] { new DateTime(2024, 4, 16, 0, 7, 57, 963, DateTimeKind.Local).AddTicks(2191), new DateTime(2024, 4, 26, 0, 7, 57, 963, DateTimeKind.Local).AddTicks(2234), "f13628c2-5ff0-4d1c-a0e2-2527ec425aa4" });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 4, 21, 7, 57, 963, DateTimeKind.Utc).AddTicks(2238), new DateTime(2024, 4, 16, 0, 7, 57, 963, DateTimeKind.Local).AddTicks(2239) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedOn", "ExpireDate", "PatientId" },
                values: new object[] { new DateTime(2024, 4, 15, 23, 20, 20, 342, DateTimeKind.Local).AddTicks(8700), new DateTime(2024, 4, 25, 23, 20, 20, 342, DateTimeKind.Local).AddTicks(8736), "d42ae752-35a7-4ba3-a9c0-190484b6c253" });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 4, 20, 20, 20, 342, DateTimeKind.Utc).AddTicks(8744), new DateTime(2024, 4, 15, 23, 20, 20, 342, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Local) });
        }
    }
}
