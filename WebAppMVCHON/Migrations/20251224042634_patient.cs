using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppMVCHON.Migrations
{
    /// <inheritdoc />
    public partial class patient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "state",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    PID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.PID);
                });

            migrationBuilder.CreateTable(
                name: "Lab",
                columns: table => new
                {
                    LabID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Report = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false),
                    Patientrefid = table.Column<int>(type: "int", nullable: false),
                    PatientPID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lab", x => x.LabID);
                    table.ForeignKey(
                        name: "FK_Lab_Patient_PatientPID",
                        column: x => x.PatientPID,
                        principalTable: "Patient",
                        principalColumn: "PID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lab_PatientPID",
                table: "Lab",
                column: "PatientPID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lab");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "state");
        }
    }
}
