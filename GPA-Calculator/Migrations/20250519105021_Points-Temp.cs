using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GPA_Calculator.Migrations
{
    /// <inheritdoc />
    public partial class PointsTemp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Points",
                table: "Courses",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Points",
                table: "Courses");
        }
    }
}
