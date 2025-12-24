using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppMVCHON.Migrations
{
    /// <inheritdoc />
    public partial class Doctorss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DocDegree_Doctor_DoctorsID",
                table: "DocDegree");

            migrationBuilder.DropIndex(
                name: "IX_DocDegree_DoctorsID",
                table: "DocDegree");

            migrationBuilder.RenameColumn(
                name: "DoctorsID",
                table: "DocDegree",
                newName: "Doctor____ID");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DocDegree_Doctor_DoctorID",
                table: "DocDegree");

            migrationBuilder.DropIndex(
                name: "IX_DocDegree_DoctorID",
                table: "DocDegree");

            migrationBuilder.RenameColumn(
                name: "Doctor____ID",
                table: "DocDegree",
                newName: "DoctorsID");

            migrationBuilder.CreateIndex(
                name: "IX_DocDegree_DoctorsID",
                table: "DocDegree",
                column: "DoctorsID");

            migrationBuilder.AddForeignKey(
                name: "FK_DocDegree_Doctor_DoctorsID",
                table: "DocDegree",
                column: "DoctorsID",
                principalTable: "Doctor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
