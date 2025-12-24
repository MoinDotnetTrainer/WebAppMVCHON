using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppMVCHON.Migrations
{
    /// <inheritdoc />
    public partial class patients : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "state");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Lab");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "state",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Lab",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
