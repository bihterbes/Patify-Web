using Microsoft.EntityFrameworkCore.Migrations;

namespace Patify.Data.Migrations
{
    public partial class ModelDuzenlemeleri1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Subject",
                table: "Contact",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Advert",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Subject",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Advert");
        }
    }
}
