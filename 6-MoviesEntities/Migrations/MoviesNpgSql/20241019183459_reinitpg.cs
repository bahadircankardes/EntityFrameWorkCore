using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _6_MoviesEntities.Migrations.MoviesNpgSql
{
    /// <inheritdoc />
    public partial class reinitpg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 18, 34, 59, 764, DateTimeKind.Utc).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 18, 34, 59, 764, DateTimeKind.Utc).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 18, 34, 59, 764, DateTimeKind.Utc).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 18, 34, 59, 764, DateTimeKind.Utc).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 18, 34, 59, 764, DateTimeKind.Utc).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Weeks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 21, 34, 59, 768, DateTimeKind.Local).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "Weeks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 21, 34, 59, 768, DateTimeKind.Local).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "Weeks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 21, 34, 59, 768, DateTimeKind.Local).AddTicks(2720));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 18, 21, 13, 476, DateTimeKind.Utc).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 18, 21, 13, 476, DateTimeKind.Utc).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 18, 21, 13, 476, DateTimeKind.Utc).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 18, 21, 13, 476, DateTimeKind.Utc).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 18, 21, 13, 476, DateTimeKind.Utc).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "Weeks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 21, 21, 13, 480, DateTimeKind.Local).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "Weeks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 21, 21, 13, 480, DateTimeKind.Local).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "Weeks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 21, 21, 13, 480, DateTimeKind.Local).AddTicks(5000));
        }
    }
}
