using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _6_MoviesEntities.Migrations
{
    /// <inheritdoc />
    public partial class saloonupdate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 19, 5, 37, 741, DateTimeKind.Utc).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 19, 5, 37, 741, DateTimeKind.Utc).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 19, 5, 37, 741, DateTimeKind.Utc).AddTicks(3290));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 19, 5, 37, 741, DateTimeKind.Utc).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 19, 5, 37, 741, DateTimeKind.Utc).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "Salons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 22, 5, 37, 744, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "Salons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 22, 5, 37, 744, DateTimeKind.Utc).AddTicks(410));

            migrationBuilder.InsertData(
                table: "Salons",
                columns: new[] { "Id", "CreateDate", "Kapasite", "SalonName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 19, 22, 5, 37, 744, DateTimeKind.Utc).AddTicks(490), (short)50, "A Salonu" },
                    { 4, new DateTime(2024, 10, 19, 22, 5, 37, 744, DateTimeKind.Utc).AddTicks(500), (short)50, "D Salonu" }
                });

            migrationBuilder.UpdateData(
                table: "Weeks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 22, 5, 37, 747, DateTimeKind.Local).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "Weeks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 22, 5, 37, 747, DateTimeKind.Local).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "Weeks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 22, 5, 37, 747, DateTimeKind.Local).AddTicks(1290));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Salons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Salons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 18, 56, 56, 232, DateTimeKind.Utc).AddTicks(2410));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 18, 56, 56, 232, DateTimeKind.Utc).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 18, 56, 56, 232, DateTimeKind.Utc).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 18, 56, 56, 232, DateTimeKind.Utc).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 18, 56, 56, 232, DateTimeKind.Utc).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "Salons",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 21, 56, 56, 234, DateTimeKind.Utc).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "Salons",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 21, 56, 56, 234, DateTimeKind.Utc).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "Weeks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 21, 56, 56, 238, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "Weeks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 21, 56, 56, 238, DateTimeKind.Local).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "Weeks",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 10, 19, 21, 56, 56, 238, DateTimeKind.Local).AddTicks(6020));
        }
    }
}
