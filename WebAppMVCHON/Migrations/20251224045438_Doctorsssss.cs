using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppMVCHON.Migrations
{
    /// <inheritdoc />
    public partial class Doctorsssss : Migration
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

            migrationBuilder.DropColumn(
                name: "DoctorsID",
                table: "DocDegree");

            migrationBuilder.CreateIndex(
                name: "IX_DocDegree_DoctorrefID",
                table: "DocDegree",
                column: "DoctorrefID");

            migrationBuilder.AddForeignKey(
                name: "FK_DocDegree_Doctor_DoctorrefID",
                table: "DocDegree",
                column: "DoctorrefID",
                principalTable: "Doctor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DocDegree_Doctor_DoctorrefID",
                table: "DocDegree");

            migrationBuilder.DropIndex(
                name: "IX_DocDegree_DoctorrefID",
                table: "DocDegree");

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
    }
}
