using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _6_MoviesEntities.Migrations
{
    /// <inheritdoc />
    public partial class updatesalons : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Salons",
                columns: new[] { "Id", "CreateDate", "Kapasite", "SalonName" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 10, 19, 21, 56, 56, 234, DateTimeKind.Utc).AddTicks(9130), (short)150, "B Salonu" },
                    { 3, new DateTime(2024, 10, 19, 21, 56, 56, 234, DateTimeKind.Utc).AddTicks(9060), (short)50, "C Salonu" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Salons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Salons",
                keyColumn: "Id",
                keyValue: 3);

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
    }
}
