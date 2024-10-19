using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _6_MoviesEntities.Migrations.MoviesNpgSql
{
    /// <inheritdoc />
    public partial class npgsqlsecond : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 21, 9, 11, 114, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 21, 9, 11, 114, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 21, 9, 11, 114, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 21, 9, 11, 114, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 21, 9, 11, 114, DateTimeKind.Local).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Weeks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 21, 9, 11, 117, DateTimeKind.Local).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "Weeks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 21, 9, 11, 117, DateTimeKind.Local).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "Weeks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 21, 9, 11, 117, DateTimeKind.Local).AddTicks(6030));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 21, 0, 7, 816, DateTimeKind.Local).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 21, 0, 7, 816, DateTimeKind.Local).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 21, 0, 7, 816, DateTimeKind.Local).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 21, 0, 7, 816, DateTimeKind.Local).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 21, 0, 7, 816, DateTimeKind.Local).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "Weeks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 21, 0, 7, 820, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "Weeks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 21, 0, 7, 820, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Weeks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 21, 0, 7, 820, DateTimeKind.Local).AddTicks(5430));
        }
    }
}
