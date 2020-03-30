using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelAPI.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Description", "Destination", "Rating", "Title" },
                values: new object[,]
                {
                    { 1, "Always ask for them.", "Hawaii", 3, "Coconuts Yes!" },
                    { 2, "Mhm", "Seattle", 3, "The Emerald City" },
                    { 3, "Bring your hiking shoes with you!", "Denver", 3, "Hiking Paradise" },
                    { 4, "So little time, so much distance to travel", "New York", 6, "Walk, walk, walk" },
                    { 5, "Dunkin donuts all around!", "Chicago", 5, "Good 'ol Chicago" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 5);
        }
    }
}
