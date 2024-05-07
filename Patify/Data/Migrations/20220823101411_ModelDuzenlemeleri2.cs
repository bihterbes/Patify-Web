using Microsoft.EntityFrameworkCore.Migrations;

namespace Patify.Data.Migrations
{
    public partial class ModelDuzenlemeleri2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Advert");

            migrationBuilder.AddColumn<bool>(
                name: "Publish",
                table: "Advert",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Publish",
                table: "Advert");

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Advert",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
