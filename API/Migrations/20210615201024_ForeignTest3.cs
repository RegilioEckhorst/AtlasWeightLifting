﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace AtlasWeightApp.Migrations
{
    public partial class ForeignTest3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Weightlifting");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 3, "Crossfit" },
                    { 4, "Revalidation" },
                    { 5, "Other" }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Name", "Private" },
                values: new object[,]
                {
                    { 3, "ThreadMill", "1" },
                    { 4, "Rope skipping", "1" },
                    { 5, "Bulgarian splitsquat", " " }
                });

            migrationBuilder.UpdateData(
                table: "HasCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CategoriesId",
                value: 2);

            migrationBuilder.InsertData(
                table: "HasCategories",
                columns: new[] { "Id", "CategoriesId", "ExercisesId" },
                values: new object[] { 3, 2, 2 });

            migrationBuilder.UpdateData(
                table: "HasCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CategoriesId",
                value: 3);

            migrationBuilder.InsertData(
                table: "HasCategories",
                columns: new[] { "Id", "CategoriesId", "ExercisesId" },
                values: new object[,]
                {
                    { 4, 1, 3 },
                    { 5, 1, 4 },
                    { 6, 3, 4 },
                    { 7, 4, 4 },
                    { 8, 2, 5 },
                    { 9, 3, 5 },
                    { 10, 4, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "HasCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "HasCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "HasCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "HasCategories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "HasCategories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "HasCategories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "HasCategories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "HasCategories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Weight");

            migrationBuilder.UpdateData(
                table: "HasCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CategoriesId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "HasCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CategoriesId",
                value: 2);
        }
    }
}
