using Microsoft.EntityFrameworkCore.Migrations;

namespace AtlasWeightApp.Migrations
{
    public partial class ForeignTest2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Cardio" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Weight" });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Name", "Private" },
                values: new object[] { 2, "Dumbell press", "0" });

            migrationBuilder.InsertData(
                table: "HasCategories",
                columns: new[] { "Id", "CategoriesId", "ExercisesId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "HasCategories",
                columns: new[] { "Id", "CategoriesId", "ExercisesId" },
                values: new object[] { 2, 2, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HasCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HasCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
