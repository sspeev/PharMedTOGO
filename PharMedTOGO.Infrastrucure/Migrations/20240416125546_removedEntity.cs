using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharMedTOGO.Infrastrucure.Migrations
{
    public partial class removedEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicines_Orders_OrderId",
                table: "Medicines");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Medicines_OrderId",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Medicines");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Medicines",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_PatientId",
                        column: x => x.PatientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "PatientId" },
                values: new object[,]
                {
                    { 1, "d42ae752-35a7-4ba3-a9c0-190484b6c253" },
                    { 2, "3fe16750-157b-4110-a05f-0d2ba0812b3c" }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_OrderId",
                table: "Medicines",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PatientId",
                table: "Orders",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicines_Orders_OrderId",
                table: "Medicines",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }
    }
}
