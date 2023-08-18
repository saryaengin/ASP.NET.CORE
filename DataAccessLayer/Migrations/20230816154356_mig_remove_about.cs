using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig_remove_about : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adress",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Mail",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Abouts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    }
}
