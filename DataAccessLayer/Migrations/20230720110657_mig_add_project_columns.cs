using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig_add_project_columns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*migrationBuilder.RenameColumn(
                name: "Contect",
                table: "Messages",
                newName: "Content");*/

            migrationBuilder.AddColumn<string>(
                name: "Platform",
                table: "Portfolios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Platform",
                table: "Portfolios");

            /*migrationBuilder.RenameColumn(
                name: "Content",
                table: "Messages",
                newName: "Contect");*/
        }
    }
}
