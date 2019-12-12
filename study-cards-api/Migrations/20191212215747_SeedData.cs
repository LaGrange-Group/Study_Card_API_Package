using Microsoft.EntityFrameworkCore.Migrations;

namespace study_cards_api.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Stacks",
                columns: new[] { "Id", "Title" },
                values: new object[] { 1, "React" });

            migrationBuilder.InsertData(
                table: "Stacks",
                columns: new[] { "Id", "Title" },
                values: new object[] { 2, "C#" });

            migrationBuilder.InsertData(
                table: "Stacks",
                columns: new[] { "Id", "Title" },
                values: new object[] { 3, "Flutter" });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Definition", "StackId", "Word" },
                values: new object[,]
                {
                    { 1, "JS object that holds values for a component", 1, "state" },
                    { 2, "A way to pass data into components on initialization", 1, "props" },
                    { 3, "Reusable building blocks for UI using JSX", 1, "component" },
                    { 4, "Named space in memory", 2, "variable" },
                    { 5, "Template for an object that consists of member variables, constructor, methods", 2, "class" },
                    { 6, "Instance of a class", 2, "object" },
                    { 7, "Reusable component in Flutter", 3, "widget" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Stacks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stacks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stacks",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
