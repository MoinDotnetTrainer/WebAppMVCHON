using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppMVCHON.Migrations
{
    /// <inheritdoc />
    public partial class Doctorsss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DocDegree_Doctor_DoctorID",
                table: "DocDegree");

            migrationBuilder.DropIndex(
                name: "IX_DocDegree_DoctorID",
                table: "DocDegree");

            migrationBuilder.RenameColumn(
                name: "DoctorID",
                table: "DocDegree",
                newName: "DoctorrefID");

            migrationBuilder.AddColumn<int>(
                name: "DoctorsID",
                table: "DocDegree",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DocDegree_DoctorsID",
                table: "DocDegree",
                column: "DoctorsID");

            migrationBuilder.AddForeignKey(
                name: "FK_DocDegree_Doctor_DoctorsID",
                table: "DocDegree",
                column: "DoctorsID",
                principalTable: "Doctor",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DocDegree_Doctor_DoctorsID",
                table: "DocDegree");

            migrationBuilder.DropIndex(
                name: "IX_DocDegree_DoctorsID",
                table: "DocDegree");

            migrationBuilder.DropColumn(
                name: "DoctorsID",
                table: "DocDegree");

            migrationBuilder.RenameColumn(
                name: "DoctorrefID",
                table: "DocDegree",
                newName: "DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_DocDegree_DoctorID",
                table: "DocDegree",
                column: "DoctorID");

            migrationBuilder.AddForeignKey(
                name: "FK_DocDegree_Doctor_DoctorID",
                table: "DocDegree",
                column: "DoctorID",
                principalTable: "Doctor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
