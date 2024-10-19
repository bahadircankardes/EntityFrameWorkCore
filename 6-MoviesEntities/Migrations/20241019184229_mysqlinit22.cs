using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _6_MoviesEntities.Migrations
{
    /// <inheritdoc />
    public partial class mysqlinit22 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 18, 42, 29, 170, DateTimeKind.Utc).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 18, 42, 29, 170, DateTimeKind.Utc).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 18, 42, 29, 170, DateTimeKind.Utc).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 18, 42, 29, 170, DateTimeKind.Utc).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 18, 42, 29, 170, DateTimeKind.Utc).AddTicks(8910));

            migrationBuilder.InsertData(
                table: "Salons",
                columns: new[] { "Id", "CreateDate", "Kapasite", "SalonName" },
                values: new object[] { 1, new DateTime(2024, 10, 19, 21, 42, 29, 172, DateTimeKind.Utc).AddTicks(8360), (short)50, "A Salonu" });

            migrationBuilder.UpdateData(
                table: "Weeks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 21, 42, 29, 175, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Weeks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 21, 42, 29, 175, DateTimeKind.Local).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "Weeks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 21, 42, 29, 175, DateTimeKind.Local).AddTicks(6910));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Salons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 20, 43, 20, 848, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 20, 43, 20, 848, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 20, 43, 20, 848, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 20, 43, 20, 848, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 20, 43, 20, 848, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Weeks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 20, 43, 20, 852, DateTimeKind.Local).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "Weeks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 20, 43, 20, 852, DateTimeKind.Local).AddTicks(1840));

            migrationBuilder.UpdateData(
                table: "Weeks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 20, 43, 20, 852, DateTimeKind.Local).AddTicks(1850));
        }
    }
}
