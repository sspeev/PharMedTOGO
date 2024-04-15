using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharMedTOGO.Infrastrucure.Migrations
{
    public partial class new9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedOn", "ExpireDate", "IsValid" },
                values: new object[] { new DateTime(2024, 4, 16, 1, 48, 32, 410, DateTimeKind.Local).AddTicks(6466), new DateTime(2024, 4, 26, 1, 48, 32, 410, DateTimeKind.Local).AddTicks(6509), false });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 4, 22, 48, 32, 410, DateTimeKind.Utc).AddTicks(6514), new DateTime(2024, 4, 16, 1, 48, 32, 410, DateTimeKind.Local).AddTicks(6514) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CreatedOn", "ExpireDate", "IsValid" },
                values: new object[] { new DateTime(2024, 4, 16, 0, 7, 57, 963, DateTimeKind.Local).AddTicks(2191), new DateTime(2024, 4, 26, 0, 7, 57, 963, DateTimeKind.Local).AddTicks(2234), true });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 4, 21, 7, 57, 963, DateTimeKind.Utc).AddTicks(2238), new DateTime(2024, 4, 16, 0, 7, 57, 963, DateTimeKind.Local).AddTicks(2239) });
        }
    }
}
