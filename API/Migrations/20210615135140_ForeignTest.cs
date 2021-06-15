using Microsoft.EntityFrameworkCore.Migrations;

namespace AtlasWeightApp.Migrations
{
    public partial class ForeignTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HasCategories_Categories_CategoriesId",
                table: "HasCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_HasCategories_Exercises_ExercisesId",
                table: "HasCategories");

            migrationBuilder.AlterColumn<int>(
                name: "ExercisesId",
                table: "HasCategories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoriesId",
                table: "HasCategories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "HasCategories",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HasCategories",
                table: "HasCategories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HasCategories_Categories_CategoriesId",
                table: "HasCategories",
                column: "CategoriesId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HasCategories_Exercises_ExercisesId",
                table: "HasCategories",
                column: "ExercisesId",
                principalTable: "Exercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HasCategories_Categories_CategoriesId",
                table: "HasCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_HasCategories_Exercises_ExercisesId",
                table: "HasCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HasCategories",
                table: "HasCategories");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "HasCategories");

            migrationBuilder.AlterColumn<int>(
                name: "ExercisesId",
                table: "HasCategories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CategoriesId",
                table: "HasCategories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_HasCategories_Categories_CategoriesId",
                table: "HasCategories",
                column: "CategoriesId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HasCategories_Exercises_ExercisesId",
                table: "HasCategories",
                column: "ExercisesId",
                principalTable: "Exercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
