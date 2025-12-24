using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppMVCHON.Migrations
{
    /// <inheritdoc />
    public partial class AAdhar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Patientrefid",
                table: "Lab",
                newName: "PID");

            migrationBuilder.CreateTable(
                name: "Adhar",
                columns: table => new
                {
                    AdharID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adhar", x => x.AdharID);
                });

            migrationBuilder.CreateTable(
                name: "Pan",
                columns: table => new
                {
                    PanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PanUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdharNo = table.Column<int>(type: "int", nullable: false),
                    AdharID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pan", x => x.PanID);
                    table.ForeignKey(
                        name: "FK_Pan_Adhar_AdharID",
                        column: x => x.AdharID,
                        principalTable: "Adhar",
                        principalColumn: "AdharID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pan_AdharID",
                table: "Pan",
                column: "AdharID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pan");

            migrationBuilder.DropTable(
                name: "Adhar");

            migrationBuilder.RenameColumn(
                name: "PID",
                table: "Lab",
                newName: "Patientrefid");
        }
    }
}
