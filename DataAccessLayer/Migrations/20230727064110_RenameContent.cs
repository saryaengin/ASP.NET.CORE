using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class RenameContent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*migrationBuilder.RenameColumn(
                name: "Content",
                table: "UserMessages",
                newName: "Icerik");*/
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            /*migrationBuilder.RenameColumn(
                name: "Icerik",
                table: "UserMessages",
                newName: "Content");*/
        }
    }
}
