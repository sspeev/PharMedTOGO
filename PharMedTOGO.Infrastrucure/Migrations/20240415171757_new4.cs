using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharMedTOGO.Infrastrucure.Migrations
{
    public partial class new4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fb66dc7-697a-48fc-a009-3169578464bc",
                column: "ConcurrencyStamp",
                value: "d0007842-66a1-44c5-9365-708f1168b80a");

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
        }
    }
}
