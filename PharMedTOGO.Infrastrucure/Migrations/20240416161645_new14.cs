using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharMedTOGO.Infrastrucure.Migrations
{
    public partial class new14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Discount",
                table: "Sales",
                type: "int",
                nullable: false,
                comment: "Decimal value for the sale percentage",
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldComment: "Decimal value for the sale percentage");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fb66dc7-697a-48fc-a009-3169578464bc",
                column: "ConcurrencyStamp",
                value: "d6baeed0-9c21-496f-9afc-277d0b34c8b2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3fe16750-157b-4110-a05f-0d2ba0812b3c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64138f25-d1a8-40b0-91aa-fdec7dced220", "AQAAAAEAACcQAAAAECD4+YmUM+UeYaoGQUZOK/+WEyFzCzO2+ZK4sQd6rUnMZJICXQbHxvFJ21Q64YTPlA==", "60aa7a2b-66b1-4e0d-aa12-c348a4c72fac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d42ae752-35a7-4ba3-a9c0-190484b6c253",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ac03ee2-8017-4a30-9fd2-3cd1755d905a", "AQAAAAEAACcQAAAAEMLGwg2EWHOB3UdJBZ0wZUfw9JAb6HDuyJKugQFoJOgpT8iSqmbX4/tNPdj2/YmqrQ==", "cd20f549-12b2-4964-856a-a1c1af0613c7" });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 16, 19, 16, 44, 360, DateTimeKind.Local).AddTicks(7813), new DateTime(2024, 4, 26, 19, 16, 44, 360, DateTimeKind.Local).AddTicks(7852) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ExpireDate" },
                values: new object[] { new DateTime(2024, 4, 5, 16, 16, 44, 360, DateTimeKind.Utc).AddTicks(7858), new DateTime(2024, 4, 16, 19, 16, 44, 360, DateTimeKind.Local).AddTicks(7859) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                column: "Discount",
                value: 50);

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                column: "Discount",
                value: 30);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Discount",
                table: "Sales",
                type: "decimal(18,2)",
                nullable: false,
                comment: "Decimal value for the sale percentage",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Decimal value for the sale percentage");

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

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                column: "Discount",
                value: 50m);

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 2,
                column: "Discount",
                value: 30m);
        }
    }
}
